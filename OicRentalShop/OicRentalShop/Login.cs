using OicRentalShop.Manage;
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

namespace OicRentalShop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Msg.Visible = false;   
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            String mgrID = txt_MgrID.Text;
            String pass = txt_PassWord.Text;


            if (txt_MgrID.TextLength > 0 && txt_PassWord.TextLength > 0)
            {
                OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM TBL_STAFF WHERE STAFF_ID =" + mgrID + " AND STAFF_TEL='" + pass + "' AND STAFF_OWNER = TRUE", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    ManageHome mng = new ManageHome();
                    this.Hide();
                    mng.ShowDialog();
                    this.Show();
                }
                else
                {
                    Msg.Text = "ログインできません。ユーザー名、パスワードを確認してください。";
                    Msg.Visible = true;
                }
            }
            else
            {
                Msg.Text = "IDまたはパスワードを入力してください。";
                Msg.Visible = true;
            }
            
            
        }

        private void btn_Redo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}
