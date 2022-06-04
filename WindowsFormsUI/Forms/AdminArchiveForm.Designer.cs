
namespace WindowsFormsUI.Forms
{
    partial class AdminArchiveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminArchiveForm));
            this.pnlArchives = new DevExpress.XtraEditors.PanelControl();
            this.pnlTicketsDiv = new DevExpress.XtraEditors.PanelControl();
            this.lblTicketCount = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.pnlUsersDiv = new DevExpress.XtraEditors.PanelControl();
            this.lblUsersCount = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pnlDeletedCustomers = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gcDeletedCustomers = new DevExpress.XtraGrid.GridControl();
            this.gvDeletedCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlDeletedTickets = new DevExpress.XtraEditors.PanelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.gcTickets = new DevExpress.XtraGrid.GridControl();
            this.gvTickets = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pnlArchives)).BeginInit();
            this.pnlArchives.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTicketsDiv)).BeginInit();
            this.pnlTicketsDiv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUsersDiv)).BeginInit();
            this.pnlUsersDiv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDeletedCustomers)).BeginInit();
            this.pnlDeletedCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDeletedCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeletedCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDeletedTickets)).BeginInit();
            this.pnlDeletedTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlArchives
            // 
            this.pnlArchives.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlArchives.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(105)))));
            this.pnlArchives.Appearance.Options.UseBackColor = true;
            this.pnlArchives.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlArchives.Controls.Add(this.pnlTicketsDiv);
            this.pnlArchives.Controls.Add(this.pnlUsersDiv);
            this.pnlArchives.Location = new System.Drawing.Point(0, 0);
            this.pnlArchives.Name = "pnlArchives";
            this.pnlArchives.Size = new System.Drawing.Size(1174, 768);
            this.pnlArchives.TabIndex = 0;
            // 
            // pnlTicketsDiv
            // 
            this.pnlTicketsDiv.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(141)))), ((int)(((byte)(242)))));
            this.pnlTicketsDiv.Appearance.Options.UseBackColor = true;
            this.pnlTicketsDiv.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlTicketsDiv.Controls.Add(this.lblTicketCount);
            this.pnlTicketsDiv.Controls.Add(this.pictureEdit2);
            this.pnlTicketsDiv.Controls.Add(this.labelControl4);
            this.pnlTicketsDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlTicketsDiv.Location = new System.Drawing.Point(626, 242);
            this.pnlTicketsDiv.Name = "pnlTicketsDiv";
            this.pnlTicketsDiv.Size = new System.Drawing.Size(242, 204);
            this.pnlTicketsDiv.TabIndex = 5;
            this.pnlTicketsDiv.Click += new System.EventHandler(this.pnlTicketsDiv_Click);
            // 
            // lblTicketCount
            // 
            this.lblTicketCount.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTicketCount.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblTicketCount.Appearance.Options.UseFont = true;
            this.lblTicketCount.Appearance.Options.UseForeColor = true;
            this.lblTicketCount.Appearance.Options.UseTextOptions = true;
            this.lblTicketCount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTicketCount.AutoEllipsis = true;
            this.lblTicketCount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTicketCount.Location = new System.Drawing.Point(13, 138);
            this.lblTicketCount.Name = "lblTicketCount";
            this.lblTicketCount.Size = new System.Drawing.Size(216, 32);
            this.lblTicketCount.TabIndex = 2;
            this.lblTicketCount.Text = "0";
            this.lblTicketCount.Click += new System.EventHandler(this.pnlTicketsDiv_Click);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = global::WindowsFormsUI.Properties.Resources.tickets__1_;
            this.pictureEdit2.Location = new System.Drawing.Point(98, 75);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.AllowFocused = false;
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(50, 53);
            this.pictureEdit2.TabIndex = 1;
            this.pictureEdit2.Click += new System.EventHandler(this.pnlTicketsDiv_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl4.AutoEllipsis = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(13, 37);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(216, 30);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Biletler";
            this.labelControl4.Click += new System.EventHandler(this.pnlTicketsDiv_Click);
            // 
            // pnlUsersDiv
            // 
            this.pnlUsersDiv.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.pnlUsersDiv.Appearance.Options.UseBackColor = true;
            this.pnlUsersDiv.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlUsersDiv.Controls.Add(this.lblUsersCount);
            this.pnlUsersDiv.Controls.Add(this.pictureEdit1);
            this.pnlUsersDiv.Controls.Add(this.labelControl2);
            this.pnlUsersDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlUsersDiv.Location = new System.Drawing.Point(303, 242);
            this.pnlUsersDiv.Name = "pnlUsersDiv";
            this.pnlUsersDiv.Size = new System.Drawing.Size(242, 204);
            this.pnlUsersDiv.TabIndex = 4;
            this.pnlUsersDiv.Click += new System.EventHandler(this.pnlUsersDiv_Click);
            // 
            // lblUsersCount
            // 
            this.lblUsersCount.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUsersCount.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblUsersCount.Appearance.Options.UseFont = true;
            this.lblUsersCount.Appearance.Options.UseForeColor = true;
            this.lblUsersCount.Appearance.Options.UseTextOptions = true;
            this.lblUsersCount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblUsersCount.AutoEllipsis = true;
            this.lblUsersCount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblUsersCount.Location = new System.Drawing.Point(13, 138);
            this.lblUsersCount.Name = "lblUsersCount";
            this.lblUsersCount.Size = new System.Drawing.Size(216, 32);
            this.lblUsersCount.TabIndex = 2;
            this.lblUsersCount.Text = "0";
            this.lblUsersCount.Click += new System.EventHandler(this.pnlUsersDiv_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::WindowsFormsUI.Properties.Resources.user__13_;
            this.pictureEdit1.Location = new System.Drawing.Point(98, 75);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(50, 53);
            this.pictureEdit1.TabIndex = 1;
            this.pictureEdit1.Click += new System.EventHandler(this.pnlUsersDiv_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoEllipsis = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(13, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(216, 30);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Kullanıcılar";
            this.labelControl2.Click += new System.EventHandler(this.pnlUsersDiv_Click);
            // 
            // pnlDeletedCustomers
            // 
            this.pnlDeletedCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDeletedCustomers.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(105)))));
            this.pnlDeletedCustomers.Appearance.Options.UseBackColor = true;
            this.pnlDeletedCustomers.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlDeletedCustomers.Controls.Add(this.labelControl1);
            this.pnlDeletedCustomers.Controls.Add(this.gcDeletedCustomers);
            this.pnlDeletedCustomers.Location = new System.Drawing.Point(0, 0);
            this.pnlDeletedCustomers.Name = "pnlDeletedCustomers";
            this.pnlDeletedCustomers.Size = new System.Drawing.Size(1174, 768);
            this.pnlDeletedCustomers.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoEllipsis = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(13, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1149, 65);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Silinen Kullanıcılar";
            // 
            // gcDeletedCustomers
            // 
            this.gcDeletedCustomers.Location = new System.Drawing.Point(18, 85);
            this.gcDeletedCustomers.MainView = this.gvDeletedCustomers;
            this.gcDeletedCustomers.Name = "gcDeletedCustomers";
            this.gcDeletedCustomers.Size = new System.Drawing.Size(1140, 670);
            this.gcDeletedCustomers.TabIndex = 6;
            this.gcDeletedCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDeletedCustomers});
            // 
            // gvDeletedCustomers
            // 
            this.gvDeletedCustomers.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(105)))));
            this.gvDeletedCustomers.Appearance.Empty.Options.UseBackColor = true;
            this.gvDeletedCustomers.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(76)))), ((int)(((byte)(8)))));
            this.gvDeletedCustomers.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(124)))), ((int)(((byte)(16)))));
            this.gvDeletedCustomers.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvDeletedCustomers.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvDeletedCustomers.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvDeletedCustomers.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gvDeletedCustomers.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvDeletedCustomers.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvDeletedCustomers.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDeletedCustomers.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(108)))), ((int)(((byte)(39)))));
            this.gvDeletedCustomers.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(164)))), ((int)(((byte)(39)))));
            this.gvDeletedCustomers.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gvDeletedCustomers.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gvDeletedCustomers.Appearance.Row.Options.UseBackColor = true;
            this.gvDeletedCustomers.Appearance.Row.Options.UseFont = true;
            this.gvDeletedCustomers.Appearance.Row.Options.UseForeColor = true;
            this.gvDeletedCustomers.Appearance.Row.Options.UseTextOptions = true;
            this.gvDeletedCustomers.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvDeletedCustomers.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvDeletedCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gvDeletedCustomers.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gvDeletedCustomers.GridControl = this.gcDeletedCustomers;
            this.gvDeletedCustomers.Name = "gvDeletedCustomers";
            this.gvDeletedCustomers.OptionsBehavior.ReadOnly = true;
            this.gvDeletedCustomers.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvDeletedCustomers.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gvDeletedCustomers.OptionsView.RowAutoHeight = true;
            this.gvDeletedCustomers.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvDeletedCustomers.RowHeight = 35;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "TC";
            this.gridColumn1.FieldName = "TC";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Ad";
            this.gridColumn2.FieldName = "FirstName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Soyad";
            this.gridColumn3.FieldName = "LastName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Telefon";
            this.gridColumn4.FieldName = "Phone";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Email";
            this.gridColumn5.FieldName = "Email";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Cinsiyet";
            this.gridColumn6.FieldName = "Gender";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // pnlDeletedTickets
            // 
            this.pnlDeletedTickets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDeletedTickets.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(105)))));
            this.pnlDeletedTickets.Appearance.Options.UseBackColor = true;
            this.pnlDeletedTickets.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlDeletedTickets.Controls.Add(this.labelControl5);
            this.pnlDeletedTickets.Controls.Add(this.gcTickets);
            this.pnlDeletedTickets.Location = new System.Drawing.Point(0, 0);
            this.pnlDeletedTickets.Name = "pnlDeletedTickets";
            this.pnlDeletedTickets.Size = new System.Drawing.Size(1174, 768);
            this.pnlDeletedTickets.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl5.AutoEllipsis = true;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(13, 13);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(1149, 65);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Silinen Biletler";
            // 
            // gcTickets
            // 
            this.gcTickets.Location = new System.Drawing.Point(18, 85);
            this.gcTickets.MainView = this.gvTickets;
            this.gcTickets.Name = "gcTickets";
            this.gcTickets.Size = new System.Drawing.Size(1140, 670);
            this.gcTickets.TabIndex = 8;
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
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15});
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
            // gridColumn7
            // 
            this.gridColumn7.Caption = "TC";
            this.gridColumn7.FieldName = "TC";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Ad";
            this.gridColumn8.FieldName = "FirstName";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Soyad";
            this.gridColumn9.FieldName = "LastName";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Nereden";
            this.gridColumn10.FieldName = "FromCity";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Nereye";
            this.gridColumn11.FieldName = "DestinationCity";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 4;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Saat";
            this.gridColumn12.FieldName = "DepartureTime";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 5;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Tarih";
            this.gridColumn13.FieldName = "DepartureDate";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 6;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Koltuk";
            this.gridColumn14.FieldName = "Seat";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 7;
            // 
            // gridColumn15
            // 
            this.gridColumn15.Caption = "Fiyat";
            this.gridColumn15.FieldName = "Price";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 8;
            // 
            // AdminArchiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1174, 768);
            this.Controls.Add(this.pnlDeletedTickets);
            this.Controls.Add(this.pnlDeletedCustomers);
            this.Controls.Add(this.pnlArchives);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminArchiveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arşivler";
            this.Load += new System.EventHandler(this.AdminArchiveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlArchives)).EndInit();
            this.pnlArchives.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTicketsDiv)).EndInit();
            this.pnlTicketsDiv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUsersDiv)).EndInit();
            this.pnlUsersDiv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDeletedCustomers)).EndInit();
            this.pnlDeletedCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDeletedCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDeletedCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDeletedTickets)).EndInit();
            this.pnlDeletedTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlArchives;
        private DevExpress.XtraEditors.PanelControl pnlTicketsDiv;
        private DevExpress.XtraEditors.LabelControl lblTicketCount;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.PanelControl pnlUsersDiv;
        private DevExpress.XtraEditors.LabelControl lblUsersCount;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl pnlDeletedCustomers;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gcDeletedCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDeletedCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.PanelControl pnlDeletedTickets;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.GridControl gcTickets;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTickets;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
    }
}