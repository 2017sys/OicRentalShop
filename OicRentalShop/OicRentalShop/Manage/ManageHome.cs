using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OicRentalShop.Manage
{
    public partial class ManageHome : Form
    {
        public ManageHome()
        {
            InitializeComponent();
        }

        public static Event.EventList ee;
        public static Item.ItemList ii;
        public static Log.LogList ll;
        public static Member.MemberList mm;
        public static Price.PriceList pp;
        public static Profit.ProfitList pr;
        public static Staff.StaffList ss;

        private void ManageHome_Load(object sender, EventArgs e)
        {
            ee = new Event.EventList();
            ii = new Item.ItemList();
            ll = new Log.LogList();
            mm = new Member.MemberList();
            pp = new Price.PriceList();
            pr = new Profit.ProfitList();
            ss = new Staff.StaffList();

            panel2.Controls.Add(ee);
            panel2.Controls.Add(ii);
            panel2.Controls.Add(ll);
            panel2.Controls.Add(mm);
            panel2.Controls.Add(pp);
            panel2.Controls.Add(pr);
            panel2.Controls.Add(ss);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ee.Visible = true;
            ii.Visible = false;
            ll.Visible = false;
            mm.Visible = false;
            pp.Visible = false;
            pr.Visible = false;
            ss.Visible = false;
        }

        private void btn_Lend_Click(object sender, EventArgs e)
        {
            ee.Visible = false;
            ii.Visible = true;
            ll.Visible = false;
            mm.Visible = false;
            pp.Visible = false;
            pr.Visible = false;
            ss.Visible = false;
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            ee.Visible = false;
            ii.Visible = false;
            ll.Visible = true;
            mm.Visible = false;
            pp.Visible = false;
            pr.Visible = false;
            ss.Visible = false;
        }

        private void btn_PriceList_Click(object sender, EventArgs e)
        {
            ee.Visible = false;
            ii.Visible = false;
            ll.Visible = false;
            mm.Visible = true;
            pp.Visible = false;
            pr.Visible = false;
            ss.Visible = false;
        }

        private void btn_ItemInfo_Click(object sender, EventArgs e)
        {
            ee.Visible = false;
            ii.Visible = false;
            ll.Visible = false;
            mm.Visible = false;
            pp.Visible = true;
            pr.Visible = false;
            ss.Visible = false;
        }

        private void btn_ItemAdd_Click(object sender, EventArgs e)
        {
            ee.Visible = false;
            ii.Visible = false;
            ll.Visible = false;
            mm.Visible = false;
            pp.Visible = false;
            pr.Visible = true;
            ss.Visible = false;
        }

        private void btn_MemberAdd_Click(object sender, EventArgs e)
        {
            ee.Visible = false;
            ii.Visible = false;
            ll.Visible = false;
            mm.Visible = false;
            pp.Visible = false;
            pr.Visible = false;
            ss.Visible = true;
        }

        private void btn_Top_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
