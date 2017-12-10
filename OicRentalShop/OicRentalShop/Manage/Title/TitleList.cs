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

namespace OicRentalShop.Manage.Title
{
    public partial class TitleList : UserControl
    {

        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();


        public TitleList()
        {
            InitializeComponent();
        }

        private void selectfunc(string cmdstr)
        {
            dt.Clear();
            dt = new DataTable();
            dgv_TitleInfo.DataSource = null;
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            dgv_TitleInfo.DataSource = dt;
            dgv_TitleInfo.AutoResizeColumns();
        }

        private void TitleList_Load(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ManageHome.GoNext(4);
        }

        private void dgv_TitleInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            //"Button"列ならば、ボタンがクリックされた
            if (dgv.Columns[e.ColumnIndex].Name == "DELETE")
            {
                if (DialogResult.Yes == MessageBox.Show("タイトルID　" + dgv.Rows[e.RowIndex].Cells[1].Value + "　タイトル名　" + dgv.Rows[e.RowIndex].Cells[2].Value + "　のデータを削除してよろしいですか？", "確認",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    CmdFunc("UPDATE TBL_Title SET Title_DELETE = true WHERE Title_ID =" + dgv.Rows[e.RowIndex].Cells[0].Value);
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dgv_TitleInfo.Columns.Clear();
            dgv_TitleInfo.ClearSelection();

            selectfunc("SELECT * FROM TBL_TITLE ORDER BY  TITLE_ID ASC");

            //DataGridViewButtonColumnの作成
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            //列の名前を設定
            column.Name = "DELETE";
            //全てのボタンに"詳細閲覧"と表示する
            column.UseColumnTextForButtonValue = true;
            column.Text = "削除";
            //DataGridViewに追加する
            dgv_TitleInfo.Columns.Add(column);
        }
    }
}
