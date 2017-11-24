using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OicRentalShop.Register.ItemAdd
{
    public partial class ItemAddConfirmation : UserControl
    {
        public ItemAddConfirmation()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            int flag=1;
            TestForm.cancel(flag);
        }
    }
}
