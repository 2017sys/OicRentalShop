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

namespace OicRentalShop.Manage.Event
{
    public partial class EventAdd : UserControl
    {
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dtp = new DataTable();
        DataTable dt = new DataTable();

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


            string old="null";
            if(cmb_Old.Text=="新作")
            {
                old = "1";
            }
            else if (cmb_Old.Text == "旧作")
            {
                old = "2";
            }
            else if(cmb_Old.Text=="すべて")
            {

            }
            
            string sd = date_Start.Value.ToString("yyyy/MM/dd");
            string ed = date_End.Value.ToString("yyyy/MM/dd");
            MessageBox.Show(sd);
            CmdFunc("INSERT INTO TBL_EVENT(EVENT_NAME,EVENT_PRICE,TYPE_ID,EVENT_NUM,EVENT_START,EVENT_END,EVENT_OLD,EVENT_DELETE)  VALUES('"+txt_EventName.Text+"',"+txt_EventPrice.Text+","+txt_ItemType.Text+","+txt_ItemNum.Text+",#"+sd+"#,#"+ed+"#,"+old+",false)");
        }

        private void CmdFunc(string cmdstr) //UPDATE DELETE INSERTを実行できる　CmdFunc("SQL文"); 
        {
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = cn;
            cn.Open();
            Cmd.CommandText = cmdstr;
            Cmd.ExecuteNonQuery();
            cn.Close();
        }

    }
}
