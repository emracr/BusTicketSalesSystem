
namespace WindowsFormsUI.Forms
{
    partial class PasswordReset
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordReset));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teMail = new DevExpress.XtraEditors.TextEdit();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.peClose = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pnlSecurityQuestion = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.peClose2 = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.teSecurityQuestionAnswer = new DevExpress.XtraEditors.TextEdit();
            this.btnNextNewPassword = new DevExpress.XtraEditors.SimpleButton();
            this.lblSecurityQuestion = new DevExpress.XtraEditors.LabelControl();
            this.pnlNewPassword = new DevExpress.XtraEditors.PanelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.teNewPasswordConfirm = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.peClose3 = new DevExpress.XtraEditors.PictureEdit();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.teNewPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnPasswordUpdate = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.teMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peClose.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSecurityQuestion)).BeginInit();
            this.pnlSecurityQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peClose2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teSecurityQuestionAnswer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNewPassword)).BeginInit();
            this.pnlNewPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teNewPasswordConfirm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peClose3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teNewPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(127, 164);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 30);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Email";
            // 
            // teMail
            // 
            this.teMail.Location = new System.Drawing.Point(11, 9);
            this.teMail.Name = "teMail";
            this.teMail.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.teMail.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teMail.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.teMail.Properties.Appearance.Options.UseBackColor = true;
            this.teMail.Properties.Appearance.Options.UseFont = true;
            this.teMail.Properties.Appearance.Options.UseForeColor = true;
            this.teMail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.teMail.Size = new System.Drawing.Size(380, 28);
            this.teMail.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnQuery.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQuery.Appearance.Options.UseBackColor = true;
            this.btnQuery.Appearance.Options.UseFont = true;
            this.btnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuery.Location = new System.Drawing.Point(258, 309);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(134, 33);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "Sorgula";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.teMail);
            this.panelControl1.Location = new System.Drawing.Point(125, 202);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(401, 45);
            this.panelControl1.TabIndex = 3;
            // 
            // peClose
            // 
            this.peClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.peClose.EditValue = global::WindowsFormsUI.Properties.Resources.clear;
            this.peClose.Location = new System.Drawing.Point(580, 5);
            this.peClose.Name = "peClose";
            this.peClose.Properties.AllowFocused = false;
            this.peClose.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peClose.Properties.Appearance.Options.UseBackColor = true;
            this.peClose.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peClose.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peClose.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peClose.Size = new System.Drawing.Size(41, 31);
            this.peClose.TabIndex = 15;
            this.peClose.Click += new System.EventHandler(this.peClose_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(236, 45);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(164, 32);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Parola Sıfırlama";
            // 
            // pnlSecurityQuestion
            // 
            this.pnlSecurityQuestion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlSecurityQuestion.Controls.Add(this.labelControl3);
            this.pnlSecurityQuestion.Controls.Add(this.peClose2);
            this.pnlSecurityQuestion.Controls.Add(this.panelControl2);
            this.pnlSecurityQuestion.Controls.Add(this.btnNextNewPassword);
            this.pnlSecurityQuestion.Controls.Add(this.lblSecurityQuestion);
            this.pnlSecurityQuestion.Location = new System.Drawing.Point(0, -2);
            this.pnlSecurityQuestion.Name = "pnlSecurityQuestion";
            this.pnlSecurityQuestion.Size = new System.Drawing.Size(625, 435);
            this.pnlSecurityQuestion.TabIndex = 17;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(228, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(173, 32);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Güvenlik Sorusu";
            // 
            // peClose2
            // 
            this.peClose2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.peClose2.EditValue = global::WindowsFormsUI.Properties.Resources.clear;
            this.peClose2.Location = new System.Drawing.Point(580, 5);
            this.peClose2.Name = "peClose2";
            this.peClose2.Properties.AllowFocused = false;
            this.peClose2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peClose2.Properties.Appearance.Options.UseBackColor = true;
            this.peClose2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peClose2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peClose2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peClose2.Size = new System.Drawing.Size(41, 31);
            this.peClose2.TabIndex = 20;
            this.peClose2.Click += new System.EventHandler(this.peClose_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.teSecurityQuestionAnswer);
            this.panelControl2.Location = new System.Drawing.Point(68, 222);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(491, 45);
            this.panelControl2.TabIndex = 19;
            // 
            // teSecurityQuestionAnswer
            // 
            this.teSecurityQuestionAnswer.Location = new System.Drawing.Point(11, 9);
            this.teSecurityQuestionAnswer.Name = "teSecurityQuestionAnswer";
            this.teSecurityQuestionAnswer.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.teSecurityQuestionAnswer.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teSecurityQuestionAnswer.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.teSecurityQuestionAnswer.Properties.Appearance.Options.UseBackColor = true;
            this.teSecurityQuestionAnswer.Properties.Appearance.Options.UseFont = true;
            this.teSecurityQuestionAnswer.Properties.Appearance.Options.UseForeColor = true;
            this.teSecurityQuestionAnswer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.teSecurityQuestionAnswer.Size = new System.Drawing.Size(465, 28);
            this.teSecurityQuestionAnswer.TabIndex = 1;
            // 
            // btnNextNewPassword
            // 
            this.btnNextNewPassword.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnNextNewPassword.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNextNewPassword.Appearance.Options.UseBackColor = true;
            this.btnNextNewPassword.Appearance.Options.UseFont = true;
            this.btnNextNewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextNewPassword.Location = new System.Drawing.Point(245, 325);
            this.btnNextNewPassword.Name = "btnNextNewPassword";
            this.btnNextNewPassword.Size = new System.Drawing.Size(134, 33);
            this.btnNextNewPassword.TabIndex = 18;
            this.btnNextNewPassword.Text = "Doğrula";
            this.btnNextNewPassword.Click += new System.EventHandler(this.btnNextNewPassword_Click);
            // 
            // lblSecurityQuestion
            // 
            this.lblSecurityQuestion.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecurityQuestion.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lblSecurityQuestion.Appearance.Options.UseFont = true;
            this.lblSecurityQuestion.Appearance.Options.UseForeColor = true;
            this.lblSecurityQuestion.Appearance.Options.UseTextOptions = true;
            this.lblSecurityQuestion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblSecurityQuestion.AutoEllipsis = true;
            this.lblSecurityQuestion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSecurityQuestion.Location = new System.Drawing.Point(12, 164);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(600, 30);
            this.lblSecurityQuestion.TabIndex = 17;
            this.lblSecurityQuestion.Text = "-";
            // 
            // pnlNewPassword
            // 
            this.pnlNewPassword.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlNewPassword.Controls.Add(this.labelControl6);
            this.pnlNewPassword.Controls.Add(this.panelControl3);
            this.pnlNewPassword.Controls.Add(this.labelControl5);
            this.pnlNewPassword.Controls.Add(this.labelControl4);
            this.pnlNewPassword.Controls.Add(this.peClose3);
            this.pnlNewPassword.Controls.Add(this.panelControl4);
            this.pnlNewPassword.Controls.Add(this.btnPasswordUpdate);
            this.pnlNewPassword.Location = new System.Drawing.Point(0, 1);
            this.pnlNewPassword.Name = "pnlNewPassword";
            this.pnlNewPassword.Size = new System.Drawing.Size(622, 432);
            this.pnlNewPassword.TabIndex = 18;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(67, 226);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(154, 25);
            this.labelControl6.TabIndex = 29;
            this.labelControl6.Text = "Yeni Parola Tekrar";
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.teNewPasswordConfirm);
            this.panelControl3.Location = new System.Drawing.Point(65, 261);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(491, 45);
            this.panelControl3.TabIndex = 28;
            // 
            // teNewPasswordConfirm
            // 
            this.teNewPasswordConfirm.Location = new System.Drawing.Point(11, 9);
            this.teNewPasswordConfirm.Name = "teNewPasswordConfirm";
            this.teNewPasswordConfirm.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.teNewPasswordConfirm.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teNewPasswordConfirm.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.teNewPasswordConfirm.Properties.Appearance.Options.UseBackColor = true;
            this.teNewPasswordConfirm.Properties.Appearance.Options.UseFont = true;
            this.teNewPasswordConfirm.Properties.Appearance.Options.UseForeColor = true;
            this.teNewPasswordConfirm.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.teNewPasswordConfirm.Properties.UseSystemPasswordChar = true;
            this.teNewPasswordConfirm.Size = new System.Drawing.Size(465, 28);
            this.teNewPasswordConfirm.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(70, 114);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(96, 25);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "Yeni Parola";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(261, 26);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(118, 32);
            this.labelControl4.TabIndex = 26;
            this.labelControl4.Text = "Yeni Parola";
            // 
            // peClose3
            // 
            this.peClose3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.peClose3.EditValue = global::WindowsFormsUI.Properties.Resources.clear;
            this.peClose3.Location = new System.Drawing.Point(580, 5);
            this.peClose3.Name = "peClose3";
            this.peClose3.Properties.AllowFocused = false;
            this.peClose3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peClose3.Properties.Appearance.Options.UseBackColor = true;
            this.peClose3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peClose3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peClose3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peClose3.Size = new System.Drawing.Size(41, 31);
            this.peClose3.TabIndex = 25;
            this.peClose3.Click += new System.EventHandler(this.peClose_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelControl4.Appearance.Options.UseBackColor = true;
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.teNewPassword);
            this.panelControl4.Location = new System.Drawing.Point(68, 149);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(491, 45);
            this.panelControl4.TabIndex = 24;
            // 
            // teNewPassword
            // 
            this.teNewPassword.Location = new System.Drawing.Point(11, 9);
            this.teNewPassword.Name = "teNewPassword";
            this.teNewPassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.teNewPassword.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teNewPassword.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.teNewPassword.Properties.Appearance.Options.UseBackColor = true;
            this.teNewPassword.Properties.Appearance.Options.UseFont = true;
            this.teNewPassword.Properties.Appearance.Options.UseForeColor = true;
            this.teNewPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.teNewPassword.Properties.UseSystemPasswordChar = true;
            this.teNewPassword.Size = new System.Drawing.Size(465, 28);
            this.teNewPassword.TabIndex = 1;
            // 
            // btnPasswordUpdate
            // 
            this.btnPasswordUpdate.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnPasswordUpdate.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPasswordUpdate.Appearance.Options.UseBackColor = true;
            this.btnPasswordUpdate.Appearance.Options.UseFont = true;
            this.btnPasswordUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPasswordUpdate.Location = new System.Drawing.Point(260, 355);
            this.btnPasswordUpdate.Name = "btnPasswordUpdate";
            this.btnPasswordUpdate.Size = new System.Drawing.Size(134, 33);
            this.btnPasswordUpdate.TabIndex = 23;
            this.btnPasswordUpdate.Text = "Güncelle";
            this.btnPasswordUpdate.Click += new System.EventHandler(this.btnPasswordUpdate_Click);
            // 
            // PasswordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(55)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(624, 432);
            this.Controls.Add(this.pnlNewPassword);
            this.Controls.Add(this.pnlSecurityQuestion);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.peClose);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordReset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordReset";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PasswordReset_FormClosed);
            this.Load += new System.EventHandler(this.PasswordReset_Load);
            this.Shown += new System.EventHandler(this.PasswordReset_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.teMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peClose.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSecurityQuestion)).EndInit();
            this.pnlSecurityQuestion.ResumeLayout(false);
            this.pnlSecurityQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peClose2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teSecurityQuestionAnswer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNewPassword)).EndInit();
            this.pnlNewPassword.ResumeLayout(false);
            this.pnlNewPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teNewPasswordConfirm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peClose3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teNewPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit teMail;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PictureEdit peClose;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl pnlSecurityQuestion;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PictureEdit peClose2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TextEdit teSecurityQuestionAnswer;
        private DevExpress.XtraEditors.SimpleButton btnNextNewPassword;
        private DevExpress.XtraEditors.LabelControl lblSecurityQuestion;
        private DevExpress.XtraEditors.PanelControl pnlNewPassword;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.TextEdit teNewPasswordConfirm;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PictureEdit peClose3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.TextEdit teNewPassword;
        private DevExpress.XtraEditors.SimpleButton btnPasswordUpdate;
    }
}