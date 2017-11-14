namespace OicRentalShop.Register
{
    partial class TestForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Top = new System.Windows.Forms.Button();
            this.btn_MemberAdd = new System.Windows.Forms.Button();
            this.btn_Lend = new System.Windows.Forms.Button();
            this.btn_ItemAdd = new System.Windows.Forms.Button();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_PriceList = new System.Windows.Forms.Button();
            this.btn_ItemInfo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Top);
            this.panel1.Controls.Add(this.btn_MemberAdd);
            this.panel1.Controls.Add(this.btn_Lend);
            this.panel1.Controls.Add(this.btn_ItemAdd);
            this.panel1.Controls.Add(this.btn_Return);
            this.panel1.Controls.Add(this.btn_PriceList);
            this.panel1.Controls.Add(this.btn_ItemInfo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 591);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(152, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 600);
            this.label1.TabIndex = 261;
            this.label1.Text = "label1";
            // 
            // btn_Top
            // 
            this.btn_Top.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Top.Location = new System.Drawing.Point(8, 12);
            this.btn_Top.Name = "btn_Top";
            this.btn_Top.Size = new System.Drawing.Size(140, 109);
            this.btn_Top.TabIndex = 51;
            this.btn_Top.Text = "TOP";
            this.btn_Top.UseVisualStyleBackColor = true;
            this.btn_Top.Click += new System.EventHandler(this.btn_Top_Click);
            // 
            // btn_MemberAdd
            // 
            this.btn_MemberAdd.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_MemberAdd.Location = new System.Drawing.Point(8, 512);
            this.btn_MemberAdd.Name = "btn_MemberAdd";
            this.btn_MemberAdd.Size = new System.Drawing.Size(140, 60);
            this.btn_MemberAdd.TabIndex = 57;
            this.btn_MemberAdd.Text = "会員登録";
            this.btn_MemberAdd.UseVisualStyleBackColor = true;
            this.btn_MemberAdd.Click += new System.EventHandler(this.btn_MemberAdd_Click);
            // 
            // btn_Lend
            // 
            this.btn_Lend.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Lend.Location = new System.Drawing.Point(8, 182);
            this.btn_Lend.Name = "btn_Lend";
            this.btn_Lend.Size = new System.Drawing.Size(140, 60);
            this.btn_Lend.TabIndex = 52;
            this.btn_Lend.Text = "貸出処理";
            this.btn_Lend.UseVisualStyleBackColor = true;
            this.btn_Lend.Click += new System.EventHandler(this.btn_Lend_Click);
            // 
            // btn_ItemAdd
            // 
            this.btn_ItemAdd.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_ItemAdd.Location = new System.Drawing.Point(8, 446);
            this.btn_ItemAdd.Name = "btn_ItemAdd";
            this.btn_ItemAdd.Size = new System.Drawing.Size(140, 60);
            this.btn_ItemAdd.TabIndex = 56;
            this.btn_ItemAdd.Text = "商品登録";
            this.btn_ItemAdd.UseVisualStyleBackColor = true;
            this.btn_ItemAdd.Click += new System.EventHandler(this.btn_ItemAdd_Click);
            // 
            // btn_Return
            // 
            this.btn_Return.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Return.Location = new System.Drawing.Point(8, 248);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(140, 60);
            this.btn_Return.TabIndex = 53;
            this.btn_Return.Text = "返却処理";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_PriceList
            // 
            this.btn_PriceList.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_PriceList.Location = new System.Drawing.Point(8, 380);
            this.btn_PriceList.Name = "btn_PriceList";
            this.btn_PriceList.Size = new System.Drawing.Size(140, 60);
            this.btn_PriceList.TabIndex = 55;
            this.btn_PriceList.Text = "料金表";
            this.btn_PriceList.UseVisualStyleBackColor = true;
            this.btn_PriceList.Click += new System.EventHandler(this.btn_PriceList_Click);
            // 
            // btn_ItemInfo
            // 
            this.btn_ItemInfo.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_ItemInfo.Location = new System.Drawing.Point(8, 314);
            this.btn_ItemInfo.Name = "btn_ItemInfo";
            this.btn_ItemInfo.Size = new System.Drawing.Size(140, 60);
            this.btn_ItemInfo.TabIndex = 54;
            this.btn_ItemInfo.Text = "商品情報";
            this.btn_ItemInfo.UseVisualStyleBackColor = true;
            this.btn_ItemInfo.Click += new System.EventHandler(this.btn_ItemInfo_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(154, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 591);
            this.panel2.TabIndex = 1;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 592);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TestForm";
            this.Text = "Manatsu_no_yoru_no_inmu";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Top;
        private System.Windows.Forms.Button btn_MemberAdd;
        private System.Windows.Forms.Button btn_Lend;
        private System.Windows.Forms.Button btn_ItemAdd;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_PriceList;
        private System.Windows.Forms.Button btn_ItemInfo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel2;
    }
}