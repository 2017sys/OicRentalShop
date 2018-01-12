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
         
            ArtistList.Add(cmb_Artist.Text);
          
            while (oleReader.Read())
            {
                ArtistList.Add(oleReader["ARTIST_NAME"].ToString());
            }
            cmb_Artist.Items.AddRange(ArtistList.ToArray());
            cn.Close();
            oleCmd.Dispose();
        }

        private static Boolean DuplicationIDSerch(string Table, string ID)//Tableに検索するテーブル名　IDに検索するIDを入力　存在すればfalse存在しなければtrueを返す
        {
            OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataTable dt = new DataTable();

            Boolean result;

            dt.Clear();
            dt = new DataTable();
            da = new OleDbDataAdapter("SELECT " + Table + "_ID FROM TBL_" + Table + " WHERE " + Table + "_ID = " + ID, cn);
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        private static Boolean DuplicationNameSerch(string Table, string Name)//Tableに検索するテーブル名　IDに検索するIDを入力　存在すればfalse存在しなければtrueを返す
        {
            OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataTable dt = new DataTable();

            Boolean result;

            dt.Clear();
            dt = new DataTable();
            da = new OleDbDataAdapter("SELECT " + Table + "_ID FROM TBL_" + Table + " WHERE " + Table + "_Name = '" + Name+"'", cn);
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        private static void GenreArtistAdd(string Table,string Name)//TableにGENRE又はARTISTを入れNameに名前を入れると指定したTableに項目が作られる
        {
            OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = cn;
            cn.Open();
            Cmd.CommandText = "INSERT INTO TBL_"+Table+"("+Table+"_Name) VALUES('"+Name+"')";
            Cmd.ExecuteNonQuery();
            cn.Close();
        }



        //↑ここまで関数
        //
        //
        //
        //↓ここからイベント


        private void btn_Toadd_Click(object sender, EventArgs e)
        {
            if (txt_TitleID.Text.Length == 8)
            {
                if (DuplicationIDSerch("Title", "'" + ZeroCut(txt_TitleID.Text) + "'") == true)
                {
                    this.dgv_ItemRe.Rows.Add(txt_TitleID.Text, txt_Title.Text, cmb_Genre.Text, cmb_Artist.Text, txt_ReleaseDay.Text, cmb_Format.Text, "削除"); 
                }
                else
                {
                    MessageBox.Show("重複行があります");
                }
                
            }
            else
            {
                MessageBox.Show("タイトルIDは8桁で入力してください");
            }

     


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

                    if(DuplicationNameSerch("GENRE",dgv_ItemRe.Rows[i].Cells[2].Value.ToString())==true)
                    {
                        GenreArtistAdd("GENRE", dgv_ItemRe.Rows[i].Cells[2].Value.ToString());
                        MessageBox.Show("ジャンル "+dgv_ItemRe.Rows[i].Cells[2].Value.ToString()+" を追加");
                    }

                    if(DuplicationNameSerch("ARTIST",dgv_ItemRe.Rows[i].Cells[3].Value.ToString())==true)
                    {
                        GenreArtistAdd("ARTIST", dgv_ItemRe.Rows[i].Cells[3].Value.ToString());
                        MessageBox.Show("アーティスト " + dgv_ItemRe.Rows[i].Cells[3].Value.ToString() + " を追加");
                    }

                    Cmd.CommandText = "INSERT INTO TBL_TITLE(TITLE_ID,TITLE_NAME,GENRE_ID,ARTIST_ID,TITLE_RELEASE,TYPE_ID) VALUES('" + dgv_ItemRe.Rows[i].Cells[0].Value + "','" + dgv_ItemRe.Rows[i].Cells[1].Value + "'," + SerchID("GENRE", dgv_ItemRe.Rows[i].Cells[2].Value.ToString()) + "," + SerchID("ARTIST", dgv_ItemRe.Rows[i].Cells[3].Value.ToString()) + ",#" + dgv_ItemRe.Rows[i].Cells[4].Value + "#," + SerchID("TYPE", dgv_ItemRe.Rows[i].Cells[5].Value.ToString()) + ")";
                    Cmd.ExecuteNonQuery();

                }
                cn.Close();
                MessageBox.Show("登録が完了しました");
                dgv_ItemRe.Rows.Clear();

            }
        }




        private void ManageTitleAdd_Load(object sender, EventArgs e)
        {
            cmb_Format.Text = "シングル";
            ArtistLoad();
        }



        private void cmb_Artist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmb_Artist.Items.Clear();
                ArtistLoad();
               cmb_Artist.Select(cmb_Artist.Text.Length, 0);
              
            }
        }

        private void txt_TitleID_TextChanged(object sender, EventArgs e)
        {
            if(txt_TitleID.Text.Length==8)
            {
                if (DuplicationIDSerch("TITLE","'"+ ZeroCut(txt_TitleID.Text)+"'") == false)//すでにそのタイトルIDが登録されていたら
                {
                    ChangeCorrection();
                    
                }
            }
        }

        private void ChangeCorrection()
        {
            lbl_TopTitle.Text = "タイトル修正";
            this.BackColor = Color.Red;
            btn_Add.Visible = false;
            btn_Clear.Visible = false;
            btn_Toadd.Visible = false;
            dgv_ItemRe.Visible = false;
            btn_Correction.Visible = true;
            btn_ReturnAdd.Visible = true;

            dt.Clear();
            dt = new DataTable();
            dgv_ItemRe.DataSource = null;
            da = new OleDbDataAdapter("SELECT title.TITLE_NAME , type.TYPE_NAME , genre.GENRE_NAME ,art.ARTIST_NAME , title.TITLE_RELEASE  FROM TBL_TITLE title , TBL_ITEM item , TBL_TYPE type , TBL_GENRE genre, TBL_ARTIST art WHERE title.TYPE_ID = type.TYPE_ID AND  title.GENRE_ID = genre.GENRE_ID AND title.ARTIST_ID = art.ARTIST_ID", cn);
            da.Fill(dt);
            txt_Title.Text = dt.Rows[0][0].ToString();
            cmb_Format.Text = dt.Rows[0][1].ToString();
            cmb_Genre.Text = dt.Rows[0][2].ToString();
            cmb_Artist.Text=dt.Rows[0][3].ToString();
            txt_ReleaseDay.Text = dt.Rows[0][4].ToString();
        }

        private void ChangeDefault()
        {
            this.BackColor = System.Drawing.SystemColors.Control;
            lbl_TopTitle.Text = "タイトル登録";
            dgv_ItemRe.Rows.Clear();
            txt_TitleID.Clear();
            txt_Title.Clear();
            txt_ReleaseDay.Clear();
            cmb_Artist.Text = "";
            cmb_Format.Text = "シングル";
            cmb_Genre.Text = "";
            btn_Add.Visible = true;
            btn_Clear.Visible = true;
            btn_Toadd.Visible = true;
            dgv_ItemRe.Visible = true;
            btn_Correction.Visible = false;
            btn_ReturnAdd.Visible = false;
        }

        private void ManageTitleAdd_VisibleChanged(object sender, EventArgs e)
        {
            ChangeDefault();
      
        }

        private void btn_Correction_Click(object sender, EventArgs e)
        {

        }

        private void btn_ReturnAdd_Click(object sender, EventArgs e)
        {
            ChangeDefault();
        }
   
    }
}
