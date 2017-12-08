using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OicRentalShop.Register.Return
{
    public partial class Return : UserControl
    {
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        DataTable dtp = new DataTable();

        public Return()
        {
            InitializeComponent();
        }

        private void Return_Load(object sender, EventArgs e)
        {
            txt_MemberID.Focus();
            slipID = SetCount("SELECT COUNT(*) FROM TBL_SLIP");
            slipID++;
        }




        private void selectfunc(string cmdstr)//DataGridViewにレジを通した商品の情報を出力 DataTable dtpを他の用途に使う(Clearする)とDataGridViewに表示してるものが消える
        {
            dt.Clear();
            dt = new DataTable();
            dgv_ReturnItem.DataSource = null;
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            dgv_ReturnItem.DataSource = dt;
            dgv_ReturnItem.AutoResizeColumns();
        }

        private void CmdFunc(string cmdstr) //UPDATE DELETE INSERTを実行できる　CmdFunc("SQL文"); 
        {
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = cn;
            cn.Open();
            Cmd.CommandText = cmdstr;
            Cmd.ExecuteNonQuery();
            cn.Close();
        }

        private int dtCheck(string cmdstr)　//IDを入力した際　1列以上選択されるかチェックをし　データの有無を確認する
        {
            int flag = 0;
            dt.Clear();
            dt = new DataTable();
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                flag = 1;
            }
            return flag;
        }

        private string SetInfo(string cmdstr) //SQLでデータが1行1列だけ出力される形で取り出したいデータを持ってくるのに使う　数値で使うならint.Parse(SetInfo("SQL"))
        {
            dtp.Clear();
            dtp = new DataTable();
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dtp);
            return dtp.Rows[0][0].ToString();
        }

        private void clearfunc() //現在行っているレジ内容の破棄・入力した会員情報・商品情報を取り消す
        {
            txt_MemberID.Clear();
            txt_MemberPoint.Clear();
            txt_MemberName.Clear();
            txt_MemberID.ReadOnly = false;
            txt_ProductID.Clear();
            txt_money.Clear();
            dtp.Clear();
        }

         private void InsertLineSlip()   //レジを通した商品の情報を伝票表に登録
        {
            int lineslipID = SetCount("SELECT COUNT(*) FROM TBL_LINESLIP");
            lineslipID++;
            dtp.Clear();
            dtp = new DataTable();
            da = new OleDbDataAdapter("SELECT t.TYPE_ID FROM TBL_TITLE t,TBL_ITEM i WHERE t.TITLE_ID=i.TITLE_ID AND i.ITEM_ID=" + txt_InProductID.Text, cn);
            da.Fill(dtp);
            string typeid = dtp.Rows[0][0].ToString();

            dtp.Clear();
            dtp = new DataTable();
            da = new OleDbDataAdapter("SELECT p.PRICE_12 FROM TBL_PRICE p,TBL_TITLE t,TBL_ITEM i WHERE i.TITLE_ID=t.TITLE_ID AND t.OLD_ID=p.OLD_ID AND t.TYPE_ID=p.TYPE_ID AND i.ITEM_ID=" + txt_InProductID.Text, cn);
            da.Fill(dtp);
            string Price = dtp.Rows[0][0].ToString();

            CmdFunc("INSERT INTO TBL_LINESLIP VALUES(" + lineslipID + "," + slipID + "," + int.Parse(txt_InProductID.Text) + ",1," + int.Parse(typeid) + "," + int.Parse(Price) + ")");
        }

        private void txt_MemberID_TextChanged(object sender, EventArgs e)
        {
            if (txt_MemberID.Text.Length == 1)
            {
                if (dtCheck("SELECT * FROM TBL_MEMBER WHERE MEMBER_ID=" + txt_MemberID.Text) == 1)
                {
                    txt_MemberPoint.Text = SetInfo("SELECT MEMBER_POINT FROM TBL_MEMBER WHERE MEMBER_ID=" + txt_MemberID.Text);
                    txt_MemberName.Text = SetInfo("SELECT MEMBER_NAME FROM TBL_MEMBER WHERE MEMBER_ID=" + txt_MemberID.Text);
                    txt_MemberID.ReadOnly = true;
                    txt_InProductID.Focus();
                }
                else
                {
                    MessageBox.Show("メンバーID:" + txt_MemberID.Text + "は存在しません");
                    txt_MemberID.Clear();
                }
            }
            else if (txt_MemberID.Text.Length >= 2)
            {
                MessageBox.Show("メンバーIDはN文字です");
                txt_MemberID.Clear();
            }
            if (txt_MemberID.Text.Length == 0)
            {
                clearfunc();
            }
        }

        private int SetCount(string cmdstr)　//特定のDBの行数の取得に使う
        {
            dt.Clear();
            dt = new DataTable();
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            string cnt =dt.Rows[0][0].ToString();
            int count = int.Parse(cnt);
            return count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Today = DateTime.Today;    //今日の日付の取得
            
            //int miday = int.Parse(SetInfo("SELECT DATEDIFF(dd,2017/11/30,SYSDATE) FROM TBL_SLIP"));
            //SetInfo("SELECT SLIP");
            //MessageBox.Show(miday.ToString());
        }



        int SlipFlag = 0;
        int slipprice = 0;
        int selectedlsID;
        int lsIDpoint;
        int slipID;

        private void txt_InProductID_TextChanged(object sender, EventArgs e)
        {
            if (txt_MemberID.Text != "")
            {
                if (txt_InProductID.Text.Length == 1)
                {
                    if (dtCheck("SELECT * FROM TBL_ITEM WHERE ITEM_ID=" + txt_InProductID.Text) == 1)
                    {
                        if ("False" == SetInfo("SELECT ITEM_STATE FROM TBL_ITEM WHERE ITEM_ID=" + txt_InProductID.Text))
                        {
                            if (SlipFlag == 0)
                            {
                                DateTime Today = DateTime.Today;
                                CmdFunc("INSERT INTO TBL_SLIP VALUES(" + slipID + "," + int.Parse(txt_MemberID.Text) + ",false,#" + Today.ToString() + "#,0,1)");
                                txt_MemberID.ReadOnly = true;
                                SlipFlag = 1;
                            }
                            txt_ProductID.Text = txt_InProductID.Text;
                            txt_title.Text = SetInfo("SELECT t.TITLE_NAME FROM TBL_TITLE t,TBL_ITEM i WHERE t.TITLE_ID=i.TITLE_ID AND i.ITEM_ID = " + txt_InProductID.Text);
                            //InsertLineSlip();
                            slipprice = int.Parse(SetInfo("SELECT SUM(LS_PRICE) FROM TBL_LINESLIP GROUP BY SLIP_ID HAVING SLIP_ID=" + slipID));
                            txt_money.Text = slipprice.ToString();
                            CmdFunc("UPDATE TBL_SLIP SET SLIP_PRICE=" + slipprice + " WHERE SLIP_ID=" + slipID);
                            txt_InProductID.Clear();
                            selectedlsID++;
                            lsIDpoint++;
                        }
                        else
                        {
                            MessageBox.Show("指定された商品は貸し出されていません");
                            txt_InProductID.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("商品ID:" + txt_InProductID.Text + "は存在しません");
                        txt_InProductID.Clear();
                    }
                }
                else if (txt_InProductID.Text.Length >= 2)
                {
                    MessageBox.Show("商品IDはN文字です");
                    txt_InProductID.Clear();
                }
            }
            else if (txt_InProductID.Text == "")
            {
                MessageBox.Show("会員IDを入力してください");
                txt_MemberID.Focus();
            }
            else
            {
                txt_InProductID.Clear();
            }
            selectfunc("SELECT t.TITLE_NAME,ty.TYPE_NAME,l.LEND_PRERIOD,ls.LS_Price FROM TBL_TITLE t,TBL_TYPE ty,TBL_LEND l,TBL_LINESLIP ls,TBL_ITEM i WHERE ls.LEND_ID=l.LEND_ID AND ls.ITEM_ID=i.ITEM_ID AND i.TITLE_ID =t.TITLE_ID  AND t.TYPE_ID=ty.TYPE_ID AND ls.SLIP_ID=" + slipID);
        }

        private void txt_ProductID_TextChanged(object sender, EventArgs e)
        {
            txt_title.Text = SetInfo("SELECT t.TITLE_NAME FROM TBL_TITLE t,TBL_ITEM i WHERE t.TITLE_ID=i.TITLE_ID AND i.ITEM_ID = " + txt_ProductID.Text);
            txt_type.Text = SetInfo("SELECT y.TYPE_NAME FROM TBL_TITLE t,TBL_ITEM i,TBL_TYPE y WHERE t.TITLE_ID=i.TITLE_ID AND y.TYPE_ID=t.TYPE_ID AND i.ITEM_ID = " + txt_ProductID.Text);
            txt_OLDNEW.Text = SetInfo("SELECT o.OLD_NAME FROM TBL_OLD o,TBL_TITLE t,TBL_ITEM i WHERE o.OLD_ID=t.OLD_ID AND i.TITLE_ID = t.TITLE_ID AND i.ITEM_ID= " + txt_ProductID.Text);
        }
    }
}

