namespace OicRentalShop.Manage.Lend
{
    partial class LendConf
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_PayInfo = new System.Windows.Forms.DataGridView();
            this.dgv_MemberInfo = new System.Windows.Forms.DataGridView();
            this.lbl_TopTitle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.txt_TotalMoney = new System.Windows.Forms.TextBox();
            this.txt_PayMoney = new System.Windows.Forms.TextBox();
            this.txt_ReturnMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_MemberID = new System.Windows.Forms.Label();
            this.btn_Redo = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Point = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_EventDiscount = new System.Windows.Forms.DataGridView();
            this.イベント名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品タイプ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.新作旧作 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.割引額 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_EventDiscount = new System.Windows.Forms.TextBox();
            this.lbl_EventDicount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PayInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MemberInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EventDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(495, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "合計";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(488, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "預り金";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(488, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "おつり";
            // 
            // dgv_PayInfo
            // 
            this.dgv_PayInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PayInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_PayInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PayInfo.Location = new System.Drawing.Point(3, 105);
            this.dgv_PayInfo.Name = "dgv_PayInfo";
            this.dgv_PayInfo.RowTemplate.Height = 21;
            this.dgv_PayInfo.Size = new System.Drawing.Size(454, 352);
            this.dgv_PayInfo.TabIndex = 5;
            // 
            // dgv_MemberInfo
            // 
            this.dgv_MemberInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_MemberInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MemberInfo.Location = new System.Drawing.Point(472, 105);
            this.dgv_MemberInfo.Name = "dgv_MemberInfo";
            this.dgv_MemberInfo.RowTemplate.Height = 21;
            this.dgv_MemberInfo.Size = new System.Drawing.Size(461, 65);
            this.dgv_MemberInfo.TabIndex = 6;
            // 
            // lbl_TopTitle
            // 
            this.lbl_TopTitle.AutoSize = true;
            this.lbl_TopTitle.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_TopTitle.Location = new System.Drawing.Point(395, 9);
            this.lbl_TopTitle.Name = "lbl_TopTitle";
            this.lbl_TopTitle.Size = new System.Drawing.Size(158, 64);
            this.lbl_TopTitle.TabIndex = 131;
            this.lbl_TopTitle.Text = "貸出";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(-2, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1000, 1);
            this.label9.TabIndex = 132;
            // 
            // btn_Pay
            // 
            this.btn_Pay.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_Pay.Location = new System.Drawing.Point(796, 480);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(110, 94);
            this.btn_Pay.TabIndex = 133;
            this.btn_Pay.Text = "会計";
            this.btn_Pay.UseVisualStyleBackColor = true;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // txt_TotalMoney
            // 
            this.txt_TotalMoney.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_TotalMoney.Location = new System.Drawing.Point(630, 230);
            this.txt_TotalMoney.Multiline = true;
            this.txt_TotalMoney.Name = "txt_TotalMoney";
            this.txt_TotalMoney.ReadOnly = true;
            this.txt_TotalMoney.Size = new System.Drawing.Size(248, 40);
            this.txt_TotalMoney.TabIndex = 135;
            // 
            // txt_PayMoney
            // 
            this.txt_PayMoney.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_PayMoney.Location = new System.Drawing.Point(629, 364);
            this.txt_PayMoney.Name = "txt_PayMoney";
            this.txt_PayMoney.Size = new System.Drawing.Size(248, 31);
            this.txt_PayMoney.TabIndex = 136;
            this.txt_PayMoney.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_KeepM_KeyUp);
            // 
            // txt_ReturnMoney
            // 
            this.txt_ReturnMoney.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_ReturnMoney.Location = new System.Drawing.Point(630, 407);
            this.txt_ReturnMoney.Multiline = true;
            this.txt_ReturnMoney.Name = "txt_ReturnMoney";
            this.txt_ReturnMoney.ReadOnly = true;
            this.txt_ReturnMoney.Size = new System.Drawing.Size(248, 41);
            this.txt_ReturnMoney.TabIndex = 137;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(489, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 138;
            this.label4.Text = "会員番号：";
            // 
            // lbl_MemberID
            // 
            this.lbl_MemberID.AutoSize = true;
            this.lbl_MemberID.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_MemberID.Location = new System.Drawing.Point(626, 202);
            this.lbl_MemberID.Name = "lbl_MemberID";
            this.lbl_MemberID.Size = new System.Drawing.Size(0, 21);
            this.lbl_MemberID.TabIndex = 139;
            // 
            // btn_Redo
            // 
            this.btn_Redo.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_Redo.Location = new System.Drawing.Point(661, 480);
            this.btn_Redo.Name = "btn_Redo";
            this.btn_Redo.Size = new System.Drawing.Size(110, 94);
            this.btn_Redo.TabIndex = 140;
            this.btn_Redo.Text = "戻る";
            this.btn_Redo.UseVisualStyleBackColor = true;
            this.btn_Redo.Click += new System.EventHandler(this.btn_Redo_Click);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(463, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1, 550);
            this.label16.TabIndex = 141;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(463, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(493, 1);
            this.label5.TabIndex = 142;
            // 
            // txt_Point
            // 
            this.txt_Point.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Point.Location = new System.Drawing.Point(630, 285);
            this.txt_Point.Name = "txt_Point";
            this.txt_Point.Size = new System.Drawing.Size(248, 31);
            this.txt_Point.TabIndex = 144;
            this.txt_Point.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Point_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(470, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 27);
            this.label6.TabIndex = 143;
            this.label6.Text = "利用ポイント";
            // 
            // dgv_EventDiscount
            // 
            this.dgv_EventDiscount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_EventDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_EventDiscount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.イベント名,
            this.商品タイプ,
            this.新作旧作,
            this.割引額});
            this.dgv_EventDiscount.Location = new System.Drawing.Point(3, 464);
            this.dgv_EventDiscount.Name = "dgv_EventDiscount";
            this.dgv_EventDiscount.RowTemplate.Height = 21;
            this.dgv_EventDiscount.Size = new System.Drawing.Size(454, 110);
            this.dgv_EventDiscount.TabIndex = 145;
            // 
            // イベント名
            // 
            this.イベント名.HeaderText = "イベント名";
            this.イベント名.Name = "イベント名";
            // 
            // 商品タイプ
            // 
            this.商品タイプ.HeaderText = "商品タイプ";
            this.商品タイプ.Name = "商品タイプ";
            // 
            // 新作旧作
            // 
            this.新作旧作.HeaderText = "新作旧作";
            this.新作旧作.Name = "新作旧作";
            // 
            // 割引額
            // 
            this.割引額.HeaderText = "割引額";
            this.割引額.Name = "割引額";
            // 
            // txt_EventDiscount
            // 
            this.txt_EventDiscount.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_EventDiscount.Location = new System.Drawing.Point(661, 326);
            this.txt_EventDiscount.Name = "txt_EventDiscount";
            this.txt_EventDiscount.Size = new System.Drawing.Size(217, 31);
            this.txt_EventDiscount.TabIndex = 147;
            this.txt_EventDiscount.Text = "0";
            // 
            // lbl_EventDicount
            // 
            this.lbl_EventDicount.AutoSize = true;
            this.lbl_EventDicount.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_EventDicount.Location = new System.Drawing.Point(467, 326);
            this.lbl_EventDicount.Name = "lbl_EventDicount";
            this.lbl_EventDicount.Size = new System.Drawing.Size(181, 27);
            this.lbl_EventDicount.TabIndex = 146;
            this.lbl_EventDicount.Text = "イベント割引額";
            // 
            // LendConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_EventDiscount);
            this.Controls.Add(this.lbl_EventDicount);
            this.Controls.Add(this.dgv_EventDiscount);
            this.Controls.Add(this.txt_Point);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btn_Redo);
            this.Controls.Add(this.lbl_MemberID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ReturnMoney);
            this.Controls.Add(this.txt_PayMoney);
            this.Controls.Add(this.txt_TotalMoney);
            this.Controls.Add(this.btn_Pay);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_TopTitle);
            this.Controls.Add(this.dgv_MemberInfo);
            this.Controls.Add(this.dgv_PayInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LendConf";
            this.Size = new System.Drawing.Size(948, 591);
            this.Load += new System.EventHandler(this.LendConf_Load);
            this.VisibleChanged += new System.EventHandler(this.LendConf_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PayInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MemberInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EventDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_PayInfo;
        private System.Windows.Forms.DataGridView dgv_MemberInfo;
        private System.Windows.Forms.Label lbl_TopTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.TextBox txt_TotalMoney;
        private System.Windows.Forms.TextBox txt_PayMoney;
        private System.Windows.Forms.TextBox txt_ReturnMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_MemberID;
        private System.Windows.Forms.Button btn_Redo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Point;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_EventDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn イベント名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品タイプ;
        private System.Windows.Forms.DataGridViewTextBoxColumn 新作旧作;
        private System.Windows.Forms.DataGridViewTextBoxColumn 割引額;
        private System.Windows.Forms.TextBox txt_EventDiscount;
        private System.Windows.Forms.Label lbl_EventDicount;
    }
}
