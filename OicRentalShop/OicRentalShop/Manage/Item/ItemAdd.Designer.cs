namespace OicRentalShop.Manage.Item
{
    partial class ItemAdd
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
            this.txt_TitleID = new System.Windows.Forms.TextBox();
            this.lbl_TitleName = new System.Windows.Forms.Label();
            this.lbl_ReleaseDate = new System.Windows.Forms.Label();
            this.lbl_Genre = new System.Windows.Forms.Label();
            this.lbl_Artist = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_UniqueID = new System.Windows.Forms.Label();
            this.lbl_ItemIDInfo = new System.Windows.Forms.Label();
            this.lbl_TitleNameInfo = new System.Windows.Forms.Label();
            this.lbl_ArtistNameInfo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ToAdd = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.dgv_ItemRe = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_TypeInfo = new System.Windows.Forms.Label();
            this.lbl_OldNewInfo = new System.Windows.Forms.Label();
            this.lbl_GenreInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemRe)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TopTitle
            // 
            this.lbl_TopTitle.AutoSize = true;
            this.lbl_TopTitle.Font = new System.Drawing.Font("MS UI Gothic", 65.25F, System.Drawing.FontStyle.Bold);
            this.lbl_TopTitle.Location = new System.Drawing.Point(580, 26);
            this.lbl_TopTitle.Name = "lbl_TopTitle";
            this.lbl_TopTitle.Size = new System.Drawing.Size(389, 87);
            this.lbl_TopTitle.TabIndex = 63;
            this.lbl_TopTitle.Text = "商品管理";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(-2, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1660, 1);
            this.label9.TabIndex = 64;
            // 
            // txt_TitleID
            // 
            this.txt_TitleID.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txt_TitleID.Location = new System.Drawing.Point(373, 266);
            this.txt_TitleID.Multiline = true;
            this.txt_TitleID.Name = "txt_TitleID";
            this.txt_TitleID.Size = new System.Drawing.Size(299, 34);
            this.txt_TitleID.TabIndex = 132;
            this.txt_TitleID.TextChanged += new System.EventHandler(this.txt_TitleIDInfo_TextChanged);
            // 
            // lbl_TitleName
            // 
            this.lbl_TitleName.AutoSize = true;
            this.lbl_TitleName.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_TitleName.Location = new System.Drawing.Point(169, 430);
            this.lbl_TitleName.Name = "lbl_TitleName";
            this.lbl_TitleName.Size = new System.Drawing.Size(163, 33);
            this.lbl_TitleName.TabIndex = 131;
            this.lbl_TitleName.Text = "タイトル名：";
            // 
            // lbl_ReleaseDate
            // 
            this.lbl_ReleaseDate.AutoSize = true;
            this.lbl_ReleaseDate.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_ReleaseDate.Location = new System.Drawing.Point(198, 758);
            this.lbl_ReleaseDate.Name = "lbl_ReleaseDate";
            this.lbl_ReleaseDate.Size = new System.Drawing.Size(134, 33);
            this.lbl_ReleaseDate.TabIndex = 129;
            this.lbl_ReleaseDate.Text = "ジャンル：";
            // 
            // lbl_Genre
            // 
            this.lbl_Genre.AutoSize = true;
            this.lbl_Genre.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_Genre.Location = new System.Drawing.Point(129, 676);
            this.lbl_Genre.Name = "lbl_Genre";
            this.lbl_Genre.Size = new System.Drawing.Size(203, 33);
            this.lbl_Genre.TabIndex = 128;
            this.lbl_Genre.Text = "旧作 / 新作：";
            // 
            // lbl_Artist
            // 
            this.lbl_Artist.AutoSize = true;
            this.lbl_Artist.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_Artist.Location = new System.Drawing.Point(120, 512);
            this.lbl_Artist.Name = "lbl_Artist";
            this.lbl_Artist.Size = new System.Drawing.Size(212, 33);
            this.lbl_Artist.TabIndex = 127;
            this.lbl_Artist.Text = "アーティスト名：";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.Location = new System.Drawing.Point(171, 266);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(161, 33);
            this.lbl_Title.TabIndex = 126;
            this.lbl_Title.Text = "タイトルID：";
            // 
            // lbl_UniqueID
            // 
            this.lbl_UniqueID.AutoSize = true;
            this.lbl_UniqueID.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_UniqueID.Location = new System.Drawing.Point(203, 348);
            this.lbl_UniqueID.Name = "lbl_UniqueID";
            this.lbl_UniqueID.Size = new System.Drawing.Size(129, 33);
            this.lbl_UniqueID.TabIndex = 125;
            this.lbl_UniqueID.Text = "商品ID：";
            // 
            // lbl_ItemIDInfo
            // 
            this.lbl_ItemIDInfo.AutoSize = true;
            this.lbl_ItemIDInfo.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_ItemIDInfo.Location = new System.Drawing.Point(367, 348);
            this.lbl_ItemIDInfo.Name = "lbl_ItemIDInfo";
            this.lbl_ItemIDInfo.Size = new System.Drawing.Size(0, 33);
            this.lbl_ItemIDInfo.TabIndex = 133;
            // 
            // lbl_TitleNameInfo
            // 
            this.lbl_TitleNameInfo.AutoSize = true;
            this.lbl_TitleNameInfo.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_TitleNameInfo.Location = new System.Drawing.Point(367, 430);
            this.lbl_TitleNameInfo.Name = "lbl_TitleNameInfo";
            this.lbl_TitleNameInfo.Size = new System.Drawing.Size(0, 33);
            this.lbl_TitleNameInfo.TabIndex = 134;
            // 
            // lbl_ArtistNameInfo
            // 
            this.lbl_ArtistNameInfo.AutoSize = true;
            this.lbl_ArtistNameInfo.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_ArtistNameInfo.Location = new System.Drawing.Point(367, 512);
            this.lbl_ArtistNameInfo.Name = "lbl_ArtistNameInfo";
            this.lbl_ArtistNameInfo.Size = new System.Drawing.Size(0, 33);
            this.lbl_ArtistNameInfo.TabIndex = 135;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(152, 594);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 33);
            this.label6.TabIndex = 138;
            this.label6.Text = "CD / DVD：";
            // 
            // btn_ToAdd
            // 
            this.btn_ToAdd.Font = new System.Drawing.Font("Meiryo UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_ToAdd.Location = new System.Drawing.Point(921, 922);
            this.btn_ToAdd.Name = "btn_ToAdd";
            this.btn_ToAdd.Size = new System.Drawing.Size(174, 85);
            this.btn_ToAdd.TabIndex = 146;
            this.btn_ToAdd.Text = "追加";
            this.btn_ToAdd.UseVisualStyleBackColor = true;
            this.btn_ToAdd.Click += new System.EventHandler(this.btn_ToAdd_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Meiryo UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_Add.Location = new System.Drawing.Point(1404, 922);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(174, 85);
            this.btn_Add.TabIndex = 145;
            this.btn_Add.Text = "登録";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Meiryo UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_clear.Location = new System.Drawing.Point(1173, 922);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(174, 85);
            this.btn_clear.TabIndex = 144;
            this.btn_clear.Text = "クリア";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Meiryo UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_Cancel.Location = new System.Drawing.Point(77, 922);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(174, 85);
            this.btn_Cancel.TabIndex = 147;
            this.btn_Cancel.Text = "キャンセル";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click_1);
            // 
            // dgv_ItemRe
            // 
            this.dgv_ItemRe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ItemRe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7});
            this.dgv_ItemRe.Location = new System.Drawing.Point(864, 197);
            this.dgv_ItemRe.Name = "dgv_ItemRe";
            this.dgv_ItemRe.RowTemplate.Height = 21;
            this.dgv_ItemRe.Size = new System.Drawing.Size(745, 650);
            this.dgv_ItemRe.TabIndex = 148;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "タイトルID";
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "商品ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "タイトル名";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "アーティスト名";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CD / DVD";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "旧作 / 新作";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ジャンル";
            this.Column7.Name = "Column7";
            // 
            // lbl_TypeInfo
            // 
            this.lbl_TypeInfo.AutoSize = true;
            this.lbl_TypeInfo.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_TypeInfo.Location = new System.Drawing.Point(367, 595);
            this.lbl_TypeInfo.Name = "lbl_TypeInfo";
            this.lbl_TypeInfo.Size = new System.Drawing.Size(0, 33);
            this.lbl_TypeInfo.TabIndex = 149;
            // 
            // lbl_OldNewInfo
            // 
            this.lbl_OldNewInfo.AutoSize = true;
            this.lbl_OldNewInfo.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_OldNewInfo.Location = new System.Drawing.Point(367, 676);
            this.lbl_OldNewInfo.Name = "lbl_OldNewInfo";
            this.lbl_OldNewInfo.Size = new System.Drawing.Size(0, 33);
            this.lbl_OldNewInfo.TabIndex = 150;
            // 
            // lbl_GenreInfo
            // 
            this.lbl_GenreInfo.AutoSize = true;
            this.lbl_GenreInfo.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_GenreInfo.Location = new System.Drawing.Point(367, 758);
            this.lbl_GenreInfo.Name = "lbl_GenreInfo";
            this.lbl_GenreInfo.Size = new System.Drawing.Size(0, 33);
            this.lbl_GenreInfo.TabIndex = 151;
            // 
            // ItemAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_GenreInfo);
            this.Controls.Add(this.lbl_OldNewInfo);
            this.Controls.Add(this.lbl_TypeInfo);
            this.Controls.Add(this.dgv_ItemRe);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_ToAdd);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_ArtistNameInfo);
            this.Controls.Add(this.lbl_TitleNameInfo);
            this.Controls.Add(this.lbl_ItemIDInfo);
            this.Controls.Add(this.txt_TitleID);
            this.Controls.Add(this.lbl_TitleName);
            this.Controls.Add(this.lbl_ReleaseDate);
            this.Controls.Add(this.lbl_Genre);
            this.Controls.Add(this.lbl_Artist);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_UniqueID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_TopTitle);
            this.Name = "ItemAdd";
            this.Size = new System.Drawing.Size(1661, 1042);
            this.Load += new System.EventHandler(this.ItemAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemRe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TopTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_ToAdd;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_Cancel;
        public System.Windows.Forms.DataGridView dgv_ItemRe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label lbl_TitleName;
        private System.Windows.Forms.Label lbl_ReleaseDate;
        private System.Windows.Forms.Label lbl_Genre;
        private System.Windows.Forms.Label lbl_Artist;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_UniqueID;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_TitleID;
        public System.Windows.Forms.Label lbl_ItemIDInfo;
        public System.Windows.Forms.Label lbl_TitleNameInfo;
        public System.Windows.Forms.Label lbl_ArtistNameInfo;
        public System.Windows.Forms.Label lbl_TypeInfo;
        public System.Windows.Forms.Label lbl_OldNewInfo;
        public System.Windows.Forms.Label lbl_GenreInfo;
    }
}
