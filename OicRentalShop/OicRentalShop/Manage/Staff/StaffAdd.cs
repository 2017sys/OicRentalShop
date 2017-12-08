using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OicRentalShop.Manage.Staff
{
    public partial class StaffAdd : UserControl
    {
        public StaffAdd()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            ManageHome.cancel(2);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text.Length > 0 && txt_FamilyName.Text.Length > 0 && txt_FamilyNameKANA.Text.Length > 0 && txt_GivenName.Text.Length > 0 && txt_GivenNameKANA.Text.Length > 0 && txt_Birtyday.Text.Length > 0 && (txt_PhoneNumber.Text.Length > 0 || txt_TelePhoneNumber.Text.Length > 0) && txt_PostalCode.Text.Length > 0 && txt_Address1.Text.Length > 0 && txt_Address2.Text.Length > 0 && (rdb_MAN.Checked == true || rdb_WOMAN.Checked == true))
            {
           

                StaffAddConfirmation.si.ID = txt_ID.Text;
                StaffAddConfirmation.si.FName = txt_FamilyName.Text;
                StaffAddConfirmation.si.GName = txt_GivenName.Text;
                StaffAddConfirmation.si.FNameK = txt_FamilyNameKANA.Text;
                StaffAddConfirmation.si.GNameK = txt_GivenNameKANA.Text;
                StaffAddConfirmation.si.BDay = txt_Birtyday.Text;
                StaffAddConfirmation.si.PhoneNum = txt_PhoneNumber.Text;
                StaffAddConfirmation.si.TelePhoneNum = txt_TelePhoneNumber.Text;
                StaffAddConfirmation.si.PostNum = txt_PostalCode.Text;
                StaffAddConfirmation.si.AD1 = txt_Address1.Text;
                StaffAddConfirmation.si.AD2 = txt_Address2.Text;
                if (rdb_MAN.Checked == true)
                {
                    StaffAddConfirmation.si.Sex = "男";
                }
                else
                {
                    StaffAddConfirmation.si.Sex = "女";
                }
                ManageHome.GoNext(3);
                ManageHome.cancel(3);
                ManageHome.GoNext(3);
            }
            else
            {
                //項目に空欄があるってダイアログ
            }
           
        }
    
        
    }
}
