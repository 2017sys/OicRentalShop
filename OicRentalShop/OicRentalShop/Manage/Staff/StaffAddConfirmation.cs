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

namespace OicRentalShop.Manage.Staff
{
    public partial class StaffAddConfirmation : UserControl
    {
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        public static StaffInfo si;
        public struct StaffInfo
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

        public StaffAddConfirmation()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ManageHome.cancel(3);
        }

        private void StaffAddConfirmation_VisibleChanged(object sender, EventArgs e)
        {
            lbl_StaffIDInfo.Text = si.ID;
            lbl_FamilyNameInfo.Text = si.FName;
            lbl_FamilyNameKANAInfo.Text = si.FNameK;
            lbl_GivenNameInfo.Text = si.GName;
            lbl_GivenNameKANAInfo.Text = si.GNameK;
            lbl_SexInfo.Text = si.Sex;
            lbl_BirthDayInfo.Text = si.BDay;
            lbl_TelePhoneNumberInfo.Text = si.TelePhoneNum;
            lbl_PhoneNumberInfo.Text = si.PhoneNum;
            lbl_PostalNumberInfo.Text = si.PostNum;
            lbl_Address1Info.Text = si.AD1;
            lbl_Address2Info.Text = si.AD2;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = cn;
            cn.Open();
            Cmd.CommandText = "INSERT INTO TBL_STAFF(STAFF_NAME,STAFF_KANA,STAFF_OWNER,STAFF_SEX,STAFF_POST,STAFF_ADDRESS";


            if (si.PhoneNum.Length > 0)//携帯電話番号と電話番号の入力されている項目のインサート文を追加
            {
                Cmd.CommandText += ",STAFF_TEL";
            }

            if (si.TelePhoneNum.Length > 0)
            {
                Cmd.CommandText += ",STAFF_MOBILE";
            }


            DateTime Today = DateTime.Today;
            Cmd.CommandText += ",STAFF_BIRTH,STAFF_DELETE)  VALUES('" + si.FName + " " + si.GName + "','" + si.FNameK +
                                " " + si.GNameK + "',false,'" + si.Sex + "','" + si.PostNum + "','" + si.AD1 + " " + si.AD2;

            if (si.PhoneNum.Length > 0)
            {
                Cmd.CommandText += "','" + si.PhoneNum;
            }

            if (si.TelePhoneNum.Length > 0)
            {
                Cmd.CommandText += "','" + si.TelePhoneNum;
            }

            Cmd.CommandText += "',#" + si.BDay + "#,false)";


            Cmd.ExecuteNonQuery();
            cn.Close();
            lbl_Message.Text = "登録しました";

        }

        private void StaffAddConfirmation_Load(object sender, EventArgs e)
        {

        }
    }
}
