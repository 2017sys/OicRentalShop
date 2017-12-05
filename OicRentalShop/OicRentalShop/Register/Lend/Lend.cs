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
        DataTable dtp = new DataTable();
        DataTable dt = new DataTable();

        public Lend()
        {
            InitializeComponent();
        }

        private int SetCount(string cmdstr)
        {
            dt.Clear();
            dt = new DataTable();
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dt);
            string cnt =dt.Rows[0][0].ToString();
            int count = int.Parse(cnt);
            return count;
        }

        private string SetInfo(string cmdstr)
        {
            dtp.Clear();
            dtp = new DataTable();
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dtp);
            return dtp.Rows[0][0].ToString();
         }

        private void UpdateOldDate() //旧作の日時を現在の日付より1か月前に変更する
        {
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = cn;
            cn.Open();
            DateTime Today = DateTime.Today;    //今日の日付の取得
            DateTime upday = Today.AddMonths(-1);   //今日の日付に-1か月足す
            Cmd.CommandText = "UPDATE TBL_OLD SET OLD_DATE=#" + upday.ToString() + "# WHERE OLD_ID=2";
            Cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void UpdateOldID() //TBL_TITLEのリリース日時がが旧作の指定日時より古い物のOLD_ID（新旧分別用）を旧作用に変更する
        {
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = cn;
            cn.Open();
            Cmd.CommandText = "UPDATE TBL_TITLE SET OLD_ID=2 WHERE TITLE_RELEASE <= ANY(SELECT OLD_DATE FROM TBL_OLD WHERE OLD_ID=2)";
            Cmd.ExecuteNonQuery();
            cn.Close();
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

        private void selectfunc(string cmdstr)//DataGridViewにレジを通した商品の情報を登録
        {
            dtp.Clear();
            dtp = new DataTable();
            dgv_info.DataSource = null;
            da = new OleDbDataAdapter(cmdstr, cn);
            da.Fill(dtp);
            dgv_info.DataSource = dtp;
            dgv_info.AutoResizeColumns();
        }

        private void deletefunc(string cmdstr)
        {
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = cn;
            cn.Open();
            Cmd.CommandText = cmdstr;
            Cmd.ExecuteNonQuery();
            cn.Close();
            
        }

        private void clearfunc()
        {
            txt_MemberID.Clear();
            txt_MemberPoint.Clear();
            txt_MemberName.Clear();
            txt_MemberID.ReadOnly = false;
            txt_ProductID.Clear();
            txt_money.Clear();
            dtp.Clear();
            deletefunc("DELETE FROM TBL_LINESLIP WHERE SLIP_ID=" + slipID);
            deletefunc("DELETE FROM TBL_SLIP WHERE SLIP_ID=" + slipID);
            SlipFlag = 0;
        }


        private void InsertLineSlip()   //レジを通した商品の情報を伝票表に登録
        {
            int lineslipID = SetCount("SELECT COUNT(*) FROM TBL_LINESLIP");
            lineslipID++;
            dtp.Clear();
            dtp = new DataTable();
            da = new OleDbDataAdapter("SELECT t.TYPE_ID FROM TBL_TITLE t,TBL_ITEM i WHERE t.TITLE_ID=i.TITLE_ID AND i.ITEM_ID=" + txt_InProductID.Text, cn);
            da.Fill(dtp);
            string typeid = dtp.Rows[0][0].ToString();

            dtp.Clear();
            dtp = new DataTable();
            da = new OleDbDataAdapter("SELECT p.PRICE_12 FROM TBL_PRICE p,TBL_TITLE t,TBL_ITEM i WHERE i.TITLE_ID=t.TITLE_ID AND t.OLD_ID=p.OLD_ID AND t.TYPE_ID=p.TYPE_ID AND i.ITEM_ID=" + txt_InProductID.Text, cn);
            da.Fill(dtp);
            string Price = dtp.Rows[0][0].ToString();

            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = cn;
            cn.Open();
            Cmd.CommandText = "INSERT INTO TBL_LINESLIP VALUES(" + lineslipID + "," + slipID + "," + int.Parse(txt_InProductID.Text) + ",1," + int.Parse(typeid) + "," + int.Parse(Price)+ ")";
            Cmd.ExecuteNonQuery();
            cn.Close();
        }

        int slipID;

        private void SetSlip()
        {
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = cn;
            cn.Open();
            DateTime Today = DateTime.Today;    //今日の日付の取得
            Cmd.CommandText = "INSERT INTO TBL_SLIP VALUES(" + slipID + "," + int.Parse(txt_MemberID.Text) + ",false,#" + Today.ToString() + "#,0,1)";  //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!スタッフIDを後で変更する!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            Cmd.ExecuteNonQuery();
            cn.Close();
            txt_MemberID.ReadOnly = true;
        }

        private void updateSlipPrice() //TBL_SLIPのSLIP_PRICEを更新
        {
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = cn;
            cn.Open();
            Cmd.CommandText = "UPDATE TBL_SLIP SET SLIP_PRICE="+slipprice+" WHERE SLIP_ID="+slipID;
            Cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void updatefunc(string cmdstr)
        {
            OleDbCommand Cmd = new OleDbCommand();
            Cmd.Connection = cn;
            cn.Open();
            Cmd.CommandText = cmdstr;
            Cmd.ExecuteNonQuery();
            cn.Close();
        }



        private void Lend_Load(object sender, EventArgs e)
        {
            UpdateOldDate();
            UpdateOldID();
            slipID = SetCount("SELECT COUNT(*) FROM TBL_SLIP");
            slipID++;
            LblSlipID.Text = slipID.ToString();
            selectedlsID = SetCount("SELECT COUNT(*) FROM TBL_LINESLIP");
            lsIDpoint = 0;
        }

        private void txt_MemberID_TextChanged(object sender, EventArgs e)
        {
                if (txt_MemberID.Text.Length == 1)
                {
                    if (dtCheck("SELECT * FROM TBL_MEMBER WHERE MEMBER_ID=" + txt_MemberID.Text) == 1)
                    {
                        txt_MemberPoint.Text = SetInfo("SELECT MEMBER_POINT FROM TBL_MEMBER WHERE MEMBER_ID=" + txt_MemberID.Text);
                        txt_MemberName.Text = SetInfo("SELECT MEMBER_NAME FROM TBL_MEMBER WHERE MEMBER_ID=" + txt_MemberID.Text);
                        txt_InProductID.Focus();
                        selectfunc("SELECT t.TITLE_NAME,ty.TYPE_NAME,l.LEND_PRERIOD,ls.LS_Price FROM TBL_TITLE t,TBL_TYPE ty,TBL_LEND l,TBL_LINESLIP ls,TBL_ITEM i WHERE ls.LEND_ID=l.LEND_ID AND ls.ITEM_ID=i.ITEM_ID AND i.TITLE_ID =t.TITLE_ID  AND t.TYPE_ID=ty.TYPE_ID AND ls.SLIP_ID=" + slipID);
                    }
                    else
                    {
                        MessageBox.Show("メンバーID:" + txt_MemberID.Text + "は存在しません");
                        txt_MemberID.Clear();
                    }
                }
                else if (txt_MemberID.Text.Length >= 2)
                {
                    MessageBox.Show("メンバーIDはN文字です");
                    txt_MemberID.Clear();
                }
                if (txt_MemberID.Text.Length == 0)
                {
                    clearfunc();
                }
        }


        int SlipFlag = 0;
        int slipprice = 0;
        int selectedlsID;
        int lsIDpoint;
        private void txt_ProductID_TextChanged(object sender, EventArgs e)
        {
            if (txt_MemberID.Text!="")
            {
                if (txt_InProductID.Text.Length == 1)
                {
                    if (dtCheck("SELECT * FROM TBL_ITEM WHERE ITEM_ID=" + txt_InProductID.Text) == 1)
                    {
                        if (SlipFlag == 0)
                        {
                            SetSlip();
                            SlipFlag = 1;
                        }
                        txt_title.Text = SetInfo("SELECT t.TITLE_NAME FROM TBL_TITLE t,TBL_ITEM i WHERE t.TITLE_ID=i.TITLE_ID AND i.ITEM_ID = " + txt_InProductID.Text);
                        InsertLineSlip();
                        slipprice = int.Parse(SetInfo("SELECT SUM(LS_PRICE) FROM TBL_LINESLIP GROUP BY SLIP_ID HAVING SLIP_ID=" + slipID));
                        txt_money.Text = slipprice.ToString();
                        txt_ProductID.Text = txt_InProductID.Text;
                        updateSlipPrice();
                        txt_InProductID.Clear();
                        selectedlsID++;
                        lsIDpoint++;
                    }
                    else
                    {
                        MessageBox.Show("商品ID:" + txt_InProductID.Text + "は存在しません");
                        txt_InProductID.Clear();
                    }
                }
                else if (txt_InProductID.Text.Length >= 2)
                {
                    MessageBox.Show("商品IDはN文字です");
                    txt_InProductID.Clear();
                }
            }
            else if (txt_InProductID.Text == "")
            {
                MessageBox.Show("会員IDを入力してください");
                txt_MemberID.Focus();
            }else
            {
                txt_InProductID.Clear();
            }
            selectfunc("SELECT t.TITLE_NAME,ty.TYPE_NAME,l.LEND_PRERIOD,ls.LS_Price FROM TBL_TITLE t,TBL_TYPE ty,TBL_LEND l,TBL_LINESLIP ls,TBL_ITEM i WHERE ls.LEND_ID=l.LEND_ID AND ls.ITEM_ID=i.ITEM_ID AND i.TITLE_ID =t.TITLE_ID  AND t.TYPE_ID=ty.TYPE_ID AND ls.SLIP_ID="+slipID);
        }

        private void Btn_ClearPID_Click(object sender, EventArgs e)
        {
            if (lsIDpoint > 0)
            {
            txt_ProductID.Clear();
            slipprice -= int.Parse(SetInfo("SELECT LS_PRICE FROM TBL_LINESLIP WHERE LINESLIP_ID=" + selectedlsID));
            updateSlipPrice();
            deletefunc("DELETE FROM TBL_LINESLIP WHERE LINESLIP_ID = " + selectedlsID.ToString());
            selectedlsID--;
            lsIDpoint--;
                if(lsIDpoint==0)
                {
                    txt_money.Clear();
                    deletefunc("DELETE FROM TBL_SLIP WHERE SLIP_ID= " + slipID);
                    SlipFlag = 0;
                }
                else
                {
                    txt_money.Text = SetInfo("SELECT SUM(LS_PRICE) FROM TBL_LINESLIP GROUP BY SLIP_ID HAVING SLIP_ID=" + slipID);

                    txt_ProductID.Text = SetInfo("SELECT ITEM_ID FROM TBL_LINESLIP WHERE LINESLIP_ID=" + selectedlsID);

                 
                }
                selectfunc("SELECT t.TITLE_NAME,ty.TYPE_NAME,l.LEND_PRERIOD,ls.LS_Price FROM TBL_TITLE t,TBL_TYPE ty,TBL_LEND l,TBL_LINESLIP ls,TBL_ITEM i WHERE ls.LEND_ID=l.LEND_ID AND ls.ITEM_ID=i.ITEM_ID AND i.TITLE_ID =t.TITLE_ID  AND t.TYPE_ID=ty.TYPE_ID AND ls.SLIP_ID=" + slipID);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearfunc();
        }

        private void txt_MemberID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txt_ProductID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            SlipFlag = 0;
        }

        private void Lend_VisibleChanged(object sender, EventArgs e)
        {
            clearfunc();
        }

        private void Btn_ClearMID_Click(object sender, EventArgs e)
        {
            txt_MemberID.Clear();
        }

        private void txt_ProductID_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_ProductID.Text != "")
            {
                txt_title.Text = SetInfo("SELECT t.TITLE_NAME FROM TBL_TITLE t,TBL_ITEM i WHERE t.TITLE_ID=i.TITLE_ID AND i.ITEM_ID = " + txt_ProductID.Text);
                txt_type.Text = SetInfo("SELECT y.TYPE_NAME FROM TBL_TITLE t,TBL_ITEM i,TBL_TYPE y WHERE t.TITLE_ID=i.TITLE_ID AND y.TYPE_ID=t.TYPE_ID AND i.ITEM_ID = " + txt_ProductID.Text);
                txt_OLDNEW.Text = SetInfo("SELECT o.OLD_NAME FROM TBL_OLD o,TBL_TITLE t,TBL_ITEM i WHERE o.OLD_ID=t.OLD_ID AND i.TITLE_ID = t.TITLE_ID AND i.ITEM_ID= " + txt_ProductID.Text);
                txt_1d2n.Text = SetInfo("SELECT p.PRICE_12 FROM TBL_PRICE p,TBL_TITLE t,TBL_ITEM i WHERE t.TYPE_ID=p.TYPE_ID AND t.OLD_ID=p.OLD_ID AND i.TITLE_ID = t.TITLE_ID AND i.ITEM_ID=" + txt_ProductID.Text);
                txt_2d3n.Text = SetInfo("SELECT p.PRICE_23 FROM TBL_PRICE p,TBL_TITLE t,TBL_ITEM i WHERE t.TYPE_ID=p.TYPE_ID AND t.OLD_ID=p.OLD_ID AND i.TITLE_ID = t.TITLE_ID AND i.ITEM_ID=" + txt_ProductID.Text);
                txt_7d8n.Text = SetInfo("SELECT p.PRICE_78 FROM TBL_PRICE p,TBL_TITLE t,TBL_ITEM i WHERE t.TYPE_ID=p.TYPE_ID AND t.OLD_ID=p.OLD_ID AND i.TITLE_ID = t.TITLE_ID AND i.ITEM_ID=" + txt_ProductID.Text);
            }else
            {
                txt_title.Clear();
                txt_type.Clear();
                txt_InProductID.Clear();
                txt_OLDNEW.Clear();
                txt_ProductID.Clear();
                txt_1d2n.Clear();
                txt_2d3n.Clear();
                txt_7d8n.Clear();
            }
        }
        int uprice;
        private void btn_1d2n_Click(object sender, EventArgs e)
        {
            if (txt_ProductID.Text != "")
            {
                uprice = int.Parse(txt_1d2n.Text);
                updatefunc("UPDATE TBL_LINESLIP SET LS_PRICE =" + uprice + "  WHERE LINESLIP_ID=" + selectedlsID);

                slipprice = int.Parse(SetInfo("SELECT SUM(LS_PRICE) FROM TBL_LINESLIP GROUP BY SliP_ID HAVING SLIP_ID=" + slipID));
                updatefunc("UPDATE TBL_SLIP SET SLIP_PRICE=" + slipprice + " WHERE SLIP_ID=" + slipID);
                txt_money.Text = SetInfo("SELECT SUM(LS_PRICE) FROM TBL_LINESLIP GROUP BY SLIP_ID HAVING SLIP_ID=" + slipID);

                selectfunc("SELECT t.TITLE_NAME,ty.TYPE_NAME,l.LEND_PRERIOD,ls.LS_Price FROM TBL_TITLE t,TBL_TYPE ty,TBL_LEND l,TBL_LINESLIP ls,TBL_ITEM i WHERE ls.LEND_ID=l.LEND_ID AND ls.ITEM_ID=i.ITEM_ID AND i.TITLE_ID =t.TITLE_ID  AND t.TYPE_ID=ty.TYPE_ID AND ls.SLIP_ID=" + slipID);
            }
            else
            {
                MessageBox.Show("更新可能な商品が存在しません");
            }
        }

        private void btn_2d3n_Click(object sender, EventArgs e)
        {
            if (txt_ProductID.Text != "")
            {
                uprice = int.Parse(txt_2d3n.Text);
                updatefunc("UPDATE TBL_LINESLIP SET LS_PRICE =" + uprice + "  WHERE LINESLIP_ID=" + selectedlsID);
                
                slipprice = int.Parse(SetInfo("SELECT SUM(LS_PRICE) FROM TBL_LINESLIP GROUP BY SliP_ID HAVING SLIP_ID="+slipID));
                updatefunc("UPDATE TBL_SLIP SET SLIP_PRICE=" + slipprice + " WHERE SLIP_ID=" + slipID);
                txt_money.Text = SetInfo("SELECT SUM(LS_PRICE) FROM TBL_LINESLIP GROUP BY SLIP_ID HAVING SLIP_ID=" + slipID);

                selectfunc("SELECT t.TITLE_NAME,ty.TYPE_NAME,l.LEND_PRERIOD,ls.LS_Price FROM TBL_TITLE t,TBL_TYPE ty,TBL_LEND l,TBL_LINESLIP ls,TBL_ITEM i WHERE ls.LEND_ID=l.LEND_ID AND ls.ITEM_ID=i.ITEM_ID AND i.TITLE_ID =t.TITLE_ID  AND t.TYPE_ID=ty.TYPE_ID AND ls.SLIP_ID=" + slipID);
            }
            else
            {
                MessageBox.Show("更新可能な商品が存在しません");
            }
        }

        private void btn_7d8n_Click(object sender, EventArgs e)
        {
            if (txt_ProductID.Text != "")
            {
                uprice = int.Parse(txt_7d8n.Text);
                updatefunc("UPDATE TBL_LINESLIP SET LS_PRICE =" + uprice + "  WHERE LINESLIP_ID=" + selectedlsID);

                slipprice = int.Parse(SetInfo("SELECT SUM(LS_PRICE) FROM TBL_LINESLIP GROUP BY SliP_ID HAVING SLIP_ID=" + slipID));
                updatefunc("UPDATE TBL_SLIP SET SLIP_PRICE=" + slipprice + " WHERE SLIP_ID=" + slipID);
                txt_money.Text = SetInfo("SELECT SUM(LS_PRICE) FROM TBL_LINESLIP GROUP BY SLIP_ID HAVING SLIP_ID=" + slipID);

                selectfunc("SELECT t.TITLE_NAME,ty.TYPE_NAME,l.LEND_PRERIOD,ls.LS_Price FROM TBL_TITLE t,TBL_TYPE ty,TBL_LEND l,TBL_LINESLIP ls,TBL_ITEM i WHERE ls.LEND_ID=l.LEND_ID AND ls.ITEM_ID=i.ITEM_ID AND i.TITLE_ID =t.TITLE_ID  AND t.TYPE_ID=ty.TYPE_ID AND ls.SLIP_ID=" + slipID);
            }
            else
            {
                MessageBox.Show("更新可能な商品が存在しません");
            }
        }


    }
}

/*
 * DBへの追加反映まで終わった
 * 決定ボタンを押したときにSLIPの合計金額を更新
 * 決定ボタンを押したときにSlipFlagを0に戻す
 * 読み込んだ（LINESLIPに登録した)物をDELETE文で取り消せる機能をつける
 * バーコードで随時読み込むことを考慮して現txt_ProductIDを隔離　商品IDを表示する別の項目を作り　読み込むごとにクリアしてスムーズに登録できるようにする
 * n泊n日のボタンを押すことで　最後に読み込んだ商品のの貸出日程・金額などを更新する機能を付与
 * 右上の金額の機能（合計金額の標示　ポイント利用の際の差など）
 * その他誤操作などで起こりうるバグに対する制御の追加
 * 後々従業員の判別ができるようになった際にSLIP表に登録する従業員の番号の制御変更
 * 
*/