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
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(211, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(353, 64);
            this.label11.TabIndex = 58;
            this.label11.Text = "従業員管理";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(311, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 27);
            this.label10.TabIndex = 59;
            this.label10.Text = "従業員情報";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(-2, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(813, 1);
            this.label9.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(811, -17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1, 617);
            this.label8.TabIndex = 61;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(-2, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(813, 1);
            this.label7.TabIndex = 60;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(800, 424);
            this.dataGridView1.TabIndex = 63;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Add.Location = new System.Drawing.Point(818, 419);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(120, 50);
            this.btn_Add.TabIndex = 65;
            this.btn_Add.Text = "追加";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.button12_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.Location = new System.Drawing.Point(819, 499);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(120, 50);
            this.btn_Delete.TabIndex = 64;
            this.btn_Delete.Text = "削除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.button11_Click);
            // 
            // StaffList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Name = "StaffList";
            this.Size = new System.Drawing.Size(948, 591);
            this.Load += new System.EventHandler(this.StaffList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
    }
}
