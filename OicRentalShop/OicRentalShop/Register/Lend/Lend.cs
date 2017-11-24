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
using System.Data.SqlClient;

namespace OicRentalShop.Register.Lend
{
    public partial class Lend : UserControl
    {

        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        public Lend()
        {
            InitializeComponent();
        }

        private void SetProductInfo(string cmdstr)
        {
            dt.Clear();
            dt = new DataTable();
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                strpi = dt.Rows[0][0].ToString();
            }
         }

        private void SetMemberInfo(string cmdstr)
        {
            {
                dt.Clear();
                dt = new DataTable();
                da = new OleDbDataAdapter(cmdstr, cn);
                da.Fill(dt);
                if (dt.Rows.Count != 0)
                {
                    strmi = dt.Rows[0][0].ToString();
                }
            }
        }

        private int dtCheck(string cmdstr)　//IDを入力した際　1列以上選択されるかチェックをし　データの有無を確認する
        {
            int flag=0;
            dt.Clear();
            dt = new DataTable();
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                flag = 1;
            }
            return flag;

        }

        private void Lend_Load(object sender, EventArgs e)
        {

        }

        private void txt_MemberID_TextChanged(object sender, EventArgs e)
        {
            if (txt_MemberID.Text.Length == 1)
            {
                if (dtCheck("SELECT * FROM TBL_MEMBER WHERE MEMBER_ID=" + txt_MemberID.Text) == 1)
                {
                    SetMemberInfo("SELECT MEMBER_POINT FROM TBL_MEMBER WHERE MEMBER_ID=" + txt_MemberID.Text);
                    txt_MemberPoint.Text = strmi;
                    SetMemberInfo("SELECT MEMBER_NAME FROM TBL_MEMBER WHERE MEMBER_ID=" + txt_MemberID.Text);
                    txt_MemberName.Text = strmi;
                }
                else
                {
                    MessageBox.Show("メンバーID:" + txt_MemberID.Text + "は存在しません");
                    txt_MemberID.Clear();
                }
            }
            else if(txt_MemberID.Text.Length>=2)
            {
                MessageBox.Show("メンバーIDはN文字です");
                txt_MemberID.Clear();
            }

            if (txt_MemberID.Text.Length == 0)
            {
                txt_MemberPoint.Clear();
                txt_MemberName.Clear();
            }

        }

        string strpi;
        string strmi;
        private void txt_ProductID_TextChanged(object sender, EventArgs e)
        {
            if (txt_ProductID.Text.Length == 1)
            {
                if (dtCheck("SELECT * FROM TBL_ITEM WHERE ITEM_ID=" + txt_ProductID.Text)==1)
                {
                    SetProductInfo("SELECT t.TITLE_NAME FROM TBL_TITLE t,TBL_ITEM i WHERE t.TITLE_ID=i.TITLE_ID AND i.ITEM_ID = " + txt_ProductID.Text);
                    txt_title.Text = strpi;
                    SetProductInfo("SELECT y.TYPE_NAME FROM TBL_TITLE t,TBL_ITEM i,TBL_TYPE y WHERE t.TITLE_ID=i.TITLE_ID AND y.TYPE_ID=t.TYPE_ID AND i.ITEM_ID = " + txt_ProductID.Text);
                    txt_type.Text = strpi;
                }
                else
                {
                    MessageBox.Show("商品ID:" + txt_ProductID.Text + "は存在しません");
                    txt_ProductID.Clear();
                }
            }
            else if(txt_ProductID.Text.Length>=2)
            {
                MessageBox.Show("商品IDはN文字です");
                txt_ProductID.Clear();
            }
            
            if(txt_ProductID.Text.Length==0)
            {
                txt_title.Clear();
                txt_type.Clear();
            }
        }
    }
}
