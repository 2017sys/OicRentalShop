namespace OicRentalShop.Manage.Profit
{
    partial class ProfitList
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
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_Voucher = new System.Windows.Forms.DataGridView();
            this.btn_Set = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_EndDay = new System.Windows.Forms.TextBox();
            this.txt_StartDay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Voucher)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(339, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 227;
            this.label7.Text = "合計";
            // 
            // txt_Total
            // 
            this.txt_Total.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.txt_Total.Location = new System.Drawing.Point(400, 217);
            this.txt_Total.Multiline = true;
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(262, 27);
            this.txt_Total.TabIndex = 226;
            this.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 12);
            this.label6.TabIndex = 225;
            this.label6.Text = "終了日:YYYY/MM/DD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 12);
            this.label5.TabIndex = 224;
            this.label5.Text = "開始日:YYYY/MM/DD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(331, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 64);
            this.label4.TabIndex = 223;
            this.label4.Text = "売上管理";
            // 
            // dgv_Voucher
            // 
            this.dgv_Voucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Voucher.Location = new System.Drawing.Point(205, 270);
            this.dgv_Voucher.Name = "dgv_Voucher";
            this.dgv_Voucher.RowTemplate.Height = 21;
            this.dgv_Voucher.Size = new System.Drawing.Size(535, 314);
            this.dgv_Voucher.TabIndex = 222;
            // 
            // btn_Set
            // 
            this.btn_Set.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Set.Location = new System.Drawing.Point(776, 95);
            this.btn_Set.Name = "btn_Set";
            this.btn_Set.Size = new System.Drawing.Size(92, 56);
            this.btn_Set.TabIndex = 221;
            this.btn_Set.Text = "決定";
            this.btn_Set.UseVisualStyleBackColor = true;
            this.btn_Set.Click += new System.EventHandler(this.btn_Set_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(680, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1, 76);
            this.label3.TabIndex = 220;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(329, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 24);
            this.label2.TabIndex = 219;
            this.label2.Text = "から";
            // 
            // txt_EndDay
            // 
            this.txt_EndDay.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_EndDay.Location = new System.Drawing.Point(395, 107);
            this.txt_EndDay.Name = "txt_EndDay";
            this.txt_EndDay.Size = new System.Drawing.Size(262, 44);
            this.txt_EndDay.TabIndex = 218;
            // 
            // txt_StartDay
            // 
            this.txt_StartDay.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_StartDay.Location = new System.Drawing.Point(34, 107);
            this.txt_StartDay.Name = "txt_StartDay";
            this.txt_StartDay.Size = new System.Drawing.Size(262, 44);
            this.txt_StartDay.TabIndex = 217;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(-1, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(950, 1);
            this.label1.TabIndex = 216;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(-1, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(950, 1);
            this.label9.TabIndex = 215;
            // 
            // ProfitList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_Voucher);
            this.Controls.Add(this.btn_Set);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_EndDay);
            this.Controls.Add(this.txt_StartDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Name = "ProfitList";
            this.Size = new System.Drawing.Size(948, 591);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Voucher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_Voucher;
        private System.Windows.Forms.Button btn_Set;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_EndDay;
        private System.Windows.Forms.TextBox txt_StartDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;

    }
}
