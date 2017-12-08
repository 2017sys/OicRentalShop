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

namespace OicRentalShop.Register.Return
{
    public partial class Return : UserControl
    {
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        public Return()
        {
            InitializeComponent();
        }

        private void Return_Load(object sender, EventArgs e)
        {

        }

        private void selectfunc(string cmdstr)//DataGridViewにレジを通した商品の情報を出力 DataTable dtpを他の用途に使う(Clearする)とDataGridViewに表示してるものが消える
        {
            dt.Clear();
            dt = new DataTable();
            dgv_ReturnItem.DataSource = null;
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            dgv_ReturnItem.DataSource = dt;
            dgv_ReturnItem.AutoResizeColumns();
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

        private int dtCheck(string cmdstr)　//IDを入力した際　1列以上選択されるかチェックをし　データの有無を確認する
        {
            int flag = 0;
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
    }
}
