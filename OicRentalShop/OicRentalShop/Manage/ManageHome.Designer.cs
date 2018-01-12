namespace OicRentalShop.Manage
{
    partial class ManageHome
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
            this.panel = new System.Windows.Forms.Panel();
            this.btn_Top = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Title = new System.Windows.Forms.Button();
            this.btn_Item = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Log = new System.Windows.Forms.Button();
            this.btn_Member = new System.Windows.Forms.Button();
            this.btn_Event = new System.Windows.Forms.Button();
            this.btn_Staff = new System.Windows.Forms.Button();
            this.btn_Profit = new System.Windows.Forms.Button();
            this.btn_Price = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(271, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1632, 1042);
            this.panel.TabIndex = 3;
            // 
            // btn_Top
            // 
            this.btn_Top.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Top.Location = new System.Drawing.Point(11, 11);
            this.btn_Top.Name = "btn_Top";
            this.btn_Top.Size = new System.Drawing.Size(245, 175);
            this.btn_Top.TabIndex = 51;
            this.btn_Top.Text = "TOP";
            this.btn_Top.UseVisualStyleBackColor = true;
            this.btn_Top.Click += new System.EventHandler(this.btn_Top_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Title);
            this.panel1.Controls.Add(this.btn_Item);
            this.panel1.Controls.Add(this.btn_Top);
            this.panel1.Controls.Add(this.btn_Log);
            this.panel1.Controls.Add(this.btn_Member);
            this.panel1.Controls.Add(this.btn_Event);
            this.panel1.Controls.Add(this.btn_Staff);
            this.panel1.Controls.Add(this.btn_Profit);
            this.panel1.Controls.Add(this.btn_Price);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 1041);
            this.panel1.TabIndex = 2;
            // 
            // btn_Title
            // 
            this.btn_Title.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Title.Location = new System.Drawing.Point(11, 192);
            this.btn_Title.Name = "btn_Title";
            this.btn_Title.Size = new System.Drawing.Size(245, 95);
            this.btn_Title.TabIndex = 262;
            this.btn_Title.Text = "タイトル管理";
            this.btn_Title.UseVisualStyleBackColor = true;
            this.btn_Title.Click += new System.EventHandler(this.btn_Title_Click);
            // 
            // btn_Item
            // 
            this.btn_Item.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Item.Location = new System.Drawing.Point(11, 293);
            this.btn_Item.Name = "btn_Item";
            this.btn_Item.Size = new System.Drawing.Size(245, 95);
            this.btn_Item.TabIndex = 53;
            this.btn_Item.Text = "商品管理";
            this.btn_Item.UseVisualStyleBackColor = true;
            this.btn_Item.Click += new System.EventHandler(this.btn_Item_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(269, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 1042);
            this.label1.TabIndex = 261;
            this.label1.Text = "label1";
            // 
            // btn_Log
            // 
            this.btn_Log.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Log.Location = new System.Drawing.Point(11, 899);
            this.btn_Log.Name = "btn_Log";
            this.btn_Log.Size = new System.Drawing.Size(245, 95);
            this.btn_Log.TabIndex = 57;
            this.btn_Log.Text = "ログ管理";
            this.btn_Log.UseVisualStyleBackColor = true;
            this.btn_Log.Click += new System.EventHandler(this.btn_Log_Click);
            // 
            // btn_Member
            // 
            this.btn_Member.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Member.Location = new System.Drawing.Point(11, 394);
            this.btn_Member.Name = "btn_Member";
            this.btn_Member.Size = new System.Drawing.Size(245, 95);
            this.btn_Member.TabIndex = 52;
            this.btn_Member.Text = "会員管理";
            this.btn_Member.UseVisualStyleBackColor = true;
            this.btn_Member.Click += new System.EventHandler(this.btn_Member_Click);
            // 
            // btn_Event
            // 
            this.btn_Event.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Event.Location = new System.Drawing.Point(11, 798);
            this.btn_Event.Name = "btn_Event";
            this.btn_Event.Size = new System.Drawing.Size(245, 95);
            this.btn_Event.TabIndex = 56;
            this.btn_Event.Text = "イベント管理";
            this.btn_Event.UseVisualStyleBackColor = true;
            this.btn_Event.Click += new System.EventHandler(this.btn_Event_Click);
            // 
            // btn_Staff
            // 
            this.btn_Staff.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Staff.Location = new System.Drawing.Point(11, 495);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.Size = new System.Drawing.Size(245, 95);
            this.btn_Staff.TabIndex = 53;
            this.btn_Staff.Text = "従業員管理";
            this.btn_Staff.UseVisualStyleBackColor = true;
            this.btn_Staff.Click += new System.EventHandler(this.btn_Staff_Click);
            // 
            // btn_Profit
            // 
            this.btn_Profit.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Profit.Location = new System.Drawing.Point(11, 697);
            this.btn_Profit.Name = "btn_Profit";
            this.btn_Profit.Size = new System.Drawing.Size(245, 95);
            this.btn_Profit.TabIndex = 55;
            this.btn_Profit.Text = "売上管理";
            this.btn_Profit.UseVisualStyleBackColor = true;
            this.btn_Profit.Click += new System.EventHandler(this.btn_Profit_Click);
            // 
            // btn_Price
            // 
            this.btn_Price.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Price.Location = new System.Drawing.Point(11, 596);
            this.btn_Price.Name = "btn_Price";
            this.btn_Price.Size = new System.Drawing.Size(245, 95);
            this.btn_Price.TabIndex = 54;
            this.btn_Price.Text = "料金管理";
            this.btn_Price.UseVisualStyleBackColor = true;
            this.btn_Price.Click += new System.EventHandler(this.btn_Price_Click);
            // 
            // ManageHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1042);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ManageHome";
            this.Text = "ManageHome";
            this.Load += new System.EventHandler(this.ManageHome_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btn_Top;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Log;
        private System.Windows.Forms.Button btn_Member;
        private System.Windows.Forms.Button btn_Event;
        private System.Windows.Forms.Button btn_Staff;
        private System.Windows.Forms.Button btn_Profit;
        private System.Windows.Forms.Button btn_Price;
        private System.Windows.Forms.Button btn_Title;
    }
}