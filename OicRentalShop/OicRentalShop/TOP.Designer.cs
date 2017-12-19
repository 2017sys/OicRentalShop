namespace OicRentalShop
{
    partial class Form1
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Manage = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Manage
            // 
            this.btn_Manage.Location = new System.Drawing.Point(155, 165);
            this.btn_Manage.Name = "btn_Manage";
            this.btn_Manage.Size = new System.Drawing.Size(300, 300);
            this.btn_Manage.TabIndex = 0;
            this.btn_Manage.Text = "店長";
            this.btn_Manage.UseVisualStyleBackColor = true;
            this.btn_Manage.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(566, 165);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(300, 300);
            this.btn_Register.TabIndex = 1;
            this.btn_Register.Text = "一般";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 592);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Manage);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Top";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Manage;
        private System.Windows.Forms.Button btn_Register;
    }
}

