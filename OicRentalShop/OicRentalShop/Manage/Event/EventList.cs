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

namespace OicRentalShop.Manage.Event
{
    public partial class EventList : UserControl
    {
        OleDbConnection cn = new OleDbConnection();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        public EventList()
        {
            InitializeComponent();
        }

        private void selectfunc(string cmdstr)
        {
            dt.Clear();
            dt = new DataTable();
            dgv_EventInfo.DataSource = null;
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            dgv_EventInfo.DataSource = dt;
            dgv_EventInfo.AutoResizeColumns();

        }

        private void EventList_Load(object sender, EventArgs e)
        {
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
            selectfunc("SELECT * FROM TBL_EVENT");
            //DataGridViewButtonColumnの作成
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            //列の名前を設定
            column.Name = "UPDATE";
            //全てのボタンに"詳細閲覧"と表示する
            column.UseColumnTextForButtonValue = true;
            column.Text = "編集";
            //DataGridViewに追加する
            dgv_EventInfo.Columns.Add(column);


            //DataGridViewButtonColumnの作成
            DataGridViewButtonColumn column2 = new DataGridViewButtonColumn();
            //列の名前を設定
            column2.Name = "DELETE";
            //全てのボタンに"詳細閲覧"と表示する
            column2.UseColumnTextForButtonValue = true;
            column2.Text = "削除";
            //DataGridViewに追加する
            dgv_EventInfo.Columns.Add(column2);
        }

        private void dgv_EventInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            //"Button"列ならば、ボタンがクリックされた
            if (dgv.Columns[e.ColumnIndex].Name == "DELETE")
            {
                if (DialogResult.Yes == MessageBox.Show("タイトルID　" + dgv.Rows[e.RowIndex].Cells[0].Value + "　タイトル名　" + dgv.Rows[e.RowIndex].Cells[1].Value + "　のデータを削除してよろしいですか？", "確認",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    CmdFunc("UPDATE TBL_EVENT SET EVENT_DELETE = true WHERE EVENT_ID =" + dgv.Rows[e.RowIndex].Cells[0].Value);
                }


            }
            else if(dgv.Columns[e.ColumnIndex].Name=="UPDATE")
            {
                if (DialogResult.Yes == MessageBox.Show("イベントID　" + dgv.Rows[e.RowIndex].Cells[1].Value + "　イベント名　" + dgv.Rows[e.RowIndex].Cells[2].Value + "　のデータを編集してよろしいですか？", "確認",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    CmdFunc("UPDATE TBL_EVENT SET EVENT_DELETE = true WHERE EVENT_ID =" + dgv.Rows[e.RowIndex].Cells[0].Value);
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