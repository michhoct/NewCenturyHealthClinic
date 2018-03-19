namespace NewCenturyHealthClinic
{
    partial class HouseholdUpdate
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
            this.cboHouseholdList = new System.Windows.Forms.ComboBox();
            this.radUpdateHousehold = new System.Windows.Forms.RadioButton();
            this.radNewHousehold = new System.Windows.Forms.RadioButton();
            this.txtHouseholdProvider = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtHouseholdPhone = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtHouseholdInsurance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHouseholdAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHouseholdName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb = new System.Windows.Forms.Label();
            this.txtHouseholdBalance = new System.Windows.Forms.TextBox();
            this.btnPatients = new System.Windows.Forms.Button();
            this.btnCommitChanges = new System.Windows.Forms.Button();
            this.btnBackMenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboHouseholdList);
            this.groupBox1.Controls.Add(this.radUpdateHousehold);
            this.groupBox1.Controls.Add(this.radNewHousehold);
            this.groupBox1.Location = new System.Drawing.Point(0, -11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1025, 58);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // cboHouseholdList
            // 
            this.cboHouseholdList.FormattingEnabled = true;
            this.cboHouseholdList.Items.AddRange(new object[] {
            "Cody Shane",
            "Jama Jama",
            "Michael Hoctor"});
            this.cboHouseholdList.Location = new System.Drawing.Point(575, 21);
            this.cboHouseholdList.Name = "cboHouseholdList";
            this.cboHouseholdList.Size = new System.Drawing.Size(293, 24);
            this.cboHouseholdList.TabIndex = 2;
            // 
            // radUpdateHousehold
            // 
            this.radUpdateHousehold.AutoSize = true;
            this.radUpdateHousehold.Location = new System.Drawing.Point(295, 21);
            this.radUpdateHousehold.Name = "radUpdateHousehold";
            this.radUpdateHousehold.Size = new System.Drawing.Size(147, 21);
            this.radUpdateHousehold.TabIndex = 1;
            this.radUpdateHousehold.Text = "Update Household";
            this.radUpdateHousehold.UseVisualStyleBackColor = true;
            this.radUpdateHousehold.CheckedChanged += new System.EventHandler(this.radUpdateHousehold_CheckedChanged);
            // 
            // radNewHousehold
            // 
            this.radNewHousehold.AutoSize = true;
            this.radNewHousehold.Checked = true;
            this.radNewHousehold.Location = new System.Drawing.Point(79, 21);
            this.radNewHousehold.Name = "radNewHousehold";
            this.radNewHousehold.Size = new System.Drawing.Size(128, 21);
            this.radNewHousehold.TabIndex = 0;
            this.radNewHousehold.TabStop = true;
            this.radNewHousehold.Text = "New Household";
            this.radNewHousehold.UseVisualStyleBackColor = true;
            this.radNewHousehold.CheckedChanged += new System.EventHandler(this.radNewPatient_CheckedChanged);
            // 
            // txtHouseholdProvider
            // 
            this.txtHouseholdProvider.Location = new System.Drawing.Point(223, 263);
            this.txtHouseholdProvider.Name = "txtHouseholdProvider";
            this.txtHouseholdProvider.Size = new System.Drawing.Size(326, 22);
            this.txtHouseholdProvider.TabIndex = 52;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(83, 314);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 17);
            this.label17.TabIndex = 51;
            this.label17.Text = "Default Provider:";
            // 
            // txtHouseholdPhone
            // 
            this.txtHouseholdPhone.Location = new System.Drawing.Point(417, 216);
            this.txtHouseholdPhone.Name = "txtHouseholdPhone";
            this.txtHouseholdPhone.Size = new System.Drawing.Size(132, 22);
            this.txtHouseholdPhone.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(83, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 17);
            this.label14.TabIndex = 49;
            this.label14.Text = "Phone Number:";
            // 
            // txtHouseholdInsurance
            // 
            this.txtHouseholdInsurance.Location = new System.Drawing.Point(223, 311);
            this.txtHouseholdInsurance.Name = "txtHouseholdInsurance";
            this.txtHouseholdInsurance.Size = new System.Drawing.Size(326, 22);
            this.txtHouseholdInsurance.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Insurance Provider:";
            // 
            // txtHouseholdAddress
            // 
            this.txtHouseholdAddress.Location = new System.Drawing.Point(153, 167);
            this.txtHouseholdAddress.Name = "txtHouseholdAddress";
            this.txtHouseholdAddress.Size = new System.Drawing.Size(396, 22);
            this.txtHouseholdAddress.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Address:";
            // 
            // txtHouseholdName
            // 
            this.txtHouseholdName.Location = new System.Drawing.Point(376, 126);
            this.txtHouseholdName.Name = "txtHouseholdName";
            this.txtHouseholdName.Size = new System.Drawing.Size(174, 22);
            this.txtHouseholdName.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Name:";
            // 
            // txtb
            // 
            this.txtb.AutoSize = true;
            this.txtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb.Location = new System.Drawing.Point(83, 360);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(63, 17);
            this.txtb.TabIndex = 54;
            this.txtb.Text = "Balance:";
            // 
            // txtHouseholdBalance
            // 
            this.txtHouseholdBalance.Location = new System.Drawing.Point(469, 357);
            this.txtHouseholdBalance.Name = "txtHouseholdBalance";
            this.txtHouseholdBalance.Size = new System.Drawing.Size(80, 22);
            this.txtHouseholdBalance.TabIndex = 53;
            // 
            // btnPatients
            // 
            this.btnPatients.Location = new System.Drawing.Point(725, 223);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(143, 55);
            this.btnPatients.TabIndex = 57;
            this.btnPatients.Text = "Patient Management";
            this.btnPatients.UseVisualStyleBackColor = true;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnCommitChanges
            // 
            this.btnCommitChanges.Location = new System.Drawing.Point(725, 128);
            this.btnCommitChanges.Name = "btnCommitChanges";
            this.btnCommitChanges.Size = new System.Drawing.Size(143, 55);
            this.btnCommitChanges.TabIndex = 56;
            this.btnCommitChanges.Text = "Add Patient";
            this.btnCommitChanges.UseVisualStyleBackColor = true;
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.Location = new System.Drawing.Point(725, 318);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(143, 55);
            this.btnBackMenu.TabIndex = 55;
            this.btnBackMenu.Text = "Back To Menu";
            this.btnBackMenu.UseVisualStyleBackColor = true;
            this.btnBackMenu.Click += new System.EventHandler(this.btnBackMenu_Click);
            // 
            // HouseholdUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 446);
            this.Controls.Add(this.btnPatients);
            this.Controls.Add(this.btnCommitChanges);
            this.Controls.Add(this.btnBackMenu);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txtHouseholdBalance);
            this.Controls.Add(this.txtHouseholdProvider);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtHouseholdPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtHouseholdName);
            this.Controls.Add(this.txtHouseholdInsurance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHouseholdAddress);
            this.Name = "HouseholdUpdate";
            this.Text = "HouseholdUpdate";
            this.Load += new System.EventHandler(this.HouseholdUpdate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboHouseholdList;
        private System.Windows.Forms.RadioButton radUpdateHousehold;
        private System.Windows.Forms.RadioButton radNewHousehold;
        private System.Windows.Forms.TextBox txtHouseholdProvider;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtHouseholdPhone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtHouseholdInsurance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHouseholdAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHouseholdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtb;
        private System.Windows.Forms.TextBox txtHouseholdBalance;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button btnCommitChanges;
        private System.Windows.Forms.Button btnBackMenu;
    }
}