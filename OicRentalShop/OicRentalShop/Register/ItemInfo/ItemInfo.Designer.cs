namespace OicRentalShop.Register.ItemInfo
{
    partial class ItemInfo
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
            this.cmb_Order = new System.Windows.Forms.ComboBox();
            this.lbl_Order = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ArtistName = new System.Windows.Forms.TextBox();
            this.lbl_ArtistName = new System.Windows.Forms.Label();
            this.txt_ItemID = new System.Windows.Forms.TextBox();
            this.lbl_ItemID = new System.Windows.Forms.Label();
            this.cmb_Genre = new System.Windows.Forms.ComboBox();
            this.cmb_State = new System.Windows.Forms.ComboBox();
            this.cmb_OLDNEW = new System.Windows.Forms.ComboBox();
            this.txt_TitleID = new System.Windows.Forms.TextBox();
            this.txt_TitleName = new System.Windows.Forms.TextBox();
            this.lbl_Genre = new System.Windows.Forms.Label();
            this.lbl_State = new System.Windows.Forms.Label();
            this.lbl_OLDNEW = new System.Windows.Forms.Label();
            this.lbl_TitleID = new System.Windows.Forms.Label();
            this.lbl_TitleName = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_TopTitle = new System.Windows.Forms.Label();
            this.lbl_SearchC = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_ItemInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Order
            // 
            this.cmb_Order.FormattingEnabled = true;
            this.cmb_Order.Items.AddRange(new object[] {
            "CD",
            "DVD"});
            this.cmb_Order.Location = new System.Drawing.Point(537, 176);
            this.cmb_Order.Name = "cmb_Order";
            this.cmb_Order.Size = new System.Drawing.Size(60, 20);
            this.cmb_Order.TabIndex = 102;
            // 
            // lbl_Order
            // 
            this.lbl_Order.AutoSize = true;
            this.lbl_Order.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Order.Location = new System.Drawing.Point(474, 178);
            this.lbl_Order.Name = "lbl_Order";
            this.lbl_Order.Size = new System.Drawing.Size(63, 13);
            this.lbl_Order.TabIndex = 101;
            this.lbl_Order.Text = "昇順降順";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(-2, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(950, 1);
            this.label8.TabIndex = 100;
            // 
            // txt_ArtistName
            // 
            this.txt_ArtistName.Location = new System.Drawing.Point(249, 176);
            this.txt_ArtistName.Name = "txt_ArtistName";
            this.txt_ArtistName.Size = new System.Drawing.Size(76, 19);
            this.txt_ArtistName.TabIndex = 99;
            // 
            // lbl_ArtistName
            // 
            this.lbl_ArtistName.AutoSize = true;
            this.lbl_ArtistName.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_ArtistName.Location = new System.Drawing.Point(159, 177);
            this.lbl_ArtistName.Name = "lbl_ArtistName";
            this.lbl_ArtistName.Size = new System.Drawing.Size(84, 13);
            this.lbl_ArtistName.TabIndex = 98;
            this.lbl_ArtistName.Text = "アーティスト名";
            // 
            // txt_ItemID
            // 
            this.txt_ItemID.Location = new System.Drawing.Point(388, 136);
            this.txt_ItemID.Name = "txt_ItemID";
            this.txt_ItemID.Size = new System.Drawing.Size(76, 19);
            this.txt_ItemID.TabIndex = 97;
            // 
            // lbl_ItemID
            // 
            this.lbl_ItemID.AutoSize = true;
            this.lbl_ItemID.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_ItemID.Location = new System.Drawing.Point(341, 142);
            this.lbl_ItemID.Name = "lbl_ItemID";
            this.lbl_ItemID.Size = new System.Drawing.Size(45, 12);
            this.lbl_ItemID.TabIndex = 96;
            this.lbl_ItemID.Text = "商品ＩＤ";
            // 
            // cmb_Genre
            // 
            this.cmb_Genre.FormattingEnabled = true;
            this.cmb_Genre.Location = new System.Drawing.Point(388, 175);
            this.cmb_Genre.Name = "cmb_Genre";
            this.cmb_Genre.Size = new System.Drawing.Size(80, 20);
            this.cmb_Genre.TabIndex = 95;
            // 
            // cmb_State
            // 
            this.cmb_State.FormattingEnabled = true;
            this.cmb_State.Items.AddRange(new object[] {
            "新作",
            "旧作"});
            this.cmb_State.Location = new System.Drawing.Point(98, 175);
            this.cmb_State.Name = "cmb_State";
            this.cmb_State.Size = new System.Drawing.Size(40, 20);
            this.cmb_State.TabIndex = 94;
            // 
            // cmb_OLDNEW
            // 
            this.cmb_OLDNEW.FormattingEnabled = true;
            this.cmb_OLDNEW.Items.AddRange(new object[] {
            "CD",
            "DVD"});
            this.cmb_OLDNEW.Location = new System.Drawing.Point(537, 136);
            this.cmb_OLDNEW.Name = "cmb_OLDNEW";
            this.cmb_OLDNEW.Size = new System.Drawing.Size(60, 20);
            this.cmb_OLDNEW.TabIndex = 93;
            // 
            // txt_TitleID
            // 
            this.txt_TitleID.Location = new System.Drawing.Point(249, 136);
            this.txt_TitleID.Name = "txt_TitleID";
            this.txt_TitleID.Size = new System.Drawing.Size(76, 19);
            this.txt_TitleID.TabIndex = 92;
            // 
            // txt_TitleName
            // 
            this.txt_TitleName.Location = new System.Drawing.Point(98, 135);
            this.txt_TitleName.Name = "txt_TitleName";
            this.txt_TitleName.Size = new System.Drawing.Size(76, 19);
            this.txt_TitleName.TabIndex = 91;
            // 
            // lbl_Genre
            // 
            this.lbl_Genre.AutoSize = true;
            this.lbl_Genre.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Genre.Location = new System.Drawing.Point(331, 177);
            this.lbl_Genre.Name = "lbl_Genre";
            this.lbl_Genre.Size = new System.Drawing.Size(52, 13);
            this.lbl_Genre.TabIndex = 90;
            this.lbl_Genre.Text = "ジャンル";
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_State.Location = new System.Drawing.Point(21, 177);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(71, 13);
            this.lbl_State.TabIndex = 89;
            this.lbl_State.Text = "旧作/新作";
            // 
            // lbl_OLDNEW
            // 
            this.lbl_OLDNEW.AutoSize = true;
            this.lbl_OLDNEW.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_OLDNEW.Location = new System.Drawing.Point(470, 141);
            this.lbl_OLDNEW.Name = "lbl_OLDNEW";
            this.lbl_OLDNEW.Size = new System.Drawing.Size(61, 13);
            this.lbl_OLDNEW.TabIndex = 88;
            this.lbl_OLDNEW.Text = "CD/DVD";
            // 
            // lbl_TitleID
            // 
            this.lbl_TitleID.AutoSize = true;
            this.lbl_TitleID.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_TitleID.Location = new System.Drawing.Point(181, 142);
            this.lbl_TitleID.Name = "lbl_TitleID";
            this.lbl_TitleID.Size = new System.Drawing.Size(62, 13);
            this.lbl_TitleID.TabIndex = 87;
            this.lbl_TitleID.Text = "タイトルID";
            // 
            // lbl_TitleName
            // 
            this.lbl_TitleName.AutoSize = true;
            this.lbl_TitleName.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_TitleName.Location = new System.Drawing.Point(21, 142);
            this.lbl_TitleName.Name = "lbl_TitleName";
            this.lbl_TitleName.Size = new System.Drawing.Size(63, 13);
            this.lbl_TitleName.TabIndex = 86;
            this.lbl_TitleName.Text = "タイトル名";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Location = new System.Drawing.Point(711, 126);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(113, 86);
            this.btn_Search.TabIndex = 85;
            this.btn_Search.Text = "検索";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // lbl_TopTitle
            // 
            this.lbl_TopTitle.AutoSize = true;
            this.lbl_TopTitle.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_TopTitle.Location = new System.Drawing.Point(251, 5);
            this.lbl_TopTitle.Name = "lbl_TopTitle";
            this.lbl_TopTitle.Size = new System.Drawing.Size(288, 64);
            this.lbl_TopTitle.TabIndex = 84;
            this.lbl_TopTitle.Text = "商品情報";
            // 
            // lbl_SearchC
            // 
            this.lbl_SearchC.AutoSize = true;
            this.lbl_SearchC.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_SearchC.Location = new System.Drawing.Point(5, 95);
            this.lbl_SearchC.Name = "lbl_SearchC";
            this.lbl_SearchC.Size = new System.Drawing.Size(89, 19);
            this.lbl_SearchC.TabIndex = 83;
            this.lbl_SearchC.Text = "検索条件";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(-2, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(950, 1);
            this.label9.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(-2, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(950, 1);
            this.label7.TabIndex = 81;
            // 
            // dgv_ItemInfo
            // 
            this.dgv_ItemInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ItemInfo.Location = new System.Drawing.Point(0, 214);
            this.dgv_ItemInfo.Name = "dgv_ItemInfo";
            this.dgv_ItemInfo.RowTemplate.Height = 21;
            this.dgv_ItemInfo.Size = new System.Drawing.Size(948, 377);
            this.dgv_ItemInfo.TabIndex = 80;
            // 
            // ItemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmb_Order);
            this.Controls.Add(this.lbl_Order);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_ArtistName);
            this.Controls.Add(this.lbl_ArtistName);
            this.Controls.Add(this.txt_ItemID);
            this.Controls.Add(this.lbl_ItemID);
            this.Controls.Add(this.cmb_Genre);
            this.Controls.Add(this.cmb_State);
            this.Controls.Add(this.cmb_OLDNEW);
            this.Controls.Add(this.txt_TitleID);
            this.Controls.Add(this.txt_TitleName);
            this.Controls.Add(this.lbl_Genre);
            this.Controls.Add(this.lbl_State);
            this.Controls.Add(this.lbl_OLDNEW);
            this.Controls.Add(this.lbl_TitleID);
            this.Controls.Add(this.lbl_TitleName);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_TopTitle);
            this.Controls.Add(this.lbl_SearchC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_ItemInfo);
            this.Name = "ItemInfo";
            this.Size = new System.Drawing.Size(948, 591);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Order;
        private System.Windows.Forms.Label lbl_Order;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ArtistName;
        private System.Windows.Forms.Label lbl_ArtistName;
        private System.Windows.Forms.TextBox txt_ItemID;
        private System.Windows.Forms.Label lbl_ItemID;
        private System.Windows.Forms.ComboBox cmb_Genre;
        private System.Windows.Forms.ComboBox cmb_State;
        private System.Windows.Forms.ComboBox cmb_OLDNEW;
        private System.Windows.Forms.TextBox txt_TitleID;
        private System.Windows.Forms.TextBox txt_TitleName;
        private System.Windows.Forms.Label lbl_Genre;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.Label lbl_OLDNEW;
        private System.Windows.Forms.Label lbl_TitleID;
        private System.Windows.Forms.Label lbl_TitleName;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_TopTitle;
        private System.Windows.Forms.Label lbl_SearchC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_ItemInfo;
    }
}
