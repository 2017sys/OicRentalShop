namespace OicRentalShop.Manage.Member
{
    partial class MemberList
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
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.lbl_TopTitle = new System.Windows.Forms.Label();
            this.lbl_SearchC = new System.Windows.Forms.Label();
            this.txt_MemberID = new System.Windows.Forms.TextBox();
            this.txt_MemberName = new System.Windows.Forms.TextBox();
            this.lbl_MemberID = new System.Windows.Forms.Label();
            this.lbl_MemberName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dgv_MemberInfo = new System.Windows.Forms.DataGridView();
            this.btn_AddCorrection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MemberInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(1071, 271);
            this.txt_PhoneNumber.Multiline = true;
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(180, 30);
            this.txt_PhoneNumber.TabIndex = 88;
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(888, 271);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(124, 27);
            this.lbl_PhoneNumber.TabIndex = 87;
            this.lbl_PhoneNumber.Text = "電話番号";
            // 
            // lbl_TopTitle
            // 
            this.lbl_TopTitle.AutoSize = true;
            this.lbl_TopTitle.Font = new System.Drawing.Font("MS UI Gothic", 65.25F, System.Drawing.FontStyle.Bold);
            this.lbl_TopTitle.Location = new System.Drawing.Point(580, 26);
            this.lbl_TopTitle.Name = "lbl_TopTitle";
            this.lbl_TopTitle.Size = new System.Drawing.Size(389, 87);
            this.lbl_TopTitle.TabIndex = 86;
            this.lbl_TopTitle.Text = "会員管理";
            // 
            // lbl_SearchC
            // 
            this.lbl_SearchC.AutoSize = true;
            this.lbl_SearchC.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbl_SearchC.Location = new System.Drawing.Point(34, 148);
            this.lbl_SearchC.Name = "lbl_SearchC";
            this.lbl_SearchC.Size = new System.Drawing.Size(159, 35);
            this.lbl_SearchC.TabIndex = 85;
            this.lbl_SearchC.Text = "検索条件";
            // 
            // txt_MemberID
            // 
            this.txt_MemberID.Location = new System.Drawing.Point(595, 271);
            this.txt_MemberID.Multiline = true;
            this.txt_MemberID.Name = "txt_MemberID";
            this.txt_MemberID.Size = new System.Drawing.Size(180, 30);
            this.txt_MemberID.TabIndex = 84;
            // 
            // txt_MemberName
            // 
            this.txt_MemberName.Location = new System.Drawing.Point(216, 268);
            this.txt_MemberName.Multiline = true;
            this.txt_MemberName.Name = "txt_MemberName";
            this.txt_MemberName.Size = new System.Drawing.Size(180, 30);
            this.txt_MemberName.TabIndex = 83;
            // 
            // lbl_MemberID
            // 
            this.lbl_MemberID.AutoSize = true;
            this.lbl_MemberID.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_MemberID.Location = new System.Drawing.Point(484, 271);
            this.lbl_MemberID.Name = "lbl_MemberID";
            this.lbl_MemberID.Size = new System.Drawing.Size(95, 27);
            this.lbl_MemberID.TabIndex = 82;
            this.lbl_MemberID.Text = "会員ID";
            // 
            // lbl_MemberName
            // 
            this.lbl_MemberName.AutoSize = true;
            this.lbl_MemberName.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lbl_MemberName.Location = new System.Drawing.Point(91, 271);
            this.lbl_MemberName.Name = "lbl_MemberName";
            this.lbl_MemberName.Size = new System.Drawing.Size(96, 27);
            this.lbl_MemberName.TabIndex = 81;
            this.lbl_MemberName.Text = "会員名";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(-2, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1660, 1);
            this.label9.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(-2, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1660, 1);
            this.label7.TabIndex = 89;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Search.Font = new System.Drawing.Font("Meiryo UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Location = new System.Drawing.Point(1314, 255);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(135, 64);
            this.btn_Search.TabIndex = 92;
            this.btn_Search.Text = "検索";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dgv_MemberInfo
            // 
            this.dgv_MemberInfo.AllowUserToAddRows = false;
            this.dgv_MemberInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MemberInfo.Location = new System.Drawing.Point(12, 346);
            this.dgv_MemberInfo.Name = "dgv_MemberInfo";
            this.dgv_MemberInfo.ReadOnly = true;
            this.dgv_MemberInfo.RowTemplate.Height = 21;
            this.dgv_MemberInfo.Size = new System.Drawing.Size(1612, 671);
            this.dgv_MemberInfo.TabIndex = 91;
            this.dgv_MemberInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MemberInfo_CellContentClick);
            // 
            // btn_AddCorrection
            // 
            this.btn_AddCorrection.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_AddCorrection.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_AddCorrection.Location = new System.Drawing.Point(1472, 255);
            this.btn_AddCorrection.Name = "btn_AddCorrection";
            this.btn_AddCorrection.Size = new System.Drawing.Size(135, 64);
            this.btn_AddCorrection.TabIndex = 93;
            this.btn_AddCorrection.Text = "登録/修正";
            this.btn_AddCorrection.UseVisualStyleBackColor = false;
            this.btn_AddCorrection.Click += new System.EventHandler(this.btn_AddCorrection_Click);
            // 
            // MemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btn_AddCorrection);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dgv_MemberInfo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_PhoneNumber);
            this.Controls.Add(this.lbl_PhoneNumber);
            this.Controls.Add(this.lbl_TopTitle);
            this.Controls.Add(this.lbl_SearchC);
            this.Controls.Add(this.txt_MemberID);
            this.Controls.Add(this.txt_MemberName);
            this.Controls.Add(this.lbl_MemberID);
            this.Controls.Add(this.lbl_MemberName);
            this.Name = "MemberList";
            this.Size = new System.Drawing.Size(1661, 1042);
            this.Load += new System.EventHandler(this.MemberList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MemberInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.Label lbl_TopTitle;
        private System.Windows.Forms.Label lbl_SearchC;
        private System.Windows.Forms.TextBox txt_MemberID;
        private System.Windows.Forms.TextBox txt_MemberName;
        private System.Windows.Forms.Label lbl_MemberID;
        private System.Windows.Forms.Label lbl_MemberName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_MemberInfo;
        private System.Windows.Forms.Button btn_AddCorrection;
    }
}
