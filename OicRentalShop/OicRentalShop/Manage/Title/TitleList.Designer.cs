﻿namespace OicRentalShop.Manage.Title
{
    partial class TitleList
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dgv_TitleInfo = new System.Windows.Forms.DataGridView();
            this.txt_Artist = new System.Windows.Forms.TextBox();
            this.lbl_Artist = new System.Windows.Forms.Label();
            this.cmb_Genre = new System.Windows.Forms.ComboBox();
            this.cmb_Old_New = new System.Windows.Forms.ComboBox();
            this.lbl_Genre = new System.Windows.Forms.Label();
            this.lbl_Old_New = new System.Windows.Forms.Label();
            this.cmb_Type = new System.Windows.Forms.ComboBox();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.txt_TitleID = new System.Windows.Forms.TextBox();
            this.lbl_TitleID = new System.Windows.Forms.Label();
            this.txt_TitleName = new System.Windows.Forms.TextBox();
            this.lbl_TitleName = new System.Windows.Forms.Label();
            this.lbl_SearchC = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_TopTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TitleInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Search.Font = new System.Drawing.Font("Meiryo UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Location = new System.Drawing.Point(1165, 251);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(114, 97);
            this.btn_Search.TabIndex = 130;
            this.btn_Search.Text = "検索";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Add.Font = new System.Drawing.Font("Meiryo UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_Add.Location = new System.Drawing.Point(1418, 926);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(174, 85);
            this.btn_Add.TabIndex = 128;
            this.btn_Add.Text = "追加";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dgv_TitleInfo
            // 
            this.dgv_TitleInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TitleInfo.Location = new System.Drawing.Point(16, 390);
            this.dgv_TitleInfo.Name = "dgv_TitleInfo";
            this.dgv_TitleInfo.RowTemplate.Height = 21;
            this.dgv_TitleInfo.Size = new System.Drawing.Size(1317, 621);
            this.dgv_TitleInfo.TabIndex = 126;
            this.dgv_TitleInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TitleInfo_CellContentClick);
            // 
            // txt_Artist
            // 
            this.txt_Artist.Location = new System.Drawing.Point(584, 318);
            this.txt_Artist.Multiline = true;
            this.txt_Artist.Name = "txt_Artist";
            this.txt_Artist.Size = new System.Drawing.Size(180, 30);
            this.txt_Artist.TabIndex = 125;
            // 
            // lbl_Artist
            // 
            this.lbl_Artist.AutoSize = true;
            this.lbl_Artist.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Artist.Location = new System.Drawing.Point(401, 321);
            this.lbl_Artist.Name = "lbl_Artist";
            this.lbl_Artist.Size = new System.Drawing.Size(164, 27);
            this.lbl_Artist.TabIndex = 124;
            this.lbl_Artist.Text = "アーティスト名";
            // 
            // cmb_Genre
            // 
            this.cmb_Genre.FormattingEnabled = true;
            this.cmb_Genre.Items.AddRange(new object[] {
            "全ジャンル"});
            this.cmb_Genre.Location = new System.Drawing.Point(932, 321);
            this.cmb_Genre.Name = "cmb_Genre";
            this.cmb_Genre.Size = new System.Drawing.Size(180, 20);
            this.cmb_Genre.TabIndex = 123;
            this.cmb_Genre.Text = "全ジャンル";
            // 
            // cmb_Old_New
            // 
            this.cmb_Old_New.FormattingEnabled = true;
            this.cmb_Old_New.Items.AddRange(new object[] {
            "新作",
            "旧作"});
            this.cmb_Old_New.Location = new System.Drawing.Point(177, 328);
            this.cmb_Old_New.Name = "cmb_Old_New";
            this.cmb_Old_New.Size = new System.Drawing.Size(153, 20);
            this.cmb_Old_New.TabIndex = 122;
            // 
            // lbl_Genre
            // 
            this.lbl_Genre.AutoSize = true;
            this.lbl_Genre.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Genre.Location = new System.Drawing.Point(789, 321);
            this.lbl_Genre.Name = "lbl_Genre";
            this.lbl_Genre.Size = new System.Drawing.Size(98, 27);
            this.lbl_Genre.TabIndex = 121;
            this.lbl_Genre.Text = "ジャンル";
            // 
            // lbl_Old_New
            // 
            this.lbl_Old_New.AutoSize = true;
            this.lbl_Old_New.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Old_New.Location = new System.Drawing.Point(35, 321);
            this.lbl_Old_New.Name = "lbl_Old_New";
            this.lbl_Old_New.Size = new System.Drawing.Size(139, 27);
            this.lbl_Old_New.TabIndex = 120;
            this.lbl_Old_New.Text = "旧作/新作";
            // 
            // cmb_Type
            // 
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Items.AddRange(new object[] {
            "CD",
            "DVD",
            "アルバム",
            "シングル",
            "すべて"});
            this.cmb_Type.Location = new System.Drawing.Point(932, 251);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(180, 20);
            this.cmb_Type.TabIndex = 119;
            this.cmb_Type.Text = "すべて";
            this.cmb_Type.SelectedIndexChanged += new System.EventHandler(this.cmb_Type_SelectedIndexChanged);
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Type.Location = new System.Drawing.Point(789, 244);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(121, 27);
            this.lbl_Type.TabIndex = 118;
            this.lbl_Type.Text = "CD/DVD";
            // 
            // txt_TitleID
            // 
            this.txt_TitleID.Location = new System.Drawing.Point(550, 241);
            this.txt_TitleID.Multiline = true;
            this.txt_TitleID.Name = "txt_TitleID";
            this.txt_TitleID.Size = new System.Drawing.Size(180, 30);
            this.txt_TitleID.TabIndex = 115;
            // 
            // lbl_TitleID
            // 
            this.lbl_TitleID.AutoSize = true;
            this.lbl_TitleID.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_TitleID.Location = new System.Drawing.Point(401, 244);
            this.lbl_TitleID.Name = "lbl_TitleID";
            this.lbl_TitleID.Size = new System.Drawing.Size(123, 27);
            this.lbl_TitleID.TabIndex = 114;
            this.lbl_TitleID.Text = "タイトルID";
            // 
            // txt_TitleName
            // 
            this.txt_TitleName.Location = new System.Drawing.Point(177, 241);
            this.txt_TitleName.Multiline = true;
            this.txt_TitleName.Name = "txt_TitleName";
            this.txt_TitleName.Size = new System.Drawing.Size(180, 30);
            this.txt_TitleName.TabIndex = 113;
            // 
            // lbl_TitleName
            // 
            this.lbl_TitleName.AutoSize = true;
            this.lbl_TitleName.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_TitleName.Location = new System.Drawing.Point(35, 244);
            this.lbl_TitleName.Name = "lbl_TitleName";
            this.lbl_TitleName.Size = new System.Drawing.Size(124, 27);
            this.lbl_TitleName.TabIndex = 112;
            this.lbl_TitleName.Text = "タイトル名";
            // 
            // lbl_SearchC
            // 
            this.lbl_SearchC.AutoSize = true;
            this.lbl_SearchC.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_SearchC.Location = new System.Drawing.Point(34, 148);
            this.lbl_SearchC.Name = "lbl_SearchC";
            this.lbl_SearchC.Size = new System.Drawing.Size(159, 35);
            this.lbl_SearchC.TabIndex = 111;
            this.lbl_SearchC.Text = "検索条件";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(1353, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1, 900);
            this.label8.TabIndex = 110;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(-278, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1632, 1);
            this.label7.TabIndex = 109;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(-2, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1660, 1);
            this.label9.TabIndex = 108;
            // 
            // lbl_TopTitle
            // 
            this.lbl_TopTitle.AutoSize = true;
            this.lbl_TopTitle.Font = new System.Drawing.Font("MS UI Gothic", 65.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_TopTitle.Location = new System.Drawing.Point(580, 26);
            this.lbl_TopTitle.Name = "lbl_TopTitle";
            this.lbl_TopTitle.Size = new System.Drawing.Size(473, 87);
            this.lbl_TopTitle.TabIndex = 107;
            this.lbl_TopTitle.Text = "タイトル管理";
            // 
            // TitleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_TitleInfo);
            this.Controls.Add(this.txt_Artist);
            this.Controls.Add(this.lbl_Artist);
            this.Controls.Add(this.cmb_Genre);
            this.Controls.Add(this.cmb_Old_New);
            this.Controls.Add(this.lbl_Genre);
            this.Controls.Add(this.lbl_Old_New);
            this.Controls.Add(this.cmb_Type);
            this.Controls.Add(this.lbl_Type);
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
            this.Size = new System.Drawing.Size(1661, 1042);
            this.Load += new System.EventHandler(this.TitleList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TitleInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dgv_TitleInfo;
        private System.Windows.Forms.TextBox txt_Artist;
        private System.Windows.Forms.Label lbl_Artist;
        private System.Windows.Forms.ComboBox cmb_Genre;
        private System.Windows.Forms.ComboBox cmb_Old_New;
        private System.Windows.Forms.Label lbl_Genre;
        private System.Windows.Forms.Label lbl_Old_New;
        private System.Windows.Forms.ComboBox cmb_Type;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.TextBox txt_TitleID;
        private System.Windows.Forms.Label lbl_TitleID;
        private System.Windows.Forms.TextBox txt_TitleName;
        private System.Windows.Forms.Label lbl_TitleName;
        private System.Windows.Forms.Label lbl_SearchC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_TopTitle;
    }
}
