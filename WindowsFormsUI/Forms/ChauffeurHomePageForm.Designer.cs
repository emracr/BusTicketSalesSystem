
namespace WindowsFormsUI.Forms
{
    partial class ChauffeurHomePageForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChauffeurHomePageForm));
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.pnlDateAndTime = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblTravelInfo = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lblTime = new DevExpress.XtraEditors.LabelControl();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDateAndTime)).BeginInit();
            this.pnlDateAndTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrClock
            // 
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // pnlDateAndTime
            // 
            this.pnlDateAndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDateAndTime.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlDateAndTime.Controls.Add(this.panelControl1);
            this.pnlDateAndTime.Controls.Add(this.lblTime);
            this.pnlDateAndTime.Controls.Add(this.lblDate);
            this.pnlDateAndTime.Location = new System.Drawing.Point(0, 0);
            this.pnlDateAndTime.Name = "pnlDateAndTime";
            this.pnlDateAndTime.Size = new System.Drawing.Size(1173, 766);
            this.pnlDateAndTime.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.lblTravelInfo);
            this.panelControl1.Controls.Add(this.pictureEdit1);
            this.panelControl1.Location = new System.Drawing.Point(106, 435);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(984, 209);
            this.panelControl1.TabIndex = 16;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(63)))), ((int)(((byte)(46)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(485, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(176, 30);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Önemli Hatırlatma!";
            // 
            // lblTravelInfo
            // 
            this.lblTravelInfo.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTravelInfo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTravelInfo.Appearance.Options.UseFont = true;
            this.lblTravelInfo.Appearance.Options.UseForeColor = true;
            this.lblTravelInfo.Appearance.Options.UseTextOptions = true;
            this.lblTravelInfo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTravelInfo.AutoEllipsis = true;
            this.lblTravelInfo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblTravelInfo.Location = new System.Drawing.Point(219, 78);
            this.lblTravelInfo.Name = "lblTravelInfo";
            this.lblTravelInfo.Size = new System.Drawing.Size(710, 21);
            this.lblTravelInfo.TabIndex = 16;
            this.lblTravelInfo.Text = "Info";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::WindowsFormsUI.Properties.Resources.warn;
            this.pictureEdit1.Location = new System.Drawing.Point(30, 35);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(155, 143);
            this.pictureEdit1.TabIndex = 15;
            // 
            // lblTime
            // 
            this.lblTime.Appearance.Font = new System.Drawing.Font("Century Gothic", 48F);
            this.lblTime.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.lblTime.Appearance.Options.UseFont = true;
            this.lblTime.Appearance.Options.UseForeColor = true;
            this.lblTime.Appearance.Options.UseTextOptions = true;
            this.lblTime.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTime.AutoEllipsis = true;
            this.lblTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTime.Location = new System.Drawing.Point(21, 216);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(1130, 100);
            this.lblTime.TabIndex = 14;
            // 
            // lblDate
            // 
            this.lblDate.Appearance.Font = new System.Drawing.Font("Century Gothic", 48F);
            this.lblDate.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.lblDate.Appearance.Options.UseFont = true;
            this.lblDate.Appearance.Options.UseForeColor = true;
            this.lblDate.Appearance.Options.UseTextOptions = true;
            this.lblDate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblDate.AutoEllipsis = true;
            this.lblDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDate.Location = new System.Drawing.Point(22, 97);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(1130, 100);
            this.lblDate.TabIndex = 13;
            // 
            // ChauffeurHomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1173, 765);
            this.Controls.Add(this.pnlDateAndTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChauffeurHomePageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.ChauffeurHomePageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDateAndTime)).EndInit();
            this.pnlDateAndTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrClock;
        private DevExpress.XtraEditors.PanelControl pnlDateAndTime;
        private DevExpress.XtraEditors.LabelControl lblTime;
        private DevExpress.XtraEditors.LabelControl lblDate;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lblTravelInfo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}