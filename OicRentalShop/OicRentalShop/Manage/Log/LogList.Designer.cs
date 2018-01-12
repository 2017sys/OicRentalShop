namespace OicRentalShop.Manage.Log
{
    partial class LogList
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
            this.dgv_LogInfo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LogInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_LogInfo
            // 
            this.dgv_LogInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LogInfo.Location = new System.Drawing.Point(0, 147);
            this.dgv_LogInfo.Name = "dgv_LogInfo";
            this.dgv_LogInfo.RowTemplate.Height = 21;
            this.dgv_LogInfo.Size = new System.Drawing.Size(948, 444);
            this.dgv_LogInfo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(347, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "ログ管理";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(432, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "ログ";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(-2, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(950, 1);
            this.label9.TabIndex = 123;
            // 
            // LogList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_LogInfo);
            this.Name = "LogList";
            this.Size = new System.Drawing.Size(1632, 1042);
            this.Load += new System.EventHandler(this.LogList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LogInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LogInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
    }
}
