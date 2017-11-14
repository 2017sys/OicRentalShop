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

        private void ItemInfo_Load(object sender, EventArgs e)
        {
            
             cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\DB\Database1.accdb;");
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            dt.Clear();
            dt = new DataTable();
            dgv_ItemInfo.DataSource = null;
            da = new OleDbDataAdapter("SELECT * FROM TBL_DVDTITLE", cn);
            da.Fill(dt);
            dgv_ItemInfo.DataSource = dt;
            dgv_ItemInfo.AutoResizeColumns();
        }

        

    }
}
