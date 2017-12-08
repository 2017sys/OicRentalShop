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

namespace OicRentalShop.Register.Lend
{
    public partial class LendConf : UserControl
    {

        OleDbConnection cn = new OleDbConnection();
        OleDbDataAdapter da_p = new OleDbDataAdapter();
        DataTable dt_p = new DataTable();

        OleDbDataAdapter da_m = new OleDbDataAdapter();
        DataTable dt_m = new DataTable();

        public LendConf()
        {
            InitializeComponent();
        }

        private void selectfunc_p(string cmdstr)
        {
            dt_p.Clear();
            dt_p = new DataTable();
            dgv_PayInfo.DataSource = null;
            da_p = new OleDbDataAdapter(cmdstr, cn);
            da_p.Fill(dt_p);
            dgv_PayInfo.DataSource = dt_p;
            dgv_PayInfo.AutoResizeColumns();
        }

        private void selectfunc_m(string cmdstr)
        {
            dt_m.Clear();
            dt_m = new DataTable();
            dgv_PayInfo.DataSource = null;
            da_m = new OleDbDataAdapter(cmdstr, cn);
            da_m.Fill(dt_m);
            dgv_PayInfo.DataSource = dt_m;
            dgv_PayInfo.AutoResizeColumns();
        }

        private void LendConf_Load(object sender, EventArgs e)
        {

        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            string km = txt_KeepM.Text;
            string tm = txt_TotalM.Text;
            int keepm = int.Parse(km);
            int totalm = int.Parse(tm);
            int cm= totalm - keepm;

            string changemoney = cm.ToString();


            txt_ChangeM.Text = changemoney;
        }




    }
}
