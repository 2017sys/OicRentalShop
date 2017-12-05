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

        private void selectfunc(string cmdstr)//DataGridViewにレジを通した商品の情報を登録
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
            //selectfunc("SELECT t.TITLE_NAME,gn.GENRE_NAME,at.ARTIST_NAME,t.TITLE_RELEASE,ty.TYPE_NAME,ol.OLD_NAME,i.ITEM_ID FROM TBL_TITLE t,TBL_ITEM i,TBL_GENRE gn,TBL_ARTIST at,TBL_OLD ol,TBL_TYPE ty WHERE t.TITLE_ID=i.TITLE_ID AND t.GENRE_ID=gn.GENRE_ID AND t.TYPE_ID=ty.TYPE_ID AND t.ARTIST_ID=at.ARTIST_ID AND t.OLD_ID = ol.OLD_ID ");


            //,COUNT(i.ITEM_ID) AS 枚数        GROUP BY  t.TITLE_NAME,gn.GENRE_NAME,at.ARTIST_NAME,t.TITLE_RELEASE,ty.TYPE_NAME,ol.OLD_NAME
        }
    }
}
