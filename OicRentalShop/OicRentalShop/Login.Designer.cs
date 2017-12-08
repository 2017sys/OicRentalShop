namespace OicRentalShop
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MgrID = new System.Windows.Forms.TextBox();
            this.txt_PassWord = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Redo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.label1.Location = new System.Drawing.Point(282, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "店長ID：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(250, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "パスワード：";
            // 
            // txt_MgrID
            // 
            this.txt_MgrID.Location = new System.Drawing.Point(436, 145);
            this.txt_MgrID.Multiline = true;
            this.txt_MgrID.Name = "txt_MgrID";
            this.txt_MgrID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_MgrID.Size = new System.Drawing.Size(357, 50);
            this.txt_MgrID.TabIndex = 2;
            this.txt_MgrID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_PassWord
            // 
            this.txt_PassWord.Location = new System.Drawing.Point(436, 266);
            this.txt_PassWord.Multiline = true;
            this.txt_PassWord.Name = "txt_PassWord";
            this.txt_PassWord.Size = new System.Drawing.Size(357, 50);
            this.txt_PassWord.TabIndex = 3;
            this.txt_PassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_PassWord.UseSystemPasswordChar = true;
            // 
            // btn_Login
            // 
            this.btn_Login.AutoSize = true;
            this.btn_Login.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Login.Location = new System.Drawing.Point(611, 389);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(182, 55);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "ログイン";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Redo
            // 
            this.btn_Redo.AutoSize = true;
            this.btn_Redo.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Redo.Location = new System.Drawing.Point(300, 389);
            this.btn_Redo.Name = "btn_Redo";
            this.btn_Redo.Size = new System.Drawing.Size(182, 55);
            this.btn_Redo.TabIndex = 5;
            this.btn_Redo.Text = "戻る";
            this.btn_Redo.UseVisualStyleBackColor = true;
            this.btn_Redo.Click += new System.EventHandler(this.btn_Redo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(799, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "パスワードは一旦、店長の電話番号2222001111で。";
            // 
            // Msg
            // 
            this.Msg.Font = new System.Drawing.Font("MS UI Gothic", 24F);
            this.Msg.ForeColor = System.Drawing.Color.Red;
            this.Msg.Location = new System.Drawing.Point(109, 319);
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(887, 67);
            this.Msg.TabIndex = 6;
            this.Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Msg.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 592);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.btn_Redo);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_PassWord);
            this.Controls.Add(this.txt_MgrID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MgrID;
        private System.Windows.Forms.TextBox txt_PassWord;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Redo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Msg;
    }
}