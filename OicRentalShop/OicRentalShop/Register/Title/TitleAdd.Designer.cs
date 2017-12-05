﻿namespace OicRentalShop.Register.Title
{
    partial class TitleAdd
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
            this.btn_Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Genre = new System.Windows.Forms.Label();
            this.lbl_Artist = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Format = new System.Windows.Forms.Label();
            this.lbl_TopTitle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_Format = new System.Windows.Forms.ComboBox();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.txt_Artist = new System.Windows.Forms.TextBox();
            this.txt_Genre = new System.Windows.Forms.TextBox();
            this.btn_Toadd = new System.Windows.Forms.Button();
            this.lbl_TaitleID = new System.Windows.Forms.Label();
            this.txt_TaitleID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemRe)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Add.Location = new System.Drawing.Point(788, 509);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(97, 70);
            this.btn_Add.TabIndex = 136;
            this.btn_Add.Text = "登録";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_clear.Location = new System.Drawing.Point(648, 509);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(97, 70);
            this.btn_clear.TabIndex = 135;
            this.btn_clear.Text = "クリア";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // dgv_ItemRe
            // 
            this.dgv_ItemRe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ItemRe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btn_Delete,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_ItemRe.Location = new System.Drawing.Point(529, 111);
            this.dgv_ItemRe.Name = "dgv_ItemRe";
            this.dgv_ItemRe.RowTemplate.Height = 21;
            this.dgv_ItemRe.Size = new System.Drawing.Size(392, 380);
            this.dgv_ItemRe.TabIndex = 134;
            this.dgv_ItemRe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ItemRe_CellContentClick);
            // 
            // btn_Delete
            // 
            this.btn_Delete.HeaderText = "行削除";
            this.btn_Delete.Name = "btn_Delete";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "タイトルID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "形式";
            this.Column2.Name = "Column2";
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
            // Column5
            // 
            this.Column5.HeaderText = "ジャンル";
            this.Column5.Name = "Column5";
            // 
            // lbl_Genre
            // 
            this.lbl_Genre.AutoSize = true;
            this.lbl_Genre.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Genre.Location = new System.Drawing.Point(71, 309);
            this.lbl_Genre.Name = "lbl_Genre";
            this.lbl_Genre.Size = new System.Drawing.Size(90, 21);
            this.lbl_Genre.TabIndex = 127;
            this.lbl_Genre.Text = "ジャンル：";
            // 
            // lbl_Artist
            // 
            this.lbl_Artist.AutoSize = true;
            this.lbl_Artist.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Artist.Location = new System.Drawing.Point(41, 362);
            this.lbl_Artist.Name = "lbl_Artist";
            this.lbl_Artist.Size = new System.Drawing.Size(120, 21);
            this.lbl_Artist.TabIndex = 126;
            this.lbl_Artist.Text = "アーティスト：";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Title.Location = new System.Drawing.Point(61, 246);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(110, 21);
            this.lbl_Title.TabIndex = 125;
            this.lbl_Title.Text = "タイトル名：";
            // 
            // lbl_Format
            // 
            this.lbl_Format.AutoSize = true;
            this.lbl_Format.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Format.Location = new System.Drawing.Point(95, 421);
            this.lbl_Format.Name = "lbl_Format";
            this.lbl_Format.Size = new System.Drawing.Size(66, 21);
            this.lbl_Format.TabIndex = 124;
            this.lbl_Format.Text = "形式：";
            // 
            // lbl_TopTitle
            // 
            this.lbl_TopTitle.AutoSize = true;
            this.lbl_TopTitle.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_TopTitle.Location = new System.Drawing.Point(252, 11);
            this.lbl_TopTitle.Name = "lbl_TopTitle";
            this.lbl_TopTitle.Size = new System.Drawing.Size(349, 64);
            this.lbl_TopTitle.TabIndex = 123;
            this.lbl_TopTitle.Text = "タイトル登録";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(-1, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(950, 1);
            this.label9.TabIndex = 122;
            // 
            // cmb_Format
            // 
            this.cmb_Format.FormattingEnabled = true;
            this.cmb_Format.Items.AddRange(new object[] {
            "シングル",
            "アルバム",
            "DVD"});
            this.cmb_Format.Location = new System.Drawing.Point(227, 421);
            this.cmb_Format.Name = "cmb_Format";
            this.cmb_Format.Size = new System.Drawing.Size(176, 20);
            this.cmb_Format.TabIndex = 137;
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(227, 246);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(281, 19);
            this.txt_Title.TabIndex = 138;
            this.txt_Title.Text = "いいい";
            // 
            // txt_Artist
            // 
            this.txt_Artist.Location = new System.Drawing.Point(227, 362);
            this.txt_Artist.Name = "txt_Artist";
            this.txt_Artist.Size = new System.Drawing.Size(281, 19);
            this.txt_Artist.TabIndex = 139;
            this.txt_Artist.Text = "ううう";
            // 
            // txt_Genre
            // 
            this.txt_Genre.Location = new System.Drawing.Point(227, 309);
            this.txt_Genre.Name = "txt_Genre";
            this.txt_Genre.Size = new System.Drawing.Size(281, 19);
            this.txt_Genre.TabIndex = 140;
            this.txt_Genre.Text = "えええ";
            // 
            // btn_Toadd
            // 
            this.btn_Toadd.Location = new System.Drawing.Point(386, 525);
            this.btn_Toadd.Name = "btn_Toadd";
            this.btn_Toadd.Size = new System.Drawing.Size(75, 23);
            this.btn_Toadd.TabIndex = 142;
            this.btn_Toadd.Text = "追加";
            this.btn_Toadd.UseVisualStyleBackColor = true;
            this.btn_Toadd.Click += new System.EventHandler(this.btn_Toadd_Click);
            // 
            // lbl_TaitleID
            // 
            this.lbl_TaitleID.AutoSize = true;
            this.lbl_TaitleID.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_TaitleID.Location = new System.Drawing.Point(52, 186);
            this.lbl_TaitleID.Name = "lbl_TaitleID";
            this.lbl_TaitleID.Size = new System.Drawing.Size(109, 21);
            this.lbl_TaitleID.TabIndex = 143;
            this.lbl_TaitleID.Text = "タイトルID：";
            // 
            // txt_TaitleID
            // 
            this.txt_TaitleID.Location = new System.Drawing.Point(227, 186);
            this.txt_TaitleID.Name = "txt_TaitleID";
            this.txt_TaitleID.Size = new System.Drawing.Size(281, 19);
            this.txt_TaitleID.TabIndex = 144;
            this.txt_TaitleID.Text = "123";
            // 
            // TitleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_TaitleID);
            this.Controls.Add(this.lbl_TaitleID);
            this.Controls.Add(this.btn_Toadd);
            this.Controls.Add(this.txt_Genre);
            this.Controls.Add(this.txt_Artist);
            this.Controls.Add(this.txt_Title);
            this.Controls.Add(this.cmb_Format);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.dgv_ItemRe);
            this.Controls.Add(this.lbl_Genre);
            this.Controls.Add(this.lbl_Artist);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_Format);
            this.Controls.Add(this.lbl_TopTitle);
            this.Controls.Add(this.label9);
            this.Name = "TitleAdd";
            this.Size = new System.Drawing.Size(948, 591);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemRe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridView dgv_ItemRe;
        private System.Windows.Forms.Label lbl_Genre;
        private System.Windows.Forms.Label lbl_Artist;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Format;
        private System.Windows.Forms.Label lbl_TopTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_Format;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.TextBox txt_Artist;
        private System.Windows.Forms.TextBox txt_Genre;
        private System.Windows.Forms.Button btn_Toadd;
        private System.Windows.Forms.Label lbl_TaitleID;
        private System.Windows.Forms.TextBox txt_TaitleID;
        private System.Windows.Forms.DataGridViewButtonColumn btn_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}