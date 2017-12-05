namespace OicRentalShop.Manage.Title
{
    partial class TitleList
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
            this.lbl_TopTitle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_SearchC = new System.Windows.Forms.Label();
            this.txt_Artist = new System.Windows.Forms.TextBox();
            this.lbl_Artist = new System.Windows.Forms.Label();
            this.cmb_Genre = new System.Windows.Forms.ComboBox();
            this.cmb_Old_New = new System.Windows.Forms.ComboBox();
            this.lbl_Genre = new System.Windows.Forms.Label();
            this.lbl_Old_New = new System.Windows.Forms.Label();
            this.cmb_Type = new System.Windows.Forms.ComboBox();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.txt_ItemID = new System.Windows.Forms.TextBox();
            this.lbl_ProductID = new System.Windows.Forms.Label();
            this.txt_TitleID = new System.Windows.Forms.TextBox();
            this.lbl_TitleID = new System.Windows.Forms.Label();
            this.txt_TitleName = new System.Windows.Forms.TextBox();
            this.lbl_TitleName = new System.Windows.Forms.Label();
            this.dgv_ItemInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TopTitle
            // 
            this.lbl_TopTitle.AutoSize = true;
            this.lbl_TopTitle.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_TopTitle.Location = new System.Drawing.Point(247, 11);
            this.lbl_TopTitle.Name = "lbl_TopTitle";
            this.lbl_TopTitle.Size = new System.Drawing.Size(349, 64);
            this.lbl_TopTitle.TabIndex = 63;
            this.lbl_TopTitle.Text = "タイトル管理";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(0, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(813, 1);
            this.label9.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(0, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(813, 1);
            this.label7.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(812, -9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1, 617);
            this.label8.TabIndex = 86;
            this.label8.Text = "label8";
            // 
            // lbl_SearchC
            // 
            this.lbl_SearchC.AutoSize = true;
            this.lbl_SearchC.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_SearchC.Location = new System.Drawing.Point(19, 102);
            this.lbl_SearchC.Name = "lbl_SearchC";
            this.lbl_SearchC.Size = new System.Drawing.Size(89, 19);
            this.lbl_SearchC.TabIndex = 87;
            this.lbl_SearchC.Text = "検索条件";
            // 
            // txt_Artist
            // 
            this.txt_Artist.Location = new System.Drawing.Point(254, 190);
            this.txt_Artist.Name = "txt_Artist";
            this.txt_Artist.Size = new System.Drawing.Size(76, 19);
            this.txt_Artist.TabIndex = 101;
            // 
            // lbl_Artist
            // 
            this.lbl_Artist.AutoSize = true;
            this.lbl_Artist.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Artist.Location = new System.Drawing.Point(164, 191);
            this.lbl_Artist.Name = "lbl_Artist";
            this.lbl_Artist.Size = new System.Drawing.Size(84, 13);
            this.lbl_Artist.TabIndex = 100;
            this.lbl_Artist.Text = "アーティスト名";
            // 
            // cmb_Genre
            // 
            this.cmb_Genre.FormattingEnabled = true;
            this.cmb_Genre.Location = new System.Drawing.Point(402, 189);
            this.cmb_Genre.Name = "cmb_Genre";
            this.cmb_Genre.Size = new System.Drawing.Size(80, 20);
            this.cmb_Genre.TabIndex = 99;
            this.cmb_Genre.Text = "全ジャンル";
            // 
            // cmb_Old_New
            // 
            this.cmb_Old_New.FormattingEnabled = true;
            this.cmb_Old_New.Items.AddRange(new object[] {
            "新作",
            "旧作"});
            this.cmb_Old_New.Location = new System.Drawing.Point(95, 189);
            this.cmb_Old_New.Name = "cmb_Old_New";
            this.cmb_Old_New.Size = new System.Drawing.Size(55, 20);
            this.cmb_Old_New.TabIndex = 98;
            // 
            // lbl_Genre
            // 
            this.lbl_Genre.AutoSize = true;
            this.lbl_Genre.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Genre.Location = new System.Drawing.Point(344, 191);
            this.lbl_Genre.Name = "lbl_Genre";
            this.lbl_Genre.Size = new System.Drawing.Size(52, 13);
            this.lbl_Genre.TabIndex = 97;
            this.lbl_Genre.Text = "ジャンル";
            // 
            // lbl_Old_New
            // 
            this.lbl_Old_New.AutoSize = true;
            this.lbl_Old_New.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Old_New.Location = new System.Drawing.Point(26, 191);
            this.lbl_Old_New.Name = "lbl_Old_New";
            this.lbl_Old_New.Size = new System.Drawing.Size(71, 13);
            this.lbl_Old_New.TabIndex = 96;
            this.lbl_Old_New.Text = "旧作/新作";
            // 
            // cmb_Type
            // 
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Items.AddRange(new object[] {
            "CD",
            "DVD"});
            this.cmb_Type.Location = new System.Drawing.Point(561, 155);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(60, 20);
            this.cmb_Type.TabIndex = 95;
            this.cmb_Type.Text = "CD";
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Type.Location = new System.Drawing.Point(494, 156);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(61, 13);
            this.lbl_Type.TabIndex = 94;
            this.lbl_Type.Text = "CD/DVD";
            // 
            // txt_ItemID
            // 
            this.txt_ItemID.Location = new System.Drawing.Point(402, 154);
            this.txt_ItemID.Name = "txt_ItemID";
            this.txt_ItemID.Size = new System.Drawing.Size(76, 19);
            this.txt_ItemID.TabIndex = 93;
            // 
            // lbl_ProductID
            // 
            this.lbl_ProductID.AutoSize = true;
            this.lbl_ProductID.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_ProductID.Location = new System.Drawing.Point(351, 157);
            this.lbl_ProductID.Name = "lbl_ProductID";
            this.lbl_ProductID.Size = new System.Drawing.Size(45, 12);
            this.lbl_ProductID.TabIndex = 92;
            this.lbl_ProductID.Text = "商品ＩＤ";
            // 
            // txt_TitleID
            // 
            this.txt_TitleID.Location = new System.Drawing.Point(255, 154);
            this.txt_TitleID.Name = "txt_TitleID";
            this.txt_TitleID.Size = new System.Drawing.Size(76, 19);
            this.txt_TitleID.TabIndex = 91;
            // 
            // lbl_TitleID
            // 
            this.lbl_TitleID.AutoSize = true;
            this.lbl_TitleID.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_TitleID.Location = new System.Drawing.Point(187, 156);
            this.lbl_TitleID.Name = "lbl_TitleID";
            this.lbl_TitleID.Size = new System.Drawing.Size(62, 13);
            this.lbl_TitleID.TabIndex = 90;
            this.lbl_TitleID.Text = "タイトルID";
            // 
            // txt_TitleName
            // 
            this.txt_TitleName.Location = new System.Drawing.Point(95, 156);
            this.txt_TitleName.Name = "txt_TitleName";
            this.txt_TitleName.Size = new System.Drawing.Size(76, 19);
            this.txt_TitleName.TabIndex = 89;
            // 
            // lbl_TitleName
            // 
            this.lbl_TitleName.AutoSize = true;
            this.lbl_TitleName.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_TitleName.Location = new System.Drawing.Point(26, 156);
            this.lbl_TitleName.Name = "lbl_TitleName";
            this.lbl_TitleName.Size = new System.Drawing.Size(63, 13);
            this.lbl_TitleName.TabIndex = 88;
            this.lbl_TitleName.Text = "タイトル名";
            // 
            // dgv_ItemInfo
            // 
            this.dgv_ItemInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ItemInfo.Location = new System.Drawing.Point(3, 232);
            this.dgv_ItemInfo.Name = "dgv_ItemInfo";
            this.dgv_ItemInfo.RowTemplate.Height = 21;
            this.dgv_ItemInfo.Size = new System.Drawing.Size(800, 354);
            this.dgv_ItemInfo.TabIndex = 102;
            // 
            // TitleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(932, 575);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_ItemInfo);
            this.Controls.Add(this.txt_Artist);
            this.Controls.Add(this.lbl_Artist);
            this.Controls.Add(this.cmb_Genre);
            this.Controls.Add(this.cmb_Old_New);
            this.Controls.Add(this.lbl_Genre);
            this.Controls.Add(this.lbl_Old_New);
            this.Controls.Add(this.cmb_Type);
            this.Controls.Add(this.lbl_Type);
            this.Controls.Add(this.txt_ItemID);
            this.Controls.Add(this.lbl_ProductID);
            this.Controls.Add(this.txt_TitleID);
            this.Controls.Add(this.lbl_TitleID);
            this.Controls.Add(this.txt_TitleName);
            this.Controls.Add(this.lbl_TitleName);
            this.Controls.Add(this.lbl_SearchC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_TopTitle);
            this.Name = "TitleList";
            this.Load += new System.EventHandler(this.TitleList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TopTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_SearchC;
        private System.Windows.Forms.TextBox txt_Artist;
        private System.Windows.Forms.Label lbl_Artist;
        private System.Windows.Forms.ComboBox cmb_Genre;
        private System.Windows.Forms.ComboBox cmb_Old_New;
        private System.Windows.Forms.Label lbl_Genre;
        private System.Windows.Forms.Label lbl_Old_New;
        private System.Windows.Forms.ComboBox cmb_Type;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.TextBox txt_ItemID;
        private System.Windows.Forms.Label lbl_ProductID;
        private System.Windows.Forms.TextBox txt_TitleID;
        private System.Windows.Forms.Label lbl_TitleID;
        private System.Windows.Forms.TextBox txt_TitleName;
        private System.Windows.Forms.Label lbl_TitleName;
        private System.Windows.Forms.DataGridView dgv_ItemInfo;
    }
}