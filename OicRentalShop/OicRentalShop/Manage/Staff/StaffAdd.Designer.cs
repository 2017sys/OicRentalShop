namespace OicRentalShop.Manage.Staff
{
    partial class StaffAdd
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_TelePhoneNumber = new System.Windows.Forms.Label();
            this.txt_TelePhoneNumber = new System.Windows.Forms.TextBox();
            this.rdb_WOMAN = new System.Windows.Forms.RadioButton();
            this.rdb_MAN = new System.Windows.Forms.RadioButton();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_Address2 = new System.Windows.Forms.Label();
            this.lbl_Address1 = new System.Windows.Forms.Label();
            this.lbl_PostalCode = new System.Windows.Forms.Label();
            this.lbl_PhoneNumber = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Birthday = new System.Windows.Forms.Label();
            this.lbl_GivenNameKANA = new System.Windows.Forms.Label();
            this.lbl_FamilyNameKANA = new System.Windows.Forms.Label();
            this.lbl_Sex = new System.Windows.Forms.Label();
            this.lbl_GivenName = new System.Windows.Forms.Label();
            this.lbl_FamilyName = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txt_Birtyday = new System.Windows.Forms.TextBox();
            this.txt_GivenNameKANA = new System.Windows.Forms.TextBox();
            this.txt_FamilyNameKANA = new System.Windows.Forms.TextBox();
            this.txt_Address2 = new System.Windows.Forms.TextBox();
            this.txt_Address1 = new System.Windows.Forms.TextBox();
            this.txt_PostalCode = new System.Windows.Forms.TextBox();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_GivenName = new System.Windows.Forms.TextBox();
            this.txt_FamilyName = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Back.Font = new System.Drawing.Font("Meiryo UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_Back.Location = new System.Drawing.Point(1418, 926);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(174, 85);
            this.btn_Back.TabIndex = 317;
            this.btn_Back.Text = "戻る";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_TelePhoneNumber
            // 
            this.lbl_TelePhoneNumber.AutoSize = true;
            this.lbl_TelePhoneNumber.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_TelePhoneNumber.Location = new System.Drawing.Point(229, 544);
            this.lbl_TelePhoneNumber.Name = "lbl_TelePhoneNumber";
            this.lbl_TelePhoneNumber.Size = new System.Drawing.Size(230, 33);
            this.lbl_TelePhoneNumber.TabIndex = 316;
            this.lbl_TelePhoneNumber.Text = "携帯電話番号：";
            // 
            // txt_TelePhoneNumber
            // 
            this.txt_TelePhoneNumber.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_TelePhoneNumber.Location = new System.Drawing.Point(529, 544);
            this.txt_TelePhoneNumber.Multiline = true;
            this.txt_TelePhoneNumber.Name = "txt_TelePhoneNumber";
            this.txt_TelePhoneNumber.Size = new System.Drawing.Size(603, 33);
            this.txt_TelePhoneNumber.TabIndex = 315;
            // 
            // rdb_WOMAN
            // 
            this.rdb_WOMAN.AutoSize = true;
            this.rdb_WOMAN.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.rdb_WOMAN.Location = new System.Drawing.Point(680, 457);
            this.rdb_WOMAN.Name = "rdb_WOMAN";
            this.rdb_WOMAN.Size = new System.Drawing.Size(99, 37);
            this.rdb_WOMAN.TabIndex = 314;
            this.rdb_WOMAN.TabStop = true;
            this.rdb_WOMAN.Tag = "Sex";
            this.rdb_WOMAN.Text = "女性";
            this.rdb_WOMAN.UseVisualStyleBackColor = true;
            // 
            // rdb_MAN
            // 
            this.rdb_MAN.AutoSize = true;
            this.rdb_MAN.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.rdb_MAN.Location = new System.Drawing.Point(529, 457);
            this.rdb_MAN.Name = "rdb_MAN";
            this.rdb_MAN.Size = new System.Drawing.Size(99, 37);
            this.rdb_MAN.TabIndex = 313;
            this.rdb_MAN.TabStop = true;
            this.rdb_MAN.Tag = "Sex";
            this.rdb_MAN.Text = "男性";
            this.rdb_MAN.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Clear.Font = new System.Drawing.Font("Meiryo UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_Clear.Location = new System.Drawing.Point(1418, 809);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(174, 85);
            this.btn_Clear.TabIndex = 312;
            this.btn_Clear.Text = "クリア";
            this.btn_Clear.UseVisualStyleBackColor = false;
            // 
            // lbl_Address2
            // 
            this.lbl_Address2.AutoSize = true;
            this.lbl_Address2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_Address2.Location = new System.Drawing.Point(338, 884);
            this.lbl_Address2.Name = "lbl_Address2";
            this.lbl_Address2.Size = new System.Drawing.Size(121, 33);
            this.lbl_Address2.TabIndex = 311;
            this.lbl_Address2.Text = "住所２：";
            // 
            // lbl_Address1
            // 
            this.lbl_Address1.AutoSize = true;
            this.lbl_Address1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_Address1.Location = new System.Drawing.Point(338, 799);
            this.lbl_Address1.Name = "lbl_Address1";
            this.lbl_Address1.Size = new System.Drawing.Size(121, 33);
            this.lbl_Address1.TabIndex = 310;
            this.lbl_Address1.Text = "住所１：";
            // 
            // lbl_PostalCode
            // 
            this.lbl_PostalCode.AutoSize = true;
            this.lbl_PostalCode.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_PostalCode.Location = new System.Drawing.Point(295, 714);
            this.lbl_PostalCode.Name = "lbl_PostalCode";
            this.lbl_PostalCode.Size = new System.Drawing.Size(164, 33);
            this.lbl_PostalCode.TabIndex = 309;
            this.lbl_PostalCode.Text = "郵便番号：";
            // 
            // lbl_PhoneNumber
            // 
            this.lbl_PhoneNumber.AutoSize = true;
            this.lbl_PhoneNumber.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_PhoneNumber.Location = new System.Drawing.Point(295, 629);
            this.lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            this.lbl_PhoneNumber.Size = new System.Drawing.Size(164, 33);
            this.lbl_PhoneNumber.TabIndex = 308;
            this.lbl_PhoneNumber.Text = "電話番号：";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Add.Font = new System.Drawing.Font("Meiryo UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.btn_Add.Location = new System.Drawing.Point(1418, 690);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(174, 85);
            this.btn_Add.TabIndex = 307;
            this.btn_Add.Text = "登録";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Birthday
            // 
            this.lbl_Birthday.AutoSize = true;
            this.lbl_Birthday.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_Birthday.Location = new System.Drawing.Point(968, 459);
            this.lbl_Birthday.Name = "lbl_Birthday";
            this.lbl_Birthday.Size = new System.Drawing.Size(164, 33);
            this.lbl_Birthday.TabIndex = 306;
            this.lbl_Birthday.Text = "生年月日：";
            // 
            // lbl_GivenNameKANA
            // 
            this.lbl_GivenNameKANA.AutoSize = true;
            this.lbl_GivenNameKANA.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_GivenNameKANA.Location = new System.Drawing.Point(1053, 371);
            this.lbl_GivenNameKANA.Name = "lbl_GivenNameKANA";
            this.lbl_GivenNameKANA.Size = new System.Drawing.Size(79, 33);
            this.lbl_GivenNameKANA.TabIndex = 305;
            this.lbl_GivenNameKANA.Text = "メイ：";
            // 
            // lbl_FamilyNameKANA
            // 
            this.lbl_FamilyNameKANA.AutoSize = true;
            this.lbl_FamilyNameKANA.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_FamilyNameKANA.Location = new System.Drawing.Point(1049, 291);
            this.lbl_FamilyNameKANA.Name = "lbl_FamilyNameKANA";
            this.lbl_FamilyNameKANA.Size = new System.Drawing.Size(83, 33);
            this.lbl_FamilyNameKANA.TabIndex = 304;
            this.lbl_FamilyNameKANA.Text = "セイ：";
            // 
            // lbl_Sex
            // 
            this.lbl_Sex.AutoSize = true;
            this.lbl_Sex.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_Sex.Location = new System.Drawing.Point(361, 459);
            this.lbl_Sex.Name = "lbl_Sex";
            this.lbl_Sex.Size = new System.Drawing.Size(98, 33);
            this.lbl_Sex.TabIndex = 303;
            this.lbl_Sex.Text = "性別：";
            // 
            // lbl_GivenName
            // 
            this.lbl_GivenName.AutoSize = true;
            this.lbl_GivenName.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_GivenName.Location = new System.Drawing.Point(394, 374);
            this.lbl_GivenName.Name = "lbl_GivenName";
            this.lbl_GivenName.Size = new System.Drawing.Size(65, 33);
            this.lbl_GivenName.TabIndex = 302;
            this.lbl_GivenName.Text = "名：";
            // 
            // lbl_FamilyName
            // 
            this.lbl_FamilyName.AutoSize = true;
            this.lbl_FamilyName.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_FamilyName.Location = new System.Drawing.Point(394, 289);
            this.lbl_FamilyName.Name = "lbl_FamilyName";
            this.lbl_FamilyName.Size = new System.Drawing.Size(65, 33);
            this.lbl_FamilyName.TabIndex = 301;
            this.lbl_FamilyName.Text = "性：";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_ID.Location = new System.Drawing.Point(297, 204);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(162, 33);
            this.lbl_ID.TabIndex = 300;
            this.lbl_ID.Text = "従業員ID：";
            // 
            // txt_Birtyday
            // 
            this.txt_Birtyday.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Birtyday.Location = new System.Drawing.Point(1197, 459);
            this.txt_Birtyday.Multiline = true;
            this.txt_Birtyday.Name = "txt_Birtyday";
            this.txt_Birtyday.Size = new System.Drawing.Size(250, 33);
            this.txt_Birtyday.TabIndex = 299;
            // 
            // txt_GivenNameKANA
            // 
            this.txt_GivenNameKANA.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_GivenNameKANA.Location = new System.Drawing.Point(1197, 371);
            this.txt_GivenNameKANA.Multiline = true;
            this.txt_GivenNameKANA.Name = "txt_GivenNameKANA";
            this.txt_GivenNameKANA.Size = new System.Drawing.Size(250, 33);
            this.txt_GivenNameKANA.TabIndex = 298;
            // 
            // txt_FamilyNameKANA
            // 
            this.txt_FamilyNameKANA.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_FamilyNameKANA.Location = new System.Drawing.Point(1197, 289);
            this.txt_FamilyNameKANA.Multiline = true;
            this.txt_FamilyNameKANA.Name = "txt_FamilyNameKANA";
            this.txt_FamilyNameKANA.Size = new System.Drawing.Size(250, 33);
            this.txt_FamilyNameKANA.TabIndex = 297;
            // 
            // txt_Address2
            // 
            this.txt_Address2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Address2.Location = new System.Drawing.Point(529, 884);
            this.txt_Address2.Multiline = true;
            this.txt_Address2.Name = "txt_Address2";
            this.txt_Address2.Size = new System.Drawing.Size(603, 33);
            this.txt_Address2.TabIndex = 296;
            // 
            // txt_Address1
            // 
            this.txt_Address1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_Address1.Location = new System.Drawing.Point(529, 799);
            this.txt_Address1.Multiline = true;
            this.txt_Address1.Name = "txt_Address1";
            this.txt_Address1.Size = new System.Drawing.Size(603, 33);
            this.txt_Address1.TabIndex = 295;
            // 
            // txt_PostalCode
            // 
            this.txt_PostalCode.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_PostalCode.Location = new System.Drawing.Point(529, 714);
            this.txt_PostalCode.Multiline = true;
            this.txt_PostalCode.Name = "txt_PostalCode";
            this.txt_PostalCode.Size = new System.Drawing.Size(603, 33);
            this.txt_PostalCode.TabIndex = 294;
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_PhoneNumber.Location = new System.Drawing.Point(529, 629);
            this.txt_PhoneNumber.Multiline = true;
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(603, 33);
            this.txt_PhoneNumber.TabIndex = 293;
            // 
            // txt_GivenName
            // 
            this.txt_GivenName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_GivenName.Location = new System.Drawing.Point(529, 374);
            this.txt_GivenName.Multiline = true;
            this.txt_GivenName.Name = "txt_GivenName";
            this.txt_GivenName.Size = new System.Drawing.Size(250, 33);
            this.txt_GivenName.TabIndex = 292;
            // 
            // txt_FamilyName
            // 
            this.txt_FamilyName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_FamilyName.Location = new System.Drawing.Point(529, 289);
            this.txt_FamilyName.Multiline = true;
            this.txt_FamilyName.Name = "txt_FamilyName";
            this.txt_FamilyName.Size = new System.Drawing.Size(250, 33);
            this.txt_FamilyName.TabIndex = 291;
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_ID.Location = new System.Drawing.Point(529, 204);
            this.txt_ID.Multiline = true;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(392, 33);
            this.txt_ID.TabIndex = 290;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 65.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(592, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(477, 87);
            this.label4.TabIndex = 289;
            this.label4.Text = "従業員登録";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(-2, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1660, 1);
            this.label9.TabIndex = 288;
            // 
            // StaffAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_TelePhoneNumber);
            this.Controls.Add(this.txt_TelePhoneNumber);
            this.Controls.Add(this.rdb_WOMAN);
            this.Controls.Add(this.rdb_MAN);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.lbl_Address2);
            this.Controls.Add(this.lbl_Address1);
            this.Controls.Add(this.lbl_PostalCode);
            this.Controls.Add(this.lbl_PhoneNumber);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Birthday);
            this.Controls.Add(this.lbl_GivenNameKANA);
            this.Controls.Add(this.lbl_FamilyNameKANA);
            this.Controls.Add(this.lbl_Sex);
            this.Controls.Add(this.lbl_GivenName);
            this.Controls.Add(this.lbl_FamilyName);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.txt_Birtyday);
            this.Controls.Add(this.txt_GivenNameKANA);
            this.Controls.Add(this.txt_FamilyNameKANA);
            this.Controls.Add(this.txt_Address2);
            this.Controls.Add(this.txt_Address1);
            this.Controls.Add(this.txt_PostalCode);
            this.Controls.Add(this.txt_PhoneNumber);
            this.Controls.Add(this.txt_GivenName);
            this.Controls.Add(this.txt_FamilyName);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StaffAdd";
            this.Size = new System.Drawing.Size(1661, 1042);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_TelePhoneNumber;
        private System.Windows.Forms.TextBox txt_TelePhoneNumber;
        private System.Windows.Forms.RadioButton rdb_WOMAN;
        private System.Windows.Forms.RadioButton rdb_MAN;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_Address2;
        private System.Windows.Forms.Label lbl_Address1;
        private System.Windows.Forms.Label lbl_PostalCode;
        private System.Windows.Forms.Label lbl_PhoneNumber;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Birthday;
        private System.Windows.Forms.Label lbl_GivenNameKANA;
        private System.Windows.Forms.Label lbl_FamilyNameKANA;
        private System.Windows.Forms.Label lbl_Sex;
        private System.Windows.Forms.Label lbl_GivenName;
        private System.Windows.Forms.Label lbl_FamilyName;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txt_Birtyday;
        private System.Windows.Forms.TextBox txt_GivenNameKANA;
        private System.Windows.Forms.TextBox txt_FamilyNameKANA;
        private System.Windows.Forms.TextBox txt_Address2;
        private System.Windows.Forms.TextBox txt_Address1;
        private System.Windows.Forms.TextBox txt_PostalCode;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.TextBox txt_GivenName;
        private System.Windows.Forms.TextBox txt_FamilyName;
        public System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
    }
}
