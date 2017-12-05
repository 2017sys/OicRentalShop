using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OicRentalShop.Register.Title
{
    public partial class TitleAdd : UserControl
    {
  


        public TitleAdd()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("仮登録データを全て登録しますか？", "確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                

                /* 　-　ここ　-　 */


                dgv_ItemRe.Rows.Clear();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("仮登録データを全て削除しますか？", "確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                dgv_ItemRe.Rows.Clear();
            }
            
        }

        private void btn_Toadd_Click(object sender, EventArgs e)
        {
            this.dgv_ItemRe.Rows.Add("削除",txt_TaitleID.Text, cmb_Format.Text, txt_Title.Text, txt_Artist.Text, txt_Genre.Text); 
        }

        private void dgv_ItemRe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dgv_ItemRe.Columns["btn_Delete"].Index)
            {
                if (DialogResult.Yes == MessageBox.Show("削除しますか？", "確認",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    this.dgv_ItemRe.Rows.RemoveAt(e.RowIndex);
                }
            } 
        }
    }
}
