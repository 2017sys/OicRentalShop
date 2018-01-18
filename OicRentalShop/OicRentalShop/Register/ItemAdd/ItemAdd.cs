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

namespace OicRentalShop.Manage.ItemAdd
{
    public partial class ItemAdd : UserControl
    {

        OleDbConnection cn = new OleDbConnection();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        int count = 0;
        RegisterHome rh;
        public ItemAdd(RegisterHome fm)
        {
            InitializeComponent();
            rh = fm;
        }

        private void ItemAdd_Load(object sender, EventArgs e)
        {
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //int flag = 1;
            //RegisterHome.GoNext(flag);

            if (DialogResult.Yes == MessageBox.Show("仮登録データを全て登録しますか？", "確認",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {


                OleDbCommand Cmd = new OleDbCommand();
                Cmd.Connection = cn;
                cn.Open();

                String text = "商品ID";
                for (int i = 0; i < dgv_ItemRe.Rows.Count - 1; i++)
                {

                    Cmd.CommandText = "INSERT INTO TBL_ITEM VALUES(" + dgv_ItemRe.Rows[i].Cells[0].Value + ",true,'" + dgv_ItemRe.Rows[i].Cells[1].Value.ToString() + "',false)";
                    Cmd.ExecuteNonQuery();

                    text += "[" + dgv_ItemRe.Rows[i].Cells[0].Value + "] ";

                }
                cn.Close();

                //ログ登録
                text += "を追加";
                
                rh.add_Log("追加", "商品", text);

                MessageBox.Show("登録が完了しました");
                dgv_ItemRe.Rows.Clear();

            }
        }


        private string ZeroCut(string Num)
        {
            string ZeroCutNum = int.Parse(Num).ToString();
            return ZeroCutNum;
        }

        private void txt_TitleID_TextChanged(object sender, EventArgs e)
        {
            if(txt_TitleID.Text.Length==13)
            {
                txt_TitleID.Text.Remove(12);
                int ID = int.Parse(SetInfo("SELECT MAX(ITEM_ID) FROM TBL_ITEM")) + 1+count;

                lbl_UniqueIDInfo.Text = ID.ToString();

              
                dt.Clear();
                dt = new DataTable();
                da = new OleDbDataAdapter("SELECT t.TITLE_NAME,ar.ARTIST_NAME,gn.GENRE_NAME,t.TITLE_RELEASE FROM TBL_TITLE t,TBL_ARTIST ar,TBL_GENRE gn WHERE t.ARTIST_ID = ar.ARTIST_ID AND t.GENRE_ID=gn.GENRE_ID AND t.TITLE_ID = '" + txt_TitleID.Text + "'", cn);
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    lbl_TitleNameInfo.Text = dt.Rows[0][0].ToString();
                    lbl_ArtistInfo.Text = dt.Rows[0][1].ToString();
                    lbl_GenreInfo.Text = dt.Rows[0][2].ToString();
                    lbl_ReleaseDateInfo.Text = dt.Rows[0][3].ToString();
                }
                else
                {
                    MessageBox.Show("error");
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

        private void btn_ToAdd_Click(object sender, EventArgs e)
        {
            this.dgv_ItemRe.Rows.Add(lbl_UniqueIDInfo.Text,txt_TitleID.Text, lbl_TitleNameInfo.Text, lbl_ArtistInfo.Text, lbl_GenreInfo.Text, lbl_ReleaseDateInfo.Text);
            count++;
            txt_TitleID.Text = "";
            txt_TitleID.Focus();
            lbl_UniqueIDInfo.Text = "";
            lbl_ArtistInfo.Text = "";
            lbl_GenreInfo.Text = "";
            lbl_ReleaseDateInfo.Text = "";
            lbl_TitleNameInfo.Text = "";
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("仮登録データを全て削除しますか？", "確認",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                dgv_ItemRe.Rows.Clear();
            }
        }


    }
}
