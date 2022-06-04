
namespace WindowsFormsUI.Forms
{
    partial class ChauffeurLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChauffeurLoginForm));
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.pnlPassword = new DevExpress.XtraEditors.PanelControl();
            this.pnlEmail = new DevExpress.XtraEditors.PanelControl();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.lblEmail = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.pePassword = new DevExpress.XtraEditors.PictureEdit();
            this.teUserName = new DevExpress.XtraEditors.TextEdit();
            this.peEmail = new DevExpress.XtraEditors.PictureEdit();
            this.peClose = new DevExpress.XtraEditors.PictureEdit();
            this.peUserLogo = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlPassword)).BeginInit();
            this.pnlPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEmail)).BeginInit();
            this.pnlEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peClose.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peUserLogo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Location = new System.Drawing.Point(208, 421);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnLogin.Size = new System.Drawing.Size(162, 41);
            this.btnLogin.TabIndex = 30;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlPassword
            // 
            this.pnlPassword.Appearance.BackColor = System.Drawing.Color.White;
            this.pnlPassword.Appearance.Options.UseBackColor = true;
            this.pnlPassword.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlPassword.Controls.Add(this.tePassword);
            this.pnlPassword.Controls.Add(this.pePassword);
            this.pnlPassword.Location = new System.Drawing.Point(99, 342);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(372, 45);
            this.pnlPassword.TabIndex = 27;
            // 
            // pnlEmail
            // 
            this.pnlEmail.Appearance.BackColor = System.Drawing.Color.White;
            this.pnlEmail.Appearance.Options.UseBackColor = true;
            this.pnlEmail.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlEmail.Controls.Add(this.teUserName);
            this.pnlEmail.Controls.Add(this.peEmail);
            this.pnlEmail.Location = new System.Drawing.Point(99, 256);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(372, 45);
            this.pnlEmail.TabIndex = 26;
            // 
            // lblPassword
            // 
            this.lblPassword.Appearance.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.lblPassword.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Appearance.Options.UseFont = true;
            this.lblPassword.Appearance.Options.UseForeColor = true;
            this.lblPassword.Location = new System.Drawing.Point(100, 316);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 21);
            this.lblPassword.TabIndex = 24;
            this.lblPassword.Text = "Parola";
            // 
            // lblEmail
            // 
            this.lblEmail.Appearance.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.lblEmail.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Appearance.Options.UseFont = true;
            this.lblEmail.Appearance.Options.UseForeColor = true;
            this.lblEmail.Location = new System.Drawing.Point(100, 230);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(97, 21);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "Kullanıcı adı";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(247, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(100, 30);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "Şoför Girişi";
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
            // teUserName
            // 
            this.teUserName.Location = new System.Drawing.Point(45, 11);
            this.teUserName.Name = "teUserName";
            this.teUserName.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.teUserName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.teUserName.Properties.Appearance.Options.UseFont = true;
            this.teUserName.Properties.Appearance.Options.UseForeColor = true;
            this.teUserName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.teUserName.Size = new System.Drawing.Size(320, 24);
            this.teUserName.TabIndex = 1;
            // 
            // peEmail
            // 
            this.peEmail.EditValue = global::WindowsFormsUI.Properties.Resources.id_card__1_;
            this.peEmail.Location = new System.Drawing.Point(7, 11);
            this.peEmail.Name = "peEmail";
            this.peEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peEmail.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peEmail.Size = new System.Drawing.Size(30, 24);
            this.peEmail.TabIndex = 12;
            // 
            // peClose
            // 
            this.peClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.peClose.EditValue = global::WindowsFormsUI.Properties.Resources.clear;
            this.peClose.Location = new System.Drawing.Point(515, 4);
            this.peClose.Name = "peClose";
            this.peClose.Properties.AllowFocused = false;
            this.peClose.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.peClose.Properties.Appearance.Options.UseBackColor = true;
            this.peClose.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peClose.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peClose.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peClose.Size = new System.Drawing.Size(41, 31);
            this.peClose.TabIndex = 25;
            this.peClose.Click += new System.EventHandler(this.peClose_Click);
            // 
            // peUserLogo
            // 
            this.peUserLogo.EditValue = global::WindowsFormsUI.Properties.Resources.chauffeur__2_;
            this.peUserLogo.Location = new System.Drawing.Point(220, 78);
            this.peUserLogo.Name = "peUserLogo";
            this.peUserLogo.Properties.AllowFocused = false;
            this.peUserLogo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.peUserLogo.Properties.Appearance.Options.UseBackColor = true;
            this.peUserLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peUserLogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peUserLogo.Size = new System.Drawing.Size(150, 132);
            this.peUserLogo.TabIndex = 22;
            // 
            // ChauffeurLoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(86)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(560, 545);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnlPassword);
            this.Controls.Add(this.pnlEmail);
            this.Controls.Add(this.peClose);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.peUserLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChauffeurLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChauffeurLoginForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChauffeurLoginForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pnlPassword)).EndInit();
            this.pnlPassword.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlEmail)).EndInit();
            this.pnlEmail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peClose.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peUserLogo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.PanelControl pnlPassword;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.PictureEdit pePassword;
        private DevExpress.XtraEditors.PanelControl pnlEmail;
        private DevExpress.XtraEditors.TextEdit teUserName;
        private DevExpress.XtraEditors.PictureEdit peEmail;
        private DevExpress.XtraEditors.PictureEdit peClose;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.LabelControl lblEmail;
        private DevExpress.XtraEditors.PictureEdit peUserLogo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}