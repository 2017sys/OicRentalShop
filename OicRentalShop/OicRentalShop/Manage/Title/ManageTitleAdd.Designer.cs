namespace OicRentalShop.Manage.Title
{
    partial class ManageTitleAdd
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
            this.cmb_Artist = new System.Windows.Forms.ComboBox();
            this.cmb_Genre = new System.Windows.Forms.ComboBox();
            this.txt_ReleaseDay = new System.Windows.Forms.TextBox();
            this.lbl_ReleaseDay = new System.Windows.Forms.Label();
            this.txt_TitleID = new System.Windows.Forms.TextBox();
            this.lbl_TitleID = new System.Windows.Forms.Label();
            this.btn_Toadd = new System.Windows.Forms.Button();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.cmb_Format = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.dgv_ItemRe = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl_Genre = new System.Windows.Forms.Label();
            this.lbl_Artist = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Format = new System.Windows.Forms.Label();
            this.lbl_TopTitle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Correction = new System.Windows.Forms.Button();
            this.btn_ReturnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemRe)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Artist
            // 
            this.cmb_Artist.FormattingEnabled = true;
            this.cmb_Artist.Location = new System.Drawing.Point(394, 567);
            this.cmb_Artist.Name = "cmb_Artist";
            this.cmb_Artist.Size = new System.Drawing.Size(310, 20);
            this.cmb_Artist.TabIndex = 166;
            this.cmb_Artist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_Artist_KeyDown);
            // 
            // cmb_Genre
            // 
            this.cmb_Genre.FormattingEnabled = true;
            this.cmb_Genre.Location = new System.Drawing.Point(394, 666);
            this.cmb_Genre.Name = "cmb_Genre";
            this.cmb_Genre.Size = new System.Drawing.Size(310, 20);
            this.cmb_Genre.TabIndex = 165;
            // 
            // txt_ReleaseDay
            // 
            this.txt_ReleaseDay.Location = new System.Drawing.Point(394, 768);
            this.txt_ReleaseDay.Name = "txt_ReleaseDay";
            this.txt_ReleaseDay.Size = new System.Drawing.Size(310, 19);
            this.txt_ReleaseDay.TabIndex = 164;
            // 
            // lbl_ReleaseDay
            // 
            this.lbl_ReleaseDay.AutoSize = true;
            this.lbl_ReleaseDay.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_ReleaseDay.Location = new System.Drawing.Point(198, 758);
            this.lbl_ReleaseDay.Name = "lbl_ReleaseDay";
            this.lbl_ReleaseDay.Size = new System.Drawing.Size(88, 21);
            this.lbl_ReleaseDay.TabIndex = 163;
            this.lbl_ReleaseDay.Text = "発売日：";
            // 
            // txt_TitleID
            // 
            this.txt_TitleID.Location = new System.Drawing.Point(394, 263);
            this.txt_TitleID.Multiline = true;
            this.txt_TitleID.Name = "txt_TitleID";
            this.txt_TitleID.Size = new System.Drawing.Size(310, 30);
            this.txt_TitleID.TabIndex = 162;
            this.txt_TitleID.TextChanged += new System.EventHandler(this.txt_TitleID_TextChanged);
            // 
            // lbl_TitleID
            // 
            this.lbl_TitleID.AutoSize = true;
            this.lbl_TitleID.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_TitleID.Location = new System.Drawing.Point(171, 266);
            this.lbl_TitleID.Name = "lbl_TitleID";
            this.lbl_TitleID.Size = new System.Drawing.Size(109, 21);
            this.lbl_TitleID.TabIndex = 161;
            this.lbl_TitleID.Text = "タイトルID：";
            // 
            // btn_Toadd
            // 
            this.btn_Toadd.Font = new System.Drawing.Font("Meiryo UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_Toadd.Location = new System.Drawing.Point(1165, 893);
            this.btn_Toadd.Name = "btn_Toadd";
            this.btn_Toadd.Size = new System.Drawing.Size(174, 85);
            this.btn_Toadd.TabIndex = 160;
            this.btn_Toadd.Text = "追加";
            this.btn_Toadd.UseVisualStyleBackColor = true;
            this.btn_Toadd.Click += new System.EventHandler(this.btn_Toadd_Click);
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(394, 359);
            this.txt_Title.Multiline = true;
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(310, 30);
            this.txt_Title.TabIndex = 159;
            // 
            // cmb_Format
            // 
            this.cmb_Format.FormattingEnabled = true;
            this.cmb_Format.Items.AddRange(new object[] {
            "シングル",
            "アルバム",
            "DVD"});
            this.cmb_Format.Location = new System.Drawing.Point(394, 461);
            this.cmb_Format.Name = "cmb_Format";
            this.cmb_Format.Size = new System.Drawing.Size(310, 20);
            this.cmb_Format.TabIndex = 158;
            this.cmb_Format.SelectedIndexChanged += new System.EventHandler(this.cmb_Format_SelectedIndexChanged);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Meiryo UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_Add.Location = new System.Drawing.Point(1389, 893);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(174, 85);
            this.btn_Add.TabIndex = 157;
            this.btn_Add.Text = "登録";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Meiryo UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_Clear.Location = new System.Drawing.Point(888, 893);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(174, 85);
            this.btn_Clear.TabIndex = 156;
            this.btn_Clear.Text = "クリア";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // dgv_ItemRe
            // 
            this.dgv_ItemRe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ItemRe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column2,
            this.btn_Delete});
            this.dgv_ItemRe.Location = new System.Drawing.Point(864, 197);
            this.dgv_ItemRe.Name = "dgv_ItemRe";
            this.dgv_ItemRe.RowTemplate.Height = 21;
            this.dgv_ItemRe.Size = new System.Drawing.Size(745, 650);
            this.dgv_ItemRe.TabIndex = 155;
            this.dgv_ItemRe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ItemRe_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "タイトルID";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "タイトル名";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "アーティスト";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "発売日";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ジャンル";
            this.Column5.Name = "Column5";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "形式";
            this.Column2.Name = "Column2";
            // 
            // btn_Delete
            // 
            this.btn_Delete.HeaderText = "行削除";
            this.btn_Delete.Name = "btn_Delete";
            // 
            // lbl_Genre
            // 
            this.lbl_Genre.AutoSize = true;
            this.lbl_Genre.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Genre.Location = new System.Drawing.Point(196, 659);
            this.lbl_Genre.Name = "lbl_Genre";
            this.lbl_Genre.Size = new System.Drawing.Size(90, 21);
            this.lbl_Genre.TabIndex = 154;
            this.lbl_Genre.Text = "ジャンル：";
            // 
            // lbl_Artist
            // 
            this.lbl_Artist.AutoSize = true;
            this.lbl_Artist.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Artist.Location = new System.Drawing.Point(158, 560);
            this.lbl_Artist.Name = "lbl_Artist";
            this.lbl_Artist.Size = new System.Drawing.Size(120, 21);
            this.lbl_Artist.TabIndex = 153;
            this.lbl_Artist.Text = "アーティスト：";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.Location = new System.Drawing.Point(170, 362);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(110, 21);
            this.lbl_Title.TabIndex = 152;
            this.lbl_Title.Text = "タイトル名：";
            // 
            // lbl_Format
            // 
            this.lbl_Format.AutoSize = true;
            this.lbl_Format.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_Format.Location = new System.Drawing.Point(226, 461);
            this.lbl_Format.Name = "lbl_Format";
            this.lbl_Format.Size = new System.Drawing.Size(66, 21);
            this.lbl_Format.TabIndex = 151;
            this.lbl_Format.Text = "形式：";
            // 
            // lbl_TopTitle
            // 
            this.lbl_TopTitle.AutoSize = true;
            this.lbl_TopTitle.Font = new System.Drawing.Font("MS UI Gothic", 65.25F, System.Drawing.FontStyle.Bold);
            this.lbl_TopTitle.Location = new System.Drawing.Point(580, 26);
            this.lbl_TopTitle.Name = "lbl_TopTitle";
            this.lbl_TopTitle.Size = new System.Drawing.Size(473, 87);
            this.lbl_TopTitle.TabIndex = 150;
            this.lbl_TopTitle.Text = "タイトル登録";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(-2, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1660, 1);
            this.label9.TabIndex = 149;
            // 
            // btn_Correction
            // 
            this.btn_Correction.Font = new System.Drawing.Font("Meiryo UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_Correction.Location = new System.Drawing.Point(1421, 893);
            this.btn_Correction.Name = "btn_Correction";
            this.btn_Correction.Size = new System.Drawing.Size(174, 85);
            this.btn_Correction.TabIndex = 167;
            this.btn_Correction.Text = "修正";
            this.btn_Correction.UseVisualStyleBackColor = true;
            this.btn_Correction.Visible = false;
            this.btn_Correction.Click += new System.EventHandler(this.btn_Correction_Click);
            // 
            // btn_ReturnAdd
            // 
            this.btn_ReturnAdd.Font = new System.Drawing.Font("Meiryo UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_ReturnAdd.Location = new System.Drawing.Point(926, 893);
            this.btn_ReturnAdd.Name = "btn_ReturnAdd";
            this.btn_ReturnAdd.Size = new System.Drawing.Size(174, 85);
            this.btn_ReturnAdd.TabIndex = 168;
            this.btn_ReturnAdd.Text = "戻る";
            this.btn_ReturnAdd.UseVisualStyleBackColor = true;
            this.btn_ReturnAdd.Visible = false;
            this.btn_ReturnAdd.Click += new System.EventHandler(this.btn_ReturnAdd_Click);
            // 
            // ManageTitleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btn_ReturnAdd);
            this.Controls.Add(this.btn_Correction);
            this.Controls.Add(this.cmb_Artist);
            this.Controls.Add(this.cmb_Genre);
            this.Controls.Add(this.txt_ReleaseDay);
            this.Controls.Add(this.lbl_ReleaseDay);
            this.Controls.Add(this.txt_TitleID);
            this.Controls.Add(this.lbl_TitleID);
            this.Controls.Add(this.btn_Toadd);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.cmb_Format);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.dgv_ItemRe);
            this.Controls.Add(this.lbl_Genre);
            this.Controls.Add(this.lbl_Artist);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_Format);
            this.Controls.Add(this.lbl_TopTitle);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageTitleAdd";
            this.Size = new System.Drawing.Size(1661, 1042);
            this.Load += new System.EventHandler(this.ManageTitleAdd_Load);
            this.VisibleChanged += new System.EventHandler(this.ManageTitleAdd_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemRe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Artist;
        private System.Windows.Forms.ComboBox cmb_Genre;
        private System.Windows.Forms.TextBox txt_ReleaseDay;
        private System.Windows.Forms.Label lbl_ReleaseDay;
        private System.Windows.Forms.TextBox txt_TitleID;
        private System.Windows.Forms.Label lbl_TitleID;
        private System.Windows.Forms.Button btn_Toadd;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.ComboBox cmb_Format;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.DataGridView dgv_ItemRe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Delete;
        private System.Windows.Forms.Label lbl_Genre;
        private System.Windows.Forms.Label lbl_Artist;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Format;
        private System.Windows.Forms.Label lbl_TopTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Correction;
        private System.Windows.Forms.Button btn_ReturnAdd;

    }
}
