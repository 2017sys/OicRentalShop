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

        public static Item.ItemList ii;
        public static Member.MemberList mm;
        public static Staff.StaffList ss;
        public static Price.PriceList pp;
        public static Profit.ProfitList pr;
        public static Event.EventList ee;
        public static Log.LogList ll;

        private void ManageHome_Load(object sender, EventArgs e)
        {
            ee = new Event.EventList();
            ii = new Item.ItemList();
            ll = new Log.LogList();
            mm = new Member.MemberList();
            pp = new Price.PriceList();
            pr = new Profit.ProfitList();
            ss = new Staff.StaffList();

            panel2.Controls.Add(ii);
            panel2.Controls.Add(mm);
            panel2.Controls.Add(ss);
            panel2.Controls.Add(pp);
            panel2.Controls.Add(pr);
            panel2.Controls.Add(ee);
            panel2.Controls.Add(ll);
        }


        private void btn_Top_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ii.Visible = true;
            mm.Visible = false;
            ss.Visible = false;
            pp.Visible = false;
            pr.Visible = false;
            ee.Visible = false;
            ll.Visible = false;
        }

        private void btn_Lend_Click(object sender, EventArgs e)
        {
            ii.Visible = false;
            mm.Visible = true;
            ss.Visible = false;
            pp.Visible = false;
            pr.Visible = false;
            ee.Visible = false;
            ll.Visible = false;
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            ii.Visible = false;
            mm.Visible = false;
            ss.Visible = true;
            pp.Visible = false;
            pr.Visible = false;
            ee.Visible = false;
            ll.Visible = false;
        }

        private void btn_ItemInfo_Click(object sender, EventArgs e)
        {
            ii.Visible = false;
            mm.Visible = false;
            ss.Visible = false;
            pp.Visible = true;
            pr.Visible = false;
            ee.Visible = false;
            ll.Visible = false;
        }

        private void btn_PriceList_Click(object sender, EventArgs e)
        {
            ii.Visible = false;
            mm.Visible = false;
            ss.Visible = false;
            pp.Visible = false;
            pr.Visible = true;
            ee.Visible = false;
            ll.Visible = false;
        }

        private void btn_ItemAdd_Click(object sender, EventArgs e)
        {
            ii.Visible = false;
            mm.Visible = false;
            ss.Visible = false;
            pp.Visible = false;
            pr.Visible = false;
            ee.Visible = true;
            ll.Visible = false;
        }

        private void btn_MemberAdd_Click(object sender, EventArgs e)
        {
            ii.Visible = false;
            mm.Visible = false;
            ss.Visible = false;
            pp.Visible = false;
            pr.Visible = false;
            ee.Visible = false;
            ll.Visible = true;
        }
    }
}
