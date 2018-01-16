namespace OicRentalShop.Manage.Lend
{
    partial class Lend
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
            this.txt_MemberName = new System.Windows.Forms.TextBox();
            this.txt_MemberPoint = new System.Windows.Forms.TextBox();
            this.txt_MemberID = new System.Windows.Forms.TextBox();
            this.txt_OLDNEW = new System.Windows.Forms.TextBox();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.txt_InProductID = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.lbl_OLDNEW = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_ProductID = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lbl_money = new System.Windows.Forms.Label();
            this.txt_money = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_ProductInfo = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_MemberName = new System.Windows.Forms.Label();
            this.lbl_MemberPoint = new System.Windows.Forms.Label();
            this.lbl_MemberID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.tBLLENDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new OicRentalShop.Database1DataSet();
            this.lbl_TopTitle = new System.Windows.Forms.Label();
            this.lbl_MemberInfo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.tBLCDITEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_CDITEMTableAdapter = new OicRentalShop.Database1DataSetTableAdapters.TBL_CDITEMTableAdapter();
            this.tBL_LENDTableAdapter = new OicRentalShop.Database1DataSetTableAdapters.TBL_LENDTableAdapter();
            this.label41 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.txt_1d2n = new System.Windows.Forms.TextBox();
            this.txt_2d3n = new System.Windows.Forms.TextBox();
            this.txt_7d8n = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.btn_1d2n = new System.Windows.Forms.Button();
            this.btn_2d3n = new System.Windows.Forms.Button();
            this.lbl_LendPeriod = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_1d2n = new System.Windows.Forms.Label();
            this.lbl_2d3n = new System.Windows.Forms.Label();
            this.lbl_7d8n = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.btn_7d8n = new System.Windows.Forms.Button();
            this.LblSlipID = new System.Windows.Forms.Label();
            this.txt_ProductID = new System.Windows.Forms.TextBox();
            this.Btn_ClearPID = new System.Windows.Forms.Button();
            this.Btn_ClearMID = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLLENDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCDITEMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_MemberName
            // 
            this.txt_MemberName.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_MemberName.Location = new System.Drawing.Point(263, 293);
            this.txt_MemberName.Multiline = true;
            this.txt_MemberName.Name = "txt_MemberName";
            this.txt_MemberName.ReadOnly = true;
            this.txt_MemberName.Size = new System.Drawing.Size(522, 23);
            this.txt_MemberName.TabIndex = 169;
            // 
            // txt_MemberPoint
            // 
            this.txt_MemberPoint.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_MemberPoint.Location = new System.Drawing.Point(263, 243);
            this.txt_MemberPoint.Multiline = true;
            this.txt_MemberPoint.Name = "txt_MemberPoint";
            this.txt_MemberPoint.ReadOnly = true;
            this.txt_MemberPoint.Size = new System.Drawing.Size(156, 28);
            this.txt_MemberPoint.TabIndex = 168;
            // 
            // txt_MemberID
            // 
            this.txt_MemberID.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_MemberID.Location = new System.Drawing.Point(629, 243);
            this.txt_MemberID.Multiline = true;
            this.txt_MemberID.Name = "txt_MemberID";
            this.txt_MemberID.Size = new System.Drawing.Size(156, 27);
            this.txt_MemberID.TabIndex = 167;
            this.txt_MemberID.TextChanged += new System.EventHandler(this.txt_MemberID_TextChanged);
            this.txt_MemberID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MemberID_KeyPress);
            // 
            // txt_OLDNEW
            // 
            this.txt_OLDNEW.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_OLDNEW.Location = new System.Drawing.Point(167, 637);
            this.txt_OLDNEW.Multiline = true;
            this.txt_OLDNEW.Name = "txt_OLDNEW";
            this.txt_OLDNEW.ReadOnly = true;
            this.txt_OLDNEW.Size = new System.Drawing.Size(209, 26);
            this.txt_OLDNEW.TabIndex = 166;
            // 
            // txt_type
            // 
            this.txt_type.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_type.Location = new System.Drawing.Point(167, 458);
            this.txt_type.Multiline = true;
            this.txt_type.Name = "txt_type";
            this.txt_type.ReadOnly = true;
            this.txt_type.Size = new System.Drawing.Size(209, 26);
            this.txt_type.TabIndex = 165;
            // 
            // txt_InProductID
            // 
            this.txt_InProductID.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_InProductID.Location = new System.Drawing.Point(629, 353);
            this.txt_InProductID.Multiline = true;
            this.txt_InProductID.Name = "txt_InProductID";
            this.txt_InProductID.Size = new System.Drawing.Size(248, 31);
            this.txt_InProductID.TabIndex = 164;
            this.txt_InProductID.TextChanged += new System.EventHandler(this.txt_ProductID_TextChanged);
            this.txt_InProductID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ProductID_KeyPress);
            // 
            // txt_title
            // 
            this.txt_title.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_title.Location = new System.Drawing.Point(167, 534);
            this.txt_title.Multiline = true;
            this.txt_title.Name = "txt_title";
            this.txt_title.ReadOnly = true;
            this.txt_title.Size = new System.Drawing.Size(306, 46);
            this.txt_title.TabIndex = 163;
            // 
            // lbl_OLDNEW
            // 
            this.lbl_OLDNEW.AutoSize = true;
            this.lbl_OLDNEW.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_OLDNEW.Location = new System.Drawing.Point(11, 720);
            this.lbl_OLDNEW.Name = "lbl_OLDNEW";
            this.lbl_OLDNEW.Size = new System.Drawing.Size(154, 27);
            this.lbl_OLDNEW.TabIndex = 161;
            this.lbl_OLDNEW.Text = "新作/旧作：";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_type.Location = new System.Drawing.Point(29, 633);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(136, 27);
            this.lbl_type.TabIndex = 160;
            this.lbl_type.Text = "CD/DVD：";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_title.Location = new System.Drawing.Point(25, 534);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(139, 27);
            this.lbl_title.TabIndex = 159;
            this.lbl_title.Text = "タイトル名：";
            // 
            // lbl_ProductID
            // 
            this.lbl_ProductID.AutoSize = true;
            this.lbl_ProductID.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_ProductID.Location = new System.Drawing.Point(43, 457);
            this.lbl_ProductID.Name = "lbl_ProductID";
            this.lbl_ProductID.Size = new System.Drawing.Size(110, 27);
            this.lbl_ProductID.TabIndex = 158;
            this.lbl_ProductID.Text = "商品ID：";
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label29.Location = new System.Drawing.Point(1404, 108);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(1, 56);
            this.label29.TabIndex = 156;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label28.Location = new System.Drawing.Point(1181, 108);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(452, 1);
            this.label28.TabIndex = 155;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label27.Location = new System.Drawing.Point(1181, 164);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(452, 1);
            this.label27.TabIndex = 154;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label25.Location = new System.Drawing.Point(1180, 280);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(452, 1);
            this.label25.TabIndex = 152;
            // 
            // lbl_money
            // 
            this.lbl_money.AutoSize = true;
            this.lbl_money.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_money.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_money.Location = new System.Drawing.Point(1436, 115);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.Size = new System.Drawing.Size(99, 40);
            this.lbl_money.TabIndex = 147;
            this.lbl_money.Text = "金額";
            // 
            // txt_money
            // 
            this.txt_money.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.txt_money.Location = new System.Drawing.Point(1188, 112);
            this.txt_money.Name = "txt_money";
            this.txt_money.ReadOnly = true;
            this.txt_money.Size = new System.Drawing.Size(210, 47);
            this.txt_money.TabIndex = 146;
            this.txt_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(1181, 337);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(1, 708);
            this.label17.TabIndex = 142;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(596, 336);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(1, 708);
            this.label16.TabIndex = 140;
            // 
            // lbl_ProductInfo
            // 
            this.lbl_ProductInfo.AutoSize = true;
            this.lbl_ProductInfo.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbl_ProductInfo.Location = new System.Drawing.Point(233, 349);
            this.lbl_ProductInfo.Name = "lbl_ProductInfo";
            this.lbl_ProductInfo.Size = new System.Drawing.Size(159, 35);
            this.lbl_ProductInfo.TabIndex = 139;
            this.lbl_ProductInfo.Text = "商品情報";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(3, 394);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1632, 1);
            this.label14.TabIndex = 138;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(1181, -1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1, 337);
            this.label13.TabIndex = 137;
            // 
            // lbl_MemberName
            // 
            this.lbl_MemberName.AutoSize = true;
            this.lbl_MemberName.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_MemberName.Location = new System.Drawing.Point(76, 289);
            this.lbl_MemberName.Name = "lbl_MemberName";
            this.lbl_MemberName.Size = new System.Drawing.Size(172, 27);
            this.lbl_MemberName.TabIndex = 136;
            this.lbl_MemberName.Text = "会員名(カナ)：";
            // 
            // lbl_MemberPoint
            // 
            this.lbl_MemberPoint.AutoSize = true;
            this.lbl_MemberPoint.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_MemberPoint.Location = new System.Drawing.Point(455, 243);
            this.lbl_MemberPoint.Name = "lbl_MemberPoint";
            this.lbl_MemberPoint.Size = new System.Drawing.Size(168, 27);
            this.lbl_MemberPoint.TabIndex = 135;
            this.lbl_MemberPoint.Text = "保有ポイント：";
            // 
            // lbl_MemberID
            // 
            this.lbl_MemberID.AutoSize = true;
            this.lbl_MemberID.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_MemberID.Location = new System.Drawing.Point(138, 244);
            this.lbl_MemberID.Name = "lbl_MemberID";
            this.lbl_MemberID.Size = new System.Drawing.Size(110, 27);
            this.lbl_MemberID.TabIndex = 134;
            this.lbl_MemberID.Text = "会員ID：";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(3, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1632, 1);
            this.label3.TabIndex = 133;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(0, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1182, 1);
            this.label2.TabIndex = 132;
            // 
            // dgv_info
            // 
            this.dgv_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_info.Location = new System.Drawing.Point(598, 394);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.RowTemplate.Height = 21;
            this.dgv_info.Size = new System.Drawing.Size(584, 578);
            this.dgv_info.TabIndex = 131;
            // 
            // tBLLENDBindingSource
            // 
            this.tBLLENDBindingSource.DataMember = "TBL_LEND";
            this.tBLLENDBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_TopTitle
            // 
            this.lbl_TopTitle.AutoSize = true;
            this.lbl_TopTitle.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Bold);
            this.lbl_TopTitle.Location = new System.Drawing.Point(408, 35);
            this.lbl_TopTitle.Name = "lbl_TopTitle";
            this.lbl_TopTitle.Size = new System.Drawing.Size(236, 97);
            this.lbl_TopTitle.TabIndex = 130;
            this.lbl_TopTitle.Text = "貸出";
            // 
            // lbl_MemberInfo
            // 
            this.lbl_MemberInfo.AutoSize = true;
            this.lbl_MemberInfo.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbl_MemberInfo.Location = new System.Drawing.Point(449, 164);
            this.lbl_MemberInfo.Name = "lbl_MemberInfo";
            this.lbl_MemberInfo.Size = new System.Drawing.Size(159, 35);
            this.lbl_MemberInfo.TabIndex = 129;
            this.lbl_MemberInfo.Text = "会員情報";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(0, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1182, 1);
            this.label9.TabIndex = 128;
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ok.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_ok.Location = new System.Drawing.Point(1285, 697);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(250, 118);
            this.btn_ok.TabIndex = 127;
            this.btn_ok.Text = "決定";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_clear.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_clear.Location = new System.Drawing.Point(1285, 854);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(250, 118);
            this.btn_clear.TabIndex = 126;
            this.btn_clear.Text = "クリア";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label23.Location = new System.Drawing.Point(1410, 112);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(153, 47);
            this.label23.TabIndex = 150;
            // 
            // tBLCDITEMBindingSource
            // 
            this.tBLCDITEMBindingSource.DataMember = "TBL_CDITEM";
            this.tBLCDITEMBindingSource.DataSource = this.database1DataSet;
            // 
            // tBL_CDITEMTableAdapter
            // 
            this.tBL_CDITEMTableAdapter.ClearBeforeFill = true;
            // 
            // tBL_LENDTableAdapter
            // 
            this.tBL_LENDTableAdapter.ClearBeforeFill = true;
            // 
            // label41
            // 
            this.label41.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label41.Location = new System.Drawing.Point(167, 962);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(217, 1);
            this.label41.TabIndex = 179;
            // 
            // label46
            // 
            this.label46.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label46.Location = new System.Drawing.Point(167, 890);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(215, 70);
            this.label46.TabIndex = 184;
            // 
            // txt_1d2n
            // 
            this.txt_1d2n.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_1d2n.Location = new System.Drawing.Point(167, 935);
            this.txt_1d2n.Name = "txt_1d2n";
            this.txt_1d2n.ReadOnly = true;
            this.txt_1d2n.Size = new System.Drawing.Size(73, 19);
            this.txt_1d2n.TabIndex = 185;
            this.txt_1d2n.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_2d3n
            // 
            this.txt_2d3n.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_2d3n.Location = new System.Drawing.Point(239, 935);
            this.txt_2d3n.Name = "txt_2d3n";
            this.txt_2d3n.ReadOnly = true;
            this.txt_2d3n.Size = new System.Drawing.Size(73, 19);
            this.txt_2d3n.TabIndex = 186;
            this.txt_2d3n.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_7d8n
            // 
            this.txt_7d8n.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_7d8n.Location = new System.Drawing.Point(311, 935);
            this.txt_7d8n.Name = "txt_7d8n";
            this.txt_7d8n.ReadOnly = true;
            this.txt_7d8n.Size = new System.Drawing.Size(73, 19);
            this.txt_7d8n.TabIndex = 187;
            this.txt_7d8n.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label45
            // 
            this.label45.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label45.Location = new System.Drawing.Point(311, 891);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(1, 70);
            this.label45.TabIndex = 183;
            // 
            // btn_1d2n
            // 
            this.btn_1d2n.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_1d2n.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_1d2n.Location = new System.Drawing.Point(181, 796);
            this.btn_1d2n.Name = "btn_1d2n";
            this.btn_1d2n.Size = new System.Drawing.Size(110, 40);
            this.btn_1d2n.TabIndex = 170;
            this.btn_1d2n.Text = "1泊2日";
            this.btn_1d2n.UseVisualStyleBackColor = false;
            this.btn_1d2n.Click += new System.EventHandler(this.btn_1d2n_Click);
            // 
            // btn_2d3n
            // 
            this.btn_2d3n.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_2d3n.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_2d3n.Location = new System.Drawing.Point(309, 796);
            this.btn_2d3n.Name = "btn_2d3n";
            this.btn_2d3n.Size = new System.Drawing.Size(110, 40);
            this.btn_2d3n.TabIndex = 172;
            this.btn_2d3n.Text = "2泊3日";
            this.btn_2d3n.UseVisualStyleBackColor = false;
            this.btn_2d3n.Click += new System.EventHandler(this.btn_2d3n_Click);
            // 
            // lbl_LendPeriod
            // 
            this.lbl_LendPeriod.AutoSize = true;
            this.lbl_LendPeriod.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_LendPeriod.Location = new System.Drawing.Point(14, 800);
            this.lbl_LendPeriod.Name = "lbl_LendPeriod";
            this.lbl_LendPeriod.Size = new System.Drawing.Size(139, 27);
            this.lbl_LendPeriod.TabIndex = 162;
            this.lbl_LendPeriod.Text = "貸出期間：";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(167, 891);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1, 70);
            this.label5.TabIndex = 174;
            // 
            // lbl_1d2n
            // 
            this.lbl_1d2n.AutoSize = true;
            this.lbl_1d2n.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_1d2n.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_1d2n.Location = new System.Drawing.Point(178, 903);
            this.lbl_1d2n.Name = "lbl_1d2n";
            this.lbl_1d2n.Size = new System.Drawing.Size(60, 16);
            this.lbl_1d2n.TabIndex = 175;
            this.lbl_1d2n.Text = "1泊2日";
            // 
            // lbl_2d3n
            // 
            this.lbl_2d3n.AutoSize = true;
            this.lbl_2d3n.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_2d3n.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_2d3n.Location = new System.Drawing.Point(251, 903);
            this.lbl_2d3n.Name = "lbl_2d3n";
            this.lbl_2d3n.Size = new System.Drawing.Size(60, 16);
            this.lbl_2d3n.TabIndex = 176;
            this.lbl_2d3n.Text = "2泊3日";
            // 
            // lbl_7d8n
            // 
            this.lbl_7d8n.AutoSize = true;
            this.lbl_7d8n.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_7d8n.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_7d8n.Location = new System.Drawing.Point(317, 903);
            this.lbl_7d8n.Name = "lbl_7d8n";
            this.lbl_7d8n.Size = new System.Drawing.Size(60, 16);
            this.lbl_7d8n.TabIndex = 177;
            this.lbl_7d8n.Text = "7泊8日";
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label40.Location = new System.Drawing.Point(383, 890);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(1, 72);
            this.label40.TabIndex = 178;
            // 
            // label42
            // 
            this.label42.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label42.Location = new System.Drawing.Point(167, 928);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(217, 1);
            this.label42.TabIndex = 180;
            // 
            // label43
            // 
            this.label43.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label43.Location = new System.Drawing.Point(167, 890);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(217, 1);
            this.label43.TabIndex = 181;
            // 
            // label44
            // 
            this.label44.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label44.Location = new System.Drawing.Point(239, 890);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(1, 70);
            this.label44.TabIndex = 182;
            // 
            // btn_7d8n
            // 
            this.btn_7d8n.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_7d8n.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_7d8n.Location = new System.Drawing.Point(425, 796);
            this.btn_7d8n.Name = "btn_7d8n";
            this.btn_7d8n.Size = new System.Drawing.Size(110, 40);
            this.btn_7d8n.TabIndex = 173;
            this.btn_7d8n.Text = "7泊8日";
            this.btn_7d8n.UseVisualStyleBackColor = false;
            this.btn_7d8n.Click += new System.EventHandler(this.btn_7d8n_Click);
            // 
            // LblSlipID
            // 
            this.LblSlipID.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblSlipID.Location = new System.Drawing.Point(1471, 999);
            this.LblSlipID.Name = "LblSlipID";
            this.LblSlipID.Size = new System.Drawing.Size(120, 19);
            this.LblSlipID.TabIndex = 188;
            this.LblSlipID.Text = "1";
            this.LblSlipID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_ProductID
            // 
            this.txt_ProductID.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_ProductID.Location = new System.Drawing.Point(167, 724);
            this.txt_ProductID.Multiline = true;
            this.txt_ProductID.Name = "txt_ProductID";
            this.txt_ProductID.ReadOnly = true;
            this.txt_ProductID.Size = new System.Drawing.Size(209, 26);
            this.txt_ProductID.TabIndex = 190;
            this.txt_ProductID.TextChanged += new System.EventHandler(this.txt_ProductID_TextChanged_1);
            // 
            // Btn_ClearPID
            // 
            this.Btn_ClearPID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_ClearPID.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.Btn_ClearPID.Location = new System.Drawing.Point(385, 453);
            this.Btn_ClearPID.Name = "Btn_ClearPID";
            this.Btn_ClearPID.Size = new System.Drawing.Size(100, 35);
            this.Btn_ClearPID.TabIndex = 191;
            this.Btn_ClearPID.Text = "取り消し";
            this.Btn_ClearPID.UseVisualStyleBackColor = false;
            this.Btn_ClearPID.Click += new System.EventHandler(this.Btn_ClearPID_Click);
            // 
            // Btn_ClearMID
            // 
            this.Btn_ClearMID.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_ClearMID.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_ClearMID.Location = new System.Drawing.Point(812, 238);
            this.Btn_ClearMID.Name = "Btn_ClearMID";
            this.Btn_ClearMID.Size = new System.Drawing.Size(100, 35);
            this.Btn_ClearMID.TabIndex = 192;
            this.Btn_ClearMID.Text = "取り消し";
            this.Btn_ClearMID.UseVisualStyleBackColor = false;
            this.Btn_ClearMID.Click += new System.EventHandler(this.Btn_ClearMID_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(1285, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 230);
            this.button1.TabIndex = 193;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(1236, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 75);
            this.button2.TabIndex = 195;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_ClearMID);
            this.Controls.Add(this.Btn_ClearPID);
            this.Controls.Add(this.txt_ProductID);
            this.Controls.Add(this.LblSlipID);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.lbl_7d8n);
            this.Controls.Add(this.lbl_2d3n);
            this.Controls.Add(this.lbl_1d2n);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_7d8n);
            this.Controls.Add(this.btn_2d3n);
            this.Controls.Add(this.btn_1d2n);
            this.Controls.Add(this.txt_MemberName);
            this.Controls.Add(this.txt_MemberPoint);
            this.Controls.Add(this.txt_MemberID);
            this.Controls.Add(this.txt_OLDNEW);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.txt_InProductID);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.lbl_LendPeriod);
            this.Controls.Add(this.lbl_OLDNEW);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_ProductID);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.lbl_money);
            this.Controls.Add(this.txt_money);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbl_ProductInfo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbl_MemberName);
            this.Controls.Add(this.lbl_MemberPoint);
            this.Controls.Add(this.lbl_MemberID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_info);
            this.Controls.Add(this.lbl_TopTitle);
            this.Controls.Add(this.lbl_MemberInfo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txt_7d8n);
            this.Controls.Add(this.txt_2d3n);
            this.Controls.Add(this.txt_1d2n);
            this.Controls.Add(this.label46);
            this.Name = "Lend";
            this.Size = new System.Drawing.Size(1632, 1042);
            this.Load += new System.EventHandler(this.Lend_Load);
            this.VisibleChanged += new System.EventHandler(this.Lend_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLLENDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLCDITEMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MemberName;
        private System.Windows.Forms.TextBox txt_MemberPoint;
        private System.Windows.Forms.TextBox txt_OLDNEW;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.TextBox txt_InProductID;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label lbl_OLDNEW;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_ProductID;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbl_money;
        private System.Windows.Forms.TextBox txt_money;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_ProductInfo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_MemberName;
        private System.Windows.Forms.Label lbl_MemberPoint;
        private System.Windows.Forms.Label lbl_MemberID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_info;
        private System.Windows.Forms.Label lbl_TopTitle;
        private System.Windows.Forms.Label lbl_MemberInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.BindingSource tBLLENDBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tBLCDITEMBindingSource;
        private Database1DataSetTableAdapters.TBL_CDITEMTableAdapter tBL_CDITEMTableAdapter;
        private Database1DataSetTableAdapters.TBL_LENDTableAdapter tBL_LENDTableAdapter;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txt_1d2n;
        private System.Windows.Forms.TextBox txt_2d3n;
        private System.Windows.Forms.TextBox txt_7d8n;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Button btn_1d2n;
        private System.Windows.Forms.Button btn_2d3n;
        private System.Windows.Forms.Label lbl_LendPeriod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_1d2n;
        private System.Windows.Forms.Label lbl_2d3n;
        private System.Windows.Forms.Label lbl_7d8n;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Button btn_7d8n;
        private System.Windows.Forms.Label LblSlipID;
        private System.Windows.Forms.TextBox txt_ProductID;
        private System.Windows.Forms.Button Btn_ClearPID;
        private System.Windows.Forms.Button Btn_ClearMID;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txt_MemberID;
        private System.Windows.Forms.Button button2;
    }
}
