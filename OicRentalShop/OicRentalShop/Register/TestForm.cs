using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OicRentalShop.Register
{
    public partial class TestForm : Form
    {
        public static Return.Return rr;
        public static PriceList.PriceList pp;
        public static Lend.Lend ll;
        public static ItemInfo.ItemInfo ii;

        public TestForm()
        {
            InitializeComponent();
        }
        private void TestForm_Load(object sender, EventArgs e)
        {
            rr= new Return.Return();
            pp = new PriceList.PriceList();
            ll = new Lend.Lend();
            ii = new ItemInfo.ItemInfo();
            panel2.Controls.Add(rr);
            panel2.Controls.Add(pp);
            panel2.Controls.Add(ll);
            panel2.Controls.Add(ii);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rr.Visible = true;
            ll.Visible = true;
            pp.Visible = false;
            ii.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            ll.Visible = false;
            rr.Visible = false;
            pp.Visible = true;
            ii.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ll.Visible = true;
            rr.Visible = false;
            pp.Visible = false;
            ii.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ll.Visible = false;
            rr.Visible = false;
            pp.Visible = false;
            ii.Visible = true;

        }
    }
}
