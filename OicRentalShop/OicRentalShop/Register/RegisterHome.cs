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
    public partial class RegisterHome : Form
    {
        public static ItemAdd.ItemAdd ia;
        public static ItemInfo.ItemInfo ii;
        public static Lend.Lend ll;
        public static MemberAdd.MemberAdd mm;
        public static PriceList.PriceList pp;
        public static Return.Return rr;
        public static MemberAdd.MemberAddConfirmation ma;
        public static ItemAdd.ItemAddConfirmation ic;
        public static Title.TitleAdd ta;
        
        

        public RegisterHome()
        {
            InitializeComponent();
        }

        public static void GoNext(int flag)
        {
            if (flag == 0)
            {
                mm.Visible = false;
                ma.Visible = true;
            }
            else
            {
                ia.Visible = false;
                ic.Visible = true;
            }
        }

        public static void cancel(int flag)
        {
            if (flag == 0)
            {
                mm.Visible = true;
                ma.Visible = false;
            }
            else
            {
                ia.Visible = true;
                ic.Visible = false;
            }
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            ia = new ItemAdd.ItemAdd();
            ii = new ItemInfo.ItemInfo();
            ll = new Lend.Lend();
            mm = new MemberAdd.MemberAdd();
            pp = new PriceList.PriceList();
            rr= new Return.Return();
            ma = new MemberAdd.MemberAddConfirmation();
            ic = new ItemAdd.ItemAddConfirmation();
            ta = new Title.TitleAdd();
            
        }

        private void btn_Top_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Lend_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(ll);
            ll.Visible = true;
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(rr);
            rr.Visible = true;
        }

        private void btn_ItemInfo_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(ii);
            ii.Visible = true;
        }

        private void btn_PriceList_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(pp);
            pp.Visible = true;
        }

        private void btn_ItemAdd_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(ia);
            panel.Controls.Add(ic);
            ia.Visible = true;
        }

        private void btn_MemberAdd_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(mm);
            panel.Controls.Add(ma);
            mm.Visible = true;
        }

        private void btn_Title_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(ta);
            ta.Visible = true;
        }
  

    }
}
