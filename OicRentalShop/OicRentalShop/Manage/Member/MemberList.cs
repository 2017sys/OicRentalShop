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

namespace OicRentalShop.Manage.Member
{
    public partial class MemberList : UserControl
    {
        OleDbConnection cn = new OleDbConnection();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        public MemberList()
        {
            InitializeComponent();
        }

        private void selectfunc(string cmdstr)
        {
            dt.Clear();
            dt = new DataTable();
            dgv_MemberInfo.DataSource = null;
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            dgv_MemberInfo.DataSource = dt;
            dgv_MemberInfo.AutoResizeColumns();
        }

        private void MemberList_Load(object sender, EventArgs e)
        {
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            String sID = txt_MemberID.Text;
            String sName = txt_MemberName.Text;
            String sPhone = txt_PhoneNumber.Text;

            if (txt_PhoneNumber.TextLength == 10)
            {
                selectfunc("SELECT * FROM TBL_MEMBER WHERE MEMBER_NAME LIKE '%" + sName + "%' AND MEMBER_ID LIKE '%" + sID + "%' AND MEMBER_TEL LIKE '%" + sPhone + "%'");
            }
            else
            {
                selectfunc("SELECT * FROM TBL_MEMBER WHERE MEMBER_NAME LIKE '%" + sName + "%' AND MEMBER_ID LIKE '%" + sID + "%' AND MEMBER_MOBILE LIKE '%" + sPhone + "%'");
            }
        }

        


    }
}
