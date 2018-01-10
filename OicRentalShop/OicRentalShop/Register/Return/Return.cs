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

namespace OicRentalShop.Manage.Return
{
    public partial class Return : UserControl
    {
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        DataTable dtp = new DataTable();

        public DataSet ds = new DataSet();//dtsour
        DataTable dts;
        DataRow dr;

        RegisterHome rh;
        ReturnConf rc;
        public Return(RegisterHome fm1,ReturnConf fm2)
        {
            InitializeComponent();
            rh = fm1;
            rc = fm2;
        }

        int flag = 1;
        private void Return_Load(object sender, EventArgs e)
        {
            DateTime Today = DateTime.Today;    //今日の日付の取得
            DateTime upday = Today.AddMonths(-1);
            CmdFunc("UPDATE TBL_OLD SET OLD_DATE=#" + upday.ToString() + "# WHERE OLD_ID = 2");       //旧作の日時設定（画面を読み込んだ日の1か月前）
            CmdFunc("UPDATE TBL_TITLE SET OLD_ID=2 WHERE TITLE_RELEASE <= ANY(SELECT OLD_DATE FROM TBL_OLD WHERE OLD_ID=2)");   //新作が旧作の期間になっていないかチェックする
            txt_MemberID.Focus();

            selectedlsID = int.Parse(SetInfo("SELECT COUNT(*) FROM TBL_LINESLIP").ToString());
            lsIDpoint = 0;
            dt.Clear();

            dts = ds.Tables.Add("Product");

            dts.Columns.Add("タイトル");
            dts.Columns.Add("CD DVD");
            dts.Columns.Add("返却予定日");
            dts.Columns.Add("延滞料金");
        }

        public void Commit()
        {
            slipID++;
            SlipFlag = 1;

        }


        private void selectfunc(string cmdstr)//DataGridViewにレジを通した商品の情報を出力 DataTable dtpを他の用途に使う(Clearする)とDataGridViewに表示してるものが消える
        {
            dt.Clear();
            dt = new DataTable();
            dgv_ReturnItem.DataSource = null;
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            dgv_ReturnItem.DataSource = dt;
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
            CmdFunc("DELETE FROM TBL_LINESLIP WHERE SLIP_ID=" + slipID);
            CmdFunc("DELETE FROM TBL_SLIP WHERE SLIP_ID=" + slipID);
            SlipFlag = 0;
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

            CmdFunc("INSERT INTO TBL_LINESLIP VALUES(" + lineslipID + "," + slipID + "," + int.Parse(txt_InProductID.Text) + ",4," + int.Parse(typeid) + "," + int.Parse(Price) + ")");
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
            //if (dtCheck("SELECT ls.LEND_ID FROM TBL_SLIP s,TBL_LINESLIP ls WHERE ls.ITEM_ID= " + txt_ProductID.Text + " AND s.SLIP_ID = ls.SLIP_ID AND s.SLIP_ID = (SELECT MAX(SLIP_ID) FROM TBL_LINESLIP WHERE LEND_ID=1 AND ITEM_ID= " + txt_ProductID.Text + ")") == 1)
            //{
            //    if (int.Parse(SetInfo("SELECT ls.LEND_ID FROM TBL_SLIP s,TBL_LINESLIP ls WHERE ls.ITEM_ID= " + txt_ProductID.Text + " AND s.SLIP_ID = ls.SLIP_ID AND s.SLIP_ID = (SELECT MAX(SLIP_ID) FROM TBL_LINESLIP WHERE LEND_ID=1 AND ITEM_ID= " + txt_ProductID.Text + ")")) == 1)
            //    {
            //        DateTime today = DateTime.Today;
            //        string slipdate = SetInfo("SELECT SLIP_DATE FROM TBL_SLIP WHERE SLIP_ID = (SELECT MAX(SLIP_ID) FROM TBL_LINESLIP WHERE LEND_ID<>4 AND ITEM_ID= " + txt_ProductID.Text + ")");
            //        string returndate = SetInfo("SELECT DateAdd('d',1,#" + slipdate + "#)");
            //        txt_ReturnDay.Text = returndate.Remove(10, 8);
            //        int latefees = int.Parse(SetInfo("SELECT DateDiff('d',#" + returndate + "#,#" + today + "#) FROM TBL_SLIP s WHERE SLIP_ID=" + slipID));
            //        if (latefees < 0)
            //        {
            //            txt_late.Text = "0";
            //        }
            //        else
            //        {
            //            txt_late.Text = (latefees *= 100).ToString();
            //        }
            //    }
            //}
            //if (dtCheck("SELECT ls.LEND_ID FROM TBL_SLIP s,TBL_LINESLIP ls WHERE ls.ITEM_ID= " + txt_ProductID.Text + " AND s.SLIP_ID = ls.SLIP_ID AND s.SLIP_ID = (SELECT MAX(SLIP_ID) FROM TBL_LINESLIP WHERE LEND_ID=2 AND ITEM_ID= " + txt_ProductID.Text + ")") == 1)
            //{
            //    DateTime today = DateTime.Today;
            //    string slipdate = SetInfo("SELECT SLIP_DATE FROM TBL_SLIP WHERE SLIP_ID = (SELECT MAX(SLIP_ID) FROM TBL_LINESLIP WHERE LEND_ID<>4 AND ITEM_ID= " + txt_ProductID.Text + ")");
            //    string returndate = SetInfo("SELECT DateAdd('d',2,#" + slipdate + "#)");
            //    txt_ReturnDay.Text = returndate.Remove(10, 8);
            //    int latefees = int.Parse(SetInfo("SELECT DateDiff('d',#" + returndate + "#,#" + today + "#) FROM TBL_SLIP s WHERE SLIP_ID=" + slipID));
            //    if (latefees < 0)
            //    {
            //        txt_late.Text = "0";
            //    }
            //    else
            //    {
            //        txt_late.Text = (latefees *= 100).ToString();
            //    }
            //}
            //if (dtCheck("SELECT ls.LEND_ID FROM TBL_SLIP s,TBL_LINESLIP ls WHERE ls.ITEM_ID= " + txt_ProductID.Text + " AND s.SLIP_ID = ls.SLIP_ID AND s.SLIP_ID = (SELECT MAX(SLIP_ID) FROM TBL_LINESLIP WHERE LEND_ID=3 AND ITEM_ID= " + txt_ProductID.Text + ")") == 1)
            //{
            //    DateTime today = DateTime.Today;
            //    string slipdate = SetInfo("SELECT SLIP_DATE FROM TBL_SLIP WHERE SLIP_ID = (SELECT MAX(SLIP_ID) FROM TBL_LINESLIP WHERE LEND_ID<>4 AND ITEM_ID= " + txt_ProductID.Text + ")");
            //    string returndate = SetInfo("SELECT DateAdd('d',7,#" + slipdate + "#)");
            //    txt_ReturnDay.Text = returndate.Remove(10, 8);
            //    int latefees = int.Parse(SetInfo("SELECT DateDiff('d',#" + returndate + "#,#" + today + "#) FROM TBL_SLIP s WHERE SLIP_ID=" + slipID));
            //    if (latefees < 0)
            //    {
            //        txt_late.Text = "0";
            //    }
            //    else
            //    {
            //        txt_late.Text = (latefees *= 100).ToString();
            //    }
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string tst = SetInfo("SELECT MAX(SLIP_ID) FROM TBL_LINESLIP WHERE LEND_ID<>4 AND ITEM_ID=" + txt_ProductID.Text);
            //MessageBox.Show(tst);
            //selectfunc("SELECT SLIP_DATE FROM TBL_SLIP WHERE SLIP_ID = (SELECT MAX(SLIP_ID) FROM TBL_LINESLIP WHERE LEND_ID<>4 AND ITEM_ID= " + txt_ProductID.Text + ")");
            //DateTime today = DateTime.Today;
            //string slipdate = SetInfo("SELECT SLIP_DATE FROM TBL_SLIP WHERE SLIP_ID = (SELECT MAX(SLIP_ID) FROM TBL_LINESLIP WHERE LEND_ID<>4 AND ITEM_ID= " + txt_ProductID.Text + ")");
            //string returndate = SetInfo("SELECT DateAdd('d',1,#" + slipdate + "#)");
            //MessageBox.Show(returndate);

            //for(int i=0;i<lt.Count;i++)
            //{
            //    MessageBox.Show(lt[i]);
            //}
        }


        int SlipFlag = 0;
        int selectedlsID;
        int lsIDpoint;
        public int slipID;

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
                                slipID = int.Parse(SetInfo("SELECT COUNT(*) FROM TBL_SLIP").ToString());
                                slipID++;
                                DateTime Today = DateTime.Today;
                                CmdFunc("INSERT INTO TBL_SLIP VALUES(" + slipID + "," + int.Parse(txt_MemberID.Text) + ",false,#" + Today.ToString() + "#,0,1,null)");
                                txt_MemberID.ReadOnly = true;
                                SlipFlag = 1;

                                

                               
                            }

                            txt_ProductID.Text = txt_InProductID.Text;
                            txt_title.Text = SetInfo("SELECT t.TITLE_NAME FROM TBL_TITLE t,TBL_ITEM i WHERE t.TITLE_ID=i.TITLE_ID AND i.ITEM_ID = " + txt_InProductID.Text);
                            InsertLineSlip();
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
            //int late = int.Parse(txt_late.Text);
         
                         
                rd.Add(txt_ReturnDay.Text);
                lt.Add(txt_late.Text);

                //selectfunc("SELECT t.TITLE_NAME,ty.TYPE_NAME,#" + txt_ReturnDay.Text + "# AS 返却予定日," + txt_late.Text + " AS 延滞料金 FROM TBL_TITLE t,TBL_TYPE ty,TBL_LEND l,TBL_LINESLIP ls,TBL_ITEM i WHERE ls.LEND_ID=l.LEND_ID AND ls.ITEM_ID=i.ITEM_ID AND i.TITLE_ID =t.TITLE_ID  AND t.TYPE_ID=ty.TYPE_ID AND ls.SLIP_ID=" + slipID);
                txt_money.Text = totalmoney.ToString() ;
            
        }
        public List<string> rd = new List<string>();
        public List<string> lt = new List<string>();

        public int totalmoney;
        private void txt_ProductID_TextChanged(object sender, EventArgs e)
        {
            if (txt_ProductID.Text != "")
            {
                txt_title.Text = SetInfo("SELECT t.TITLE_NAME FROM TBL_TITLE t,TBL_ITEM i WHERE t.TITLE_ID=i.TITLE_ID AND i.ITEM_ID = " + txt_ProductID.Text);
                txt_type.Text = SetInfo("SELECT y.TYPE_NAME FROM TBL_TITLE t,TBL_ITEM i,TBL_TYPE y WHERE t.TITLE_ID=i.TITLE_ID AND y.TYPE_ID=t.TYPE_ID AND i.ITEM_ID = " + txt_ProductID.Text);
                txt_OLDNEW.Text = SetInfo("SELECT o.OLD_NAME FROM TBL_OLD o,TBL_TITLE t,TBL_ITEM i WHERE o.OLD_ID=t.OLD_ID AND i.TITLE_ID = t.TITLE_ID AND i.ITEM_ID= " + txt_ProductID.Text);
                if (dtCheck("SELECT ls.LEND_ID FROM TBL_SLIP s,TBL_LINESLIP ls WHERE ls.ITEM_ID= " + txt_ProductID.Text + " AND s.SLIP_ID = ls.SLIP_ID AND s.SLIP_ID = (SELECT MAX(SLIP_ID) FROM TBL_LINESLIP WHERE LEND_ID=1 AND ITEM_ID= " + txt_ProductID.Text + ")") == 1)
                {
                    if (int.Parse(SetInfo("SELECT ls.LEND_ID FROM TBL_SLIP s,TBL_LINESLIP ls WHERE ls.ITEM_ID= " + txt_ProductID.Text + " AND s.SLIP_ID = ls.SLIP_ID AND s.SLIP_ID = (SELECT MAX(SLIP_ID) FROM TBL_LINESLIP WHERE LEND_ID=1 AND ITEM_ID= " + txt_ProductID.Text + ")")) == 1)
                    {
                        DateTime today = DateTime.Today;
                        string slipdate = SetInfo("SELECT SLIP_DATE FROM TBL_SLIP WHERE SLIP_ID = (SELECT MAX(SLIP_ID) FROM TBL_LINESLIP WHERE LEND_ID<>4 AND ITEM_ID= " + txt_ProductID.Text + ")");
                        string returndate = SetInfo("SELECT DateAdd('d',1,#" + slipdate + "#)");
                        txt_ReturnDay.Text = returndate.Remove(10, 8);
                        int latefees = int.Parse(SetInfo("SELECT DateDiff('d',#" + returndate + "#,#" + today + "#) FROM TBL_SLIP s WHERE SLIP_ID=" + slipID));
                        if (latefees < 0)
                        {
                            txt_late.Text = "0";
                        }
                        else
                        {
                            txt_late.Text = (latefees *= 100).ToString();
                            totalmoney += latefees;
                        }
                    }
                }
                if (dtCheck("SELECT ls.LEND_ID FROM TBL_SLIP s,TBL_LINESLIP ls WHERE ls.ITEM_ID= " + txt_ProductID.Text + " AND s.SLIP_ID = ls.SLIP_ID AND s.SLIP_ID = (SELECT MAX(SLIP_ID) FROM TBL_LINESLIP WHERE LEND_ID=2 AND ITEM_ID= " + txt_ProductID.Text + ")") == 1)
                {
                    DateTime today = DateTime.Today;
                    string slipdate = SetInfo("SELECT SLIP_DATE FROM TBL_SLIP WHERE SLIP_ID = (SELECT MAX(SLIP_ID) FROM TBL_LINESLIP WHERE LEND_ID<>4 AND ITEM_ID= " + txt_ProductID.Text + ")");
                    string returndate = SetInfo("SELECT DateAdd('d',2,#" + slipdate + "#)");
                    txt_ReturnDay.Text = returndate.Remove(10, 8);
                    int latefees = int.Parse(SetInfo("SELECT DateDiff('d',#" + returndate + "#,#" + today + "#) FROM TBL_SLIP s WHERE SLIP_ID=" + slipID));
                    if (latefees < 0)
                    {
                        txt_late.Text = "0";
                    }
                    else
                    {
                        txt_late.Text = (latefees *= 100).ToString();
                        totalmoney += latefees * 100;
                    }
                }
                if (dtCheck("SELECT ls.LEND_ID FROM TBL_SLIP s,TBL_LINESLIP ls WHERE ls.ITEM_ID= " + txt_ProductID.Text + " AND s.SLIP_ID = ls.SLIP_ID AND s.SLIP_ID = (SELECT MAX(SLIP_ID) FROM TBL_LINESLIP WHERE LEND_ID=3 AND ITEM_ID= " + txt_ProductID.Text + ")") == 1)
                {
                    DateTime today = DateTime.Today;
                    string slipdate = SetInfo("SELECT SLIP_DATE FROM TBL_SLIP WHERE SLIP_ID = (SELECT MAX(SLIP_ID) FROM TBL_LINESLIP WHERE LEND_ID<>4 AND ITEM_ID= " + txt_ProductID.Text + ")");
                    string returndate = SetInfo("SELECT DateAdd('d',7,#" + slipdate + "#)");
                    txt_ReturnDay.Text = returndate.Remove(10, 8);
                    int latefees = int.Parse(SetInfo("SELECT DateDiff('d',#" + returndate + "#,#" + today + "#) FROM TBL_SLIP s WHERE SLIP_ID=" + slipID));
                    if (latefees < 0)
                    {
                        txt_late.Text = "0";
                    }
                    else
                    {
                        txt_late.Text = (latefees *= 100).ToString();
                        totalmoney += latefees * 100;
                    }
                }
                if (ndflag == 0)
                {
                    dr = dts.NewRow();
                    dr["タイトル"] = txt_title.Text;
                    dr["CD DVD"] = txt_type.Text;
                    dr["返却予定日"] = txt_ReturnDay.Text;
                    dr["延滞料金"] = txt_late.Text;
                    dts.Rows.Add(dr);
                }
                dgv_ReturnItem.DataSource = ds;
                dgv_ReturnItem.DataMember = "Product";

            }
            else
            {
                txt_title.Clear();
                txt_type.Clear();
                txt_InProductID.Clear();
                txt_OLDNEW.Clear();
                txt_ProductID.Clear();
                txt_ReturnDay.Clear();
                txt_late.Clear();
                dt.Clear();
            }

            }
        int ndflag=0;

        private void Btn_ClearPID_Click(object sender, EventArgs e)
        {
            ndflag = 1;
            if (dgv_ReturnItem.RowCount >= 1)
            {
                dgv_ReturnItem.Rows.RemoveAt(dgv_ReturnItem.RowCount - 2);
            }

            {
                if (lsIDpoint > 0)
                {
                    CmdFunc("UPDATE TBL_SLIP SET SLIP_PRICE=" + txt_money.Text + " WHERE SLIP_ID=" + slipID);
                    CmdFunc("DELETE FROM TBL_LINESLIP WHERE LINESLIP_ID = " + selectedlsID.ToString());
                    selectedlsID--;

                    lsIDpoint--;
                    if (lsIDpoint == 0)
                    {
                        txt_money.Clear();
                        CmdFunc("DELETE FROM TBL_SLIP WHERE SLIP_ID= " + slipID);
                        SlipFlag = 0;
                        txt_ProductID.Clear();
                        totalmoney = 0;
                        ndflag = 0;

                    }
                    else
                    {
                        totalmoney = int.Parse(txt_money.Text) - int.Parse(txt_late.Text);
                        txt_money.Text = totalmoney.ToString();
                        txt_ProductID.Text = SetInfo("SELECT ITEM_ID FROM TBL_LINESLIP WHERE LINESLIP_ID=" + selectedlsID);
                        ndflag = 0;
                        
                    }
                    
                        //selectfunc("SELECT t.TITLE_NAME,ty.TYPE_NAME,#" + txt_ReturnDay.Text + "# AS 返却予定日," + txt_late.Text + " AS 延滞料金 FROM TBL_TITLE t,TBL_TYPE ty,TBL_LEND l,TBL_LINESLIP ls,TBL_ITEM i WHERE ls.LEND_ID=l.LEND_ID AND ls.ITEM_ID=i.ITEM_ID AND i.TITLE_ID =t.TITLE_ID  AND t.TYPE_ID=ty.TYPE_ID AND ls.SLIP_ID=" + slipID);
                }
            }
        }

        private void Btn_ClearMID_Click(object sender, EventArgs e)
        {
            txt_MemberID.Clear();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearfunc();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (dtCheck("SELECT * FROM TBL_SLIP WHERE SLIP_ID=" + slipID) == 1)
            {
                SlipFlag = 0;
                rh.MoveOnLRConf(flag);
            }
            else
            {
                MessageBox.Show("商品が選択されていません");
            }
            
        }

        private void txt_MemberID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txt_InProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void Return_VisibleChanged(object sender, EventArgs e)
        {
            if (SlipFlag == 1)
            {
                clearfunc();
            }
            dt.Clear();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //dt.Columns.Add("タイトル", typeof(string));
            //dt.Columns.Add("CD DVD",typeof(string));
            //dt.Columns.Add("返却予定日",typeof(string));
            //dt.Columns.Add("延滞料金", typeof(string));
            //dt.Rows.Add(txt_title.Text, txt_type.Text, txt_ReturnDay.Text, txt_late.Text);
            //dgv_ReturnItem.DataSource = dt;


            dts = ds.Tables.Add("Product");
 
            dts.Columns.Add("タイトル");
            dts.Columns.Add("CD DVD");
            dts.Columns.Add("返却予定日");
            dts.Columns.Add("延滞料金");

            dr = dts.NewRow();
            dr["タイトル"] = txt_title.Text;
            dr["CD DVD"] = txt_type.Text;
            dr["返却予定日"] = txt_ReturnDay.Text;
            dr["延滞料金"] = txt_late.Text;
            dts.Rows.Add(dr);

            dgv_ReturnItem.DataSource = ds;
            dgv_ReturnItem.DataMember = "Product";


        }

        private void button4_Click(object sender, EventArgs e)
        {

            dr = dts.NewRow();
            dr["タイトル"] = txt_title.Text;
            dr["CD DVD"] = txt_type.Text;
            dr["返却予定日"] = txt_ReturnDay.Text;
            dr["延滞料金"] = txt_late.Text;
            dts.Rows.Add(dr);


            dgv_ReturnItem.DataSource = ds;

        }

        
    }
}

