using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCenturyHealthClinic
{
    public partial class PatientUpdate : Form
    {

        public Main newForm;
        public HouseholdUpdate hhu;
        public PatientUpdate()
        {
            InitializeComponent();
        }

        private void PatientUpdate_Load(object sender, EventArgs e)
        {
            newForm = new Main();
            hhu = new HouseholdUpdate();
            //Design Choices
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "New Century Health Clinic" + "                           " + "UserID" + "                                                      " + DateTime.Now;
        }

        private void radNewPatient_CheckedChanged(object sender, EventArgs e)
        {
            cboPatientList.Enabled = false;
            btnCommitChanges.Text = "Add Patient";
        }

        private void radUpdatePatient_CheckedChanged(object sender, EventArgs e)
        {
            cboPatientList.Enabled = true;
            btnCommitChanges.Text = "Confirm Changes";
        }



        //Dont Delete this

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            newForm.Show();
        }

        private void btnHouseholds_Click(object sender, EventArgs e)
        {
            this.Hide();
            hhu.Show();
        }
    }
}
