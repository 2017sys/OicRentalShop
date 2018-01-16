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

namespace OicRentalShop.Manage.Price
{
    public partial class PriceList : UserControl
    {
        OleDbConnection cn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\..\..\DB\Database1.accdb;");
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();


        public PriceList()
        {
            InitializeComponent();
        }



        private void AddButton(string buttonName, string buttonText)
        {
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            //列の名前を設定
            column.Name = buttonName;
            //全てのボタンに"詳細閲覧"と表示する
            column.UseColumnTextForButtonValue = true;
            column.Text = buttonText;
            //DataGridViewに追加する
            dgv_PriceInfo.Columns.Add(column);
        }

        private void selectfunc(string cmdstr)
        {
            dt.Clear();
            dt = new DataTable();
            dgv_PriceInfo.DataSource = null;
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            dgv_PriceInfo.DataSource = dt;
            AddButton("UPDATE", "更新");
        }

        private string SetInfo(string cmdstr)
        {
            dt.Clear();
            dt = new DataTable();
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            return dt.Rows[0][0].ToString();
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

        private string SerchID(string TblName, string Name)
        {

            string ID = SetInfo("SELECT " + TblName + "_ID FROM TBL_" + TblName + " WHERE " + TblName + "_NAME" + "= '" + Name + "'");
            return ID;
        }

        private void PriceList_Load(object sender, EventArgs e)
        {
            selectfunc("SELECT t.TYPE_NAME,o.OLD_NAME,p.PRICE_12,p.PRICE_23,p.PRICE_78,p.PRICE_START,p.PRICE_END FROM TBL_PRICE p,TBL_OLD o,TBL_TYPE t WHERE p.TYPE_ID=t.TYPE_ID AND p.OLD_ID=o.OLD_ID AND p.PRICE_DELETE=false ORDER BY t.TYPE_ID ASC,o.OLD_ID DESC");

        }


        private int ReturnPriceID(int sender)
        {

            dt.Clear();
            dt = new DataTable();
            dgv_PriceInfo.DataSource = null;
            da = new OleDbDataAdapter("SELECT p.PRICE_ID,t.TYPE_NAME,o.OLD_NAME,p.PRICE_12,p.PRICE_23,p.PRICE_78,p.PRICE_START,p.PRICE_END FROM TBL_PRICE p,TBL_OLD o,TBL_TYPE t WHERE p.TYPE_ID=t.TYPE_ID AND p.OLD_ID=o.OLD_ID AND p.PRICE_DELETE=false ORDER BY t.TYPE_ID ASC,o.OLD_ID DESC", cn);
            da.Fill(dt);
            return int.Parse(dt.Rows[sender][0].ToString());
        }

        private void dgv_PriceInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            //"Button"列ならば、ボタンがクリックされた
            if (dgv.Columns[e.ColumnIndex].Name == "UPDATE")
            {
                //      if (DialogResult.Yes == MessageBox.Show("商品タイプ：　" + dgv.Rows[e.RowIndex].Cells[1].Value + "　旧作/新作　" + dgv.Rows[e.RowIndex].Cells[2].Value + "　のデータを更新してよろしいですか？", "確認",
                //       MessageBoxButtons.YesNo, MessageBoxIcon.Question))

                //●こおから　Cellsは番号でなく列名にする    
                if (DialogResult.Yes == MessageBox.Show("商品タイプ：　" + dgv.Rows[e.RowIndex].Cells["TYPE_NAME"].Value + "　旧作/新作　" + dgv.Rows[e.RowIndex].Cells["OLD_NAME"].Value + "　のデータを更新してよろしいですか？", "確認",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                //●ここまで
                {
                    //  CmdFunc("UPDATE TBL_PRICE SET PRICE_12=" + dgv.Rows[e.RowIndex].Cells[3].Value + ",PRICE_23=" + dgv.Rows[e.RowIndex].Cells[4].Value + ",PRICE_78=" + dgv.Rows[e.RowIndex].Cells[5].Value +",PRICE_DELETE=true"+ "  WHERE PRICE_ID=" + ReturnPriceID(e.RowIndex));

                    //●ここから  Cellsは番号でなく列名にする 
                    CmdFunc("UPDATE TBL_PRICE SET PRICE_12=" + dgv.Rows[e.RowIndex].Cells["PRICE_12"].Value + ",PRICE_23=" + dgv.Rows[e.RowIndex].Cells["PRICE_23"].Value + ",PRICE_78=" + dgv.Rows[e.RowIndex].Cells["PRICE_78"].Value + "  WHERE PRICE_ID=" + ReturnPriceID(e.RowIndex));
                    //●ここまで

                    //CmdFunc("INSERT INTO TBL_PRICE VALUES(" + (int.Parse(SetInfo("SELECT MAX(PRICE_ID) FROM TBL_PRICE")) + 1) + "," + SerchID("TYPE", dgv.Rows[e.RowIndex].Cells[1].Value.ToString()) + "," + SerchID("TYPE", dgv.Rows[e.RowIndex].Cells[2].Value.ToString()) + ")");

                    dgv_PriceInfo.Columns.Clear();
                    dgv_PriceInfo.ClearSelection();

                    selectfunc("SELECT t.TYPE_NAME,o.OLD_NAME,p.PRICE_12,p.PRICE_23,p.PRICE_78,p.PRICE_START,p.PRICE_END FROM TBL_PRICE p,TBL_OLD o,TBL_TYPE t WHERE p.TYPE_ID=t.TYPE_ID AND p.OLD_ID=o.OLD_ID AND p.PRICE_DELETE=false ORDER BY t.TYPE_ID ASC,o.OLD_ID DESC");

                }
            }
        }
    }
}
    
