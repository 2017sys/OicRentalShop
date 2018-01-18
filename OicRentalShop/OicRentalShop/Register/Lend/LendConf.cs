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

namespace OicRentalShop.Manage.Lend
{
    public partial class LendConf : UserControl
    {

        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        DataTable dtm = new DataTable();
        DataTable dtu = new DataTable();
        DataTable dts = new DataTable();
        DataTable dts1 = new DataTable();
        DataTable dts2= new DataTable();
        DataTable dts3 = new DataTable();
        RegisterHome rh;
        Lend ll;
        public LendConf(RegisterHome fm,Lend fm2)
        {
            InitializeComponent();
            rh = fm;
            ll = fm2;
        }

        private string SetInfo(string cmdstr) //SQLでデータが1行1列だけ出力される形で取り出したいデータを持ってくるのに使う　数値で使うならint.Parse(SetInfo("SQL"))
        {
            dts.Clear();
            dts = new DataTable();
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dts);
            return dts.Rows[0][0].ToString();
        }

        private void EventDiscount()
        {
            if(EventDiscountCheck()==true)
            {
                EventDiscountAdd();
            }
            else
            {
                MessageBox.Show("ない");
            }
        }

        private Boolean EventDiscountCheck()
        {
            DateTime Today = DateTime.Today;
            dts.Clear();
            dts = new DataTable();
            da = new OleDbDataAdapter("SELECT * FROM TBL_EVENT  WHERE EVENT_START<= #" + Today + "# AND #" + Today + "# <=EVENT_END AND EVENT_DELETE=false", cn);
            da.Fill(dts);
            if(dts.Rows.Count>=1)
            {
                return true;
            }
            return false;
        }

        private string SerchID(string TblName, string Name)
        {

            string ID = SetInfo("SELECT " + TblName + "_ID FROM TBL_" + TblName + " WHERE " + TblName + "_NAME" + "= '" + Name + "'");
            return ID;
        }

        private string SerchName(string TblName,string Id)
        {
            string Name = SetInfo("SELECT " + TblName + "_NAME FROM TBL_" + TblName + " WHERE " + TblName + "_ID" + "= " + Id + "");
            return Name;
        }

        private void EventDiscountAdd()
        {
            DateTime Today = DateTime.Today;
            dts1.Clear();
            dts1 = new DataTable();
            da = new OleDbDataAdapter("SELECT EVENT_ID FROM TBL_EVENT  WHERE EVENT_START<= #" + Today + "# AND #" + Today + "# <=EVENT_END AND EVENT_DELETE=false", cn);
            da.Fill(dts1);

            for(int i=0;i<dts1.Rows.Count;i++)
            {
                EventDiscountComparison(int.Parse(dts1.Rows[i][0].ToString()));
            }
        }

        private void EventDiscountComparison(int eventId)
        {
            DateTime Today = DateTime.Today;
            dts2.Clear();
            dts2 = new DataTable();
            da = new OleDbDataAdapter("SELECT EVENT_NAME,EVENT_PRICE,TYPE_ID,EVENT_OLD,EVENT_NUM FROM TBL_EVENT  WHERE EVENT_ID=" + eventId, cn);
            da.Fill(dts2);
            int num=0;
            int count = 0;
            for(int i=0;i<dgv_PayInfo.RowCount-1;i++)
            {
                if (SerchID("TYPE", dgv_PayInfo.Rows[i].Cells[1].Value.ToString()) == dts2.Rows[0][2].ToString() && (SerchID("OLD", dgv_PayInfo.Rows[i].Cells[2].Value.ToString()) == dts2.Rows[0][3].ToString()||dts2.Rows[0][3].ToString()==""))
                {
                     
                    if (count < int.Parse(dts2.Rows[0][4].ToString()))
                    {
                        num += int.Parse(dgv_PayInfo.Rows[i].Cells[4].Value.ToString());
                        count++;
                    }
                }
            }
            string old;
            if(dts2.Rows[0][3].ToString()=="1")
            {
                old = "新作";
            }
            else if (dts2.Rows[0][3].ToString() == "2")
            {
                old = "旧作";
            }
            else
            {
                old = "すべて";
            }
            if(num>int.Parse(dts2.Rows[0][1].ToString()))
            {
                int Discount=num-int.Parse(dts2.Rows[0][1].ToString());
                dgv_EventDiscount.Rows.Add(dts2.Rows[0][0],SerchName("TYPE",dts2.Rows[0][2].ToString()),old,Discount);
                txt_EventDiscount.Text = (int.Parse(txt_EventDiscount.Text) + Discount).ToString();
                txt_TotalMoney.Text = (int.Parse(txt_TotalMoney.Text) - Discount).ToString();
            }
            else
            {

            }
            
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

        private void selectfunc(string cmdstr)//DataGridViewにレジを通した商品の情報を出力 DataTable dtpを他の用途に使う(Clearする)とDataGridViewに表示してるものが消える
        {
            dt.Clear();
            dt = new DataTable();
            dgv_PayInfo.DataSource = null;
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            dgv_PayInfo.DataSource = dt;
            
        }

        private void selectfuncm(string cmdstr)//DataGridViewにレジを通した商品の情報を出力 DataTable dtpを他の用途に使う(Clearする)とDataGridViewに表示してるものが消える
        {
            dtm.Clear();
            dtm = new DataTable();
            dgv_MemberInfo.DataSource = null;
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dtm);
            dgv_MemberInfo.DataSource = dtm;
            dgv_MemberInfo.AutoResizeColumns();
        }


        int flag = 0;
        private void btn_Pay_Click(object sender, EventArgs e)
        {
            if (treaflag == 1)
            {
                dtu.Clear();
                dtu = new DataTable();
                da = new OleDbDataAdapter("SELECT ITEM_ID FROM TBL_LINESLIP WHERE SLIP_ID=" + ll.slipID, cn);
                da.Fill(dtu);
                CmdFunc("UPDATE TBL_SLIP SET SLIP_USEDPOINT = " + usedpoint + ",EVENT_DISCOUNT = "+ int.Parse(txt_EventDiscount.Text)+ " WHERE SLIP_ID=" + ll.slipID);
                int lscnt = int.Parse(SetInfo("SELECT COUNT(*) FROM TBL_LINESLIP GROUP BY SLIP_ID HAVING SLIP_ID=" + ll.slipID).ToString());
                for (int i = 0; i < lscnt; i++)
                {
                    CmdFunc("UPDATE TBL_ITEM SET ITEM_STATE = false WHERE ITEM_ID =" + dtu.Rows[i][0].ToString());
                }

                txt_Point.Clear();
                txt_PayMoney.Clear();
                dt.Clear();
                dtm.Clear();
                dtu.Clear();
                lbl_MemberID.Text = "";
                txt_ReturnMoney.Clear();
                int memberpoint = int.Parse(SetInfo("SELECT MEMBER_POINT FROM TBL_MEMBER WHERE MEMBER_ID=" + ll.txt_MemberID.Text)) - usedpoint+(int.Parse(txt_TotalMoney.Text)-usedpoint)/100;
                CmdFunc("UPDATE TBL_MEMBER SET MEMBER_POINT = " + memberpoint + " WHERE MEMBER_ID=" + ll.txt_MemberID.Text);
                ll.Commit();
                //rh.panel.Controls.Clear();
                txt_Point.ReadOnly = false;
                txt_PayMoney.ReadOnly = false;
                rh.CommitLend();
                string text = "貸出";

                text += "を追加";

                rh.add_Log("追加", "伝票/伝票明細", "貸出伝票を追加");
                rh.add_Log("編集", "商品", "貸出可能状態を変更");

            }
            else
            {
                MessageBox.Show("支払金額が不足しています");
            }
        }

        private void btn_Redo_Click(object sender, EventArgs e)
        {
            rh.ReturnLRHome(flag);
        }

        int visflag=0;

        int totalmoney;
        int treaflag;
        private void txt_KeepM_KeyUp(object sender, KeyEventArgs e)
        {
            int returnmoney;
            if (e.KeyData == Keys.Enter)
            {
                if (txt_PayMoney.Text.Length >= 1)
                {
                    returnmoney = int.Parse(txt_TotalMoney.Text) - int.Parse(txt_PayMoney.Text);
                    returnmoney *= -1;
                    if (returnmoney >= 0)
                    {
                        txt_ReturnMoney.Text = returnmoney.ToString();
                        treaflag = 1;
                        txt_PayMoney.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("支払金額が不足しています");
                        txt_PayMoney.Clear();
                    }
                }
            }
        }

        int usedpoint = 0;
        private void txt_Point_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txt_Point.Text.Length >= 1)
                {
                    if (int.Parse(SetInfo("SELECT MEMBER_POINT FROM TBL_MEMBER WHERE MEMBER_ID=" + ll.txt_MemberID.Text))>=int.Parse(txt_Point.Text))
                    {
                        if(int.Parse(txt_TotalMoney.Text)-int.Parse(txt_Point.Text)>=0)
                        {
                            usedpoint = int.Parse(txt_Point.Text);
                            txt_TotalMoney.Text = (int.Parse(txt_TotalMoney.Text) - int.Parse(txt_Point.Text)).ToString();
                            txt_Point.ReadOnly = true;
                        }
                        else
                        {
                            MessageBox.Show("合計金額より多くのポイントを使おうとしています。");
                            txt_Point.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("所有ポイントより多くのポイントを利用しようとしています。");
                        txt_Point.Clear();
                    }
                }

                txt_PayMoney.Focus();
            }
        }


        private void LendConf_VisibleChanged(object sender, EventArgs e)
        {
            if (visflag >= 1)
            {
                txt_TotalMoney.Text = SetInfo("SELECT SLIP_PRICE FROM TBL_SLIP WHERE SLIP_ID=" + ll.slipID);
                selectfunc("SELECT t.TITLE_NAME AS 商品名,ty.TYPE_NAME AS 種類,l.LEND_PRERIOD AS 貸出期間,ls.LS_Price AS 金額 FROM TBL_TITLE t,TBL_TYPE ty,TBL_LEND l,TBL_LINESLIP ls,TBL_ITEM i WHERE ls.LEND_ID=l.LEND_ID AND ls.ITEM_ID=i.ITEM_ID AND i.TITLE_ID =t.TITLE_ID  AND t.TYPE_ID=ty.TYPE_ID AND ls.SLIP_ID=" + ll.slipID);
                DateTime today = DateTime.Today;
                selectfuncm("SELECT MEMBER_POINT AS 所有ポイント,MEMBER_NAME AS 氏名,MEMBER_KANA AS 読み,MEMBER_SEX AS 性別,DateDiff('yyyy',MEMBER_BIRTH,#" + today + "#) AS 年齢 FROM TBL_MEMBER WHERE MEMBER_ID=" + ll.txt_MemberID.Text);
                totalmoney = int.Parse(txt_TotalMoney.Text);
                lbl_MemberID.Text = ll.txt_MemberID.Text;
                treaflag = 0;
            }
        }

        private void LendConf_Load(object sender, EventArgs e)
        {
            txt_TotalMoney.Text = SetInfo("SELECT SLIP_PRICE FROM TBL_SLIP WHERE SLIP_ID=" + ll.slipID);
            selectfunc("SELECT t.TITLE_NAME AS 商品名,ty.TYPE_NAME AS 商品タイプ,ol.OLD_NAME AS 新作旧作,l.LEND_PRERIOD AS 貸出期間,ls.LS_Price AS 金額 FROM TBL_TITLE t,TBL_TYPE ty,TBL_LEND l,TBL_LINESLIP ls,TBL_ITEM i,TBL_OLD ol WHERE ls.LEND_ID=l.LEND_ID AND ls.ITEM_ID=i.ITEM_ID AND i.TITLE_ID =t.TITLE_ID  AND t.TYPE_ID=ty.TYPE_ID AND t.OLD_ID=ol.OLD_ID AND ls.SLIP_ID=" + ll.slipID);
            DateTime today = DateTime.Today;
            selectfuncm("SELECT MEMBER_POINT AS 所有ポイント,MEMBER_NAME AS 氏名,MEMBER_KANA AS 読み,MEMBER_SEX AS 性別,DateDiff('yyyy',MEMBER_BIRTH,#" + today + "#) AS 年齢 FROM TBL_MEMBER WHERE MEMBER_ID=" + ll.txt_MemberID.Text);
            totalmoney = int.Parse(txt_TotalMoney.Text);
            lbl_MemberID.Text = ll.txt_MemberID.Text;
            visflag++;
            treaflag = 0;
            EventDiscount();
        }


    }
}
