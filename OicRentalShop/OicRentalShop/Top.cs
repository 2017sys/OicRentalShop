using OicRentalShop.Manage;
using OicRentalShop.Register;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OicRentalShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterHome tstfm = new RegisterHome();
            this.Hide();
            tstfm.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageHome mngfm = new ManageHome();
            this.Hide();
            mngfm.ShowDialog();
            this.Show();
        }
    }
}
