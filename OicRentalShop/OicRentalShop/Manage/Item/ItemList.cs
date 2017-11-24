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
            genreLoad();
        }

        //ジャンル読み込みメソッド
        private void genreLoad()
        {            
            //CD・DVDのどちらかが選択されるとジャンルを流し込む
            String sql = "SELECT GENRE_NAME FROM TBL_GENRE WHERE TYPE_ID = ";
            if (cmb_Type.Text == "DVD"){
                sql += "1";
            }
            else if (cmb_Type.Text == "CD"){
                sql += "2";
            }
            else{
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
    }
}
