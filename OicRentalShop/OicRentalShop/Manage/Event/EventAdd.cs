using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OicRentalShop.Manage.Event
{
    public partial class EventAdd : UserControl
    {
        public EventAdd()
        {
            InitializeComponent();
        }

        private void btn_Redo_Click(object sender, EventArgs e)
        {
            ManageHome.cancel(4);
        }

        private void EventAdd_Load(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
        }


    }
}
