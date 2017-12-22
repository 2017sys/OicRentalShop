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
    public partial class ReturnConf : UserControl
    {
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        DataTable dtm = new DataTable();
        DataTable dtu = new DataTable();

        private string SetInfo(string cmdstr) //SQLでデータが1行1列だけ出力される形で取り出したいデータを持ってくるのに使う　数値で使うならint.Parse(SetInfo("SQL"))
        {
            dt.Clear();
            dt = new DataTable();
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            return dt.Rows[0][0].ToString();
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

        public void selectfunc(string cmdstr)//DataGridViewにレジを通した商品の情報を出力 DataTable dtpを他の用途に使う(Clearする)とDataGridViewに表示してるものが消える
        {
            dt.Clear();
            dt = new DataTable();
            dgv_PayInfo.DataSource = null;
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            dgv_PayInfo.DataSource = dt;
            //dgv_PayInfo.AutoResizeColumns();
            //dgv_MemberInfo.AutoSizeColumnsMode = DataGridViewAutoSizeRowsMode.fi

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

        RegisterHome rh;
        Return rr;
        public ReturnConf(RegisterHome fm1, Return fm2)
        {
            InitializeComponent();
            rh = fm1;
            rr = fm2;
        }

        int flag = 1;
        int visflag;
        int treaflag;
        int totalmoney;
        private void ReturnConf_Load(object sender, EventArgs e)
        {
            dgv_PayInfo.DataMember = "Product";
            dgv_PayInfo.DataSource = rr.ds;
            txt_TotalMoney.Text = rr.txt_money.Text;
            //for (int i = 0; i < rr.rd.Count; i++)
            //{
            //    selectfunc("SELECT t.TITLE_NAME,ty.TYPE_NAME,#" + rr.rd[i] + "# AS 返却予定日," + rr.lt[i] + " AS 延滞料金 FROM TBL_TITLE t,TBL_TYPE ty,TBL_LEND l,TBL_LINESLIP ls,TBL_ITEM i WHERE ls.LEND_ID=l.LEND_ID AND ls.ITEM_ID=i.ITEM_ID AND i.TITLE_ID =t.TITLE_ID  AND t.TYPE_ID=ty.TYPE_ID AND ls.SLIP_ID=" + rr.slipID);
            //}
            DateTime today = DateTime.Today;
            selectfuncm("SELECT MEMBER_POINT AS 所有ポイント,MEMBER_NAME AS 氏名,MEMBER_KANA AS 読み,MEMBER_SEX AS 性別,DateDiff('yyyy',MEMBER_BIRTH,#" + today + "#) AS 年齢 FROM TBL_MEMBER WHERE MEMBER_ID=" + rr.txt_MemberID.Text);
            totalmoney = int.Parse(txt_TotalMoney.Text);
            lbl_MemberID.Text = rr.txt_MemberID.Text;
            visflag++;
            treaflag = 0;
            visflag = 0;
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            if (treaflag == 1)
            {
                dtu.Clear();
                dtu = new DataTable();
                da = new OleDbDataAdapter("SELECT ITEM_ID FROM TBL_LINESLIP WHERE SLIP_ID=" + rr.slipID, cn);
                da.Fill(dtu);
                CmdFunc("UPDATE TBL_SLIP SET SLIP_USEDPOINT = " + usedpoint + " WHERE SLIP_ID=" + rr.slipID);
                int lscnt = int.Parse(SetInfo("SELECT COUNT(*) FROM TBL_LINESLIP GROUP BY SLIP_ID HAVING SLIP_ID=" + rr.slipID).ToString());
                for (int i = 0; i < lscnt; i++)
                {
                    CmdFunc("UPDATE TBL_ITEM SET ITEM_STATE = true WHERE ITEM_ID =" + dtu.Rows[i][0].ToString());
                }

                txt_Point.Clear();
                txt_PayMoney.Clear();
                dt.Clear();
                dtm.Clear();
                dtu.Clear();
                lbl_MemberID.Text = "";
                txt_ReturnMoney.Clear();
                int memberpoint = int.Parse(SetInfo("SELECT MEMBER_POINT FROM TBL_MEMBER WHERE MEMBER_ID=" + rr.txt_MemberID.Text)) - usedpoint;
                CmdFunc("UPDATE TBL_MEMBER SET MEMBER_POINT = " + memberpoint + " WHERE MEMBER_ID=" + rr.txt_MemberID.Text);
                rr.Commit();
                rh.panel.Controls.Clear();
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

        private void ReturnConf_VisibleChanged(object sender, EventArgs e)
        {
            if (visflag >= 1)
            {
                txt_TotalMoney.Text = SetInfo("SELECT SLIP_PRICE FROM TBL_SLIP WHERE SLIP_ID=" + rr.slipID);
                selectfunc("SELECT t.TITLE_NAME AS 商品名,ty.TYPE_NAME AS 種類,l.LEND_PRERIOD AS 貸出期間,ls.LS_Price AS 金額 FROM TBL_TITLE t,TBL_TYPE ty,TBL_LEND l,TBL_LINESLIP ls,TBL_ITEM i WHERE ls.LEND_ID=l.LEND_ID AND ls.ITEM_ID=i.ITEM_ID AND i.TITLE_ID =t.TITLE_ID  AND t.TYPE_ID=ty.TYPE_ID AND ls.SLIP_ID=" + rr.slipID);
                DateTime today = DateTime.Today;
                selectfuncm("SELECT MEMBER_POINT AS 所有ポイント,MEMBER_NAME AS 氏名,MEMBER_KANA AS 読み,MEMBER_SEX AS 性別,DateDiff('yyyy',MEMBER_BIRTH,#" + today + "#) AS 年齢 FROM TBL_MEMBER WHERE MEMBER_ID=" + rr.txt_MemberID.Text);
                totalmoney = int.Parse(txt_TotalMoney.Text);
                lbl_MemberID.Text = rr.txt_MemberID.Text;
                treaflag = 0;
            }
        }

        int usedpoint = 0;
        private void txt_Point_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (txt_Point.Text.Length >= 1)
                {
                    if (int.Parse(SetInfo("SELECT MEMBER_POINT FROM TBL_MEMBER WHERE MEMBER_ID=" + rr.txt_MemberID.Text)) >= int.Parse(txt_Point.Text))
                    {
                        if (int.Parse(txt_TotalMoney.Text) - int.Parse(txt_Point.Text) >= 0)
                        {
                            usedpoint = int.Parse(txt_Point.Text);
                            txt_TotalMoney.Text = (int.Parse(txt_TotalMoney.Text) - int.Parse(txt_Point.Text)).ToString();
                            txt_PayMoney.Focus();
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
            }
        }

        private void txt_PayMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            int returnmoney;
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txt_PayMoney.Text.Length >= 1)
                {
                    returnmoney = int.Parse(txt_TotalMoney.Text) - int.Parse(txt_PayMoney.Text);
                    returnmoney *= -1;
                    txt_PayMoney.Clear();
                    if (returnmoney >= 0)
                    {
                        txt_ReturnMoney.Text = returnmoney.ToString();
                        treaflag = 1;
                    }
                    else
                    {
                        MessageBox.Show("支払金額が不足しています");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dgv_PayInfo.DataMember = "Product";
            //dgv_PayInfo.DataSource = rr.ds;
        }
    }
}
