﻿namespace OicRentalShop.Manage.Item
{
    partial class ItemList
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
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_SearchC = new System.Windows.Forms.Label();
            this.lbl_TitleName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TitleName = new System.Windows.Forms.TextBox();
            this.lbl_TitleID = new System.Windows.Forms.Label();
            this.txt_TitleID = new System.Windows.Forms.TextBox();
            this.lbl_ProductID = new System.Windows.Forms.Label();
            this.txt_ItemID = new System.Windows.Forms.TextBox();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.cmb_Type = new System.Windows.Forms.ComboBox();
            this.txt_Artist = new System.Windows.Forms.TextBox();
            this.lbl_Artist = new System.Windows.Forms.Label();
            this.cmb_Genre = new System.Windows.Forms.ComboBox();
            this.cmb_Old_New = new System.Windows.Forms.ComboBox();
            this.lbl_Genre = new System.Windows.Forms.Label();
            this.lbl_Old_New = new System.Windows.Forms.Label();
            this.dgv_ItemInfo = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TopTitle
            // 
            this.lbl_TopTitle.AutoSize = true;
            this.lbl_TopTitle.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_TopTitle.Location = new System.Drawing.Point(329, 14);
            this.lbl_TopTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TopTitle.Name = "lbl_TopTitle";
            this.lbl_TopTitle.Size = new System.Drawing.Size(358, 80);
            this.lbl_TopTitle.TabIndex = 62;
            this.lbl_TopTitle.Text = "商品管理";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(0, 110);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1084, 1);
            this.label9.TabIndex = 63;
            // 
            // lbl_SearchC
            // 
            this.lbl_SearchC.AutoSize = true;
            this.lbl_SearchC.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_SearchC.Location = new System.Drawing.Point(25, 128);
            this.lbl_SearchC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SearchC.Name = "lbl_SearchC";
            this.lbl_SearchC.Size = new System.Drawing.Size(110, 24);
            this.lbl_SearchC.TabIndex = 64;
            this.lbl_SearchC.Text = "検索条件";
            // 
            // lbl_TitleName
            // 
            this.lbl_TitleName.AutoSize = true;
            this.lbl_TitleName.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_TitleName.Location = new System.Drawing.Point(27, 194);
            this.lbl_TitleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TitleName.Name = "lbl_TitleName";
            this.lbl_TitleName.Size = new System.Drawing.Size(67, 14);
            this.lbl_TitleName.TabIndex = 65;
            this.lbl_TitleName.Text = "タイトル名";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(0, 170);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1084, 1);
            this.label7.TabIndex = 66;
            // 
            // txt_TitleName
            // 
            this.txt_TitleName.Location = new System.Drawing.Point(119, 194);
            this.txt_TitleName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TitleName.Name = "txt_TitleName";
            this.txt_TitleName.Size = new System.Drawing.Size(100, 22);
            this.txt_TitleName.TabIndex = 67;
            // 
            // lbl_TitleID
            // 
            this.lbl_TitleID.AutoSize = true;
            this.lbl_TitleID.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_TitleID.Location = new System.Drawing.Point(241, 194);
            this.lbl_TitleID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TitleID.Name = "lbl_TitleID";
            this.lbl_TitleID.Size = new System.Drawing.Size(66, 14);
            this.lbl_TitleID.TabIndex = 68;
            this.lbl_TitleID.Text = "タイトルID";
            // 
            // txt_TitleID
            // 
            this.txt_TitleID.Location = new System.Drawing.Point(332, 191);
            this.txt_TitleID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TitleID.Name = "txt_TitleID";
            this.txt_TitleID.Size = new System.Drawing.Size(100, 22);
            this.txt_TitleID.TabIndex = 69;
            // 
            // lbl_ProductID
            // 
            this.lbl_ProductID.AutoSize = true;
            this.lbl_ProductID.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_ProductID.Location = new System.Drawing.Point(460, 195);
            this.lbl_ProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ProductID.Name = "lbl_ProductID";
            this.lbl_ProductID.Size = new System.Drawing.Size(56, 15);
            this.lbl_ProductID.TabIndex = 70;
            this.lbl_ProductID.Text = "商品ＩＤ";
            // 
            // txt_ItemID
            // 
            this.txt_ItemID.Location = new System.Drawing.Point(528, 191);
            this.txt_ItemID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ItemID.Name = "txt_ItemID";
            this.txt_ItemID.Size = new System.Drawing.Size(100, 22);
            this.txt_ItemID.TabIndex = 71;
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Type.Location = new System.Drawing.Point(651, 194);
            this.lbl_Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(65, 14);
            this.lbl_Type.TabIndex = 72;
            this.lbl_Type.Text = "CD/DVD";
            // 
            // cmb_Type
            // 
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Items.AddRange(new object[] {
            "CD",
            "DVD"});
            this.cmb_Type.Location = new System.Drawing.Point(740, 192);
            this.cmb_Type.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(79, 23);
            this.cmb_Type.TabIndex = 73;
            this.cmb_Type.Text = "CD";
            this.cmb_Type.SelectedIndexChanged += new System.EventHandler(this.cmb_Type_SelectedIndexChanged);
            // 
            // txt_Artist
            // 
            this.txt_Artist.Location = new System.Drawing.Point(331, 236);
            this.txt_Artist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Artist.Name = "txt_Artist";
            this.txt_Artist.Size = new System.Drawing.Size(100, 22);
            this.txt_Artist.TabIndex = 79;
            // 
            // lbl_Artist
            // 
            this.lbl_Artist.AutoSize = true;
            this.lbl_Artist.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Artist.Location = new System.Drawing.Point(211, 238);
            this.lbl_Artist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Artist.Name = "lbl_Artist";
            this.lbl_Artist.Size = new System.Drawing.Size(90, 14);
            this.lbl_Artist.TabIndex = 78;
            this.lbl_Artist.Text = "アーティスト名";
            // 
            // cmb_Genre
            // 
            this.cmb_Genre.FormattingEnabled = true;
            this.cmb_Genre.Location = new System.Drawing.Point(528, 235);
            this.cmb_Genre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Genre.Name = "cmb_Genre";
            this.cmb_Genre.Size = new System.Drawing.Size(105, 23);
            this.cmb_Genre.TabIndex = 77;
            this.cmb_Genre.Text = "全ジャンル";
            // 
            // cmb_Old_New
            // 
            this.cmb_Old_New.FormattingEnabled = true;
            this.cmb_Old_New.Items.AddRange(new object[] {
            "新作",
            "旧作"});
            this.cmb_Old_New.Location = new System.Drawing.Point(119, 235);
            this.cmb_Old_New.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Old_New.Name = "cmb_Old_New";
            this.cmb_Old_New.Size = new System.Drawing.Size(72, 23);
            this.cmb_Old_New.TabIndex = 76;
            // 
            // lbl_Genre
            // 
            this.lbl_Genre.AutoSize = true;
            this.lbl_Genre.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Genre.Location = new System.Drawing.Point(451, 238);
            this.lbl_Genre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Genre.Name = "lbl_Genre";
            this.lbl_Genre.Size = new System.Drawing.Size(53, 14);
            this.lbl_Genre.TabIndex = 75;
            this.lbl_Genre.Text = "ジャンル";
            // 
            // lbl_Old_New
            // 
            this.lbl_Old_New.AutoSize = true;
            this.lbl_Old_New.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Old_New.Location = new System.Drawing.Point(27, 238);
            this.lbl_Old_New.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Old_New.Name = "lbl_Old_New";
            this.lbl_Old_New.Size = new System.Drawing.Size(75, 14);
            this.lbl_Old_New.TabIndex = 74;
            this.lbl_Old_New.Text = "旧作/新作";
            // 
            // dgv_ItemInfo
            // 
            this.dgv_ItemInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ItemInfo.Location = new System.Drawing.Point(4, 290);
            this.dgv_ItemInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_ItemInfo.Name = "dgv_ItemInfo";
            this.dgv_ItemInfo.RowTemplate.Height = 21;
            this.dgv_ItemInfo.Size = new System.Drawing.Size(1067, 442);
            this.dgv_ItemInfo.TabIndex = 80;
            this.dgv_ItemInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ItemInfo_CellContentClick);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Add.Location = new System.Drawing.Point(1092, 670);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(160, 62);
            this.btn_Add.TabIndex = 83;
            this.btn_Add.Text = "追加";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Location = new System.Drawing.Point(920, 175);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(151, 108);
            this.btn_Search.TabIndex = 84;
            this.btn_Search.Text = "検索";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(1083, -11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1, 771);
            this.label8.TabIndex = 85;
            this.label8.Text = "label8";
            // 
            // ItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Add);
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
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_TitleName);
            this.Controls.Add(this.lbl_SearchC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_TopTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ItemList";
            this.Size = new System.Drawing.Size(1264, 739);
            this.Load += new System.EventHandler(this.ItemList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TopTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_SearchC;
        private System.Windows.Forms.Label lbl_TitleName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TitleName;
        private System.Windows.Forms.Label lbl_TitleID;
        private System.Windows.Forms.TextBox txt_TitleID;
        private System.Windows.Forms.Label lbl_ProductID;
        private System.Windows.Forms.TextBox txt_ItemID;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.ComboBox cmb_Type;
        private System.Windows.Forms.TextBox txt_Artist;
        private System.Windows.Forms.Label lbl_Artist;
        private System.Windows.Forms.ComboBox cmb_Genre;
        private System.Windows.Forms.ComboBox cmb_Old_New;
        private System.Windows.Forms.Label lbl_Genre;
        private System.Windows.Forms.Label lbl_Old_New;
        private System.Windows.Forms.DataGridView dgv_ItemInfo;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label8;
    }
}
