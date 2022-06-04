
namespace WindowsFormsUI.Forms
{
    partial class ChauffeurMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChauffeurMainForm));
            this.pnlTitleBar = new DevExpress.XtraEditors.PanelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnProfil = new DevExpress.XtraEditors.SimpleButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pnlMenu = new DevExpress.XtraEditors.PanelControl();
            this.btnProfile = new DevExpress.XtraEditors.SimpleButton();
            this.btnArchives = new DevExpress.XtraEditors.SimpleButton();
            this.btnHomePage = new DevExpress.XtraEditors.SimpleButton();
            this.pnlDesktop = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitleBar)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMenu)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDesktop)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.pnlTitleBar.Appearance.Options.UseBackColor = true;
            this.pnlTitleBar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.pnlTitleBar.Controls.Add(this.btnProfil);
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Controls.Add(this.lblUserName);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1433, 83);
            this.pnlTitleBar.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.AllowFocus = false;
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.btnExit.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnExit.Appearance.Options.UseBackColor = true;
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.Appearance.Options.UseTextOptions = true;
            this.btnExit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnExit.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.AppearanceHovered.BorderColor = System.Drawing.Color.Transparent;
            this.btnExit.AppearanceHovered.Options.UseBackColor = true;
            this.btnExit.AppearanceHovered.Options.UseBorderColor = true;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.ImageOptions.Image = global::WindowsFormsUI.Properties.Resources.arrow__1_;
            this.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExit.Location = new System.Drawing.Point(1341, 19);
            this.btnExit.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnExit.Name = "btnExit";
            this.btnExit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnExit.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnExit.Size = new System.Drawing.Size(89, 47);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = " Çıkış";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.AllowFocus = false;
            this.btnProfil.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnProfil.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(170)))));
            this.btnProfil.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProfil.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnProfil.Appearance.Options.UseBackColor = true;
            this.btnProfil.Appearance.Options.UseFont = true;
            this.btnProfil.Appearance.Options.UseForeColor = true;
            this.btnProfil.Appearance.Options.UseTextOptions = true;
            this.btnProfil.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnProfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfil.ImageOptions.Image = global::WindowsFormsUI.Properties.Resources.user;
            this.btnProfil.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnProfil.Location = new System.Drawing.Point(1227, 19);
            this.btnProfil.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnProfil.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnProfil.Size = new System.Drawing.Size(100, 47);
            this.btnProfil.TabIndex = 16;
            this.btnProfil.Text = "   Profil";
            this.btnProfil.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(665, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(356, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hoşgeldiniz";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUserName.AutoEllipsis = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(1019, 27);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(210, 33);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "Username";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlMenu.Appearance.Options.UseBackColor = true;
            this.pnlMenu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlMenu.Controls.Add(this.btnProfile);
            this.pnlMenu.Controls.Add(this.btnArchives);
            this.pnlMenu.Controls.Add(this.btnHomePage);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 83);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(260, 765);
            this.pnlMenu.TabIndex = 7;
            // 
            // btnProfile
            // 
            this.btnProfile.AllowFocus = false;
            this.btnProfile.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnProfile.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProfile.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProfile.Appearance.Options.UseBackColor = true;
            this.btnProfile.Appearance.Options.UseFont = true;
            this.btnProfile.Appearance.Options.UseForeColor = true;
            this.btnProfile.Appearance.Options.UseTextOptions = true;
            this.btnProfile.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnProfile.AutoWidthInLayoutControl = true;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.ImageOptions.Image = global::WindowsFormsUI.Properties.Resources.user;
            this.btnProfile.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnProfile.Location = new System.Drawing.Point(-2, 236);
            this.btnProfile.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(15);
            this.btnProfile.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnProfile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnProfile.Size = new System.Drawing.Size(265, 60);
            this.btnProfile.TabIndex = 14;
            this.btnProfile.Text = "    Profil";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnArchives
            // 
            this.btnArchives.AllowFocus = false;
            this.btnArchives.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnArchives.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnArchives.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnArchives.Appearance.Options.UseBackColor = true;
            this.btnArchives.Appearance.Options.UseFont = true;
            this.btnArchives.Appearance.Options.UseForeColor = true;
            this.btnArchives.Appearance.Options.UseTextOptions = true;
            this.btnArchives.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnArchives.AutoWidthInLayoutControl = true;
            this.btnArchives.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnArchives.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArchives.ImageOptions.Image = global::WindowsFormsUI.Properties.Resources.ticket;
            this.btnArchives.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnArchives.Location = new System.Drawing.Point(-2, 171);
            this.btnArchives.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnArchives.Name = "btnArchives";
            this.btnArchives.Padding = new System.Windows.Forms.Padding(15);
            this.btnArchives.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnArchives.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnArchives.Size = new System.Drawing.Size(265, 60);
            this.btnArchives.TabIndex = 13;
            this.btnArchives.Text = "    Biletler";
            this.btnArchives.Click += new System.EventHandler(this.btnArchives_Click);
            // 
            // btnHomePage
            // 
            this.btnHomePage.AllowFocus = false;
            this.btnHomePage.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnHomePage.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHomePage.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHomePage.Appearance.Options.UseBackColor = true;
            this.btnHomePage.Appearance.Options.UseFont = true;
            this.btnHomePage.Appearance.Options.UseForeColor = true;
            this.btnHomePage.Appearance.Options.UseTextOptions = true;
            this.btnHomePage.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnHomePage.AutoWidthInLayoutControl = true;
            this.btnHomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHomePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomePage.ImageOptions.Image = global::WindowsFormsUI.Properties.Resources.home;
            this.btnHomePage.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnHomePage.Location = new System.Drawing.Point(-2, 106);
            this.btnHomePage.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Padding = new System.Windows.Forms.Padding(15);
            this.btnHomePage.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnHomePage.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnHomePage.Size = new System.Drawing.Size(265, 60);
            this.btnHomePage.TabIndex = 12;
            this.btnHomePage.Text = "    Ana Sayfa";
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(260, 83);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1173, 765);
            this.pnlDesktop.TabIndex = 8;
            // 
            // ChauffeurMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 848);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTitleBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChauffeurMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şoför";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChauffeurMainForm_FormClosed);
            this.Load += new System.EventHandler(this.ChauffeurMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitleBar)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlMenu)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDesktop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlTitleBar;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnProfil;
        private System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lblUserName;
        private DevExpress.XtraEditors.PanelControl pnlMenu;
        private DevExpress.XtraEditors.SimpleButton btnProfile;
        private DevExpress.XtraEditors.SimpleButton btnArchives;
        private DevExpress.XtraEditors.SimpleButton btnHomePage;
        private DevExpress.XtraEditors.PanelControl pnlDesktop;
    }
}