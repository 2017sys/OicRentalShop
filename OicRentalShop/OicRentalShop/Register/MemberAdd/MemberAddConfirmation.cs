using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OicRentalShop.Register.MemberAdd
{
    public partial class MemberAddConfirmation : UserControl
    {
        public MemberAddConfirmation()
        {
            InitializeComponent();
        }

        private void MemberAddConfirmation_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            int flag = 0;
            RegisterHome.cancel(flag);
        }
    }
}
