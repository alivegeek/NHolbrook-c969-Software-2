
namespace NHolbrook_c969_Software_2
{
    partial class Main
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
            this.viewSelectorLabel = new System.Windows.Forms.Label();
            this.radioWeek = new System.Windows.Forms.RadioButton();
            this.radioMonth = new System.Windows.Forms.RadioButton();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.apptsDGV = new System.Windows.Forms.DataGridView();
            this.buttonAddCust = new System.Windows.Forms.Button();
            this.buttonModCustomer = new System.Windows.Forms.Button();
            this.buttonDelCustomer = new System.Windows.Forms.Button();
            this.bttnConsultantSched = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.customerList = new System.Windows.Forms.GroupBox();
            this.customerDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteAppts = new System.Windows.Forms.Button();
            this.buttonModifyAppts = new System.Windows.Forms.Button();
            this.addAppointmentsButton = new System.Windows.Forms.Button();
            this.groupReports = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.bttnAppByMonth = new System.Windows.Forms.Button();
            this.bttnLogOut = new System.Windows.Forms.Button();
            this.customerIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.apptsDGV)).BeginInit();
            this.customerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // viewSelectorLabel
            // 
            this.viewSelectorLabel.AutoSize = true;
            this.viewSelectorLabel.Location = new System.Drawing.Point(721, 17);
            this.viewSelectorLabel.Name = "viewSelectorLabel";
            this.viewSelectorLabel.Size = new System.Drawing.Size(93, 13);
            this.viewSelectorLabel.TabIndex = 1;
            this.viewSelectorLabel.Text = "View Calendar By:";
            // 
            // radioWeek
            // 
            this.radioWeek.AutoSize = true;
            this.radioWeek.Location = new System.Drawing.Point(837, 15);
            this.radioWeek.Name = "radioWeek";
            this.radioWeek.Size = new System.Drawing.Size(54, 17);
            this.radioWeek.TabIndex = 2;
            this.radioWeek.TabStop = true;
            this.radioWeek.Text = "Week";
            this.radioWeek.UseVisualStyleBackColor = true;
            // 
            // radioMonth
            // 
            this.radioMonth.AutoSize = true;
            this.radioMonth.Location = new System.Drawing.Point(897, 15);
            this.radioMonth.Name = "radioMonth";
            this.radioMonth.Size = new System.Drawing.Size(55, 17);
            this.radioMonth.TabIndex = 3;
            this.radioMonth.TabStop = true;
            this.radioMonth.Text = "Month";
            this.radioMonth.UseVisualStyleBackColor = true;
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Location = new System.Drawing.Point(958, 15);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(36, 17);
            this.radioAll.TabIndex = 4;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "All";
            this.radioAll.UseVisualStyleBackColor = true;
            // 
            // apptsDGV
            // 
            this.apptsDGV.AllowUserToAddRows = false;
            this.apptsDGV.AllowUserToDeleteRows = false;
            this.apptsDGV.AllowUserToResizeRows = false;
            this.apptsDGV.AutoGenerateColumns = false;
            this.apptsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.apptsDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.apptsDGV.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.apptsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.apptsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apptsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentIDDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.createdByDataGridViewTextBoxColumn,
            this.lastUpdateDataGridViewTextBoxColumn,
            this.lastUpdatedByDataGridViewTextBoxColumn});
            this.apptsDGV.DataSource = this.appointmentsBindingSource;
            this.apptsDGV.Location = new System.Drawing.Point(6, 43);
            this.apptsDGV.MultiSelect = false;
            this.apptsDGV.Name = "apptsDGV";
            this.apptsDGV.ReadOnly = true;
            this.apptsDGV.RowHeadersWidth = 51;
            this.apptsDGV.Size = new System.Drawing.Size(988, 284);
            this.apptsDGV.TabIndex = 5;
            // 
            // buttonAddCust
            // 
            this.buttonAddCust.Location = new System.Drawing.Point(773, 14);
            this.buttonAddCust.Name = "buttonAddCust";
            this.buttonAddCust.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCust.TabIndex = 8;
            this.buttonAddCust.Text = "Add";
            this.buttonAddCust.UseVisualStyleBackColor = true;
            this.buttonAddCust.Click += new System.EventHandler(this.buttonAddCust_Click);
            // 
            // buttonModCustomer
            // 
            this.buttonModCustomer.Location = new System.Drawing.Point(773, 43);
            this.buttonModCustomer.Name = "buttonModCustomer";
            this.buttonModCustomer.Size = new System.Drawing.Size(75, 23);
            this.buttonModCustomer.TabIndex = 9;
            this.buttonModCustomer.Text = "Modify";
            this.buttonModCustomer.UseVisualStyleBackColor = true;
            this.buttonModCustomer.Click += new System.EventHandler(this.buttonModCustomer_Click);
            // 
            // buttonDelCustomer
            // 
            this.buttonDelCustomer.Location = new System.Drawing.Point(773, 72);
            this.buttonDelCustomer.Name = "buttonDelCustomer";
            this.buttonDelCustomer.Size = new System.Drawing.Size(75, 23);
            this.buttonDelCustomer.TabIndex = 10;
            this.buttonDelCustomer.Text = "Delete";
            this.buttonDelCustomer.UseVisualStyleBackColor = true;
            this.buttonDelCustomer.Click += new System.EventHandler(this.buttonDelCustomer_Click);
            // 
            // bttnConsultantSched
            // 
            this.bttnConsultantSched.Location = new System.Drawing.Point(10, 28);
            this.bttnConsultantSched.Name = "bttnConsultantSched";
            this.bttnConsultantSched.Size = new System.Drawing.Size(203, 52);
            this.bttnConsultantSched.TabIndex = 11;
            this.bttnConsultantSched.Text = "Consultant Schedule";
            this.bttnConsultantSched.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(1003, 589);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(93, 39);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // customerList
            // 
            this.customerList.Controls.Add(this.customerDGV);
            this.customerList.Controls.Add(this.buttonAddCust);
            this.customerList.Controls.Add(this.buttonDelCustomer);
            this.customerList.Controls.Add(this.buttonModCustomer);
            this.customerList.Location = new System.Drawing.Point(21, 351);
            this.customerList.Name = "customerList";
            this.customerList.Size = new System.Drawing.Size(854, 277);
            this.customerList.TabIndex = 15;
            this.customerList.TabStop = false;
            this.customerList.Text = "Customers";
            // 
            // customerDGV
            // 
            this.customerDGV.AllowUserToAddRows = false;
            this.customerDGV.AllowUserToDeleteRows = false;
            this.customerDGV.AutoGenerateColumns = false;
            this.customerDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDGV.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.customerDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.customerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn1,
            this.customerNameDataGridViewTextBoxColumn,
            this.lastUpdateDataGridViewTextBoxColumn1});
            this.customerDGV.DataSource = this.customerBindingSource;
            this.customerDGV.Location = new System.Drawing.Point(6, 14);
            this.customerDGV.Margin = new System.Windows.Forms.Padding(2);
            this.customerDGV.MultiSelect = false;
            this.customerDGV.Name = "customerDGV";
            this.customerDGV.ReadOnly = true;
            this.customerDGV.RowHeadersWidth = 51;
            this.customerDGV.RowTemplate.Height = 24;
            this.customerDGV.Size = new System.Drawing.Size(762, 258);
            this.customerDGV.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.buttonDeleteAppts);
            this.groupBox1.Controls.Add(this.buttonModifyAppts);
            this.groupBox1.Controls.Add(this.addAppointmentsButton);
            this.groupBox1.Controls.Add(this.apptsDGV);
            this.groupBox1.Controls.Add(this.viewSelectorLabel);
            this.groupBox1.Controls.Add(this.radioWeek);
            this.groupBox1.Controls.Add(this.radioMonth);
            this.groupBox1.Controls.Add(this.groupReports);
            this.groupBox1.Controls.Add(this.radioAll);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1088, 616);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointments";
            // 
            // buttonDeleteAppts
            // 
            this.buttonDeleteAppts.Location = new System.Drawing.Point(998, 102);
            this.buttonDeleteAppts.Name = "buttonDeleteAppts";
            this.buttonDeleteAppts.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteAppts.TabIndex = 19;
            this.buttonDeleteAppts.Text = "Delete";
            this.buttonDeleteAppts.UseVisualStyleBackColor = true;
            this.buttonDeleteAppts.Click += new System.EventHandler(this.buttonDeleteAppts_Click);
            // 
            // buttonModifyAppts
            // 
            this.buttonModifyAppts.Location = new System.Drawing.Point(1000, 73);
            this.buttonModifyAppts.Name = "buttonModifyAppts";
            this.buttonModifyAppts.Size = new System.Drawing.Size(75, 23);
            this.buttonModifyAppts.TabIndex = 18;
            this.buttonModifyAppts.Text = "Modify";
            this.buttonModifyAppts.UseVisualStyleBackColor = true;
            this.buttonModifyAppts.Click += new System.EventHandler(this.buttonModifyAppts_Click);
            // 
            // addAppointmentsButton
            // 
            this.addAppointmentsButton.Location = new System.Drawing.Point(1000, 44);
            this.addAppointmentsButton.Name = "addAppointmentsButton";
            this.addAppointmentsButton.Size = new System.Drawing.Size(75, 23);
            this.addAppointmentsButton.TabIndex = 17;
            this.addAppointmentsButton.Text = "Add";
            this.addAppointmentsButton.UseVisualStyleBackColor = true;
            this.addAppointmentsButton.Click += new System.EventHandler(this.addAppointmentsButton_Click);
            // 
            // groupReports
            // 
            this.groupReports.Controls.Add(this.button6);
            this.groupReports.Controls.Add(this.bttnConsultantSched);
            this.groupReports.Controls.Add(this.bttnAppByMonth);
            this.groupReports.Location = new System.Drawing.Point(860, 339);
            this.groupReports.Name = "groupReports";
            this.groupReports.Size = new System.Drawing.Size(221, 207);
            this.groupReports.TabIndex = 0;
            this.groupReports.TabStop = false;
            this.groupReports.Text = "Reports";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(10, 144);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(203, 52);
            this.button6.TabIndex = 18;
            this.button6.Text = "Time Card";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // bttnAppByMonth
            // 
            this.bttnAppByMonth.Location = new System.Drawing.Point(10, 86);
            this.bttnAppByMonth.Name = "bttnAppByMonth";
            this.bttnAppByMonth.Size = new System.Drawing.Size(203, 52);
            this.bttnAppByMonth.TabIndex = 17;
            this.bttnAppByMonth.Text = "Appt By Month";
            this.bttnAppByMonth.UseVisualStyleBackColor = true;
            // 
            // bttnLogOut
            // 
            this.bttnLogOut.Location = new System.Drawing.Point(891, 589);
            this.bttnLogOut.Name = "bttnLogOut";
            this.bttnLogOut.Size = new System.Drawing.Size(93, 39);
            this.bttnLogOut.TabIndex = 17;
            this.bttnLogOut.Text = "Log Out";
            this.bttnLogOut.UseVisualStyleBackColor = true;
            // 
            // customerIDDataGridViewTextBoxColumn1
            // 
            this.customerIDDataGridViewTextBoxColumn1.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn1.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn1.Name = "customerIDDataGridViewTextBoxColumn1";
            this.customerIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastUpdateDataGridViewTextBoxColumn1
            // 
            this.lastUpdateDataGridViewTextBoxColumn1.DataPropertyName = "LastUpdate";
            this.lastUpdateDataGridViewTextBoxColumn1.HeaderText = "LastUpdate";
            this.lastUpdateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.lastUpdateDataGridViewTextBoxColumn1.Name = "lastUpdateDataGridViewTextBoxColumn1";
            this.lastUpdateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(NHolbrook_c969_Software_2.Customer);
            // 
            // appointmentIDDataGridViewTextBoxColumn
            // 
            this.appointmentIDDataGridViewTextBoxColumn.DataPropertyName = "AppointmentID";
            this.appointmentIDDataGridViewTextBoxColumn.HeaderText = "AppointmentID";
            this.appointmentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appointmentIDDataGridViewTextBoxColumn.Name = "appointmentIDDataGridViewTextBoxColumn";
            this.appointmentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.appointmentIDDataGridViewTextBoxColumn.Width = 102;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIdDataGridViewTextBoxColumn.Width = 85;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Width = 63;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 52;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 85;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.Width = 73;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "Contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactDataGridViewTextBoxColumn.Width = 69;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 56;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.ReadOnly = true;
            this.urlDataGridViewTextBoxColumn.Width = 45;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.startTimeDataGridViewTextBoxColumn.Width = 77;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.endTimeDataGridViewTextBoxColumn.Width = 74;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.createDateDataGridViewTextBoxColumn.Width = 86;
            // 
            // createdByDataGridViewTextBoxColumn
            // 
            this.createdByDataGridViewTextBoxColumn.DataPropertyName = "CreatedBy";
            this.createdByDataGridViewTextBoxColumn.HeaderText = "CreatedBy";
            this.createdByDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdByDataGridViewTextBoxColumn.Name = "createdByDataGridViewTextBoxColumn";
            this.createdByDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdByDataGridViewTextBoxColumn.Width = 81;
            // 
            // lastUpdateDataGridViewTextBoxColumn
            // 
            this.lastUpdateDataGridViewTextBoxColumn.DataPropertyName = "LastUpdate";
            this.lastUpdateDataGridViewTextBoxColumn.HeaderText = "LastUpdate";
            this.lastUpdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastUpdateDataGridViewTextBoxColumn.Name = "lastUpdateDataGridViewTextBoxColumn";
            this.lastUpdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastUpdateDataGridViewTextBoxColumn.Width = 87;
            // 
            // lastUpdatedByDataGridViewTextBoxColumn
            // 
            this.lastUpdatedByDataGridViewTextBoxColumn.DataPropertyName = "LastUpdatedBy";
            this.lastUpdatedByDataGridViewTextBoxColumn.HeaderText = "LastUpdatedBy";
            this.lastUpdatedByDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastUpdatedByDataGridViewTextBoxColumn.Name = "lastUpdatedByDataGridViewTextBoxColumn";
            this.lastUpdatedByDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastUpdatedByDataGridViewTextBoxColumn.Width = 105;
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataSource = typeof(NHolbrook_c969_Software_2.Appointments);
            // 
            // appBindingSource
            // 
            this.appBindingSource.DataSource = typeof(NHolbrook_c969_Software_2.App);
            // 
            // customerBindingSource3
            // 
            this.customerBindingSource3.DataSource = typeof(NHolbrook_c969_Software_2.Customer);
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataSource = typeof(NHolbrook_c969_Software_2.Customer);
            // 
            // customerBindingSource2
            // 
            this.customerBindingSource2.DataSource = typeof(NHolbrook_c969_Software_2.Customer);
            // 
            // customerBindingSource4
            // 
            this.customerBindingSource4.DataSource = typeof(NHolbrook_c969_Software_2.Customer);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 638);
            this.Controls.Add(this.bttnLogOut);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.customerList);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apptsDGV)).EndInit();
            this.customerList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label viewSelectorLabel;
        private System.Windows.Forms.RadioButton radioWeek;
        private System.Windows.Forms.RadioButton radioMonth;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.DataGridView apptsDGV;
        private System.Windows.Forms.Button buttonAddCust;
        private System.Windows.Forms.Button buttonModCustomer;
        private System.Windows.Forms.Button buttonDelCustomer;
        private System.Windows.Forms.Button bttnConsultantSched;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.GroupBox customerList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDeleteAppts;
        private System.Windows.Forms.Button buttonModifyAppts;
        private System.Windows.Forms.Button addAppointmentsButton;
        private System.Windows.Forms.Button bttnAppByMonth;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupReports;
        private System.Windows.Forms.Button bttnLogOut;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.BindingSource customerBindingSource2;
        private System.Windows.Forms.BindingSource customerBindingSource3;
        private System.Windows.Forms.BindingSource customerBindingSource4;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private System.Windows.Forms.BindingSource appBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView customerDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateDataGridViewTextBoxColumn1;
    }
}