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
        public static Item.ItemList it;
        public static Member.MemberList me;
        public static Staff.StaffList st;
        public static Price.PriceList pc;
        public static Profit.ProfitList pf;
        public static Event.EventList ev;
        public static Log.LogList lo;


        public ManageHome()
        {
            InitializeComponent();
        }


        private void ManageHome_Load(object sender, EventArgs e)
        {
            it = new Item.ItemList();
            me = new Member.MemberList();
            st = new Staff.StaffList();
            pc = new Price.PriceList();
            pf = new Profit.ProfitList();
            ev = new Event.EventList();
            lo = new Log.LogList();

            panel.Controls.Clear();
            panel.Controls.Add(it);
            it.Visible = true;

        }


        private void btn_Top_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Item_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(it);
            it.Visible = true;
        }

        private void btn_Member_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(me);
            me.Visible = true;
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(st);
            st.Visible = true;
        }

        private void btn_Price_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(pc);
            pc.Visible = true;
        }

        private void btn_Profit_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(pf);
            pf.Visible = true;
        }

        private void btn_Event_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(ev);
            ev.Visible = true;
        }

        private void btn_Log_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(lo);
            lo.Visible = true;
        }
    }
}
