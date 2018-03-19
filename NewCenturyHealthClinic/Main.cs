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
    public partial class Main : Form
    {
        public PatientUpdate patientForm;
        public EnterAppointment appointmentForm;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            patientForm = new PatientUpdate();
            appointmentForm = new EnterAppointment();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "New Century Health Clinic" + "                              " + "UserID" + "                                                      " + DateTime.Now;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            patientForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            appointmentForm.Show();
            this.Hide();
        }
    }
}
