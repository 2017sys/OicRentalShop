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

namespace OicRentalShop.Manage.Item
{
    public partial class ItemList : UserControl
    {

        OleDbConnection cn = new OleDbConnection();
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand oleCmd = new OleDbCommand();
        DataTable dt = new DataTable();

        public ItemList()
        {
            InitializeComponent();
        }

        private void selectfunc(string cmdstr)
        {
            dt.Clear();
            dt = new DataTable();
            dgv_ItemInfo.DataSource = null;
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            dgv_ItemInfo.DataSource = dt;
            dgv_ItemInfo.AutoResizeColumns();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            if (cmb_Type.Text == "DVD")
            {
                selectfunc("SELECT title.TITLE_NAME AS タイトル名, title.TITLE_ID AS タイトルID , item.ITEM_ID AS 商品ID , type.TYPE_NAME AS 商品タイプ , genre.GENRE_NAME AS ジャンル FROM TBL_TITLE title , TBL_ITEM item , TBL_TYPE type , TBL_GENRE genre WHERE title.TYPE_ID = type.TYPE_ID AND item.TITLE_ID = title.TITLE_ID AND title.GENRE_ID = genre.GENRE_ID AND title.TYPE_ID = 1" + serchItems()+"AND item.ITEM_DELETE= false");
            }
            else if (cmb_Type.Text == "CD")
            {
                selectfunc("SELECT title.TITLE_NAME AS タイトル名,title.TITLE_ID AS タイトルID,item.ITEM_ID AS 商品ID,type.TYPE_NAME AS 商品タイプ,genre.GENRE_NAME AS ジャンル,art.ARTIST_NAME AS アーティスト FROM TBL_TITLE title,TBL_ITEM item,TBL_TYPE type,TBL_GENRE genre,TBL_ARTIST art WHERE title.TYPE_ID = type.TYPE_ID AND item.TITLE_ID=title.TITLE_ID AND title.GENRE_ID = genre.GENRE_ID AND art.ARTIST_ID=title.ARTIST_ID" + serchItems() +"AND item.ITEM_DELETE= false");
            }
            else return;

            //DataGridViewButtonColumnの作成
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            //列の名前を設定
            column.Name = "DELETE";
            //全てのボタンに"詳細閲覧"と表示する
            column.UseColumnTextForButtonValue = true;
            column.Text = "削除";
            //DataGridViewに追加する
            dgv_ItemInfo.Columns.Add(column);
        }

        private void ItemList_Load(object sender, EventArgs e)
        {
            cmb_Old_New.SelectedIndex = 0;
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
            genreLoad();
        }

        //CD・DVDを選択するとジャンルリセット->ジャンル流し込み
        private void cmb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Genre.Text = "全ジャンル";
            cmb_Genre.Items.Clear();
            cmb_Genre.Items.Add("全ジャンル");
            genreLoad();
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

        //ジャンル読み込みメソッド
        private void genreLoad()
        {
            //CD・DVDのどちらかが選択されるとジャンルを流し込む
            String sql = "SELECT GENRE_NAME FROM TBL_GENRE WHERE TYPE_ID =";
            if (cmb_Type.Text == "DVD")
            {
                sql += " 1";
            }
            else if (cmb_Type.Text == "CD")
            {
                sql += " 2";
            }
            else
            {
                return;
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
        
        //検索条件をSQLに追加
        private String serchItems()
        {

            dgv_ItemInfo.Columns.Clear();
            dgv_ItemInfo.ClearSelection();

            String sql = "";
            //タイトル検索
            if (txt_TitleName.Text.Trim() != ""){
                sql += " AND title.TITLE_NAME LIKE '%" + txt_TitleName.Text.TrimStart() +"%'";
            }
            //タイトルID検索
            if (txt_TitleID.Text.Trim() != "")
            {
                sql += " AND title.TITLE_ID LIKE '%" + txt_TitleID.Text.TrimStart() + "%'";
            }
            //商品ID検索
            if (txt_ItemID.Text.Trim() != "")
            {
                sql += " AND item.ITEM_ID LIKE '" + txt_ItemID.Text.TrimStart() + "'";
            }
            //新作旧作検索
            if (cmb_Old_New.Text.Trim() != "")
            {
                if (cmb_Old_New.Text == "新作")
                    sql += " AND title.TITLE_RELEASE > " + DateTime.Today.AddMonths(-1).ToString("yyyy/MM/dd");
                else if (cmb_Old_New.Text == "旧作")
                    sql += " AND title.TITLE_RELEASE < " + DateTime.Today.AddMonths(-1).ToString("yyyy/MM/dd");
            }
            //アーティスト検索
            if (txt_Artist.Text.Trim() != "")
            {
                sql += " AND art.ARTIST_NAME LIKE '%" + txt_Artist.Text.TrimStart() + "%'";
            }
            //ジャンル検索
            if (cmb_Genre.Text.Trim() != "" && cmb_Genre.Text != "全ジャンル")
            {
                sql += " AND genre.GENRE_NAME = '" + cmb_Genre.Text + "'";
            }

            return sql;
        }

        private void dgv_ItemInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            //"Button"列ならば、ボタンがクリックされた
            if (dgv.Columns[e.ColumnIndex].Name == "DELETE")
            {
                if (DialogResult.Yes == MessageBox.Show("タイトルID　" + dgv.Rows[e.RowIndex].Cells[0].Value + "　タイトル名　" + dgv.Rows[e.RowIndex].Cells[1].Value + "　のデータを削除してよろしいですか？", "確認",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    CmdFunc("UPDATE TBL_ITEM SET ITEM_DELETE = true WHERE ITEM_ID =" + dgv.Rows[e.RowIndex].Cells[2].Value);

                    if (cmb_Type.Text == "DVD")
                    {
                        selectfunc("SELECT title.TITLE_NAME AS タイトル名, title.TITLE_ID AS タイトルID , item.ITEM_ID AS 商品ID , type.TYPE_NAME AS 商品タイプ , genre.GENRE_NAME AS ジャンル FROM TBL_TITLE title , TBL_ITEM item , TBL_TYPE type , TBL_GENRE genre WHERE title.TYPE_ID = type.TYPE_ID AND item.TITLE_ID = title.TITLE_ID AND title.GENRE_ID = genre.GENRE_ID AND title.TYPE_ID = 1" + serchItems() + "AND item.ITEM_DELETE= false");
                    }
                    else if (cmb_Type.Text == "CD")
                    {
                        selectfunc("SELECT title.TITLE_NAME AS タイトル名,title.TITLE_ID AS タイトルID,item.ITEM_ID AS 商品ID,type.TYPE_NAME AS 商品タイプ,genre.GENRE_NAME AS ジャンル,art.ARTIST_NAME AS アーティスト FROM TBL_TITLE title,TBL_ITEM item,TBL_TYPE type,TBL_GENRE genre,TBL_ARTIST art WHERE title.TYPE_ID = type.TYPE_ID AND item.TITLE_ID=title.TITLE_ID AND title.GENRE_ID = genre.GENRE_ID AND art.ARTIST_ID=title.ARTIST_ID" + serchItems() + "AND item.ITEM_DELETE= false");
                    }
                }


            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ManageHome.GoNext(6);
        }
    }
}

