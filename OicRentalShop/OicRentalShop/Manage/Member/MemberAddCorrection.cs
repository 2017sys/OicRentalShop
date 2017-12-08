using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OicRentalShop.Manage.Member
{
    public partial class MemberAddCorrection : UserControl
    {
        public MemberAddCorrection()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text.Length > 0 && txt_FamilyName.Text.Length > 0 && txt_FamilyNameKANA.Text.Length > 0 && txt_GivenName.Text.Length > 0 && txt_GivenNameKANA.Text.Length > 0 && txt_Birtyday.Text.Length > 0 && (txt_PhoneNumber.Text.Length > 0 || txt_TelePhoneNumber.Text.Length > 0) && txt_PostalCode.Text.Length > 0 && txt_Address1.Text.Length > 0 && txt_Address2.Text.Length > 0 && (rdb_MAN.Checked == true || rdb_WOMAN.Checked == true))
            {
           

                MemberAddCorrectionConfirmation.mi.ID = txt_ID.Text;
                MemberAddCorrectionConfirmation.mi.FName = txt_FamilyName.Text;
                MemberAddCorrectionConfirmation.mi.GName = txt_GivenName.Text;
                MemberAddCorrectionConfirmation.mi.FNameK = txt_FamilyNameKANA.Text;
                MemberAddCorrectionConfirmation.mi.GNameK = txt_GivenNameKANA.Text;
                MemberAddCorrectionConfirmation.mi.BDay = txt_Birtyday.Text;
                MemberAddCorrectionConfirmation.mi.PhoneNum = txt_PhoneNumber.Text;
                MemberAddCorrectionConfirmation.mi.TelePhoneNum = txt_TelePhoneNumber.Text;
                MemberAddCorrectionConfirmation.mi.PostNum = txt_PostalCode.Text;
                MemberAddCorrectionConfirmation.mi.AD1 = txt_Address1.Text;
                MemberAddCorrectionConfirmation.mi.AD2 = txt_Address2.Text;
                if (rdb_MAN.Checked == true)
                {
                    MemberAddCorrectionConfirmation.mi.Sex = "男";
                }
                else
                {
                    MemberAddCorrectionConfirmation.mi.Sex = "女";
                }
                ManageHome.GoNext(1);
                ManageHome.cancel(1);
                ManageHome.GoNext(1);
            }
            else
            {
                //項目に空欄があるってダイアログ
            }
           
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            ManageHome.cancel(0);
        }
    }
}
