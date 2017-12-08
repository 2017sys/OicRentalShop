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

namespace OicRentalShop.Manage.PriceList
{
    public partial class PriceList : UserControl
    {
        OleDbConnection cn = new OleDbConnection();
        OleDbDataAdapter da_p = new OleDbDataAdapter();
        DataTable dt_p = new DataTable();

        OleDbDataAdapter da_e = new OleDbDataAdapter();
        DataTable dt_e = new DataTable();

        public PriceList()
        {
            InitializeComponent();
        }


        private void selectfunc_p(string cmdstr)
        {
            dt_p.Clear();
            dt_p = new DataTable();
            dgv_PriceInfo.DataSource = null;
            da_p = new OleDbDataAdapter(cmdstr, cn);
            da_p.Fill(dt_p);
            dgv_PriceInfo.DataSource = dt_p;
            dgv_PriceInfo.AutoResizeColumns();

            //余分なセルを排除
            dgv_PriceInfo.AllowUserToAddRows = false;
            for (int i = 0; i <= 3; i++)
            {
                //列の長さを133に設定
                dgv_PriceInfo.Columns[i].MinimumWidth = 133;
                //DatagridView(PriceInfo)のヘッダーを中央揃え
                dgv_PriceInfo.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //DatagridView(PriceInfo)の内容を中央揃え
                dgv_PriceInfo.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dgv_PriceInfo.RowTemplate.Height = 60;
        }

        private void selectfunc_e(string str)
        {
            dt_e.Clear();
            dt_e = new DataTable();
            dgv_EventInfo.DataSource = null;
            da_e = new OleDbDataAdapter(str, cn);
            da_e.Fill(dt_e);
            dgv_EventInfo.DataSource = dt_e;
            dgv_EventInfo.AutoResizeColumns();

            for (int i = 0; i <= 3; i++)
            {
                //DatagridView(EventInfo)のヘッダーを中央揃え
                dgv_EventInfo.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //DatagridView(EventInfo)の内容を中央揃え
                dgv_EventInfo.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void PriceList_Load(object sender, EventArgs e)
        {
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");

            selectfunc_p("SELECT ol.OLD_NAME AS 新作・旧作, pr.PRICE_12 AS 1泊2日, pr.PRICE_23 AS 2泊3日, pr.PRICE_78 AS 7泊8日 FROM TBL_PRICE pr, TBL_TYPE tp, TBL_OLD ol WHERE pr.TYPE_ID = tp.TYPE_ID AND pr.OLD_ID = ol.OLD_ID AND pr.PRICE_DELETE <> true order by pr.TYPE_ID ASC, pr.OLD_ID ASC");

            selectfunc_e("SELECT ev.EVENT_NAME AS イベント名, ev.EVENT_PRICE AS イベント料金, tp.TYPE_NAME AS 商品タイプ, ev.EVENT_NUM AS 枚数 FROM TBL_EVENT ev, TBL_TYPE tp WHERE ev.TYPE_ID = tp.TYPE_ID");
        }



    }
}
