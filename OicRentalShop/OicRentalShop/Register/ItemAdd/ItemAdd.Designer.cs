namespace OicRentalShop.Manage.ItemAdd
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.dgv_ItemRe = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_ReleaseDateInfo = new System.Windows.Forms.Label();
            this.lbl_GenreInfo = new System.Windows.Forms.Label();
            this.lbl_ArtistInfo = new System.Windows.Forms.Label();
            this.lbl_TitleNameInfo = new System.Windows.Forms.Label();
            this.lbl_ReleaseDate = new System.Windows.Forms.Label();
            this.lbl_Genre = new System.Windows.Forms.Label();
            this.lbl_Artist = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_UniqueID = new System.Windows.Forms.Label();
            this.lbl_TopTitle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_TitleName = new System.Windows.Forms.Label();
            this.txt_TitleID = new System.Windows.Forms.TextBox();
            this.lbl_UniqueIDInfo = new System.Windows.Forms.Label();
            this.btn_ToAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemRe)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Add.Location = new System.Drawing.Point(1257, 795);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(251, 83);
            this.btn_Add.TabIndex = 121;
            this.btn_Add.Text = "登録";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_clear.Location = new System.Drawing.Point(951, 795);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(251, 83);
            this.btn_clear.TabIndex = 120;
            this.btn_clear.Text = "クリア";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // dgv_ItemRe
            // 
            this.dgv_ItemRe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ItemRe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_ItemRe.Location = new System.Drawing.Point(822, 249);
            this.dgv_ItemRe.Name = "dgv_ItemRe";
            this.dgv_ItemRe.RowTemplate.Height = 21;
            this.dgv_ItemRe.Size = new System.Drawing.Size(644, 427);
            this.dgv_ItemRe.TabIndex = 119;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "商品ID";
            this.Column1.Name = "Column1";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "タイトルID";
            this.Column6.Name = "Column6";
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
            this.Column4.HeaderText = "ジャンル名";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "発売日";
            this.Column5.Name = "Column5";
            // 
            // lbl_ReleaseDateInfo
            // 
            this.lbl_ReleaseDateInfo.AutoSize = true;
            this.lbl_ReleaseDateInfo.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_ReleaseDateInfo.Location = new System.Drawing.Point(330, 556);
            this.lbl_ReleaseDateInfo.Name = "lbl_ReleaseDateInfo";
            this.lbl_ReleaseDateInfo.Size = new System.Drawing.Size(0, 21);
            this.lbl_ReleaseDateInfo.TabIndex = 118;
            // 
            // lbl_GenreInfo
            // 
            this.lbl_GenreInfo.AutoSize = true;
            this.lbl_GenreInfo.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_GenreInfo.Location = new System.Drawing.Point(330, 504);
            this.lbl_GenreInfo.Name = "lbl_GenreInfo";
            this.lbl_GenreInfo.Size = new System.Drawing.Size(0, 21);
            this.lbl_GenreInfo.TabIndex = 117;
            // 
            // lbl_ArtistInfo
            // 
            this.lbl_ArtistInfo.AutoSize = true;
            this.lbl_ArtistInfo.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_ArtistInfo.Location = new System.Drawing.Point(330, 437);
            this.lbl_ArtistInfo.Name = "lbl_ArtistInfo";
            this.lbl_ArtistInfo.Size = new System.Drawing.Size(0, 21);
            this.lbl_ArtistInfo.TabIndex = 116;
            // 
            // lbl_TitleNameInfo
            // 
            this.lbl_TitleNameInfo.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_TitleNameInfo.Location = new System.Drawing.Point(330, 362);
            this.lbl_TitleNameInfo.Name = "lbl_TitleNameInfo";
            this.lbl_TitleNameInfo.Size = new System.Drawing.Size(382, 45);
            this.lbl_TitleNameInfo.TabIndex = 115;
            // 
            // lbl_ReleaseDate
            // 
            this.lbl_ReleaseDate.AutoSize = true;
            this.lbl_ReleaseDate.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_ReleaseDate.Location = new System.Drawing.Point(190, 556);
            this.lbl_ReleaseDate.Name = "lbl_ReleaseDate";
            this.lbl_ReleaseDate.Size = new System.Drawing.Size(88, 21);
            this.lbl_ReleaseDate.TabIndex = 113;
            this.lbl_ReleaseDate.Text = "発売日：";
            // 
            // lbl_Genre
            // 
            this.lbl_Genre.AutoSize = true;
            this.lbl_Genre.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Genre.Location = new System.Drawing.Point(166, 504);
            this.lbl_Genre.Name = "lbl_Genre";
            this.lbl_Genre.Size = new System.Drawing.Size(112, 21);
            this.lbl_Genre.TabIndex = 112;
            this.lbl_Genre.Text = "ジャンル名：";
            // 
            // lbl_Artist
            // 
            this.lbl_Artist.AutoSize = true;
            this.lbl_Artist.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Artist.Location = new System.Drawing.Point(136, 437);
            this.lbl_Artist.Name = "lbl_Artist";
            this.lbl_Artist.Size = new System.Drawing.Size(142, 21);
            this.lbl_Artist.TabIndex = 111;
            this.lbl_Artist.Text = "アーティスト名：";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Title.Location = new System.Drawing.Point(166, 268);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(109, 21);
            this.lbl_Title.TabIndex = 110;
            this.lbl_Title.Text = "タイトルID：";
            // 
            // lbl_UniqueID
            // 
            this.lbl_UniqueID.AutoSize = true;
            this.lbl_UniqueID.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_UniqueID.Location = new System.Drawing.Point(191, 315);
            this.lbl_UniqueID.Name = "lbl_UniqueID";
            this.lbl_UniqueID.Size = new System.Drawing.Size(87, 21);
            this.lbl_UniqueID.TabIndex = 109;
            this.lbl_UniqueID.Text = "商品ID：";
            // 
            // lbl_TopTitle
            // 
            this.lbl_TopTitle.AutoSize = true;
            this.lbl_TopTitle.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_TopTitle.Location = new System.Drawing.Point(635, 26);
            this.lbl_TopTitle.Name = "lbl_TopTitle";
            this.lbl_TopTitle.Size = new System.Drawing.Size(430, 97);
            this.lbl_TopTitle.TabIndex = 108;
            this.lbl_TopTitle.Text = "商品登録";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(0, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1632, 1);
            this.label9.TabIndex = 107;
            // 
            // lbl_TitleName
            // 
            this.lbl_TitleName.AutoSize = true;
            this.lbl_TitleName.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_TitleName.Location = new System.Drawing.Point(169, 376);
            this.lbl_TitleName.Name = "lbl_TitleName";
            this.lbl_TitleName.Size = new System.Drawing.Size(110, 21);
            this.lbl_TitleName.TabIndex = 122;
            this.lbl_TitleName.Text = "タイトル名：";
            // 
            // txt_TitleID
            // 
            this.txt_TitleID.Location = new System.Drawing.Point(334, 268);
            this.txt_TitleID.Name = "txt_TitleID";
            this.txt_TitleID.Size = new System.Drawing.Size(199, 19);
            this.txt_TitleID.TabIndex = 124;
            this.txt_TitleID.TextChanged += new System.EventHandler(this.txt_TitleID_TextChanged);
            // 
            // lbl_UniqueIDInfo
            // 
            this.lbl_UniqueIDInfo.AutoSize = true;
            this.lbl_UniqueIDInfo.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_UniqueIDInfo.Location = new System.Drawing.Point(330, 315);
            this.lbl_UniqueIDInfo.Name = "lbl_UniqueIDInfo";
            this.lbl_UniqueIDInfo.Size = new System.Drawing.Size(0, 21);
            this.lbl_UniqueIDInfo.TabIndex = 125;
            // 
            // btn_ToAdd
            // 
            this.btn_ToAdd.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_ToAdd.Location = new System.Drawing.Point(636, 795);
            this.btn_ToAdd.Name = "btn_ToAdd";
            this.btn_ToAdd.Size = new System.Drawing.Size(251, 83);
            this.btn_ToAdd.TabIndex = 126;
            this.btn_ToAdd.Text = "追加";
            this.btn_ToAdd.UseVisualStyleBackColor = true;
            this.btn_ToAdd.Click += new System.EventHandler(this.btn_ToAdd_Click);
            // 
            // ItemAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ToAdd);
            this.Controls.Add(this.lbl_UniqueIDInfo);
            this.Controls.Add(this.txt_TitleID);
            this.Controls.Add(this.lbl_TitleName);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.dgv_ItemRe);
            this.Controls.Add(this.lbl_ReleaseDateInfo);
            this.Controls.Add(this.lbl_GenreInfo);
            this.Controls.Add(this.lbl_ArtistInfo);
            this.Controls.Add(this.lbl_TitleNameInfo);
            this.Controls.Add(this.lbl_ReleaseDate);
            this.Controls.Add(this.lbl_Genre);
            this.Controls.Add(this.lbl_Artist);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_UniqueID);
            this.Controls.Add(this.lbl_TopTitle);
            this.Controls.Add(this.label9);
            this.Name = "ItemAdd";
            this.Size = new System.Drawing.Size(1632, 1042);
            this.Load += new System.EventHandler(this.ItemAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemRe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_ReleaseDateInfo;
        private System.Windows.Forms.Label lbl_GenreInfo;
        private System.Windows.Forms.Label lbl_ArtistInfo;
        private System.Windows.Forms.Label lbl_TitleNameInfo;
        private System.Windows.Forms.Label lbl_ReleaseDate;
        private System.Windows.Forms.Label lbl_Genre;
        private System.Windows.Forms.Label lbl_Artist;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_UniqueID;
        private System.Windows.Forms.Label lbl_TopTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_TitleName;
        private System.Windows.Forms.TextBox txt_TitleID;
        private System.Windows.Forms.Label lbl_UniqueIDInfo;
        private System.Windows.Forms.Button btn_ToAdd;
        public System.Windows.Forms.DataGridView dgv_ItemRe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
