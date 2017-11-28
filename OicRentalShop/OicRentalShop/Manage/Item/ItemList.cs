﻿using System;
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
                selectfunc("SELECT title.TITLE_NAME AS タイトル名, title.TITLE_ID AS タイトルID , item.ITEM_ID AS 商品ID , type.TYPE_NAME AS 商品タイプ , genre.GENRE_NAME AS ジャンル FROM TBL_TITLE title , TBL_ITEM item , TBL_TYPE type , TBL_GENRE genre WHERE title.TYPE_ID = type.TYPE_ID AND item.TITLE_ID = title.TITLE_ID AND title.GENRE_ID = genre.GENRE_ID AND title.TYPE_ID = 1");
            }
            else if (cmb_Type.Text == "CD")
            {
                selectfunc("SELECT title.TITLE_NAME AS タイトル名,title.TITLE_ID AS タイトルID,item.ITEM_ID AS 商品ID,ty.TYPE_NAME AS 商品タイプ,genre.GENRE_NAME AS ジャンル,art.ARTIST_NAME AS アーティスト FROM TBL_TITLE title,TBL_ITEM item,TBL_TYPE ty,TBL_GENRE genre,TBL_ARTIST art WHERE title.TYPE_ID=ty.TYPE_ID AND item.TITLE_ID=title.TITLE_ID AND title.GENRE_ID = genre.GENRE_ID AND art.ARTIST_ID=title.ARTIST_ID");
            }
            else return;
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

        private String serchItems()
        {

            String sql = "";
            //タイトル検索
            if (txt_TitleName.Text != "")
            {
                sql += " AND title.TITLE_NAME = " + txt_TitleName.Text;
            }
            //タイトルID検索
            if (txt_TitleID.Text != "")
            {
                sql += " AND title.TITLE_ID =" + txt_TitleID.Text;
            }
            //商品ID検索
            if (txt_ItemID.Text != "")
            {
                sql += " AND title.ITEM_ID =" + txt_ItemID.Text;
            }
            //新作旧作検索
            if (cmb_Old_New.Text != "")
            {
                if (cmb_Old_New.Text == "新作")
                    sql += " AND title.TITLE_RELEASE > " + DateTime.Today.AddMonths(-1);
                else if (cmb_Old_New.Text == "旧作")
                    sql += " AND title.TITLE_RELEASE < " + DateTime.Today.AddMonths(-1);
            }

            return sql;
        }
    }
}

