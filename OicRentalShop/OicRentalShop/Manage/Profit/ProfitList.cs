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

namespace OicRentalShop.Manage.Profit
{


    public partial class ProfitList : UserControl
    {

        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbDataAdapter da1 = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        public ProfitList()
        {
            InitializeComponent();
        }

        private void btn_Set_Click(object sender, EventArgs e)
        {


            if (txt_StartDay.Text.Length > 0 && txt_EndDay.Text.Length > 0)
            {
                dt.Clear();
                dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("SELECT SUM(SLIP_PRICE) FROM TBL_SLIP WHERE SLIP_DATE BETWEEN #" + txt_StartDay.Text + "# AND #" + txt_EndDay.Text + "#", cn);
                da.Fill(dt);
                txt_Total.Text = dt.Rows[0][0].ToString();
                dt.Clear();
                dt = new DataTable();
                dgv_Voucher.Columns.Clear();
                dgv_Voucher.DataSource = null;
                OleDbDataAdapter da1 = new OleDbDataAdapter("SELECT * FROM TBL_SLIP WHERE SLIP_DATE BETWEEN #" + txt_StartDay.Text + "# AND #" + txt_EndDay.Text + "#", cn);
                da1.Fill(dt);
            }

  
            
            dgv_Voucher.DataSource = dt;
            dgv_Voucher.AutoResizeColumns();
        }
    }
}
