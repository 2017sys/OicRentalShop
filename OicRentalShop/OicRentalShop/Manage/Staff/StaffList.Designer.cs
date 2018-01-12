namespace OicRentalShop.Manage.Staff
{
    partial class StaffList
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
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_StaffInfo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_StaffList = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StaffList)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 65.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(592, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(477, 87);
            this.label11.TabIndex = 58;
            this.label11.Text = "従業員管理";
            // 
            // lbl_StaffInfo
            // 
            this.lbl_StaffInfo.AutoSize = true;
            this.lbl_StaffInfo.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbl_StaffInfo.Location = new System.Drawing.Point(571, 151);
            this.lbl_StaffInfo.Name = "lbl_StaffInfo";
            this.lbl_StaffInfo.Size = new System.Drawing.Size(195, 35);
            this.lbl_StaffInfo.TabIndex = 59;
            this.lbl_StaffInfo.Text = "従業員情報";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(-2, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1660, 1);
            this.label9.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(1353, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1, 1000);
            this.label8.TabIndex = 61;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(-278, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1632, 1);
            this.label7.TabIndex = 60;
            // 
            // dgv_StaffList
            // 
            this.dgv_StaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_StaffList.Location = new System.Drawing.Point(15, 224);
            this.dgv_StaffList.Name = "dgv_StaffList";
            this.dgv_StaffList.RowTemplate.Height = 21;
            this.dgv_StaffList.Size = new System.Drawing.Size(1319, 787);
            this.dgv_StaffList.TabIndex = 63;
            this.dgv_StaffList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_StaffList_CellContentClick);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Add.Font = new System.Drawing.Font("Meiryo UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_Add.Location = new System.Drawing.Point(1418, 926);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(174, 85);
            this.btn_Add.TabIndex = 65;
            this.btn_Add.Text = "追加";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // StaffList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_StaffList);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_StaffInfo);
            this.Controls.Add(this.label11);
            this.Name = "StaffList";
            this.Size = new System.Drawing.Size(1661, 1042);
            this.Load += new System.EventHandler(this.StaffList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_StaffList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_StaffInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_StaffList;
        private System.Windows.Forms.Button btn_Add;
    }
}
