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
    public partial class ItemAdd : UserControl
    {

        OleDbConnection cn = new OleDbConnection();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        int count = 0;

        

        public ItemAdd()
        {
            InitializeComponent();
        }

        private void ItemAdd_Load(object sender, EventArgs e)
        {
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
        }

        private string SetInfo(string cmdstr)
        {
            dt.Clear();
            dt = new DataTable();
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            return dt.Rows[0][0].ToString();
        }

        private string ZeroCut(string Num)
        {
            string ZeroCutNum = int.Parse(Num).ToString();
            return ZeroCutNum;
        }

        private void txt_TitleIDInfo_TextChanged(object sender, EventArgs e)
        {    
            if (txt_TitleID.Text.Length == 8)
            {
                int ID = int.Parse(SetInfo("SELECT MAX(ITEM_ID) FROM TBL_ITEM")) + 1 + count;

                lbl_ItemIDInfo.Text = ID.ToString();


                dt.Clear();
                dt = new DataTable();
                //da = new OleDbDataAdapter("SELECT t.TITLE_NAME,ar.ARTIST_NAME,t.TITLE_RELEASE FROM TBL_TITLE t,TBL_ARTIST ar,TBL_GENRE gn WHERE t.ARTIST_ID = ar.ARTIST_ID AND t.GENRE_ID=gn.GENRE_ID AND t.TITLE_ID = '" + ZeroCut(txt_TitleID.Text) + "'", cn);
                da = new OleDbDataAdapter("SELECT t.TITLE_NAME, a.ARTIST_NAME, ty.TYPE_NAME, o.OLD_NAME, g.GENRE_NAME FROM TBL_TITLE t,TBL_ARTIST a,TBL_TYPE ty,TBL_OLD o,TBL_GENRE g WHERE t.ARTIST_ID = a.ARTIST_ID AND t.TYPE_ID = ty.TYPE_ID AND t.OLD_ID = o.OLD_ID AND t.GENRE_ID = g.GENRE_ID AND t.TITLE_ID = '" + ZeroCut(txt_TitleID.Text) + "'", cn);
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    lbl_TitleNameInfo.Text = dt.Rows[0][0].ToString();
                    lbl_ArtistNameInfo.Text = dt.Rows[0][1].ToString();
                    lbl_TypeInfo.Text = dt.Rows[0][2].ToString();
                    lbl_OldNewInfo.Text = dt.Rows[0][3].ToString();
                    lbl_GenreInfo.Text = dt.Rows[0][4].ToString();
                    
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
        }

        public void btn_ToAdd_Click(object sender, EventArgs e)
        {
            if (txt_TitleID.Text != "" && txt_TitleID.TextLength == 8)
            {
                this.dgv_ItemRe.Rows.Add(txt_TitleID.Text, lbl_ItemIDInfo.Text, lbl_TitleNameInfo.Text, lbl_ArtistNameInfo.Text, lbl_TypeInfo.Text, lbl_OldNewInfo.Text, lbl_GenreInfo.Text);
                count++;
            }
            else
            {
                MessageBox.Show("正しいタイトルIDを入力してください");
            }
        }

        private void btn_Cancel_Click_1(object sender, EventArgs e)
        {
            　　dgv_ItemRe.Rows.Clear();
                ManageHome.cancel(5);            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //int flag = 1;
            //RegisterHome.GoNext(flag);

            
            if (dgv_ItemRe.Rows.Count-1 != 0)
            {
                if (DialogResult.Yes == MessageBox.Show("仮登録データを全て登録しますか？", "確認",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {


                    OleDbCommand Cmd = new OleDbCommand();
                    Cmd.Connection = cn;
                    cn.Open();
                    for (int i = 0; i < dgv_ItemRe.Rows.Count - 1; i++)
                    {

                        Cmd.CommandText = "INSERT INTO TBL_ITEM VALUES(" + dgv_ItemRe.Rows[i].Cells[1].Value + ",false,'" + ZeroCut(dgv_ItemRe.Rows[i].Cells[0].Value.ToString()) + "',false)";
                        Cmd.ExecuteNonQuery();

                    }
                    cn.Close();
                    /* 　-　ここ　-　 */
                    MessageBox.Show("登録が完了しました");
                    dgv_ItemRe.Rows.Clear();

                }
            }
            else
            {
                MessageBox.Show("データを追加してください");
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
        
    }
}
