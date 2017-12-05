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

namespace OicRentalShop.Register.MemberAdd
{
    public partial class MemberAddConfirmation : UserControl
    {

        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();


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
            public string TelePhoneNum;
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
            lbl_TelePhoneNumberInfo.Text = mi.TelePhoneNum;
            lbl_PhoneNumberInfo.Text = mi.PhoneNum;
            lbl_PostalNumberInfo.Text = mi.PostNum;
            lbl_Address1Info.Text = mi.AD1;
            lbl_Address2Info.Text = mi.AD2;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = cn;
            cn.Open();
            Cmd.CommandText = "INSERT INTO TBL_MEMBER(MEMBER_DAY,MEMBER_NAME,MEMBER_KANA,MEMBER_SEX,MEMBER_POST,MEMBER_ADDRES";


            if (mi.PhoneNum.Length > 0)//携帯電話番号と電話番号の入力されている項目のインサート文を追加
            {
                Cmd.CommandText += ",MEMBER_TEL";
            }

            if(mi.TelePhoneNum.Length>0)
            {
                Cmd.CommandText += ",MEMBER_MOBILE";
            }


            DateTime Today = DateTime.Today;
            Cmd.CommandText += ",MEMBER_BIRTH)  VALUES(#" + Today.ToString() + "#,'" + mi.FName + " " + mi.GName + "','" + mi.FNameK + 
                                " " + mi.GNameK + "','" + mi.Sex + "','" + mi.PostNum + "','" + mi.AD1 + " " + mi.AD2;

            if (mi.PhoneNum.Length > 0)
            {
                Cmd.CommandText += "','" +mi.PhoneNum;
            }

            if (mi.TelePhoneNum.Length > 0)
            {
                Cmd.CommandText += "','" + mi.TelePhoneNum;
            }

            Cmd.CommandText += "',#" + mi.BDay + "#)";


            Cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}
