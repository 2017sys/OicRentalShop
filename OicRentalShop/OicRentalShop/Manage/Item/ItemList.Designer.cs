namespace OicRentalShop.Manage.Item
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TopTitle
            // 
            this.lbl_TopTitle.AutoSize = true;
            this.lbl_TopTitle.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_TopTitle.Location = new System.Drawing.Point(247, 11);
            this.lbl_TopTitle.Name = "lbl_TopTitle";
            this.lbl_TopTitle.Size = new System.Drawing.Size(288, 64);
            this.lbl_TopTitle.TabIndex = 62;
            this.lbl_TopTitle.Text = "商品管理";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(0, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(813, 1);
            this.label9.TabIndex = 63;
            // 
            // lbl_SearchC
            // 
            this.lbl_SearchC.AutoSize = true;
            this.lbl_SearchC.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_SearchC.Location = new System.Drawing.Point(19, 102);
            this.lbl_SearchC.Name = "lbl_SearchC";
            this.lbl_SearchC.Size = new System.Drawing.Size(89, 19);
            this.lbl_SearchC.TabIndex = 64;
            this.lbl_SearchC.Text = "検索条件";
            // 
            // lbl_TitleName
            // 
            this.lbl_TitleName.AutoSize = true;
            this.lbl_TitleName.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_TitleName.Location = new System.Drawing.Point(20, 155);
            this.lbl_TitleName.Name = "lbl_TitleName";
            this.lbl_TitleName.Size = new System.Drawing.Size(63, 13);
            this.lbl_TitleName.TabIndex = 65;
            this.lbl_TitleName.Text = "タイトル名";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(0, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(813, 1);
            this.label7.TabIndex = 66;
            // 
            // txt_TitleName
            // 
            this.txt_TitleName.Location = new System.Drawing.Point(89, 155);
            this.txt_TitleName.Name = "txt_TitleName";
            this.txt_TitleName.Size = new System.Drawing.Size(76, 19);
            this.txt_TitleName.TabIndex = 67;
            // 
            // lbl_TitleID
            // 
            this.lbl_TitleID.AutoSize = true;
            this.lbl_TitleID.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_TitleID.Location = new System.Drawing.Point(181, 155);
            this.lbl_TitleID.Name = "lbl_TitleID";
            this.lbl_TitleID.Size = new System.Drawing.Size(62, 13);
            this.lbl_TitleID.TabIndex = 68;
            this.lbl_TitleID.Text = "タイトルID";
            // 
            // txt_TitleID
            // 
            this.txt_TitleID.Location = new System.Drawing.Point(249, 153);
            this.txt_TitleID.Name = "txt_TitleID";
            this.txt_TitleID.Size = new System.Drawing.Size(76, 19);
            this.txt_TitleID.TabIndex = 69;
            // 
            // lbl_ProductID
            // 
            this.lbl_ProductID.AutoSize = true;
            this.lbl_ProductID.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_ProductID.Location = new System.Drawing.Point(345, 156);
            this.lbl_ProductID.Name = "lbl_ProductID";
            this.lbl_ProductID.Size = new System.Drawing.Size(45, 12);
            this.lbl_ProductID.TabIndex = 70;
            this.lbl_ProductID.Text = "商品ＩＤ";
            // 
            // txt_ItemID
            // 
            this.txt_ItemID.Location = new System.Drawing.Point(396, 153);
            this.txt_ItemID.Name = "txt_ItemID";
            this.txt_ItemID.Size = new System.Drawing.Size(76, 19);
            this.txt_ItemID.TabIndex = 71;
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Type.Location = new System.Drawing.Point(488, 155);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(61, 13);
            this.lbl_Type.TabIndex = 72;
            this.lbl_Type.Text = "CD/DVD";
            // 
            // cmb_Type
            // 
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Items.AddRange(new object[] {
            "CD",
            "DVD"});
            this.cmb_Type.Location = new System.Drawing.Point(555, 154);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(60, 20);
            this.cmb_Type.TabIndex = 73;
            // 
            // txt_Artist
            // 
            this.txt_Artist.Location = new System.Drawing.Point(248, 189);
            this.txt_Artist.Name = "txt_Artist";
            this.txt_Artist.Size = new System.Drawing.Size(76, 19);
            this.txt_Artist.TabIndex = 79;
            // 
            // lbl_Artist
            // 
            this.lbl_Artist.AutoSize = true;
            this.lbl_Artist.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Artist.Location = new System.Drawing.Point(158, 190);
            this.lbl_Artist.Name = "lbl_Artist";
            this.lbl_Artist.Size = new System.Drawing.Size(84, 13);
            this.lbl_Artist.TabIndex = 78;
            this.lbl_Artist.Text = "アーティスト名";
            // 
            // cmb_Genre
            // 
            this.cmb_Genre.FormattingEnabled = true;
            this.cmb_Genre.Location = new System.Drawing.Point(387, 188);
            this.cmb_Genre.Name = "cmb_Genre";
            this.cmb_Genre.Size = new System.Drawing.Size(80, 20);
            this.cmb_Genre.TabIndex = 77;
            // 
            // cmb_Old_New
            // 
            this.cmb_Old_New.FormattingEnabled = true;
            this.cmb_Old_New.Items.AddRange(new object[] {
            "新作",
            "旧作"});
            this.cmb_Old_New.Location = new System.Drawing.Point(97, 188);
            this.cmb_Old_New.Name = "cmb_Old_New";
            this.cmb_Old_New.Size = new System.Drawing.Size(40, 20);
            this.cmb_Old_New.TabIndex = 76;
            // 
            // lbl_Genre
            // 
            this.lbl_Genre.AutoSize = true;
            this.lbl_Genre.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Genre.Location = new System.Drawing.Point(330, 190);
            this.lbl_Genre.Name = "lbl_Genre";
            this.lbl_Genre.Size = new System.Drawing.Size(52, 13);
            this.lbl_Genre.TabIndex = 75;
            this.lbl_Genre.Text = "ジャンル";
            // 
            // lbl_Old_New
            // 
            this.lbl_Old_New.AutoSize = true;
            this.lbl_Old_New.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Old_New.Location = new System.Drawing.Point(20, 190);
            this.lbl_Old_New.Name = "lbl_Old_New";
            this.lbl_Old_New.Size = new System.Drawing.Size(71, 13);
            this.lbl_Old_New.TabIndex = 74;
            this.lbl_Old_New.Text = "旧作/新作";
            // 
            // dgv_ItemInfo
            // 
            this.dgv_ItemInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ItemInfo.Location = new System.Drawing.Point(3, 232);
            this.dgv_ItemInfo.Name = "dgv_ItemInfo";
            this.dgv_ItemInfo.RowTemplate.Height = 21;
            this.dgv_ItemInfo.Size = new System.Drawing.Size(800, 354);
            this.dgv_ItemInfo.TabIndex = 80;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Add.Location = new System.Drawing.Point(818, 431);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(120, 50);
            this.btn_Add.TabIndex = 83;
            this.btn_Add.Text = "追加";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Delete.Location = new System.Drawing.Point(819, 511);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(120, 50);
            this.btn_Delete.TabIndex = 82;
            this.btn_Delete.Text = "削除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Edit.Location = new System.Drawing.Point(819, 354);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(120, 50);
            this.btn_Edit.TabIndex = 81;
            this.btn_Edit.Text = "編集";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Location = new System.Drawing.Point(690, 140);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(113, 86);
            this.btn_Search.TabIndex = 84;
            this.btn_Search.Text = "検索";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(812, -9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1, 617);
            this.label8.TabIndex = 85;
            this.label8.Text = "label8";
            // 
            // ItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
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
            this.Name = "ItemList";
            this.Size = new System.Drawing.Size(948, 591);
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
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label8;
    }
}
