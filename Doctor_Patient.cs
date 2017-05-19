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
    public partial class Doctor_Patient : Form
    {
        Doctor_controller control_object;
        int user_name;
        public Doctor_Patient(int id,Function s)
        {
            InitializeComponent();
            user_name = id;
            control_object = new Doctor_controller();
            if (s == Function.finish_appointment)
                button2.Enabled = false;
            else
                button1.Enabled = false;
        }

        private void Doctor_Patient_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Patient_info_view(Convert.ToInt32(textBox1.Text)).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int check = control_object.finish_appointment(user_name,Convert.ToInt32(textBox1.Text));
            if (check > 0)
                MessageBox.Show("Appointment is finished successfully");
            else
                MessageBox.Show("Error!Cannot finish the appointment");
        }
    }
}
