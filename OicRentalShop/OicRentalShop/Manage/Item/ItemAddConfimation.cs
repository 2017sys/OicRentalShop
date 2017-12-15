using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OicRentalShop.Manage.Item
{
    public partial class ItemAddConfimation : UserControl
    {
        Item.ItemAdd ia;

        public ItemAddConfimation(Item.ItemAdd fm)
        {
            InitializeComponent();
            ia = fm;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ManageHome.cancel(6);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            MessageBox.Show("登録が完了しました");
            ManageHome.GoNext(8);
        }

        private void ItemAddConfimation_Load(object sender, EventArgs e)
        {

                }

        private void button1_Click(object sender, EventArgs e)
        {
            //dgv_ItemCon.Rows.Add(ia.dgv_ItemRe.Rows[0].Cells[0].Value, ia.dgv_ItemRe.Rows[0].Cells[1].Value, ia.dgv_ItemRe.Rows[0].Cells[2].Value, ia.dgv_ItemRe.Rows[0].Cells[3].Value, ia.dgv_ItemRe.Rows[0].Cells[4].Value, ia.dgv_ItemRe.Rows[0].Cells[5].Value, ia.dgv_ItemRe.Rows[0].Cells[6].Value);
        }
    }
}
