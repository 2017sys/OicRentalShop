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
            this.txt_TotalM = new System.Windows.Forms.TextBox();
            this.txt_KeepM = new System.Windows.Forms.TextBox();
            this.txt_ChangeM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_MemberID = new System.Windows.Forms.Label();
            this.btn_Redo = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PayInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MemberInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(416, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "合計";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(416, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "預り金";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(416, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "おつり";
            // 
            // dgv_PayInfo
            // 
            this.dgv_PayInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PayInfo.Location = new System.Drawing.Point(20, 105);
            this.dgv_PayInfo.Name = "dgv_PayInfo";
            this.dgv_PayInfo.RowTemplate.Height = 21;
            this.dgv_PayInfo.Size = new System.Drawing.Size(291, 469);
            this.dgv_PayInfo.TabIndex = 5;
            // 
            // dgv_MemberInfo
            // 
            this.dgv_MemberInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MemberInfo.Location = new System.Drawing.Point(346, 105);
            this.dgv_MemberInfo.Name = "dgv_MemberInfo";
            this.dgv_MemberInfo.RowTemplate.Height = 21;
            this.dgv_MemberInfo.Size = new System.Drawing.Size(587, 65);
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
            this.btn_Pay.Location = new System.Drawing.Point(696, 480);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(110, 94);
            this.btn_Pay.TabIndex = 133;
            this.btn_Pay.Text = "会計";
            this.btn_Pay.UseVisualStyleBackColor = true;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // txt_TotalM
            // 
            this.txt_TotalM.Location = new System.Drawing.Point(558, 271);
            this.txt_TotalM.Multiline = true;
            this.txt_TotalM.Name = "txt_TotalM";
            this.txt_TotalM.Size = new System.Drawing.Size(248, 40);
            this.txt_TotalM.TabIndex = 135;
            // 
            // txt_KeepM
            // 
            this.txt_KeepM.Location = new System.Drawing.Point(558, 334);
            this.txt_KeepM.Multiline = true;
            this.txt_KeepM.Name = "txt_KeepM";
            this.txt_KeepM.Size = new System.Drawing.Size(248, 41);
            this.txt_KeepM.TabIndex = 136;
            // 
            // txt_ChangeM
            // 
            this.txt_ChangeM.Location = new System.Drawing.Point(558, 400);
            this.txt_ChangeM.Multiline = true;
            this.txt_ChangeM.Name = "txt_ChangeM";
            this.txt_ChangeM.Size = new System.Drawing.Size(248, 41);
            this.txt_ChangeM.TabIndex = 137;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(417, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 138;
            this.label4.Text = "会員番号：";
            // 
            // lbl_MemberID
            // 
            this.lbl_MemberID.AutoSize = true;
            this.lbl_MemberID.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_MemberID.Location = new System.Drawing.Point(554, 218);
            this.lbl_MemberID.Name = "lbl_MemberID";
            this.lbl_MemberID.Size = new System.Drawing.Size(142, 21);
            this.lbl_MemberID.TabIndex = 139;
            this.lbl_MemberID.Text = "1１１１１１１１１";
            this.lbl_MemberID.Visible = false;
            // 
            // btn_Redo
            // 
            this.btn_Redo.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_Redo.Location = new System.Drawing.Point(558, 480);
            this.btn_Redo.Name = "btn_Redo";
            this.btn_Redo.Size = new System.Drawing.Size(110, 94);
            this.btn_Redo.TabIndex = 140;
            this.btn_Redo.Text = "戻る";
            this.btn_Redo.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(326, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1, 550);
            this.label16.TabIndex = 141;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(326, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(630, 1);
            this.label5.TabIndex = 142;
            // 
            // LendConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btn_Redo);
            this.Controls.Add(this.lbl_MemberID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ChangeM);
            this.Controls.Add(this.txt_KeepM);
            this.Controls.Add(this.txt_TotalM);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PayInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MemberInfo)).EndInit();
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
        private System.Windows.Forms.TextBox txt_TotalM;
        private System.Windows.Forms.TextBox txt_KeepM;
        private System.Windows.Forms.TextBox txt_ChangeM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_MemberID;
        private System.Windows.Forms.Button btn_Redo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
    }
}
