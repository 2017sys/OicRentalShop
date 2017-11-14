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
        public static ItemAdd.ItemAdd iadd;
        public static ItemInfo.ItemInfo iinfo;
        public static Lend.Lend ll;
        public static MemberAdd.MemberAdd mm;
        public static PriceList.PriceList pp;
        public static Return.Return rr;
        
        

        public TestForm()
        {
            InitializeComponent();
        }
        private void TestForm_Load(object sender, EventArgs e)
        {
            iadd = new ItemAdd.ItemAdd();
            iinfo = new ItemInfo.ItemInfo();
            ll = new Lend.Lend();
            mm = new MemberAdd.MemberAdd();
            pp = new PriceList.PriceList();
            rr= new Return.Return();

            panel2.Controls.Add(iadd);
            panel2.Controls.Add(iinfo);
            panel2.Controls.Add(ll);
            panel2.Controls.Add(mm);
            panel2.Controls.Add(pp);
            panel2.Controls.Add(rr);
        }

        private void btn_Top_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Lend_Click(object sender, EventArgs e)
        {
            iadd.Visible = false;
            iinfo.Visible = false;
            ll.Visible = true;
            mm.Visible=false;
            pp.Visible = false;
            rr.Visible = false;
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            iadd.Visible = false;
            iinfo.Visible = false;
            ll.Visible = false;
            mm.Visible = false;
            pp.Visible = false;
            rr.Visible = true;
        }

        private void btn_ItemInfo_Click(object sender, EventArgs e)
        {
            iadd.Visible = false;
            iinfo.Visible = true;
            ll.Visible = false;
            mm.Visible = false;
            pp.Visible = false;
            rr.Visible = false;
        }

        private void btn_PriceList_Click(object sender, EventArgs e)
        {
            iadd.Visible = false;
            iinfo.Visible = false;
            ll.Visible = false;
            mm.Visible = false;
            pp.Visible = true;
            rr.Visible = false;
        }

        private void btn_ItemAdd_Click(object sender, EventArgs e)
        {
            iadd.Visible = true;
            iinfo.Visible = false;
            ll.Visible = false;
            mm.Visible = false;
            pp.Visible = true;
            rr.Visible = false;
        }

        private void btn_MemberAdd_Click(object sender, EventArgs e)
        {
            iadd.Visible = false;
            iinfo.Visible = false;
            ll.Visible = false;
            mm.Visible = true;
            pp.Visible = true;
            rr.Visible = false;
        }

    }
}
