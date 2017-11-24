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

namespace OicRentalShop.Register.ItemInfo
{
    public partial class ItemInfo : UserControl
    {

        OleDbConnection cn = new OleDbConnection();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        public ItemInfo()
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

        private void ItemInfo_Load(object sender, EventArgs e)
        {
            cmb_OLDNEW.SelectedIndex = 0;
             cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            int index = cmb_OLDNEW.SelectedIndex;
            string CheckDVD = cmb_OLDNEW.Items[index].ToString();

            if (CheckDVD == "DVD")
            {
                selectfunc("SELECT dt.TITLE_NAME AS タイトル名,dt.TITLE_ID AS タイトルID,di.ITEM_ID AS 商品ID,ty.TYPE_NAME AS 商品タイプ,dg.GENRE_NAME AS ジャンル FROM TBL_TITLE dt,TBL_ITEM di,TBL_TYPE ty,TBL_GENRE dg WHERE dt.TYPE_ID=ty.TYPE_ID AND di.TITLE_ID=dt.TITLE_ID AND dt.GENRE_ID = dg.GENRE_ID AND dt.TYPE_ID=1");
            }
            else
            {
                selectfunc("SELECT ct.TITLE_NAME AS タイトル名,ct.TITLE_ID AS タイトルID,ci.ITEM_ID AS 商品ID,ty.TYPE_NAME AS 商品タイプ,cg.GENRE_NAME AS ジャンル,art.ARTIST_NAME AS アーティスト FROM TBL_TITLE ct,TBL_ITEM ci,TBL_TYPE ty,TBL_GENRE cg,TBL_ARTIST art WHERE ct.TYPE_ID=ty.TYPE_ID AND ci.TITLE_ID=ct.TITLE_ID AND ct.GENRE_ID = cg.GENRE_ID AND art.ARTIST_ID=ct.ARTIST_ID");
            }
        }




        private void cmb_OLDNEW_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cmb_OLDNEW.SelectedIndex;
            string CheckDVD = cmb_OLDNEW.Items[index].ToString();
            if(CheckDVD=="DVD")
            {
                txt_ArtistName.ReadOnly = true;
                txt_ArtistName.Clear();
            }
            else
            {
                txt_ArtistName.ReadOnly = false;
                
            }
        }
    }
}
