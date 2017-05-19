using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_project
{
    public partial class Appointment_Information : Form
    {
        Receptionist_Controller control_object;
        public Appointment_Information()
        {
            InitializeComponent();
            control_object = new Receptionist_Controller();
            dataGridView1.DataSource = control_object.View_appointment();
            dataGridView1.Refresh();
        }

        private void Appointment_Information_Load(object sender, EventArgs e)
        {

        }
    }
}
