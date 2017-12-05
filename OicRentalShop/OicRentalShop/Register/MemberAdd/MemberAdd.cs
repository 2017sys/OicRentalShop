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
    public partial class MemberAdd : UserControl
    {
       public MemberInfo mi;
        public struct MemberInfo
        {
            public string ID;
            public string FName;
            public string GName;
            public string FNameK;
            public string GNameK;
            public string Sex;
            public string BDay;
            public string PhoneNum;
            public string TelePhoneNum;
            public string PostNum;
            public string AD1;
            public string AD2;

        }
        public MemberAdd()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            if (txt_ID.Text.Length > 0 && txt_FamilyName.Text.Length > 0 && txt_FamilyNameKANA.Text.Length > 0 && txt_GivenName.Text.Length > 0 && txt_GivenNameKANA.Text.Length > 0 && txt_Birtyday.Text.Length > 0 && (txt_PhoneNumber.Text.Length > 0 || txt_TelePhoneNumber.Text.Length >0) && txt_PostalCode.Text.Length > 0 && txt_Address1.Text.Length > 0 && txt_Address2.Text.Length > 0 && (rdb_MAN.Checked==true || rdb_WOMAN.Checked==true))
            {
                int flag = 0;

                MemberAddConfirmation.mi.ID = txt_ID.Text;
                MemberAddConfirmation.mi.FName = txt_FamilyName.Text;
                MemberAddConfirmation.mi.GName = txt_GivenName.Text;
                MemberAddConfirmation.mi.FNameK = txt_FamilyNameKANA.Text;
                MemberAddConfirmation.mi.GNameK = txt_GivenNameKANA.Text;
                MemberAddConfirmation.mi.BDay = txt_Birtyday.Text;
                MemberAddConfirmation.mi.PhoneNum = txt_PhoneNumber.Text;
                MemberAddConfirmation.mi.TelePhoneNum = txt_TelePhoneNumber.Text;
                MemberAddConfirmation.mi.PostNum = txt_PostalCode.Text;
                MemberAddConfirmation.mi.AD1 = txt_Address1.Text;
                MemberAddConfirmation.mi.AD2 = txt_Address2.Text;
                if (rdb_MAN.Checked == true)
                {
                    MemberAddConfirmation.mi.Sex = "男";
                }
                else
                {
                    MemberAddConfirmation.mi.Sex = "女";
                }

                TestForm.cancel(flag);
                TestForm.GoNext(flag);
            }
            else
            {
                //項目に空欄があるってダイアログ
            }

         
        }


        private void MemberAdd_Load(object sender, EventArgs e)
        {

            
        }

        private void MemberAdd_VisibleChanged(object sender, EventArgs e)
        {
            txt_Address1.Clear();
            txt_Address2.Clear();
            txt_Birtyday.Clear();
            txt_FamilyName.Clear();
            txt_FamilyNameKANA.Clear();
            txt_GivenName.Clear();
            txt_GivenNameKANA.Clear();
            txt_ID.Clear();
            txt_PhoneNumber.Clear();
            txt_PostalCode.Clear();
            txt_TelePhoneNumber.Clear();
        }
    }
}
