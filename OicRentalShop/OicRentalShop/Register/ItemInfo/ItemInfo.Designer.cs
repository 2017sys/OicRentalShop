namespace OicRentalShop.Manage.ItemInfo
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
            this.components = new System.ComponentModel.Container();
            this.cmb_Order = new System.Windows.Forms.ComboBox();
            this.lbl_Order = new System.Windows.Forms.Label();
            this.txt_ArtistName = new System.Windows.Forms.TextBox();
            this.lbl_ArtistName = new System.Windows.Forms.Label();
            this.txt_ItemID = new System.Windows.Forms.TextBox();
            this.lbl_ItemID = new System.Windows.Forms.Label();
            this.cmb_Genre = new System.Windows.Forms.ComboBox();
            this.cmb_State = new System.Windows.Forms.ComboBox();
            this.cmb_Type = new System.Windows.Forms.ComboBox();
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
            this.database1DataSet = new OicRentalShop.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLARTISTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_ARTISTTableAdapter = new OicRentalShop.Database1DataSetTableAdapters.TBL_ARTISTTableAdapter();
            this.dgv_ItemInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLARTISTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Order
            // 
            this.cmb_Order.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.cmb_Order.FormattingEnabled = true;
            this.cmb_Order.Items.AddRange(new object[] {
            "CD",
            "DVD"});
            this.cmb_Order.Location = new System.Drawing.Point(1200, 318);
            this.cmb_Order.Name = "cmb_Order";
            this.cmb_Order.Size = new System.Drawing.Size(72, 32);
            this.cmb_Order.TabIndex = 102;
            // 
            // lbl_Order
            // 
            this.lbl_Order.AutoSize = true;
            this.lbl_Order.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Order.Location = new System.Drawing.Point(1073, 321);
            this.lbl_Order.Name = "lbl_Order";
            this.lbl_Order.Size = new System.Drawing.Size(110, 24);
            this.lbl_Order.TabIndex = 101;
            this.lbl_Order.Text = "昇順降順";
            // 
            // txt_ArtistName
            // 
            this.txt_ArtistName.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txt_ArtistName.Location = new System.Drawing.Point(580, 320);
            this.txt_ArtistName.Multiline = true;
            this.txt_ArtistName.Name = "txt_ArtistName";
            this.txt_ArtistName.Size = new System.Drawing.Size(159, 30);
            this.txt_ArtistName.TabIndex = 99;
            // 
            // lbl_ArtistName
            // 
            this.lbl_ArtistName.AutoSize = true;
            this.lbl_ArtistName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_ArtistName.Location = new System.Drawing.Point(410, 321);
            this.lbl_ArtistName.Name = "lbl_ArtistName";
            this.lbl_ArtistName.Size = new System.Drawing.Size(146, 24);
            this.lbl_ArtistName.TabIndex = 98;
            this.lbl_ArtistName.Text = "アーティスト名";
            // 
            // txt_ItemID
            // 
            this.txt_ItemID.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txt_ItemID.Location = new System.Drawing.Point(868, 242);
            this.txt_ItemID.Multiline = true;
            this.txt_ItemID.Name = "txt_ItemID";
            this.txt_ItemID.Size = new System.Drawing.Size(159, 30);
            this.txt_ItemID.TabIndex = 97;
            // 
            // lbl_ItemID
            // 
            this.lbl_ItemID.AutoSize = true;
            this.lbl_ItemID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_ItemID.Location = new System.Drawing.Point(775, 247);
            this.lbl_ItemID.Name = "lbl_ItemID";
            this.lbl_ItemID.Size = new System.Drawing.Size(87, 24);
            this.lbl_ItemID.TabIndex = 96;
            this.lbl_ItemID.Text = "商品ＩＤ";
            // 
            // cmb_Genre
            // 
            this.cmb_Genre.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.cmb_Genre.FormattingEnabled = true;
            this.cmb_Genre.Location = new System.Drawing.Point(868, 317);
            this.cmb_Genre.Name = "cmb_Genre";
            this.cmb_Genre.Size = new System.Drawing.Size(159, 32);
            this.cmb_Genre.TabIndex = 95;
            this.cmb_Genre.Text = "全ジャンル";
            // 
            // cmb_State
            // 
            this.cmb_State.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.cmb_State.FormattingEnabled = true;
            this.cmb_State.Items.AddRange(new object[] {
            "新作",
            "旧作"});
            this.cmb_State.Location = new System.Drawing.Point(311, 316);
            this.cmb_State.Name = "cmb_State";
            this.cmb_State.Size = new System.Drawing.Size(84, 32);
            this.cmb_State.TabIndex = 94;
            // 
            // cmb_Type
            // 
            this.cmb_Type.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Items.AddRange(new object[] {
            "CD",
            "DVD"});
            this.cmb_Type.Location = new System.Drawing.Point(1200, 245);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(72, 32);
            this.cmb_Type.TabIndex = 93;
            this.cmb_Type.Text = "CD";
            this.cmb_Type.SelectedIndexChanged += new System.EventHandler(this.cmb_Type_SelectedIndexChanged);
            // 
            // txt_TitleID
            // 
            this.txt_TitleID.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txt_TitleID.Location = new System.Drawing.Point(580, 241);
            this.txt_TitleID.Multiline = true;
            this.txt_TitleID.Name = "txt_TitleID";
            this.txt_TitleID.Size = new System.Drawing.Size(159, 30);
            this.txt_TitleID.TabIndex = 92;
            // 
            // txt_TitleName
            // 
            this.txt_TitleName.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.txt_TitleName.Location = new System.Drawing.Point(288, 241);
            this.txt_TitleName.Multiline = true;
            this.txt_TitleName.Name = "txt_TitleName";
            this.txt_TitleName.Size = new System.Drawing.Size(159, 30);
            this.txt_TitleName.TabIndex = 91;
            // 
            // lbl_Genre
            // 
            this.lbl_Genre.AutoSize = true;
            this.lbl_Genre.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_Genre.Location = new System.Drawing.Point(774, 319);
            this.lbl_Genre.Name = "lbl_Genre";
            this.lbl_Genre.Size = new System.Drawing.Size(88, 24);
            this.lbl_Genre.TabIndex = 90;
            this.lbl_Genre.Text = "ジャンル";
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_State.Location = new System.Drawing.Point(172, 321);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(123, 24);
            this.lbl_State.TabIndex = 89;
            this.lbl_State.Text = "旧作/新作";
            // 
            // lbl_OLDNEW
            // 
            this.lbl_OLDNEW.AutoSize = true;
            this.lbl_OLDNEW.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_OLDNEW.Location = new System.Drawing.Point(1073, 248);
            this.lbl_OLDNEW.Name = "lbl_OLDNEW";
            this.lbl_OLDNEW.Size = new System.Drawing.Size(107, 24);
            this.lbl_OLDNEW.TabIndex = 88;
            this.lbl_OLDNEW.Text = "CD/DVD";
            // 
            // lbl_TitleID
            // 
            this.lbl_TitleID.AutoSize = true;
            this.lbl_TitleID.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_TitleID.Location = new System.Drawing.Point(465, 244);
            this.lbl_TitleID.Name = "lbl_TitleID";
            this.lbl_TitleID.Size = new System.Drawing.Size(109, 24);
            this.lbl_TitleID.TabIndex = 87;
            this.lbl_TitleID.Text = "タイトルID";
            // 
            // lbl_TitleName
            // 
            this.lbl_TitleName.AutoSize = true;
            this.lbl_TitleName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_TitleName.Location = new System.Drawing.Point(172, 244);
            this.lbl_TitleName.Name = "lbl_TitleName";
            this.lbl_TitleName.Size = new System.Drawing.Size(110, 24);
            this.lbl_TitleName.TabIndex = 86;
            this.lbl_TitleName.Text = "タイトル名";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Search.Font = new System.Drawing.Font("Meiryo UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Location = new System.Drawing.Point(1346, 245);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(114, 97);
            this.btn_Search.TabIndex = 85;
            this.btn_Search.Text = "検索";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_TopTitle
            // 
            this.lbl_TopTitle.AutoSize = true;
            this.lbl_TopTitle.Font = new System.Drawing.Font("MS UI Gothic", 65.25F, System.Drawing.FontStyle.Bold);
            this.lbl_TopTitle.Location = new System.Drawing.Point(622, 26);
            this.lbl_TopTitle.Name = "lbl_TopTitle";
            this.lbl_TopTitle.Size = new System.Drawing.Size(389, 87);
            this.lbl_TopTitle.TabIndex = 84;
            this.lbl_TopTitle.Text = "商品情報";
            // 
            // lbl_SearchC
            // 
            this.lbl_SearchC.AutoSize = true;
            this.lbl_SearchC.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbl_SearchC.Location = new System.Drawing.Point(34, 148);
            this.lbl_SearchC.Name = "lbl_SearchC";
            this.lbl_SearchC.Size = new System.Drawing.Size(159, 35);
            this.lbl_SearchC.TabIndex = 83;
            this.lbl_SearchC.Text = "検索条件";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(-2, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1660, 1);
            this.label9.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(-2, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1660, 1);
            this.label7.TabIndex = 81;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // tBLARTISTBindingSource
            // 
            this.tBLARTISTBindingSource.DataMember = "TBL_ARTIST";
            this.tBLARTISTBindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // tBL_ARTISTTableAdapter
            // 
            this.tBL_ARTISTTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_ItemInfo
            // 
            this.dgv_ItemInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ItemInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ItemInfo.Location = new System.Drawing.Point(27, 390);
            this.dgv_ItemInfo.Name = "dgv_ItemInfo";
            this.dgv_ItemInfo.RowTemplate.Height = 21;
            this.dgv_ItemInfo.Size = new System.Drawing.Size(1579, 622);
            this.dgv_ItemInfo.TabIndex = 103;
            // 
            // ItemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dgv_ItemInfo);
            this.Controls.Add(this.cmb_Order);
            this.Controls.Add(this.lbl_Order);
            this.Controls.Add(this.txt_ArtistName);
            this.Controls.Add(this.lbl_ArtistName);
            this.Controls.Add(this.txt_ItemID);
            this.Controls.Add(this.lbl_ItemID);
            this.Controls.Add(this.cmb_Genre);
            this.Controls.Add(this.cmb_State);
            this.Controls.Add(this.cmb_Type);
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
            this.Name = "ItemInfo";
            this.Size = new System.Drawing.Size(1632, 1042);
            this.Load += new System.EventHandler(this.ItemInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLARTISTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItemInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Order;
        private System.Windows.Forms.Label lbl_Order;
        private System.Windows.Forms.TextBox txt_ArtistName;
        private System.Windows.Forms.Label lbl_ArtistName;
        private System.Windows.Forms.TextBox txt_ItemID;
        private System.Windows.Forms.Label lbl_ItemID;
        private System.Windows.Forms.ComboBox cmb_Genre;
        private System.Windows.Forms.ComboBox cmb_State;
        private System.Windows.Forms.ComboBox cmb_Type;
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
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private System.Windows.Forms.BindingSource tBLARTISTBindingSource;
        private Database1DataSetTableAdapters.TBL_ARTISTTableAdapter tBL_ARTISTTableAdapter;
        private System.Windows.Forms.DataGridView dgv_ItemInfo;
    }
}
