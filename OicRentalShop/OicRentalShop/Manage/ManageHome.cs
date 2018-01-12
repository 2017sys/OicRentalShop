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
        public static Item.ItemAdd ia;
        public static Member.MemberList me;
        public static Staff.StaffList st;
        public static Staff.StaffAdd sa;
        public static Staff.StaffAddConfirmation sac;
        public static Price.PriceList pc;
        public static Profit.ProfitList pf;
        public static Event.EventList ev;
        public static Log.LogList lo;
        public static Title.TitleList tl;
        public static Title.ManageTitleAdd mta;
        public static Member.MemberAddCorrection ma;
        public static Member.MemberAddCorrectionConfirmation mac;
        public static Event.EventAdd ea;
 

        public ManageHome()
        {
            InitializeComponent();
        }


        private void ManageHome_Load(object sender, EventArgs e)
        {
            it = new Item.ItemList();
            ia = new Item.ItemAdd();
            me = new Member.MemberList();
            st = new Staff.StaffList();
            sa = new Staff.StaffAdd();
            sac = new Staff.StaffAddConfirmation();
            pc = new Price.PriceList();
            pf = new Profit.ProfitList();
            ev = new Event.EventList();
            lo = new Log.LogList();
            tl = new Title.TitleList();
            mta = new Title.ManageTitleAdd();
            ma = new Member.MemberAddCorrection();
            mac = new Member.MemberAddCorrectionConfirmation();
            ea = new Event.EventAdd();

            panel.Controls.Clear();
            panel.Controls.Add(it);
            it.Visible = true;

        }


        public static void GoNext(int flag)
        {
            if (flag == 0)
            {
                me.Visible = false;
              
                ma.Visible = true;
            }
            else if(flag==1)
            {
                ma.Visible = false;
                mac.Visible = true;
            }
            else if(flag==2)
            {
                st.Visible = false;
                sa.Visible = true;
            }
            else if(flag==3)
            {
                sa.Visible = false;
                sac.Visible = true;
            }
            else if(flag==4)
            {
                tl.Visible = false;
                mta.Visible = true;
            }
            else if (flag == 5)
            {
                ev.Visible = false;
                ea.Visible = true;
            }
            
            else if (flag==6)
            {
                it.Visible = false;
                ia.Visible = true;
            }

        }

        public static void cancel(int flag)
        {
            if (flag == 0)
            {
                me.Visible = true;
                ma.Visible = false;
            }
            else if(flag==1)
            {
                mac.Visible = false;
                ma.Visible = true;
            }
            else if(flag==2)
            {
                sa.Visible = false;
                st.Visible = true;
            }
            else if(flag==3)
            {
                sac.Visible = false;
                sa.Visible = true;
            }
            else if (flag == 4)
            {
                ea.Visible = false;
                ev.Visible = true;
            }
            else if(flag==5)
            {
                it.Visible = true;
                ia.Visible = false;
            }
        }

        private void btn_Top_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Item_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(it);
            panel.Controls.Add(ia);
            it.Visible = true;
            ia.Visible = false;
        }

        private void btn_Member_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(me);
            panel.Controls.Add(ma);
            panel.Controls.Add(mac);
            me.Visible = true;
            ma.Visible = false;
            mac.Visible = false;
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(st);
            panel.Controls.Add(sa);
            panel.Controls.Add(sac);
            st.Visible = true;
            sa.Visible = false;
            sac.Visible = false;
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
            panel.Controls.Add(ea);
            ev.Visible = true;
            ea.Visible = false;
        }

        private void btn_Log_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(lo);
            lo.Visible = true;
        }

        private void btn_Title_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(tl);
            panel.Controls.Add(mta);
            tl.Visible = true;
            mta.Visible = false;
        }
    }
}
