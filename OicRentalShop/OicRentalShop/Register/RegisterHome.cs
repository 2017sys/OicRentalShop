using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OicRentalShop.Manage
{
    public partial class RegisterHome : Form
    {
        public static ItemAdd.ItemAdd ia;
        public static ItemInfo.ItemInfo ii;
        public static Lend.Lend ll;
        public static Lend.LendConf lc;
        public static MemberAdd.MemberAdd mm;
        public static PriceList.PriceList pp;
        public static Return.Return rr;
        public static Return.ReturnConf rc;
        public static MemberAdd.MemberAddConfirmation ma;
        public static ItemAdd.ItemAddConfirmation ic;
        public static Title.TitleAdd ta;



        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();
         

        public RegisterHome()
        {
            InitializeComponent();
        }

        public static void GoNext(int flag)
        {
            if (flag == 0)
            {
                mm.Visible = false;
                ma.Visible = true;
            }
            else
            {
                ia.Visible = false;
                ic.Visible = true;
            }
        }

        public static void cancel(int flag)
        {
            if (flag == 0)
            {
                mm.Visible = true;
                ma.Visible = false;
            }
            else
            {
                ia.Visible = true;
                ic.Visible = false;
            }
        }

        public void MoveOnLRConf(int flag)
        {
            if(flag==0)
            {
                panel.Controls.Clear();
                panel.Controls.Add(lc);
                lc.Visible = true;
            }
            else if(flag==1)
            {
                panel.Controls.Clear();
                panel.Controls.Add(rc);
                rc.Visible = true;
            }
        }

        public void ReturnLRHome(int flag)
        {
            if(flag==0)
            {
                panel.Controls.Clear();
                panel.Controls.Add(ll);
                ll.Visible = true;
            }
            else if(flag==1)
            {
                panel.Controls.Clear();
                panel.Controls.Add(rr);
                rr.Visible = true;
            }
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
           
            ii = new ItemInfo.ItemInfo();

           
            pp = new PriceList.PriceList();
            rr = new Return.Return(this,rc);
            rc = new Return.ReturnConf(this,rr);
          
            ic = new ItemAdd.ItemAddConfirmation();
           
            
            
        }

        private void btn_Top_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Lend_Click(object sender, EventArgs e)
        {
            ll = new Lend.Lend(this);
            lc = new Lend.LendConf(this, ll);//this
            panel.Controls.Clear();
            panel.Controls.Add(ll);
            ll.Visible = true;
            
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(rr);
            rr.Visible = true;
        }

        private void btn_ItemInfo_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(ii);
            ii.Visible = true;
        }

        private void btn_PriceList_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(pp);
            pp.Visible = true;
        }

        private void btn_ItemAdd_Click(object sender, EventArgs e)
        {
            ia = new ItemAdd.ItemAdd(this);
            panel.Controls.Clear();
            panel.Controls.Add(ia);
            panel.Controls.Add(ic);
            ia.Visible = true;
        }

        private void btn_MemberAdd_Click(object sender, EventArgs e)
        {
            ma = new MemberAdd.MemberAddConfirmation();
            mm = new MemberAdd.MemberAdd();
            panel.Controls.Clear();
            panel.Controls.Add(mm);
            panel.Controls.Add(ma);
            mm.Visible = true;
        }

        private void btn_Title_Click(object sender, EventArgs e)
        {
            ta = new Title.TitleAdd();
            panel.Controls.Clear();
            panel.Controls.Add(ta);
            ta.Visible = true;
        }



        public void add_Log(String operation, String table, String text)
        {

            OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = cn;
            cn.Open();

            //int staffid = int.Parse(txt_staffid.Text);
            
            String sql = "INSERT INTO TBL_LOG(STAFF_ID, LOG_NAME, LOG_TABLE_NAME, LOG_DATE_TIME, LOG_NOTE) VALUES (";
            sql += lbl_LoginID.Text + ",";
            sql += "'" + operation + "',";
            sql += "'" + table + "',";
            sql += "'" + System.DateTime.Now + "',";
            sql += "'" + text + "')";

            Cmd.CommandText = sql;
            Cmd.ExecuteNonQuery();
            cn.Close();
        }

        private string ZeroCut(string Num)
        {
            string ZeroCutNum = int.Parse(Num).ToString();
            return ZeroCutNum;
        }

        private string SetInfo(string cmdstr)
        {
            dt.Clear();
            dt = new DataTable();
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            return dt.Rows[0][0].ToString();
        }

        private void txt_staffid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_staffid.TextLength == 6)
                {
                    lbl_staffname.Text = SetInfo("SELECT STAFF_NAME FROM TBL_STAFF WHERE STAFF_ID=" + ZeroCut(txt_staffid.Text));
                    lbl_LoginID.Text = ZeroCut(txt_staffid.Text);
                    txt_staffid.Text = "";
                }
            }
        }


    }
}
