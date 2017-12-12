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
            selectfunc("SELECT TBL_TITLE.TITLE_NAME, TBL_TITLE.TITLE_ID, TBL_TYPE.TYPE_NAME, TBL_OLD.OLD_NAME, TBL_ARTIST.ARTIST_NAME, TBL_GENRE.GENRE_NAME FROM TBL_TYPE INNER JOIN (TBL_OLD INNER JOIN (TBL_GENRE INNER JOIN (TBL_ARTIST RIGHT OUTER JOIN TBL_TITLE ON TBL_ARTIST.ARTIST_ID = TBL_TITLE.ARTIST_ID) ON TBL_GENRE.GENRE_ID = TBL_TITLE.GENRE_ID) ON TBL_OLD.OLD_ID = TBL_TITLE.OLD_ID) ON (TBL_TYPE.TYPE_ID = TBL_GENRE.TYPE_ID) AND (TBL_TYPE.TYPE_ID = TBL_TITLE.TYPE_ID) WHERE TBL_TITLE.TITLE_NAME LIKE '%" + txt_TitleName.Text + "%' AND TBL_TITLE.TITLE_ID LIKE '%" + txt_TitleID.Text + "%' AND TBL_TYPE.TYPE_NAME LIKE '%" + cmb_Type.Text + "%' AND TBL_OLD.OLD_NAME LIKE '%" + cmb_Old_New.Text + "%' AND TBL_ARTIST.ARTIST_NAME LIKE '%" + txt_Artist.Text + "%' AND TBL_GENRE.GENRE_NAME LIKE '%" + cmb_Genre.Text + "%' ORDER BY TBL_TITLE.TITLE_ID");
            //selectfunc("SELECT t.TITLE_NAME,t.TITLE_ID,ty.TYPE_NAME,ol.OLD_NAME,a.ARTIST_NAME,g.GENRE_NAME FROM TBL_TITLE t,TBL_TYPE ty,TBL_OLD ol,TBL_ARTIST a,TBL_GENRE g WHERE t.GENRE_ID=g.GENRE_ID AND t.TYPE_ID=ty.TYPE_ID AND t.ARTIST_ID IS NULL AND t.OLD_ID = ol.OLD_ID");
            //SELECT t.TITLE_NAME,t.TITLE_ID,ty.TYPE_NAME,ol.OLD_NAME,a.ARTIST_NAME,g.GENRE_NAME FROM TBL_TITLE t,TBL_TYPE ty,TBL_OLD ol,TBL_ARTIST a,TBL_GENRE g WHERE t.GENRE_ID=g.GENRE_ID AND t.TYPE_ID=ty.TYPE_ID AND t.ARTIST_ID = 1 AND t.OLD_ID = ol.OLD_ID
            //selectfunc("SELECT t.TITLE_NAME,t.TITLE_ID,ty.TYPE_NAME,ol.OLD_NAME,a.ARTIST_NAME,g.GENRE_NAME FROM TBL_TITLE t LEFT OUTER JOIN TBL_ARTIST a ON t.ARTIST_ID=a.ARTIST_ID,TBL_TYPE ty,TBL_OLD ol,TBL_GENRE g WHERE t.GENRE_ID=g.GENRE_ID AND t.TYPE_ID=ty.TYPE_ID AND t.OLD_ID = ol.OLD_ID");
            //SELECT t.TITLE_NAME,t.TITLE_ID,ty.TYPE_NAME,ol.OLD_NAME,IIf([a.ARTIST_NAME]!='','私','うんち'),g.GENRE_NAME FROM TBL_TITLE t,TBL_TYPE ty,TBL_OLD ol,TBL_ARTIST a,TBL_GENRE g WHERE t.GENRE_ID=g.GENRE_ID AND t.TYPE_ID=ty.TYPE_ID AND t.ARTIST_ID=a.ARTIST_ID AND t.OLD_ID = ol.OLD_ID
            //IIf([a.ARTIST_NAME]!='','私','うんち')   ON 
            // AND t.TITLE_NAME LIKE '%" + txt_TitleName.Text + "%' t.TITLE_ID LIKE '%" + txt_TitleID.Text + "%' ty.TYPE_NAME LIKE '%" + cmb_Type.Text + "%' o.OLD_NAME LILE '%" + cmb_Old_New.Text + "%' a.ARTIST_NAME LIKE '%" + txt_Artist.Text + "%' g.GENRE_NAME LIKE '%" + cmb_Genre.Text + "%'
            
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

        private void btn_Edit_Click(object sender, EventArgs e)
        {

        }
    }
}
