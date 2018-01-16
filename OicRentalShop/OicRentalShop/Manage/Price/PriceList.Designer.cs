namespace OicRentalShop.Manage.Price
{
    partial class PriceList
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
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_PriceInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PriceInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 65.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(666, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 87);
            this.label4.TabIndex = 220;
            this.label4.Text = "料金表";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(-2, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1660, 1);
            this.label9.TabIndex = 211;
            // 
            // dgv_PriceInfo
            // 
            this.dgv_PriceInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PriceInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PriceInfo.Location = new System.Drawing.Point(26, 164);
            this.dgv_PriceInfo.Name = "dgv_PriceInfo";
            this.dgv_PriceInfo.RowTemplate.Height = 21;
            this.dgv_PriceInfo.Size = new System.Drawing.Size(1589, 845);
            this.dgv_PriceInfo.TabIndex = 221;
            this.dgv_PriceInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PriceInfo_CellContentClick);
            // 
            // PriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_PriceInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Name = "PriceList";
            this.Size = new System.Drawing.Size(1632, 1042);
            this.Load += new System.EventHandler(this.PriceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PriceInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_PriceInfo;
    }
}
