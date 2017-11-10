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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MemberInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(462, 146);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(140, 19);
            this.txt_PhoneNumber.TabIndex = 88;
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(393, 148);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(63, 13);
            this.lbl_PhoneNumber.TabIndex = 87;
            this.lbl_PhoneNumber.Text = "電話番号";
            // 
            // lbl_TopTitle
            // 
            this.lbl_TopTitle.AutoSize = true;
            this.lbl_TopTitle.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_TopTitle.Location = new System.Drawing.Point(314, 10);
            this.lbl_TopTitle.Name = "lbl_TopTitle";
            this.lbl_TopTitle.Size = new System.Drawing.Size(288, 64);
            this.lbl_TopTitle.TabIndex = 86;
            this.lbl_TopTitle.Text = "会員管理";
            // 
            // lbl_SearchC
            // 
            this.lbl_SearchC.AutoSize = true;
            this.lbl_SearchC.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_SearchC.Location = new System.Drawing.Point(24, 99);
            this.lbl_SearchC.Name = "lbl_SearchC";
            this.lbl_SearchC.Size = new System.Drawing.Size(89, 19);
            this.lbl_SearchC.TabIndex = 85;
            this.lbl_SearchC.Text = "検索条件";
            // 
            // txt_MemberID
            // 
            this.txt_MemberID.Location = new System.Drawing.Point(259, 146);
            this.txt_MemberID.Name = "txt_MemberID";
            this.txt_MemberID.Size = new System.Drawing.Size(76, 19);
            this.txt_MemberID.TabIndex = 84;
            // 
            // txt_MemberName
            // 
            this.txt_MemberName.Location = new System.Drawing.Point(69, 146);
            this.txt_MemberName.Name = "txt_MemberName";
            this.txt_MemberName.Size = new System.Drawing.Size(76, 19);
            this.txt_MemberName.TabIndex = 83;
            // 
            // lbl_MemberID
            // 
            this.lbl_MemberID.AutoSize = true;
            this.lbl_MemberID.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_MemberID.Location = new System.Drawing.Point(205, 148);
            this.lbl_MemberID.Name = "lbl_MemberID";
            this.lbl_MemberID.Size = new System.Drawing.Size(48, 13);
            this.lbl_MemberID.TabIndex = 82;
            this.lbl_MemberID.Text = "会員ID";
            // 
            // lbl_MemberName
            // 
            this.lbl_MemberName.AutoSize = true;
            this.lbl_MemberName.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_MemberName.Location = new System.Drawing.Point(14, 148);
            this.lbl_MemberName.Name = "lbl_MemberName";
            this.lbl_MemberName.Size = new System.Drawing.Size(49, 13);
            this.lbl_MemberName.TabIndex = 81;
            this.lbl_MemberName.Text = "会員名";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(-59, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1074, 1);
            this.label9.TabIndex = 90;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(-59, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1074, 1);
            this.label7.TabIndex = 89;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Search.Location = new System.Drawing.Point(802, 137);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(80, 40);
            this.btn_Search.TabIndex = 92;
            this.btn_Search.Text = "検索";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // dgv_MemberInfo
            // 
            this.dgv_MemberInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MemberInfo.Location = new System.Drawing.Point(3, 188);
            this.dgv_MemberInfo.Name = "dgv_MemberInfo";
            this.dgv_MemberInfo.RowTemplate.Height = 21;
            this.dgv_MemberInfo.Size = new System.Drawing.Size(942, 400);
            this.dgv_MemberInfo.TabIndex = 91;
            // 
            // MemberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
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
            this.Size = new System.Drawing.Size(948, 591);
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
    }
}
