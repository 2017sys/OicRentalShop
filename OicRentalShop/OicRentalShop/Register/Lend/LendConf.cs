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

        private void selectfunc(string cmdstr)//DataGridViewにレジを通した商品の情報を出力 DataTable dtpを他の用途に使う(Clearする)とDataGridViewに表示してるものが消える
        {
            dt.Clear();
            dt = new DataTable();
            dgv_PayInfo.DataSource = null;
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            dgv_PayInfo.DataSource = dt;
            dgv_PayInfo.AutoResizeColumns();
            
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

            int lscnt = int.Parse(SetInfo("SELECT COUNT(*) FROM TBL_LINESLIP GROUP BY SLIP_ID HAVING SLIP_ID=" + ll.slipID).ToString());
            for (int i = 0; i < lscnt; i++)
            {
                dt.Clear();
                dt = new DataTable();
                da = new OleDbDataAdapter("SELECT ITEM_ID FROM TBL_LINESLIP WHERE SLIP_ID=" + ll.slipID, cn);
                da.Fill(dt);
                CmdFunc("UPDATE TBL_ITEM SET ITEM_STATE = false WHERE ITEM_ID =" + dt.Rows[i][0].ToString());
                ll.Commit();
                this.Visible = false;
                
            }
            
        }

        private void btn_Redo_Click(object sender, EventArgs e)
        {
            rh.ReturnLRHome(flag);
        }

        private void LendConf_Load(object sender, EventArgs e)
        {
            txt_TotalM.Text=SetInfo("SELECT SLIP_PRICE FROM TBL_SLIP WHERE SLIP_ID="+ll.slipID);
            selectfunc("SELECT t.TITLE_NAME,ty.TYPE_NAME,l.LEND_PRERIOD,ls.LS_Price FROM TBL_TITLE t,TBL_TYPE ty,TBL_LEND l,TBL_LINESLIP ls,TBL_ITEM i WHERE ls.LEND_ID=l.LEND_ID AND ls.ITEM_ID=i.ITEM_ID AND i.TITLE_ID =t.TITLE_ID  AND t.TYPE_ID=ty.TYPE_ID AND ls.SLIP_ID=" + ll.slipID);
            DateTime today = DateTime.Today;
            selectfuncm("SELECT MEMBER_NAME,MEMBER_KANA,MEMBER_SEX,DateDiff('yyyy',MEMBER_BIRTH,#" + today + "#) FROM TBL_MEMBER WHERE MEMBER_ID=" + ll.txt_MemberID.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ll.slipID.ToString());
            selectfunc("SELECT t.TITLE_NAME,ty.TYPE_NAME,l.LEND_PRERIOD,ls.LS_Price FROM TBL_TITLE t,TBL_TYPE ty,TBL_LEND l,TBL_LINESLIP ls,TBL_ITEM i WHERE ls.LEND_ID=l.LEND_ID AND ls.ITEM_ID=i.ITEM_ID AND i.TITLE_ID =t.TITLE_ID  AND t.TYPE_ID=ty.TYPE_ID AND ls.SLIP_ID=" + ll.slipID);

        }
    }
}
