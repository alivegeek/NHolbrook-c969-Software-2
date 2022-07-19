
namespace NHolbrook_c969_Software_2
{
    partial class AddAppointment
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
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.inputTitle = new System.Windows.Forms.TextBox();
            this.inputLocation = new System.Windows.Forms.TextBox();
            this.inputContact = new System.Windows.Forms.TextBox();
            this.inputURL = new System.Windows.Forms.TextBox();
            this.inputDesc = new System.Windows.Forms.RichTextBox();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelURL = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelApptId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(119, 55);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(245, 21);
            this.comboBoxCustomer.TabIndex = 0;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(119, 398);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(245, 20);
            this.dateTimePickerStart.TabIndex = 1;
            this.dateTimePickerStart.Value = new System.DateTime(2022, 7, 12, 0, 0, 0, 0);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(119, 436);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(245, 20);
            this.dateTimePickerEnd.TabIndex = 2;
            // 
            // inputTitle
            // 
            this.inputTitle.Location = new System.Drawing.Point(119, 96);
            this.inputTitle.Name = "inputTitle";
            this.inputTitle.Size = new System.Drawing.Size(245, 20);
            this.inputTitle.TabIndex = 3;
            // 
            // inputLocation
            // 
            this.inputLocation.Location = new System.Drawing.Point(119, 241);
            this.inputLocation.Name = "inputLocation";
            this.inputLocation.Size = new System.Drawing.Size(245, 20);
            this.inputLocation.TabIndex = 4;
            // 
            // inputContact
            // 
            this.inputContact.Location = new System.Drawing.Point(119, 283);
            this.inputContact.Name = "inputContact";
            this.inputContact.Size = new System.Drawing.Size(245, 20);
            this.inputContact.TabIndex = 5;
            // 
            // inputURL
            // 
            this.inputURL.Location = new System.Drawing.Point(119, 361);
            this.inputURL.Name = "inputURL";
            this.inputURL.Size = new System.Drawing.Size(245, 20);
            this.inputURL.TabIndex = 7;
            // 
            // inputDesc
            // 
            this.inputDesc.Location = new System.Drawing.Point(119, 140);
            this.inputDesc.Name = "inputDesc";
            this.inputDesc.Size = new System.Drawing.Size(245, 83);
            this.inputDesc.TabIndex = 8;
            this.inputDesc.Text = "";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.Location = new System.Drawing.Point(12, 56);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(86, 20);
            this.labelCustomer.TabIndex = 9;
            this.labelCustomer.Text = "Customer";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 96);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(43, 20);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = "Title";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesc.Location = new System.Drawing.Point(12, 140);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(100, 20);
            this.labelDesc.TabIndex = 11;
            this.labelDesc.Text = "Description";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(12, 241);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(78, 20);
            this.labelLocation.TabIndex = 12;
            this.labelLocation.Text = "Location";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.Location = new System.Drawing.Point(12, 283);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(72, 20);
            this.labelContact.TabIndex = 13;
            this.labelContact.Text = "Contact";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(12, 323);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(47, 20);
            this.labelType.TabIndex = 14;
            this.labelType.Text = "Type";
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelURL.Location = new System.Drawing.Point(12, 361);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(45, 20);
            this.labelURL.TabIndex = 15;
            this.labelURL.Text = "URL";
            // 
            // labelStartTime
            // 
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartTime.Location = new System.Drawing.Point(12, 399);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(92, 20);
            this.labelStartTime.TabIndex = 16;
            this.labelStartTime.Text = "Start Time";
            // 
            // labelEndTime
            // 
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndTime.Location = new System.Drawing.Point(12, 437);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(84, 20);
            this.labelEndTime.TabIndex = 17;
            this.labelEndTime.Text = "End Time";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(138, 485);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(104, 38);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(248, 485);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(104, 38);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(119, 323);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(245, 21);
            this.comboBoxType.TabIndex = 20;
            // 
            // labelApptId
            // 
            this.labelApptId.AutoSize = true;
            this.labelApptId.Location = new System.Drawing.Point(20, 510);
            this.labelApptId.Name = "labelApptId";
            this.labelApptId.Size = new System.Drawing.Size(0, 13);
            this.labelApptId.TabIndex = 21;
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 550);
            this.Controls.Add(this.labelApptId);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelEndTime);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.inputDesc);
            this.Controls.Add(this.inputURL);
            this.Controls.Add(this.inputContact);
            this.Controls.Add(this.inputLocation);
            this.Controls.Add(this.inputTitle);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.comboBoxCustomer);
            this.Name = "AddAppointment";
            this.Text = "AddAppointment";
            this.Load += new System.EventHandler(this.AddAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox comboBoxCustomer;
        public System.Windows.Forms.DateTimePicker dateTimePickerStart;
        public System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        public System.Windows.Forms.TextBox inputTitle;
        public System.Windows.Forms.TextBox inputLocation;
        public System.Windows.Forms.TextBox inputContact;
        public System.Windows.Forms.TextBox inputURL;
        public System.Windows.Forms.RichTextBox inputDesc;
        public System.Windows.Forms.Label labelCustomer;
        public System.Windows.Forms.Label labelTitle;
        public System.Windows.Forms.Label labelDesc;
        public System.Windows.Forms.Label labelLocation;
        public System.Windows.Forms.Label labelContact;
        public System.Windows.Forms.Label labelType;
        public System.Windows.Forms.Label labelURL;
        public System.Windows.Forms.Label labelStartTime;
        public System.Windows.Forms.Label labelEndTime;
        public System.Windows.Forms.Button buttonSave;
        public System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.ComboBox comboBoxType;
        public System.Windows.Forms.Label labelApptId;
    }
}