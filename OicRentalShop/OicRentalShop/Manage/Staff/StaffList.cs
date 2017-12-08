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

namespace OicRentalShop.Manage.Staff
{
    public partial class lbl_Title : UserControl
    {
        OleDbConnection cn = new OleDbConnection();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        public lbl_Title()
        {
            InitializeComponent();
        }

        private void selectfunc(string cmdstr)
        {
            dt.Clear();
            dt = new DataTable();
            dgv_StaffList.DataSource = null;
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            dgv_StaffList.DataSource = dt;
            dgv_StaffList.AutoResizeColumns();
        }

        private void StaffList_Load(object sender, EventArgs e)
        {
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
            selectfunc("SELECT * FROM TBL_STAFF WHERE STAFF_DELETE=false");

            //DataGridViewButtonColumnの作成
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            //列の名前を設定
            column.Name = "Button";
            //全てのボタンに"詳細閲覧"と表示する
            column.UseColumnTextForButtonValue = true;
            column.Text = "削除";
            //DataGridViewに追加する
            dgv_StaffList.Columns.Add(column);
        }

        private void dgv_StaffList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            //"Button"列ならば、ボタンがクリックされた
            if (dgv.Columns[e.ColumnIndex].Name == "Button")
            {
                if (DialogResult.Yes == MessageBox.Show("従業員番号　" + dgv.Rows[e.RowIndex].Cells[1].Value + "　従業員名　" + dgv.Rows[e.RowIndex].Cells[2].Value + "　のデータを削除してよろしいですか？", "確認",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    CmdFunc("UPDATE TBL_STAFF SET STAFF_DELETE = true WHERE STAFF_ID =" + dgv.Rows[e.RowIndex].Cells[1].Value);
                }


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

    }
}