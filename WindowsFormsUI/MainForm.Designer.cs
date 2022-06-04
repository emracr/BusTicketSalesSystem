
namespace WindowsFormsUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnllogo = new DevExpress.XtraEditors.PanelControl();
            this.peLogo = new DevExpress.XtraEditors.PictureEdit();
            this.lblLogoText = new DevExpress.XtraEditors.LabelControl();
            this.pnlMenu = new DevExpress.XtraEditors.PanelControl();
            this.btnMyProfile = new DevExpress.XtraEditors.SimpleButton();
            this.btnMyTicktes = new DevExpress.XtraEditors.SimpleButton();
            this.btnGetTicket = new DevExpress.XtraEditors.SimpleButton();
            this.btnHomePage = new DevExpress.XtraEditors.SimpleButton();
            this.pnlTitleBar = new DevExpress.XtraEditors.PanelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnProfile = new DevExpress.XtraEditors.SimpleButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pnlDesktop = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnllogo)).BeginInit();
            this.pnllogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMenu)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitleBar)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDesktop)).BeginInit();
            this.SuspendLayout();
            // 
            // pnllogo
            // 
            this.pnllogo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnllogo.Appearance.Options.UseBackColor = true;
            this.pnllogo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnllogo.Controls.Add(this.peLogo);
            this.pnllogo.Controls.Add(this.lblLogoText);
            this.pnllogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnllogo.Location = new System.Drawing.Point(0, 0);
            this.pnllogo.Name = "pnllogo";
            this.pnllogo.Size = new System.Drawing.Size(260, 184);
            this.pnllogo.TabIndex = 8;
            // 
            // peLogo
            // 
            this.peLogo.EditValue = global::WindowsFormsUI.Properties.Resources.suitcase;
            this.peLogo.Location = new System.Drawing.Point(71, 36);
            this.peLogo.Name = "peLogo";
            this.peLogo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.peLogo.Properties.Appearance.Options.UseBackColor = true;
            this.peLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peLogo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peLogo.Size = new System.Drawing.Size(139, 139);
            this.peLogo.TabIndex = 1;
            // 
            // lblLogoText
            // 
            this.lblLogoText.Appearance.Font = new System.Drawing.Font("Century Gothic", 12.75F);
            this.lblLogoText.Appearance.ForeColor = System.Drawing.Color.LightGray;
            this.lblLogoText.Appearance.Options.UseFont = true;
            this.lblLogoText.Appearance.Options.UseForeColor = true;
            this.lblLogoText.Location = new System.Drawing.Point(42, 9);
            this.lblLogoText.Name = "lblLogoText";
            this.lblLogoText.Size = new System.Drawing.Size(177, 21);
            this.lblLogoText.TabIndex = 2;
            this.lblLogoText.Text = "Bilet almanın kısa yolu";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlMenu.Appearance.Options.UseBackColor = true;
            this.pnlMenu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlMenu.Controls.Add(this.btnMyProfile);
            this.pnlMenu.Controls.Add(this.btnMyTicktes);
            this.pnlMenu.Controls.Add(this.btnGetTicket);
            this.pnlMenu.Controls.Add(this.btnHomePage);
            this.pnlMenu.Controls.Add(this.pnllogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(260, 848);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.AllowFocus = false;
            this.btnMyProfile.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnMyProfile.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMyProfile.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMyProfile.Appearance.Options.UseBackColor = true;
            this.btnMyProfile.Appearance.Options.UseFont = true;
            this.btnMyProfile.Appearance.Options.UseForeColor = true;
            this.btnMyProfile.Appearance.Options.UseTextOptions = true;
            this.btnMyProfile.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnMyProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMyProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyProfile.ImageOptions.Image = global::WindowsFormsUI.Properties.Resources.user;
            this.btnMyProfile.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnMyProfile.Location = new System.Drawing.Point(-3, 480);
            this.btnMyProfile.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Padding = new System.Windows.Forms.Padding(15);
            this.btnMyProfile.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnMyProfile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnMyProfile.Size = new System.Drawing.Size(265, 60);
            this.btnMyProfile.TabIndex = 15;
            this.btnMyProfile.Text = "    Profil";
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            // 
            // btnMyTicktes
            // 
            this.btnMyTicktes.AllowFocus = false;
            this.btnMyTicktes.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnMyTicktes.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMyTicktes.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMyTicktes.Appearance.Options.UseBackColor = true;
            this.btnMyTicktes.Appearance.Options.UseFont = true;
            this.btnMyTicktes.Appearance.Options.UseForeColor = true;
            this.btnMyTicktes.Appearance.Options.UseTextOptions = true;
            this.btnMyTicktes.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnMyTicktes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMyTicktes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyTicktes.ImageOptions.Image = global::WindowsFormsUI.Properties.Resources.ticket;
            this.btnMyTicktes.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnMyTicktes.Location = new System.Drawing.Point(-3, 420);
            this.btnMyTicktes.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnMyTicktes.Name = "btnMyTicktes";
            this.btnMyTicktes.Padding = new System.Windows.Forms.Padding(15);
            this.btnMyTicktes.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnMyTicktes.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnMyTicktes.Size = new System.Drawing.Size(265, 60);
            this.btnMyTicktes.TabIndex = 14;
            this.btnMyTicktes.Text = "    Biletlerim";
            this.btnMyTicktes.Click += new System.EventHandler(this.btnMyTicktes_Click);
            // 
            // btnGetTicket
            // 
            this.btnGetTicket.AllowFocus = false;
            this.btnGetTicket.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnGetTicket.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGetTicket.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGetTicket.Appearance.Options.UseBackColor = true;
            this.btnGetTicket.Appearance.Options.UseFont = true;
            this.btnGetTicket.Appearance.Options.UseForeColor = true;
            this.btnGetTicket.Appearance.Options.UseTextOptions = true;
            this.btnGetTicket.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.btnGetTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGetTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetTicket.ImageOptions.Image = global::WindowsFormsUI.Properties.Resources.bus_icon;
            this.btnGetTicket.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnGetTicket.Location = new System.Drawing.Point(-3, 360);
            this.btnGetTicket.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnGetTicket.Name = "btnGetTicket";
            this.btnGetTicket.Padding = new System.Windows.Forms.Padding(15);
            this.btnGetTicket.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnGetTicket.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnGetTicket.Size = new System.Drawing.Size(265, 60);
            this.btnGetTicket.TabIndex = 13;
            this.btnGetTicket.Text = "    Bilet al";
            this.btnGetTicket.Click += new System.EventHandler(this.btnGetTicket_Click);
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
            this.btnHomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHomePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomePage.ImageOptions.Image = global::WindowsFormsUI.Properties.Resources.home;
            this.btnHomePage.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnHomePage.Location = new System.Drawing.Point(-3, 300);
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
            // pnlTitleBar
            // 
            this.pnlTitleBar.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnlTitleBar.Appearance.Options.UseBackColor = true;
            this.pnlTitleBar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.pnlTitleBar.Controls.Add(this.btnProfile);
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Controls.Add(this.lblUserName);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(260, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1173, 83);
            this.pnlTitleBar.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.AllowFocus = false;
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
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
            this.btnExit.Location = new System.Drawing.Point(1081, 19);
            this.btnExit.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnExit.Name = "btnExit";
            this.btnExit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnExit.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnExit.Size = new System.Drawing.Size(89, 47);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = " Çıkış";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.AllowFocus = false;
            this.btnProfile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnProfile.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnProfile.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnProfile.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Appearance.Options.UseBackColor = true;
            this.btnProfile.Appearance.Options.UseFont = true;
            this.btnProfile.Appearance.Options.UseForeColor = true;
            this.btnProfile.Appearance.Options.UseTextOptions = true;
            this.btnProfile.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.ImageOptions.Image = global::WindowsFormsUI.Properties.Resources.user;
            this.btnProfile.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnProfile.Location = new System.Drawing.Point(967, 19);
            this.btnProfile.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnProfile.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnProfile.Size = new System.Drawing.Size(100, 47);
            this.btnProfile.TabIndex = 16;
            this.btnProfile.Text = "   Profil";
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(468, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(247, 37);
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
            this.lblUserName.Location = new System.Drawing.Point(764, 27);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(210, 33);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "UserName";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(260, 83);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1173, 765);
            this.pnlDesktop.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 848);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otobüs Bilet Satış";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnllogo)).EndInit();
            this.pnllogo.ResumeLayout(false);
            this.pnllogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMenu)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitleBar)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDesktop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl pnllogo;
        private DevExpress.XtraEditors.PictureEdit peLogo;
        private DevExpress.XtraEditors.LabelControl lblLogoText;
        private DevExpress.XtraEditors.PanelControl pnlMenu;
        private DevExpress.XtraEditors.PanelControl pnlTitleBar;
        public System.Windows.Forms.Label lblUserName;
        private DevExpress.XtraEditors.PanelControl pnlDesktop;
        private DevExpress.XtraEditors.SimpleButton btnHomePage;
        private DevExpress.XtraEditors.SimpleButton btnMyProfile;
        private DevExpress.XtraEditors.SimpleButton btnMyTicktes;
        private DevExpress.XtraEditors.SimpleButton btnGetTicket;
        private System.Windows.Forms.Label lblTitle;
        private DevExpress.XtraEditors.SimpleButton btnProfile;
        private DevExpress.XtraEditors.SimpleButton btnExit;
    }
}

