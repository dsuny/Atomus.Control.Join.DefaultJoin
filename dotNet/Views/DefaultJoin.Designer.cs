namespace Atomus.Control.Join
{
    partial class DefaultJoin
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ACCESS_NUMBER_Retry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ACCESS_NUMBER = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EMAIL_Retry = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EMAIL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordInit = new System.Windows.Forms.RadioButton();
            this.New = new System.Windows.Forms.RadioButton();
            this.Bnt_Join_Init = new System.Windows.Forms.Button();
            this.Bnt_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NICKNAME = new System.Windows.Forms.TextBox();
            this.UserAgreement_Detail = new System.Windows.Forms.RichTextBox();
            this.UserAgreement = new System.Windows.Forms.CheckBox();
            this.PersonalInformationCollectionAgreement = new System.Windows.Forms.CheckBox();
            this.PersonalInformationCollectionAgreement_Detail = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ACCESS_NUMBER_Retry, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.ACCESS_NUMBER, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.EMAIL_Retry, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.EMAIL, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.PasswordInit, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.New, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Bnt_Join_Init, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.Bnt_Cancel, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.NICKNAME, 1, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(344, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 448);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DefaultJoin_MouseDown);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DefaultJoin_MouseMove);
            // 
            // ACCESS_NUMBER_Retry
            // 
            this.ACCESS_NUMBER_Retry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ACCESS_NUMBER_Retry.Location = new System.Drawing.Point(123, 237);
            this.ACCESS_NUMBER_Retry.Name = "ACCESS_NUMBER_Retry";
            this.ACCESS_NUMBER_Retry.PasswordChar = '*';
            this.ACCESS_NUMBER_Retry.Size = new System.Drawing.Size(114, 21);
            this.ACCESS_NUMBER_Retry.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "비밀번호 확인";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ACCESS_NUMBER
            // 
            this.ACCESS_NUMBER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ACCESS_NUMBER.Location = new System.Drawing.Point(123, 212);
            this.ACCESS_NUMBER.Name = "ACCESS_NUMBER";
            this.ACCESS_NUMBER.PasswordChar = '*';
            this.ACCESS_NUMBER.Size = new System.Drawing.Size(114, 21);
            this.ACCESS_NUMBER.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "비밀번호";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EMAIL_Retry
            // 
            this.EMAIL_Retry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EMAIL_Retry.Location = new System.Drawing.Point(123, 187);
            this.EMAIL_Retry.Name = "EMAIL_Retry";
            this.EMAIL_Retry.Size = new System.Drawing.Size(114, 21);
            this.EMAIL_Retry.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "이메일 확인";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EMAIL
            // 
            this.EMAIL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EMAIL.Location = new System.Drawing.Point(123, 162);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(114, 21);
            this.EMAIL.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "이메일";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PasswordInit
            // 
            this.PasswordInit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordInit.ForeColor = System.Drawing.Color.White;
            this.PasswordInit.Location = new System.Drawing.Point(123, 137);
            this.PasswordInit.Name = "PasswordInit";
            this.PasswordInit.Size = new System.Drawing.Size(114, 19);
            this.PasswordInit.TabIndex = 1;
            this.PasswordInit.Text = "비밀번호 변경";
            this.PasswordInit.UseVisualStyleBackColor = true;
            this.PasswordInit.CheckedChanged += new System.EventHandler(this.PasswordInit_CheckedChanged);
            // 
            // New
            // 
            this.New.Checked = true;
            this.New.Dock = System.Windows.Forms.DockStyle.Fill;
            this.New.ForeColor = System.Drawing.Color.White;
            this.New.Location = new System.Drawing.Point(3, 137);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(114, 19);
            this.New.TabIndex = 0;
            this.New.TabStop = true;
            this.New.Text = "신규";
            this.New.UseVisualStyleBackColor = true;
            this.New.CheckedChanged += new System.EventHandler(this.New_CheckedChanged);
            // 
            // Bnt_Join_Init
            // 
            this.Bnt_Join_Init.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Bnt_Join_Init.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Bnt_Join_Init.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Bnt_Join_Init.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bnt_Join_Init.ForeColor = System.Drawing.Color.White;
            this.Bnt_Join_Init.Location = new System.Drawing.Point(3, 287);
            this.Bnt_Join_Init.Name = "Bnt_Join_Init";
            this.Bnt_Join_Init.Size = new System.Drawing.Size(114, 24);
            this.Bnt_Join_Init.TabIndex = 12;
            this.Bnt_Join_Init.Text = "가입";
            this.Bnt_Join_Init.UseVisualStyleBackColor = true;
            this.Bnt_Join_Init.Click += new System.EventHandler(this.Bnt_Join_Init_Click);
            // 
            // Bnt_Cancel
            // 
            this.Bnt_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Bnt_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Bnt_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Bnt_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bnt_Cancel.ForeColor = System.Drawing.Color.White;
            this.Bnt_Cancel.Location = new System.Drawing.Point(123, 287);
            this.Bnt_Cancel.Name = "Bnt_Cancel";
            this.Bnt_Cancel.Size = new System.Drawing.Size(114, 24);
            this.Bnt_Cancel.TabIndex = 13;
            this.Bnt_Cancel.Text = "취소";
            this.Bnt_Cancel.UseVisualStyleBackColor = true;
            this.Bnt_Cancel.Click += new System.EventHandler(this.Bnt_Cancel_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "별명";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NICKNAME
            // 
            this.NICKNAME.Location = new System.Drawing.Point(123, 262);
            this.NICKNAME.Name = "NICKNAME";
            this.NICKNAME.Size = new System.Drawing.Size(114, 21);
            this.NICKNAME.TabIndex = 11;
            // 
            // UserAgreement_Detail
            // 
            this.UserAgreement_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserAgreement_Detail.Location = new System.Drawing.Point(3, 28);
            this.UserAgreement_Detail.Name = "UserAgreement_Detail";
            this.UserAgreement_Detail.ReadOnly = true;
            this.UserAgreement_Detail.Size = new System.Drawing.Size(328, 193);
            this.UserAgreement_Detail.TabIndex = 1;
            this.UserAgreement_Detail.Text = "이용약관";
            // 
            // UserAgreement
            // 
            this.UserAgreement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserAgreement.ForeColor = System.Drawing.Color.White;
            this.UserAgreement.Location = new System.Drawing.Point(3, 3);
            this.UserAgreement.Name = "UserAgreement";
            this.UserAgreement.Size = new System.Drawing.Size(328, 19);
            this.UserAgreement.TabIndex = 0;
            this.UserAgreement.Text = "이용약관 동의";
            this.UserAgreement.UseVisualStyleBackColor = true;
            // 
            // PersonalInformationCollectionAgreement
            // 
            this.PersonalInformationCollectionAgreement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonalInformationCollectionAgreement.ForeColor = System.Drawing.Color.White;
            this.PersonalInformationCollectionAgreement.Location = new System.Drawing.Point(3, 227);
            this.PersonalInformationCollectionAgreement.Name = "PersonalInformationCollectionAgreement";
            this.PersonalInformationCollectionAgreement.Size = new System.Drawing.Size(328, 19);
            this.PersonalInformationCollectionAgreement.TabIndex = 2;
            this.PersonalInformationCollectionAgreement.Text = "개인정보 수집 및 이용 동의";
            this.PersonalInformationCollectionAgreement.UseVisualStyleBackColor = true;
            // 
            // PersonalInformationCollectionAgreement_Detail
            // 
            this.PersonalInformationCollectionAgreement_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonalInformationCollectionAgreement_Detail.Location = new System.Drawing.Point(3, 252);
            this.PersonalInformationCollectionAgreement_Detail.Name = "PersonalInformationCollectionAgreement_Detail";
            this.PersonalInformationCollectionAgreement_Detail.ReadOnly = true;
            this.PersonalInformationCollectionAgreement_Detail.Size = new System.Drawing.Size(328, 193);
            this.PersonalInformationCollectionAgreement_Detail.TabIndex = 3;
            this.PersonalInformationCollectionAgreement_Detail.Text = "개인정보 수집 및 이용 동의";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.UserAgreement, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.UserAgreement_Detail, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.PersonalInformationCollectionAgreement, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.PersonalInformationCollectionAgreement_Detail, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(334, 448);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // DefaultJoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DefaultJoin";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(594, 468);
            this.Load += new System.EventHandler(this.DefaultJoin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DefaultJoin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DefaultJoin_MouseMove);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox UserAgreement_Detail;
        private System.Windows.Forms.CheckBox UserAgreement;
        private System.Windows.Forms.CheckBox PersonalInformationCollectionAgreement;
        private System.Windows.Forms.RichTextBox PersonalInformationCollectionAgreement_Detail;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ACCESS_NUMBER;
        private System.Windows.Forms.TextBox ACCESS_NUMBER_Retry;
        private System.Windows.Forms.TextBox EMAIL;
        internal System.Windows.Forms.Button Bnt_Cancel;
        private System.Windows.Forms.RadioButton New;
        private System.Windows.Forms.RadioButton PasswordInit;
        private System.Windows.Forms.TextBox EMAIL_Retry;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        internal System.Windows.Forms.Button Bnt_Join_Init;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NICKNAME;
    }
}
