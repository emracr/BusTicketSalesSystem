
namespace WindowsFormsUI.Forms
{
    partial class ChauffeurCustomerTicketsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChauffeurCustomerTicketsForm));
            this.pnlTickets = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pnlRecordNotFound = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.lblRecordNotFound = new DevExpress.XtraEditors.LabelControl();
            this.pnlReportsType = new DevExpress.XtraEditors.PanelControl();
            this.btnTicketReportPdf = new DevExpress.XtraEditors.SimpleButton();
            this.btnTicketReportExel = new DevExpress.XtraEditors.SimpleButton();
            this.btnTicketReportWord = new DevExpress.XtraEditors.SimpleButton();
            this.lblDateSearch = new DevExpress.XtraEditors.LabelControl();
            this.peDateSearch = new DevExpress.XtraEditors.PictureEdit();
            this.lblInfo = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.mcTravelDate = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.gcTickets = new DevExpress.XtraGrid.GridControl();
            this.gvTickets = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn0 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTickets)).BeginInit();
            this.pnlTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRecordNotFound)).BeginInit();
            this.pnlRecordNotFound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlReportsType)).BeginInit();
            this.pnlReportsType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peDateSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcTravelDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTickets
            // 
            this.pnlTickets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTickets.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlTickets.Controls.Add(this.labelControl1);
            this.pnlTickets.Controls.Add(this.pnlRecordNotFound);
            this.pnlTickets.Controls.Add(this.pnlReportsType);
            this.pnlTickets.Controls.Add(this.lblDateSearch);
            this.pnlTickets.Controls.Add(this.peDateSearch);
            this.pnlTickets.Controls.Add(this.lblInfo);
            this.pnlTickets.Controls.Add(this.pictureEdit1);
            this.pnlTickets.Controls.Add(this.mcTravelDate);
            this.pnlTickets.Controls.Add(this.gcTickets);
            this.pnlTickets.Location = new System.Drawing.Point(0, 0);
            this.pnlTickets.Name = "pnlTickets";
            this.pnlTickets.Size = new System.Drawing.Size(1173, 766);
            this.pnlTickets.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(21, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(237, 21);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Sorgulamak istediğiniz tarihi seçin";
            // 
            // pnlRecordNotFound
            // 
            this.pnlRecordNotFound.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlRecordNotFound.Controls.Add(this.pictureEdit2);
            this.pnlRecordNotFound.Controls.Add(this.lblRecordNotFound);
            this.pnlRecordNotFound.Location = new System.Drawing.Point(16, 292);
            this.pnlRecordNotFound.Name = "pnlRecordNotFound";
            this.pnlRecordNotFound.Size = new System.Drawing.Size(1145, 464);
            this.pnlRecordNotFound.TabIndex = 21;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(523, 159);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(99, 82);
            this.pictureEdit2.TabIndex = 1;
            // 
            // lblRecordNotFound
            // 
            this.lblRecordNotFound.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRecordNotFound.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblRecordNotFound.Appearance.Options.UseFont = true;
            this.lblRecordNotFound.Appearance.Options.UseForeColor = true;
            this.lblRecordNotFound.Appearance.Options.UseTextOptions = true;
            this.lblRecordNotFound.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblRecordNotFound.AutoEllipsis = true;
            this.lblRecordNotFound.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblRecordNotFound.Location = new System.Drawing.Point(10, 110);
            this.lblRecordNotFound.Name = "lblRecordNotFound";
            this.lblRecordNotFound.Size = new System.Drawing.Size(1126, 30);
            this.lblRecordNotFound.TabIndex = 0;
            this.lblRecordNotFound.Text = "RecordNotFound";
            // 
            // pnlReportsType
            // 
            this.pnlReportsType.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlReportsType.Controls.Add(this.btnTicketReportPdf);
            this.pnlReportsType.Controls.Add(this.btnTicketReportExel);
            this.pnlReportsType.Controls.Add(this.btnTicketReportWord);
            this.pnlReportsType.Location = new System.Drawing.Point(336, 225);
            this.pnlReportsType.Name = "pnlReportsType";
            this.pnlReportsType.Size = new System.Drawing.Size(770, 60);
            this.pnlReportsType.TabIndex = 20;
            // 
            // btnTicketReportPdf
            // 
            this.btnTicketReportPdf.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(54)))), ((int)(((byte)(17)))));
            this.btnTicketReportPdf.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTicketReportPdf.Appearance.Options.UseBackColor = true;
            this.btnTicketReportPdf.Appearance.Options.UseFont = true;
            this.btnTicketReportPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTicketReportPdf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTicketReportPdf.ImageOptions.Image")));
            this.btnTicketReportPdf.Location = new System.Drawing.Point(484, 7);
            this.btnTicketReportPdf.Name = "btnTicketReportPdf";
            this.btnTicketReportPdf.Size = new System.Drawing.Size(160, 47);
            this.btnTicketReportPdf.TabIndex = 15;
            this.btnTicketReportPdf.Text = "Pdf Raporu";
            this.btnTicketReportPdf.Click += new System.EventHandler(this.btnTicketReportPdf_Click);
            // 
            // btnTicketReportExel
            // 
            this.btnTicketReportExel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(135)))), ((int)(((byte)(78)))));
            this.btnTicketReportExel.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTicketReportExel.Appearance.Options.UseBackColor = true;
            this.btnTicketReportExel.Appearance.Options.UseFont = true;
            this.btnTicketReportExel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTicketReportExel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTicketReportExel.ImageOptions.Image")));
            this.btnTicketReportExel.Location = new System.Drawing.Point(308, 7);
            this.btnTicketReportExel.Name = "btnTicketReportExel";
            this.btnTicketReportExel.Size = new System.Drawing.Size(160, 47);
            this.btnTicketReportExel.TabIndex = 19;
            this.btnTicketReportExel.Text = "Exel Raporu";
            this.btnTicketReportExel.Click += new System.EventHandler(this.btnTicketReportExel_Click);
            // 
            // btnTicketReportWord
            // 
            this.btnTicketReportWord.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(126)))), ((int)(((byte)(207)))));
            this.btnTicketReportWord.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTicketReportWord.Appearance.Options.UseBackColor = true;
            this.btnTicketReportWord.Appearance.Options.UseFont = true;
            this.btnTicketReportWord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTicketReportWord.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTicketReportWord.ImageOptions.Image")));
            this.btnTicketReportWord.Location = new System.Drawing.Point(132, 7);
            this.btnTicketReportWord.Name = "btnTicketReportWord";
            this.btnTicketReportWord.Size = new System.Drawing.Size(160, 47);
            this.btnTicketReportWord.TabIndex = 18;
            this.btnTicketReportWord.Text = "Word Raporu";
            this.btnTicketReportWord.Click += new System.EventHandler(this.btnTicketReportWord_Click);
            // 
            // lblDateSearch
            // 
            this.lblDateSearch.Appearance.BackColor = System.Drawing.Color.SeaGreen;
            this.lblDateSearch.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDateSearch.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblDateSearch.Appearance.Options.UseBackColor = true;
            this.lblDateSearch.Appearance.Options.UseFont = true;
            this.lblDateSearch.Appearance.Options.UseForeColor = true;
            this.lblDateSearch.Appearance.Options.UseTextOptions = true;
            this.lblDateSearch.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblDateSearch.AutoEllipsis = true;
            this.lblDateSearch.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblDateSearch.Location = new System.Drawing.Point(415, 160);
            this.lblDateSearch.Name = "lblDateSearch";
            this.lblDateSearch.Size = new System.Drawing.Size(629, 20);
            this.lblDateSearch.TabIndex = 17;
            this.lblDateSearch.Text = "Info";
            // 
            // peDateSearch
            // 
            this.peDateSearch.EditValue = global::WindowsFormsUI.Properties.Resources.bg_info_green2;
            this.peDateSearch.Location = new System.Drawing.Point(347, 139);
            this.peDateSearch.Name = "peDateSearch";
            this.peDateSearch.Properties.AllowFocused = false;
            this.peDateSearch.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peDateSearch.Properties.Appearance.Options.UseBackColor = true;
            this.peDateSearch.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peDateSearch.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peDateSearch.Size = new System.Drawing.Size(754, 82);
            this.peDateSearch.TabIndex = 16;
            // 
            // lblInfo
            // 
            this.lblInfo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(122)))), ((int)(((byte)(24)))));
            this.lblInfo.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblInfo.Appearance.Options.UseBackColor = true;
            this.lblInfo.Appearance.Options.UseFont = true;
            this.lblInfo.Appearance.Options.UseForeColor = true;
            this.lblInfo.Appearance.Options.UseTextOptions = true;
            this.lblInfo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblInfo.AutoEllipsis = true;
            this.lblInfo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblInfo.Location = new System.Drawing.Point(377, 49);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(688, 20);
            this.lblInfo.TabIndex = 14;
            this.lblInfo.Text = "Info";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::WindowsFormsUI.Properties.Resources.bg_orange_info;
            this.pictureEdit1.Location = new System.Drawing.Point(336, 20);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(770, 121);
            this.pictureEdit1.TabIndex = 13;
            // 
            // mcTravelDate
            // 
            this.mcTravelDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mcTravelDate.DateTime = new System.DateTime(2021, 6, 11, 0, 0, 0, 0);
            this.mcTravelDate.EditValue = new System.DateTime(2021, 6, 11, 0, 0, 0, 0);
            this.mcTravelDate.Location = new System.Drawing.Point(16, 42);
            this.mcTravelDate.Name = "mcTravelDate";
            this.mcTravelDate.Size = new System.Drawing.Size(225, 235);
            this.mcTravelDate.TabIndex = 11;
            this.mcTravelDate.DateTimeChanged += new System.EventHandler(this.mcTravelDate_DateTimeChanged);
            // 
            // gcTickets
            // 
            this.gcTickets.Location = new System.Drawing.Point(16, 292);
            this.gcTickets.MainView = this.gvTickets;
            this.gcTickets.Name = "gcTickets";
            this.gcTickets.Size = new System.Drawing.Size(1140, 464);
            this.gcTickets.TabIndex = 9;
            this.gcTickets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTickets});
            // 
            // gvTickets
            // 
            this.gvTickets.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(105)))));
            this.gvTickets.Appearance.Empty.Options.UseBackColor = true;
            this.gvTickets.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(76)))), ((int)(((byte)(8)))));
            this.gvTickets.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(124)))), ((int)(((byte)(16)))));
            this.gvTickets.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvTickets.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvTickets.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvTickets.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gvTickets.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvTickets.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvTickets.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvTickets.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(108)))), ((int)(((byte)(39)))));
            this.gvTickets.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(164)))), ((int)(((byte)(39)))));
            this.gvTickets.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gvTickets.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvTickets.Appearance.Row.Options.UseBackColor = true;
            this.gvTickets.Appearance.Row.Options.UseFont = true;
            this.gvTickets.Appearance.Row.Options.UseForeColor = true;
            this.gvTickets.Appearance.Row.Options.UseTextOptions = true;
            this.gvTickets.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvTickets.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvTickets.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn0,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn9,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.gvTickets.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gvTickets.GridControl = this.gcTickets;
            this.gvTickets.Name = "gvTickets";
            this.gvTickets.OptionsBehavior.ReadOnly = true;
            this.gvTickets.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvTickets.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvTickets.OptionsView.RowAutoHeight = true;
            this.gvTickets.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvTickets.RowHeight = 35;
            // 
            // gridColumn0
            // 
            this.gridColumn0.Caption = "TC";
            this.gridColumn0.FieldName = "TC";
            this.gridColumn0.Name = "gridColumn0";
            this.gridColumn0.Visible = true;
            this.gridColumn0.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ad";
            this.gridColumn1.FieldName = "FirstName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Soyad";
            this.gridColumn2.FieldName = "LastName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Telefon";
            this.gridColumn9.FieldName = "Phone";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nereden";
            this.gridColumn3.FieldName = "FromCity";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Nereye";
            this.gridColumn4.FieldName = "DestinationCity";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Saat";
            this.gridColumn5.FieldName = "DepartureTime";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Tarih";
            this.gridColumn6.FieldName = "DepartureDate";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 7;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Koltuk";
            this.gridColumn7.FieldName = "Seat";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 8;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Fiyat";
            this.gridColumn8.FieldName = "Price";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // ChauffeurCustomerTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1173, 766);
            this.Controls.Add(this.pnlTickets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChauffeurCustomerTicketsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biletler";
            this.Load += new System.EventHandler(this.ChauffeurCustomerTicketsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTickets)).EndInit();
            this.pnlTickets.ResumeLayout(false);
            this.pnlTickets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRecordNotFound)).EndInit();
            this.pnlRecordNotFound.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlReportsType)).EndInit();
            this.pnlReportsType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peDateSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcTravelDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlTickets;
        private DevExpress.XtraEditors.Controls.CalendarControl mcTravelDate;
        private DevExpress.XtraGrid.GridControl gcTickets;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTickets;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn0;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.LabelControl lblInfo;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl lblDateSearch;
        private DevExpress.XtraEditors.PictureEdit peDateSearch;
        private DevExpress.XtraEditors.SimpleButton btnTicketReportPdf;
        private DevExpress.XtraEditors.SimpleButton btnTicketReportExel;
        private DevExpress.XtraEditors.SimpleButton btnTicketReportWord;
        private DevExpress.XtraEditors.PanelControl pnlReportsType;
        private DevExpress.XtraEditors.PanelControl pnlRecordNotFound;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.LabelControl lblRecordNotFound;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}