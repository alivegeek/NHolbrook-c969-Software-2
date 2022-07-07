
namespace NHolbrook_c969_Software_2
{
    partial class AddCustomer
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
            this.labelAddCustomer = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputAddress1 = new System.Windows.Forms.TextBox();
            this.inputAddress2 = new System.Windows.Forms.TextBox();
            this.inputZip = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxActiveToggle = new System.Windows.Forms.CheckBox();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.labelActive = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelZipcode = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelAddress2 = new System.Windows.Forms.Label();
            this.labelAddress1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelAddCustomer
            // 
            this.labelAddCustomer.AutoSize = true;
            this.labelAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddCustomer.Location = new System.Drawing.Point(213, 47);
            this.labelAddCustomer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAddCustomer.Name = "labelAddCustomer";
            this.labelAddCustomer.Size = new System.Drawing.Size(298, 48);
            this.labelAddCustomer.TabIndex = 0;
            this.labelAddCustomer.Text = "Add Customer";
            // 
            // inputName
            // 
            this.inputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputName.Location = new System.Drawing.Point(285, 150);
            this.inputName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(430, 41);
            this.inputName.TabIndex = 1;
            this.inputName.TextChanged += new System.EventHandler(this.inputName_TextChanged);
            this.inputName.Validating += new System.ComponentModel.CancelEventHandler(this.inputName_Validating);
            // 
            // inputAddress1
            // 
            this.inputAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAddress1.Location = new System.Drawing.Point(285, 208);
            this.inputAddress1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.inputAddress1.Name = "inputAddress1";
            this.inputAddress1.Size = new System.Drawing.Size(430, 41);
            this.inputAddress1.TabIndex = 2;
            this.inputAddress1.Validating += new System.ComponentModel.CancelEventHandler(this.inputAddress1_Validating);
            // 
            // inputAddress2
            // 
            this.inputAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAddress2.Location = new System.Drawing.Point(285, 266);
            this.inputAddress2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.inputAddress2.Name = "inputAddress2";
            this.inputAddress2.Size = new System.Drawing.Size(430, 41);
            this.inputAddress2.TabIndex = 3;
            // 
            // inputZip
            // 
            this.inputZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputZip.Location = new System.Drawing.Point(285, 381);
            this.inputZip.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.inputZip.Name = "inputZip";
            this.inputZip.Size = new System.Drawing.Size(430, 41);
            this.inputZip.TabIndex = 5;
            this.inputZip.TextChanged += new System.EventHandler(this.inputZip_TextChanged);
            this.inputZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputZip_KeyPress);
            this.inputZip.Leave += new System.EventHandler(this.inputZip_Leave);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(285, 497);
            this.textBox7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(430, 41);
            this.textBox7.TabIndex = 7;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            this.textBox7.Leave += new System.EventHandler(this.textBox7_Leave);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(330, 644);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(192, 89);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.buttonSave.MouseHover += new System.EventHandler(this.buttonSave_MouseHover);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(534, 644);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(186, 89);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkBoxActiveToggle
            // 
            this.checkBoxActiveToggle.AutoSize = true;
            this.checkBoxActiveToggle.Checked = true;
            this.checkBoxActiveToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxActiveToggle.Location = new System.Drawing.Point(608, 569);
            this.checkBoxActiveToggle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.checkBoxActiveToggle.Name = "checkBoxActiveToggle";
            this.checkBoxActiveToggle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxActiveToggle.Size = new System.Drawing.Size(103, 29);
            this.checkBoxActiveToggle.TabIndex = 12;
            this.checkBoxActiveToggle.Text = "Active";
            this.checkBoxActiveToggle.UseVisualStyleBackColor = true;
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.Location = new System.Drawing.Point(18, 153);
            this.labelCustomer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(112, 37);
            this.labelCustomer.TabIndex = 13;
            this.labelCustomer.Text = "Name:";
            this.labelCustomer.Click += new System.EventHandler(this.labelCustomer_Click);
            // 
            // labelActive
            // 
            this.labelActive.AutoSize = true;
            this.labelActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActive.Location = new System.Drawing.Point(278, 569);
            this.labelActive.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelActive.Name = "labelActive";
            this.labelActive.Size = new System.Drawing.Size(0, 37);
            this.labelActive.TabIndex = 14;
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountry.Location = new System.Drawing.Point(24, 447);
            this.labelCountry.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(129, 37);
            this.labelCountry.TabIndex = 15;
            this.labelCountry.Text = "Country";
            this.labelCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(18, 503);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(242, 37);
            this.labelPhone.TabIndex = 16;
            this.labelPhone.Text = "Phone Number:";
            // 
            // labelZipcode
            // 
            this.labelZipcode.AutoSize = true;
            this.labelZipcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZipcode.Location = new System.Drawing.Point(18, 384);
            this.labelZipcode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelZipcode.Name = "labelZipcode";
            this.labelZipcode.Size = new System.Drawing.Size(156, 37);
            this.labelZipcode.TabIndex = 17;
            this.labelZipcode.Text = "Zip Code:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(18, 328);
            this.labelCity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(80, 37);
            this.labelCity.TabIndex = 18;
            this.labelCity.Text = "City:";
            // 
            // labelAddress2
            // 
            this.labelAddress2.AutoSize = true;
            this.labelAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress2.Location = new System.Drawing.Point(18, 269);
            this.labelAddress2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAddress2.Name = "labelAddress2";
            this.labelAddress2.Size = new System.Drawing.Size(171, 37);
            this.labelAddress2.TabIndex = 19;
            this.labelAddress2.Text = "Address 2:";
            // 
            // labelAddress1
            // 
            this.labelAddress1.AutoSize = true;
            this.labelAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress1.Location = new System.Drawing.Point(18, 211);
            this.labelAddress1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAddress1.Name = "labelAddress1";
            this.labelAddress1.Size = new System.Drawing.Size(169, 37);
            this.labelAddress1.TabIndex = 20;
            this.labelAddress1.Text = "Address 1:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(284, 447);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(432, 33);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox1_Validating);
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(285, 328);
            this.comboBoxCity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(432, 33);
            this.comboBoxCity.TabIndex = 22;
            this.comboBoxCity.SelectedIndexChanged += new System.EventHandler(this.comboBoxCity_SelectedIndexChanged);
            this.comboBoxCity.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxCity_Validating);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 791);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelAddress1);
            this.Controls.Add(this.labelAddress2);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelZipcode);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelActive);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.checkBoxActiveToggle);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.inputZip);
            this.Controls.Add(this.inputAddress2);
            this.Controls.Add(this.inputAddress1);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.labelAddCustomer);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.AddCustomer_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelAddCustomer;
        public System.Windows.Forms.TextBox inputName;
        public System.Windows.Forms.TextBox inputAddress1;
        public System.Windows.Forms.TextBox inputAddress2;
        public System.Windows.Forms.TextBox inputZip;
        public System.Windows.Forms.TextBox textBox7;
        public System.Windows.Forms.Button buttonSave;
        public System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.CheckBox checkBoxActiveToggle;
        public System.Windows.Forms.Label labelCustomer;
        public System.Windows.Forms.Label labelActive;
        public System.Windows.Forms.Label labelCountry;
        public System.Windows.Forms.Label labelPhone;
        public System.Windows.Forms.Label labelZipcode;
        public System.Windows.Forms.Label labelCity;
        public System.Windows.Forms.Label labelAddress2;
        public System.Windows.Forms.Label labelAddress1;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox comboBoxCity;
    }
}