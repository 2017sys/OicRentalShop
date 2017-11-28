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

namespace OicRentalShop.Register.PriceList
{
    public partial class PriceList : UserControl
    {
        OleDbConnection cn = new OleDbConnection();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        public PriceList()
        {
            InitializeComponent();
        }

        private void PriceList_Load(object sender, EventArgs e)
        {
            cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");

            dt.Clear();
            dt = new DataTable();
            dgv_EventInfo.DataSource = null;
            da = new OleDbDataAdapter("SELECT * FROM TBL_TITLE", cn);
            da.Fill(dt);
            dgv_EventInfo.DataSource = dt;
            dgv_EventInfo.AutoResizeColumns();

            selectfunc("SELECT  FROM TBL_PRICE WHERE PRICE_DELETE <> true order by LEND_ID ASC,OLD_ID ASC");
        }

        private void selectfunc(string cmdstr)
        {
            dt.Clear();
            dt = new DataTable();
            dgv_PriceInfo.DataSource = null;
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            dgv_PriceInfo.DataSource = dt;
            dgv_PriceInfo.AutoResizeColumns();
        }
    }
}
