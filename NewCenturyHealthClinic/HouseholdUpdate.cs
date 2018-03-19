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
    public partial class HouseholdUpdate : Form
    {

        public Main newForm = new Main();
        public PatientUpdate pu = new PatientUpdate();
        public HouseholdUpdate()
        {
            InitializeComponent();
        }

        private void radNewPatient_CheckedChanged(object sender, EventArgs e)
        {
            btnCommitChanges.Text = "Add Household";
        }

        private void HouseholdUpdate_Load(object sender, EventArgs e)
        {

        }

        private void radUpdateHousehold_CheckedChanged(object sender, EventArgs e)
        {
            btnCommitChanges.Text = "Update Household";
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            newForm.Show();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            this.Hide();
            pu.Show();
        }
    }
}
