namespace OicRentalShop.Manage.Event
{
    partial class EventList
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
            this.lbl_TopTitle = new System.Windows.Forms.Label();
            this.lbl_SecTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dgv_EventInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EventInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TopTitle
            // 
            this.lbl_TopTitle.AutoSize = true;
            this.lbl_TopTitle.Font = new System.Drawing.Font("MS UI Gothic", 48F);
            this.lbl_TopTitle.Location = new System.Drawing.Point(262, 11);
            this.lbl_TopTitle.Name = "lbl_TopTitle";
            this.lbl_TopTitle.Size = new System.Drawing.Size(347, 64);
            this.lbl_TopTitle.TabIndex = 0;
            this.lbl_TopTitle.Text = "イベント管理";
            // 
            // lbl_SecTitle
            // 
            this.lbl_SecTitle.AutoSize = true;
            this.lbl_SecTitle.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_SecTitle.Location = new System.Drawing.Point(247, 98);
            this.lbl_SecTitle.Name = "lbl_SecTitle";
            this.lbl_SecTitle.Size = new System.Drawing.Size(82, 24);
            this.lbl_SecTitle.TabIndex = 1;
            this.lbl_SecTitle.Text = "イベント";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(945, 1);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(-2, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(950, 1);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(798, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1, 505);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Add.Location = new System.Drawing.Point(805, 510);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(140, 60);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "追加";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dgv_EventInfo
            // 
            this.dgv_EventInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_EventInfo.Location = new System.Drawing.Point(15, 147);
            this.dgv_EventInfo.Name = "dgv_EventInfo";
            this.dgv_EventInfo.RowTemplate.Height = 21;
            this.dgv_EventInfo.Size = new System.Drawing.Size(777, 430);
            this.dgv_EventInfo.TabIndex = 14;
            this.dgv_EventInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_EventInfo_CellContentClick);
            // 
            // EventList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_EventInfo);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_SecTitle);
            this.Controls.Add(this.lbl_TopTitle);
            this.Name = "EventList";
            this.Size = new System.Drawing.Size(948, 591);
            this.Load += new System.EventHandler(this.EventList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EventInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TopTitle;
        private System.Windows.Forms.Label lbl_SecTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dgv_EventInfo;
    }
}
