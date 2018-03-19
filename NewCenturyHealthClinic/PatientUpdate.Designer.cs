namespace NewCenturyHealthClinic
{
    partial class PatientUpdate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboPatientList = new System.Windows.Forms.ComboBox();
            this.radUpdatePatient = new System.Windows.Forms.RadioButton();
            this.radNewPatient = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkMale = new System.Windows.Forms.CheckBox();
            this.chkFemale = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInsuranceProvider = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comHousehold = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSocial = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dttBirthDay = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmergencyContact = new System.Windows.Forms.TextBox();
            this.txtRelation = new System.Windows.Forms.TextBox();
            this.txtEmergencyPhone = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.txtWorkPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBackMenu = new System.Windows.Forms.Button();
            this.btnCommitChanges = new System.Windows.Forms.Button();
            this.btnHouseholds = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDoctor = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboPatientList);
            this.groupBox1.Controls.Add(this.radUpdatePatient);
            this.groupBox1.Controls.Add(this.radNewPatient);
            this.groupBox1.Location = new System.Drawing.Point(0, -11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1025, 58);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cboPatientList
            // 
            this.cboPatientList.FormattingEnabled = true;
            this.cboPatientList.Items.AddRange(new object[] {
            "Cody Shane",
            "Jama Jama",
            "Michael Hoctor"});
            this.cboPatientList.Location = new System.Drawing.Point(575, 21);
            this.cboPatientList.Name = "cboPatientList";
            this.cboPatientList.Size = new System.Drawing.Size(293, 24);
            this.cboPatientList.TabIndex = 2;
            // 
            // radUpdatePatient
            // 
            this.radUpdatePatient.AutoSize = true;
            this.radUpdatePatient.Location = new System.Drawing.Point(295, 21);
            this.radUpdatePatient.Name = "radUpdatePatient";
            this.radUpdatePatient.Size = new System.Drawing.Size(123, 21);
            this.radUpdatePatient.TabIndex = 1;
            this.radUpdatePatient.TabStop = true;
            this.radUpdatePatient.Text = "Update Patient";
            this.radUpdatePatient.UseVisualStyleBackColor = true;
            this.radUpdatePatient.CheckedChanged += new System.EventHandler(this.radUpdatePatient_CheckedChanged);
            // 
            // radNewPatient
            // 
            this.radNewPatient.AutoSize = true;
            this.radNewPatient.Location = new System.Drawing.Point(79, 21);
            this.radNewPatient.Name = "radNewPatient";
            this.radNewPatient.Size = new System.Drawing.Size(104, 21);
            this.radNewPatient.TabIndex = 0;
            this.radNewPatient.TabStop = true;
            this.radNewPatient.Text = "New Patient";
            this.radNewPatient.UseVisualStyleBackColor = true;
            this.radNewPatient.CheckedChanged += new System.EventHandler(this.radNewPatient_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(85, 81);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(191, 81);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(174, 22);
            this.txtLastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(401, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sex:";
            // 
            // chkMale
            // 
            this.chkMale.AutoSize = true;
            this.chkMale.Location = new System.Drawing.Point(440, 81);
            this.chkMale.Name = "chkMale";
            this.chkMale.Size = new System.Drawing.Size(41, 21);
            this.chkMale.TabIndex = 5;
            this.chkMale.Text = "M";
            this.chkMale.UseVisualStyleBackColor = true;
            // 
            // chkFemale
            // 
            this.chkFemale.AutoSize = true;
            this.chkFemale.Location = new System.Drawing.Point(477, 81);
            this.chkFemale.Name = "chkFemale";
            this.chkFemale.Size = new System.Drawing.Size(38, 21);
            this.chkFemale.TabIndex = 6;
            this.chkFemale.Text = "F";
            this.chkFemale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(557, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Height:";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(616, 81);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(40, 22);
            this.txtHeight.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(685, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Weight";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(743, 81);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(61, 22);
            this.txtWeight.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(829, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Age:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(872, 81);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(61, 22);
            this.txtAge.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(99, 124);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(396, 22);
            this.txtAddress.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(513, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Insurance Provider:";
            // 
            // txtInsuranceProvider
            // 
            this.txtInsuranceProvider.Location = new System.Drawing.Point(650, 123);
            this.txtInsuranceProvider.Name = "txtInsuranceProvider";
            this.txtInsuranceProvider.Size = new System.Drawing.Size(326, 22);
            this.txtInsuranceProvider.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Household:";
            // 
            // comHousehold
            // 
            this.comHousehold.FormattingEnabled = true;
            this.comHousehold.Location = new System.Drawing.Point(115, 170);
            this.comHousehold.Name = "comHousehold";
            this.comHousehold.Size = new System.Drawing.Size(240, 24);
            this.comHousehold.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(373, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Social Security Number:";
            // 
            // txtSocial
            // 
            this.txtSocial.Location = new System.Drawing.Point(538, 170);
            this.txtSocial.Name = "txtSocial";
            this.txtSocial.Size = new System.Drawing.Size(202, 22);
            this.txtSocial.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(760, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Birthday:";
            // 
            // dttBirthDay
            // 
            this.dttBirthDay.Location = new System.Drawing.Point(831, 171);
            this.dttBirthDay.Name = "dttBirthDay";
            this.dttBirthDay.Size = new System.Drawing.Size(158, 22);
            this.dttBirthDay.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Emergency Contact:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Relation to Patient:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Phone Number:";
            // 
            // txtEmergencyContact
            // 
            this.txtEmergencyContact.Location = new System.Drawing.Point(147, 13);
            this.txtEmergencyContact.Name = "txtEmergencyContact";
            this.txtEmergencyContact.Size = new System.Drawing.Size(174, 22);
            this.txtEmergencyContact.TabIndex = 26;
            // 
            // txtRelation
            // 
            this.txtRelation.Location = new System.Drawing.Point(140, 63);
            this.txtRelation.Name = "txtRelation";
            this.txtRelation.Size = new System.Drawing.Size(181, 22);
            this.txtRelation.TabIndex = 27;
            // 
            // txtEmergencyPhone
            // 
            this.txtEmergencyPhone.Location = new System.Drawing.Point(119, 114);
            this.txtEmergencyPhone.Name = "txtEmergencyPhone";
            this.txtEmergencyPhone.Size = new System.Drawing.Size(202, 22);
            this.txtEmergencyPhone.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(29, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "Phone Number:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(535, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 17);
            this.label15.TabIndex = 30;
            this.label15.Text = "Email";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(292, 228);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 17);
            this.label16.TabIndex = 31;
            this.label16.Text = "Work Phone";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(142, 225);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(132, 22);
            this.txtHomePhone.TabIndex = 33;
            // 
            // txtWorkPhone
            // 
            this.txtWorkPhone.Location = new System.Drawing.Point(384, 225);
            this.txtWorkPhone.Name = "txtWorkPhone";
            this.txtWorkPhone.Size = new System.Drawing.Size(132, 22);
            this.txtWorkPhone.TabIndex = 34;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(583, 225);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(406, 22);
            this.txtEmail.TabIndex = 35;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtEmergencyContact);
            this.groupBox2.Controls.Add(this.txtRelation);
            this.groupBox2.Controls.Add(this.txtEmergencyPhone);
            this.groupBox2.Location = new System.Drawing.Point(32, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 147);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.Location = new System.Drawing.Point(801, 330);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(143, 55);
            this.btnBackMenu.TabIndex = 38;
            this.btnBackMenu.Text = "Back To Menu";
            this.btnBackMenu.UseVisualStyleBackColor = true;
            this.btnBackMenu.Click += new System.EventHandler(this.btnBackMenu_Click);
            // 
            // btnCommitChanges
            // 
            this.btnCommitChanges.Location = new System.Drawing.Point(404, 330);
            this.btnCommitChanges.Name = "btnCommitChanges";
            this.btnCommitChanges.Size = new System.Drawing.Size(143, 55);
            this.btnCommitChanges.TabIndex = 39;
            this.btnCommitChanges.Text = "Add Patient";
            this.btnCommitChanges.UseVisualStyleBackColor = true;
            // 
            // btnHouseholds
            // 
            this.btnHouseholds.Location = new System.Drawing.Point(607, 330);
            this.btnHouseholds.Name = "btnHouseholds";
            this.btnHouseholds.Size = new System.Drawing.Size(143, 55);
            this.btnHouseholds.TabIndex = 40;
            this.btnHouseholds.Text = "Household Management";
            this.btnHouseholds.UseVisualStyleBackColor = true;
            this.btnHouseholds.Click += new System.EventHandler(this.btnHouseholds_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(416, 283);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 17);
            this.label17.TabIndex = 41;
            this.label17.Text = "Default Provider:";
            // 
            // txtDoctor
            // 
            this.txtDoctor.Location = new System.Drawing.Point(542, 280);
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.Size = new System.Drawing.Size(326, 22);
            this.txtDoctor.TabIndex = 42;
            // 
            // PatientUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 446);
            this.Controls.Add(this.txtDoctor);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnHouseholds);
            this.Controls.Add(this.btnCommitChanges);
            this.Controls.Add(this.btnBackMenu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtWorkPhone);
            this.Controls.Add(this.txtHomePhone);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dttBirthDay);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSocial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comHousehold);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtInsuranceProvider);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkFemale);
            this.Controls.Add(this.chkMale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "PatientUpdate";
            this.Text = "\"New Century Health Clinic\" + \"                           \" + \"UserID\" + \"       " +
    "                                               \" + DateTime.Now";
            this.Load += new System.EventHandler(this.PatientUpdate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radUpdatePatient;
        private System.Windows.Forms.RadioButton radNewPatient;
        private System.Windows.Forms.ComboBox cboPatientList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkMale;
        private System.Windows.Forms.CheckBox chkFemale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInsuranceProvider;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comHousehold;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSocial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dttBirthDay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmergencyContact;
        private System.Windows.Forms.TextBox txtRelation;
        private System.Windows.Forms.TextBox txtEmergencyPhone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.TextBox txtWorkPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBackMenu;
        private System.Windows.Forms.Button btnCommitChanges;
        private System.Windows.Forms.Button btnHouseholds;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtDoctor;
    }
}