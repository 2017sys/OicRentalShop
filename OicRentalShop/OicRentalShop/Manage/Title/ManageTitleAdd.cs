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


    public partial class ManageTitleAdd : UserControl
    {
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        public ManageTitleAdd()
        {
            InitializeComponent();
        }

        private void selectfunc(string cmdstr)
        {
            dt.Clear();
            dt = new DataTable();
            dgv_ItemRe.DataSource = null;
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            dgv_ItemRe.DataSource = dt;
            dgv_ItemRe.AutoResizeColumns();
        }

        private void btn_Toadd_Click(object sender, EventArgs e)
        {
            this.dgv_ItemRe.Rows.Add(txt_TitleID.Text, txt_Title.Text, cmb_Genre.Text, cmb_Artist.Text, txt_ReleaseDay.Text, cmb_Format.Text, "削除");
        }

        private string SetInfo(string cmdstr)
        {
            dt.Clear();
            dt = new DataTable();
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            return dt.Rows[0][0].ToString();
        }

        private string SerchID(string TblName, string Name)
        {

            string ID = SetInfo("SELECT " + TblName + "_ID FROM TBL_" + TblName + " WHERE " + TblName + "_NAME" + "= '" + Name + "'");
            return ID;
        }

        private string ZeroCut(string Num)
        {
            string ZeroCutNum = int.Parse(Num).ToString();
            return ZeroCutNum;
        }

        private void genreLoad()
        {
            OleDbCommand oleCmd = new OleDbCommand();
            //CD・DVDのどちらかが選択されるとジャンルを流し込む
            String sql = "SELECT GENRE_NAME FROM TBL_GENRE WHERE TYPE_ID =";
            if (cmb_Format.Text == "DVD")
            {
                sql += " 1";
            }
            else
            {
                sql += " 2";
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

        private void ArtistLoad()
        {
            OleDbCommand oleCmd = new OleDbCommand();

            String sql = "SELECT ARTIST_NAME FROM TBL_ARTIST WHERE ARTIST_NAME LIKE '%" + cmb_Artist.Text + "%'";


            cn.Open();
            oleCmd.Connection = cn;

            //sql実行
            oleCmd.CommandText = sql;
            OleDbDataReader oleReader = oleCmd.ExecuteReader(CommandBehavior.Default);

            List<String> ArtistList = new List<string>();
            while (oleReader.Read())
            {
                ArtistList.Add(oleReader["ARTIST_NAME"].ToString());
            }
            cmb_Artist.Items.AddRange(ArtistList.ToArray());
            cn.Close();
            oleCmd.Dispose();
        }

        private void cmb_Artist_TextChanged(object sender, EventArgs e)
        {
            cmb_Artist.Items.Clear();
            ArtistLoad();
        }

        private void cmb_Format_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Genre.Items.Clear();
            genreLoad();
        }

        private void dgv_ItemRe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dgv_ItemRe.Columns["btn_Delete"].Index)
            {
                if (DialogResult.Yes == MessageBox.Show("削除しますか？", "確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    this.dgv_ItemRe.Rows.RemoveAt(e.RowIndex);
                }
            } 
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("仮登録データを全て削除しますか？", "確認",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                dgv_ItemRe.Rows.Clear();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("仮登録データを全て登録しますか？", "確認",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {


                OleDbCommand Cmd = new OleDbCommand();
                Cmd.Connection = cn;
                cn.Open();
                for (int i = 0; i < dgv_ItemRe.Rows.Count - 1; i++)
                {

                    Cmd.CommandText = "INSERT INTO TBL_TITLE(TITLE_ID,TITLE_NAME,GENRE_ID,ARTIST_ID,TITLE_RELEASE,TYPE_ID) VALUES('" + dgv_ItemRe.Rows[i].Cells[0].Value + "','" + dgv_ItemRe.Rows[i].Cells[1].Value + "'," + SerchID("GENRE", dgv_ItemRe.Rows[i].Cells[2].Value.ToString()) + "," + SerchID("ARTIST", dgv_ItemRe.Rows[i].Cells[3].Value.ToString()) + ",#" + dgv_ItemRe.Rows[i].Cells[4].Value + "#," + SerchID("TYPE", dgv_ItemRe.Rows[i].Cells[5].Value.ToString()) + ")";
                    Cmd.ExecuteNonQuery();

                }
                cn.Close();
                /* 　-　ここ　-　 */
                MessageBox.Show("登録が完了しました");
                dgv_ItemRe.Rows.Clear();

            }
        }

        public static Boolean DuplicationIDSerch(string Table,string ID)
        {
            OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataTable dt = new DataTable();

            Boolean result;

            dt.Clear();
            dt = new DataTable();
            da = new OleDbDataAdapter("SELECT "+Table+"_ID FROM TBL_"+Table+" WHERE "+Table+"_ID = "+ ID, cn);
            da.Fill(dt);

            if(dt.Rows.Count==0)
            {
                result = true;
            }
            else
            {
                result=false;
            }
            return result;
        }

        private void txt_TitleID_TextChanged(object sender, EventArgs e)
        {
            if(txt_TitleID.Text.Length==8)
            {
                if(DuplicationIDSerch("Title", "'"+ZeroCut(txt_TitleID.Text)+"'")==true)
                {
                    MessageBox.Show("重複行はありません");
                }
                else
                {
                    MessageBox.Show("重複行があります");
                }
            }
        }
    }
}
