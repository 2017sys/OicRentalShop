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
        public static MemberInfo mi;
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
            public string PostNum;
            public string AD1;
            public string AD2;

        }
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
            TestForm.cancel(flag);
        }

        private void MemberAddConfirmation_VisibleChanged(object sender, EventArgs e)
        {
            lbl_MemberIDInfo.Text = mi.ID;
            lbl_FamilyNameInfo.Text = mi.FName;
            lbl_FamilyNameKANAInfo.Text = mi.FNameK;
            lbl_GivenNameInfo.Text = mi.GName;
            lbl_GivenNameKANAInfo.Text = mi.GNameK;
            lbl_SexInfo.Text = mi.Sex;
            lbl_BirthDayInfo.Text = mi.BDay;
            lbl_PhoneNumberInfo.Text = mi.PhoneNum;
            lbl_PostalNumberInfo.Text = mi.PostNum;
            lbl_Address1Info.Text = mi.AD1;
            lbl_Address2Info.Text = mi.AD2;
        }
    }
}
