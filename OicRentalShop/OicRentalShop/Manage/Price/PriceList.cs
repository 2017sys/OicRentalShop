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

namespace OicRentalShop.Manage.Price
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

        private void PriceList_Load(object sender, EventArgs e)
        {
            selectfunc("SELECT * FROM TBL_PRICE");
        }
    }
}
