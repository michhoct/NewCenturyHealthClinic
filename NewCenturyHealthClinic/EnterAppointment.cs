using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace NewCenturyHealthClinic
{
    public partial class EnterAppointment : Form
    {
        public Main formMain;
        public EnterAppointment()
        {
            InitializeComponent();
        }


        private void EnterAppointment_Load(object sender, EventArgs e)
        {
            formMain = new Main();
            
               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formMain.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //View Appointments
        }
    }
}
