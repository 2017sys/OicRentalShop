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

            dgv_MemberInfo.Columns.Clear();
            dgv_MemberInfo.ClearSelection();
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

            //DataGridViewButtonColumnの作成
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            //列の名前を設定
            column.Name = "Button";
            //全てのボタンに"詳細閲覧"と表示する
            column.UseColumnTextForButtonValue = true;
            column.Text = "削除";
            //DataGridViewに追加する
            dgv_MemberInfo.Columns.Add(column);
        }

        private void dgv_MemberInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridView dgv = (DataGridView)sender;
            //"Button"列ならば、ボタンがクリックされた
            if (dgv.Columns[e.ColumnIndex].Name == "Button")
            {
                if (DialogResult.Yes == MessageBox.Show(dgv.Rows[e.RowIndex].Cells[2].Value + "のデータを削除してよろしいですか？", "確認",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    CmdFunc("UPDATE TBL_MEMBER SET MEMBER_DELETE = true WHERE MEMBER_ID ="+dgv.Rows[e.RowIndex].Cells[0].Value);
                }


            }
        }

        private string SetInfo(string cmdstr)
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


    }
}
