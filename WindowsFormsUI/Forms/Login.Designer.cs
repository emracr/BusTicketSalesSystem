
namespace WindowsFormsUI.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.pnlEmail = new DevExpress.XtraEditors.PanelControl();
            this.teEmail = new DevExpress.XtraEditors.TextEdit();
            this.peEmail = new DevExpress.XtraEditors.PictureEdit();
            this.pnlPassword = new DevExpress.XtraEditors.PanelControl();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.pePassword = new DevExpress.XtraEditors.PictureEdit();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.lblRegister = new DevExpress.XtraEditors.LabelControl();
            this.lblForgotMyPassword = new DevExpress.XtraEditors.LabelControl();
            this.pePasswordShow = new DevExpress.XtraEditors.PictureEdit();
            this.pePasswordHide = new DevExpress.XtraEditors.PictureEdit();
            this.peClose = new DevExpress.XtraEditors.PictureEdit();
            this.peUserLogo = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEmail)).BeginInit();
            this.pnlEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPassword)).BeginInit();
            this.pnlPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePasswordShow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePasswordHide.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peClose.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peUserLogo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.Appearance.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.lblEmail.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Appearance.Options.UseFont = true;
            this.lblEmail.Appearance.Options.UseForeColor = true;
            this.lblEmail.Location = new System.Drawing.Point(98, 224);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 21);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.Appearance.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.lblPassword.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Appearance.Options.UseFont = true;
            this.lblPassword.Appearance.Options.UseForeColor = true;
            this.lblPassword.Location = new System.Drawing.Point(98, 310);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 21);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Parola";
            // 
            // pnlEmail
            // 
            this.pnlEmail.Appearance.BackColor = System.Drawing.Color.White;
            this.pnlEmail.Appearance.Options.UseBackColor = true;
            this.pnlEmail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlEmail.Controls.Add(this.teEmail);
            this.pnlEmail.Controls.Add(this.peEmail);
            this.pnlEmail.Location = new System.Drawing.Point(97, 250);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(372, 45);
            this.pnlEmail.TabIndex = 15;
            // 
            // teEmail
            // 
            this.teEmail.Location = new System.Drawing.Point(45, 11);
            this.teEmail.Name = "teEmail";
            this.teEmail.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.teEmail.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.teEmail.Properties.Appearance.Options.UseFont = true;
            this.teEmail.Properties.Appearance.Options.UseForeColor = true;
            this.teEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.teEmail.Properties.MaxLength = 50;
            this.teEmail.Size = new System.Drawing.Size(320, 24);
            this.teEmail.TabIndex = 1;
            this.teEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.teEmail_KeyDown);
            // 
            // peEmail
            // 
            this.peEmail.EditValue = global::WindowsFormsUI.Properties.Resources.email;
            this.peEmail.Location = new System.Drawing.Point(7, 11);
            this.peEmail.Name = "peEmail";
            this.peEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peEmail.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peEmail.Size = new System.Drawing.Size(30, 24);
            this.peEmail.TabIndex = 12;
            // 
            // pnlPassword
            // 
            this.pnlPassword.Appearance.BackColor = System.Drawing.Color.White;
            this.pnlPassword.Appearance.Options.UseBackColor = true;
            this.pnlPassword.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlPassword.Controls.Add(this.tePassword);
            this.pnlPassword.Controls.Add(this.pePassword);
            this.pnlPassword.Location = new System.Drawing.Point(97, 336);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(372, 45);
            this.pnlPassword.TabIndex = 16;
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(41, 11);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.tePassword.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tePassword.Properties.Appearance.Options.UseFont = true;
            this.tePassword.Properties.Appearance.Options.UseForeColor = true;
            this.tePassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tePassword.Properties.MaxLength = 20;
            this.tePassword.Properties.UseSystemPasswordChar = true;
            this.tePassword.Size = new System.Drawing.Size(320, 24);
            this.tePassword.TabIndex = 2;
            // 
            // pePassword
            // 
            this.pePassword.EditValue = global::WindowsFormsUI.Properties.Resources.padlock__1_;
            this.pePassword.Location = new System.Drawing.Point(7, 9);
            this.pePassword.Name = "pePassword";
            this.pePassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pePassword.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pePassword.Size = new System.Drawing.Size(30, 30);
            this.pePassword.TabIndex = 13;
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Location = new System.Drawing.Point(206, 415);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnLogin.Size = new System.Drawing.Size(162, 41);
            this.btnLogin.TabIndex = 19;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblRegister
            // 
            this.lblRegister.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRegister.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblRegister.Appearance.Options.UseFont = true;
            this.lblRegister.Appearance.Options.UseForeColor = true;
            this.lblRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegister.Location = new System.Drawing.Point(260, 504);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(51, 21);
            this.lblRegister.TabIndex = 20;
            this.lblRegister.Text = "Kayıt ol";
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // lblForgotMyPassword
            // 
            this.lblForgotMyPassword.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblForgotMyPassword.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblForgotMyPassword.Appearance.Options.UseFont = true;
            this.lblForgotMyPassword.Appearance.Options.UseForeColor = true;
            this.lblForgotMyPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotMyPassword.Location = new System.Drawing.Point(226, 472);
            this.lblForgotMyPassword.Name = "lblForgotMyPassword";
            this.lblForgotMyPassword.Size = new System.Drawing.Size(126, 21);
            this.lblForgotMyPassword.TabIndex = 21;
            this.lblForgotMyPassword.Text = "Parolamı unuttum";
            this.lblForgotMyPassword.Click += new System.EventHandler(this.lblForgotMyPassword_Click);
            // 
            // pePasswordShow
            // 
            this.pePasswordShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pePasswordShow.EditValue = global::WindowsFormsUI.Properties.Resources.passwordShow;
            this.pePasswordShow.Location = new System.Drawing.Point(481, 345);
            this.pePasswordShow.Name = "pePasswordShow";
            this.pePasswordShow.Properties.AllowFocused = false;
            this.pePasswordShow.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.pePasswordShow.Properties.Appearance.Options.UseBackColor = true;
            this.pePasswordShow.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pePasswordShow.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pePasswordShow.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pePasswordShow.Size = new System.Drawing.Size(30, 30);
            this.pePasswordShow.TabIndex = 18;
            this.pePasswordShow.Click += new System.EventHandler(this.pePasswordShow_Click);
            // 
            // pePasswordHide
            // 
            this.pePasswordHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pePasswordHide.EditValue = global::WindowsFormsUI.Properties.Resources.passwordHide;
            this.pePasswordHide.Location = new System.Drawing.Point(481, 345);
            this.pePasswordHide.Name = "pePasswordHide";
            this.pePasswordHide.Properties.AllowFocused = false;
            this.pePasswordHide.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.pePasswordHide.Properties.Appearance.Options.UseBackColor = true;
            this.pePasswordHide.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pePasswordHide.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pePasswordHide.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pePasswordHide.Size = new System.Drawing.Size(30, 30);
            this.pePasswordHide.TabIndex = 17;
            this.pePasswordHide.Click += new System.EventHandler(this.pePasswordHide_Click);
            // 
            // peClose
            // 
            this.peClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.peClose.EditValue = global::WindowsFormsUI.Properties.Resources.clear;
            this.peClose.Location = new System.Drawing.Point(517, 7);
            this.peClose.Name = "peClose";
            this.peClose.Properties.AllowFocused = false;
            this.peClose.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.peClose.Properties.Appearance.Options.UseBackColor = true;
            this.peClose.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peClose.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peClose.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peClose.Size = new System.Drawing.Size(41, 31);
            this.peClose.TabIndex = 14;
            this.peClose.Click += new System.EventHandler(this.peClose_Click);
            // 
            // peUserLogo
            // 
            this.peUserLogo.EditValue = global::WindowsFormsUI.Properties.Resources.user__2_;
            this.peUserLogo.Location = new System.Drawing.Point(218, 64);
            this.peUserLogo.Name = "peUserLogo";
            this.peUserLogo.Properties.AllowFocused = false;
            this.peUserLogo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.peUserLogo.Properties.Appearance.Options.UseBackColor = true;
            this.peUserLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peUserLogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peUserLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peUserLogo.Size = new System.Drawing.Size(141, 134);
            this.peUserLogo.TabIndex = 11;
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(560, 545);
            this.Controls.Add(this.lblForgotMyPassword);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pePasswordShow);
            this.Controls.Add(this.pePasswordHide);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.pnlEmail);
            this.Controls.Add(this.peClose);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.peUserLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Shown += new System.EventHandler(this.Login_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pnlEmail)).EndInit();
            this.pnlEmail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPassword)).EndInit();
            this.pnlPassword.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePasswordShow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePasswordHide.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peClose.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peUserLogo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit teEmail;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.PictureEdit peUserLogo;
        private DevExpress.XtraEditors.PictureEdit peEmail;
        private DevExpress.XtraEditors.PictureEdit pePassword;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.PictureEdit peClose;
        private DevExpress.XtraEditors.PanelControl pnlEmail;
        private DevExpress.XtraEditors.PanelControl pnlPassword;
        private DevExpress.XtraEditors.PictureEdit pePasswordHide;
        private DevExpress.XtraEditors.PictureEdit pePasswordShow;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.LabelControl lblRegister;
        private DevExpress.XtraEditors.LabelControl lblForgotMyPassword;
    }
}