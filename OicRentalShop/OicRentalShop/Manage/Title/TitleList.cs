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
            genreLoad();
        }

        //ジャンル読み込みメソッド
        private void genreLoad()
        {
            cmb_Genre.Items.Clear();
            cmb_Genre.Items.Add("全ジャンル");
            OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
            OleDbDataAdapter da = new OleDbDataAdapter();
            OleDbCommand oleCmd = new OleDbCommand();
            DataTable dt = new DataTable();
            //CD・DVDのどちらかが選択されるとジャンルを流し込む
            String sql = "SELECT GENRE_NAME FROM TBL_GENRE";
            if (cmb_Type.Text == "DVD")
            {
                sql += " WHERE TYPE_ID = 1";
            }
            else if (cmb_Type.Text == "CD" || cmb_Type.Text=="シングル" || cmb_Type.Text=="アルバム")
            {
                sql += " WHERE TYPE_ID = 2";
            }
            else if(cmb_Type.Text=="すべて")
            {
                
            }
            cn.Open();
            oleCmd.Connection = cn;

            //sql実行
            oleCmd.CommandText = sql;
            OleDbDataReader oleReader = oleCmd.ExecuteReader(CommandBehavior.Default);

            List<String> genreList = new List<string>();
            while (oleReader.Read())
            {
                genreList.Add(oleReader["GENRE_NAME"].ToString());
            }
            cmb_Genre.Items.AddRange(genreList.ToArray());
            cn.Close();
            oleCmd.Dispose();
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
                if (DialogResult.Yes == MessageBox.Show("タイトルID　" + dgv.Rows[e.RowIndex].Cells[0].Value + "　タイトル名　" + dgv.Rows[e.RowIndex].Cells[1].Value + "　のデータを削除してよろしいですか？", "確認",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    CmdFunc("UPDATE TBL_TITLE SET TITLE_DELETE = true WHERE TITLE_ID = '" + dgv.Rows[e.RowIndex].Cells[0].Value + "'");
                    dgv_Update();
                   
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


        private void dgv_Update()
        {
            string Genre;
            string Type;
            if (cmb_Genre.Text == "全ジャンル")
            {
                Genre = "";
            }
            else
            {
                Genre = cmb_Genre.Text;
            }



            if (cmb_Type.Text == "CD")
            {
                Type = "%' AND (TBL_TYPE.TYPE_NAME='シングル' or TBL_TYPE.TYPE_NAME='アルバム')";
            }
            else if (cmb_Type.Text == "DVD")
            {
                Type = "%' AND TBL_TYPE.TYPE_NAME='DVD'";
            }
            else if (cmb_Type.Text == "すべて")
            {
                Type = "%' AND (TBL_TYPE.TYPE_NAME='シングル' or TBL_TYPE.TYPE_NAME='アルバム' or TBL_TYPE.TYPE_NAME ='DVD')";
            }
            else
            {
                Type = "%' AND TBL_TYPE.TYPE_NAME='" + cmb_Type.Text + "'";
            }

            dgv_TitleInfo.Columns.Clear();
            dgv_TitleInfo.ClearSelection();
            //selectfunc("SELECT TBL_TITLE.TITLE_NAME, TBL_TITLE.TITLE_ID, TBL_TYPE.TYPE_NAME, TBL_OLD.OLD_NAME, TBL_ARTIST.ARTIST_NAME, TBL_GENRE.GENRE_NAME FROM TBL_TYPE INNER JOIN (TBL_OLD RIGHT OUTER JOIN (TBL_GENRE INNER JOIN (TBL_ARTIST RIGHT OUTER JOIN TBL_TITLE ON TBL_ARTIST.ARTIST_ID = TBL_TITLE.ARTIST_ID) ON TBL_GENRE.GENRE_ID = TBL_TITLE.GENRE_ID) ON TBL_OLD.OLD_ID = TBL_TITLE.OLD_ID) ON (TBL_TYPE.TYPE_ID = TBL_GENRE.TYPE_ID) AND (TBL_TYPE.TYPE_ID = TBL_TITLE.TYPE_ID) WHERE TBL_TITLE.TITLE_NAME LIKE '%" + txt_TitleName.Text + "%' AND TBL_TITLE.TITLE_ID LIKE '%" + txt_TitleID.Text + "%' AND TBL_TYPE.TYPE_NAME LIKE '%" + cmb_Type.Text + "%' AND TBL_OLD.OLD_NAME LIKE '%" + cmb_Old_New.Text + "%' AND TBL_ARTIST.ARTIST_NAME LIKE '%" + txt_Artist.Text + "%' AND TBL_GENRE.GENRE_NAME LIKE '%" + Genre+ "%' ORDER BY TBL_TITLE.TITLE_ID");

            selectfunc("SELECT TBL_TITLE.TITLE_ID, TBL_TITLE.TITLE_NAME, TBL_TYPE.TYPE_NAME, TBL_OLD.OLD_NAME, TBL_ARTIST.ARTIST_NAME, TBL_GENRE.GENRE_NAME FROM TBL_ARTIST RIGHT OUTER JOIN (TBL_GENRE INNER JOIN (TBL_OLD INNER JOIN (TBL_TYPE INNER JOIN TBL_TITLE ON TBL_TYPE.TYPE_ID = TBL_TITLE.TYPE_ID) ON TBL_OLD.OLD_ID = TBL_TITLE.OLD_ID) ON (TBL_TYPE.TYPE_ID = TBL_GENRE.TYPE_ID) AND (TBL_GENRE.GENRE_ID = TBL_TITLE.GENRE_ID)) ON TBL_ARTIST.ARTIST_ID = TBL_TITLE.ARTIST_ID" +
                " WHERE TBL_TITLE.TITLE_NAME LIKE '%" + txt_TitleName.Text + "%' AND TBL_TITLE.TITLE_ID LIKE '%" + txt_TitleID.Text + Type + " AND TBL_OLD.OLD_NAME LIKE '%" + cmb_Old_New.Text + "%' AND (TBL_ARTIST.ARTIST_NAME LIKE '%" + txt_Artist.Text + "%' or TBL_ARTIST.ARTIST_NAME IS NULL) AND TBL_GENRE.GENRE_NAME LIKE '%" + Genre + "%' AND TBL_TITLE.TITLE_DELETE=false ORDER BY TBL_TITLE.TITLE_ID ASC");

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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dgv_Update();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            genreLoad();
        }
    }
}
