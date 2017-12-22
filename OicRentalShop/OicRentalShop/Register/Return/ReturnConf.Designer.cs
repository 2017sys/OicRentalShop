namespace OicRentalShop.Manage.Return
{
    partial class ReturnConf
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
            this.txt_Point = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_Redo = new System.Windows.Forms.Button();
            this.lbl_MemberID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ReturnMoney = new System.Windows.Forms.TextBox();
            this.txt_PayMoney = new System.Windows.Forms.TextBox();
            this.txt_TotalMoney = new System.Windows.Forms.TextBox();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_TopTitle = new System.Windows.Forms.Label();
            this.dgv_MemberInfo = new System.Windows.Forms.DataGridView();
            this.dgv_PayInfo = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MemberInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PayInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Point
            // 
            this.txt_Point.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Point.Location = new System.Drawing.Point(629, 314);
            this.txt_Point.Name = "txt_Point";
            this.txt_Point.Size = new System.Drawing.Size(248, 31);
            this.txt_Point.TabIndex = 162;
            this.txt_Point.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Point_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(470, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 27);
            this.label6.TabIndex = 161;
            this.label6.Text = "利用ポイント";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(463, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(493, 1);
            this.label5.TabIndex = 160;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(463, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1, 550);
            this.label16.TabIndex = 159;
            // 
            // btn_Redo
            // 
            this.btn_Redo.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_Redo.Location = new System.Drawing.Point(658, 483);
            this.btn_Redo.Name = "btn_Redo";
            this.btn_Redo.Size = new System.Drawing.Size(110, 94);
            this.btn_Redo.TabIndex = 158;
            this.btn_Redo.Text = "戻る";
            this.btn_Redo.UseVisualStyleBackColor = true;
            this.btn_Redo.Click += new System.EventHandler(this.btn_Redo_Click);
            // 
            // lbl_MemberID
            // 
            this.lbl_MemberID.AutoSize = true;
            this.lbl_MemberID.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_MemberID.Location = new System.Drawing.Point(626, 205);
            this.lbl_MemberID.Name = "lbl_MemberID";
            this.lbl_MemberID.Size = new System.Drawing.Size(0, 21);
            this.lbl_MemberID.TabIndex = 157;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(489, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 156;
            this.label4.Text = "会員番号：";
            // 
            // txt_ReturnMoney
            // 
            this.txt_ReturnMoney.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_ReturnMoney.Location = new System.Drawing.Point(630, 410);
            this.txt_ReturnMoney.Multiline = true;
            this.txt_ReturnMoney.Name = "txt_ReturnMoney";
            this.txt_ReturnMoney.ReadOnly = true;
            this.txt_ReturnMoney.Size = new System.Drawing.Size(248, 41);
            this.txt_ReturnMoney.TabIndex = 155;
            // 
            // txt_PayMoney
            // 
            this.txt_PayMoney.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_PayMoney.Location = new System.Drawing.Point(630, 367);
            this.txt_PayMoney.Name = "txt_PayMoney";
            this.txt_PayMoney.Size = new System.Drawing.Size(248, 31);
            this.txt_PayMoney.TabIndex = 154;
            this.txt_PayMoney.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PayMoney_KeyPress);
            // 
            // txt_TotalMoney
            // 
            this.txt_TotalMoney.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_TotalMoney.Location = new System.Drawing.Point(630, 246);
            this.txt_TotalMoney.Multiline = true;
            this.txt_TotalMoney.Name = "txt_TotalMoney";
            this.txt_TotalMoney.ReadOnly = true;
            this.txt_TotalMoney.Size = new System.Drawing.Size(248, 40);
            this.txt_TotalMoney.TabIndex = 153;
            // 
            // btn_Pay
            // 
            this.btn_Pay.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_Pay.Location = new System.Drawing.Point(796, 483);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(110, 94);
            this.btn_Pay.TabIndex = 152;
            this.btn_Pay.Text = "会計";
            this.btn_Pay.UseVisualStyleBackColor = true;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(-2, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1000, 1);
            this.label9.TabIndex = 151;
            // 
            // lbl_TopTitle
            // 
            this.lbl_TopTitle.AutoSize = true;
            this.lbl_TopTitle.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_TopTitle.Location = new System.Drawing.Point(395, 12);
            this.lbl_TopTitle.Name = "lbl_TopTitle";
            this.lbl_TopTitle.Size = new System.Drawing.Size(158, 64);
            this.lbl_TopTitle.TabIndex = 150;
            this.lbl_TopTitle.Text = "返却";
            // 
            // dgv_MemberInfo
            // 
            this.dgv_MemberInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_MemberInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MemberInfo.Location = new System.Drawing.Point(472, 108);
            this.dgv_MemberInfo.Name = "dgv_MemberInfo";
            this.dgv_MemberInfo.RowTemplate.Height = 21;
            this.dgv_MemberInfo.Size = new System.Drawing.Size(461, 65);
            this.dgv_MemberInfo.TabIndex = 149;
            // 
            // dgv_PayInfo
            // 
            this.dgv_PayInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PayInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_PayInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PayInfo.Location = new System.Drawing.Point(3, 108);
            this.dgv_PayInfo.Name = "dgv_PayInfo";
            this.dgv_PayInfo.RowTemplate.Height = 21;
            this.dgv_PayInfo.Size = new System.Drawing.Size(454, 469);
            this.dgv_PayInfo.TabIndex = 148;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(488, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 27);
            this.label3.TabIndex = 147;
            this.label3.Text = "おつり";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(488, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 27);
            this.label2.TabIndex = 146;
            this.label2.Text = "預り金";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(495, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 27);
            this.label1.TabIndex = 145;
            this.label1.Text = "合計";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 163;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReturnConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
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
            this.Name = "ReturnConf";
            this.Size = new System.Drawing.Size(948, 591);
            this.Load += new System.EventHandler(this.ReturnConf_Load);
            this.VisibleChanged += new System.EventHandler(this.ReturnConf_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MemberInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PayInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Point;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_Redo;
        private System.Windows.Forms.Label lbl_MemberID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ReturnMoney;
        private System.Windows.Forms.TextBox txt_PayMoney;
        private System.Windows.Forms.TextBox txt_TotalMoney;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_TopTitle;
        private System.Windows.Forms.DataGridView dgv_MemberInfo;
        private System.Windows.Forms.DataGridView dgv_PayInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
