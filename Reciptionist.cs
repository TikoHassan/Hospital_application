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
    public partial class Reciptionist : Form
    {
        Login_Controller control_object;
        Receptionist_Controller control_object2;
        public Reciptionist(int id)
        {
            InitializeComponent();
            control_object = new Login_Controller();
            label1.Text = "Welcome MS." + control_object.Employee_fname(id);
        }

        private void Reciptionist_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Patient_type().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Update_appointment().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Choose_Doctor(new Schedule_view_strategy()).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Choose_Doctor(new Information_Strategy()).Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Appointment_Information().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int check = control_object2.delete_appointments();
            if (check > 0)
                MessageBox.Show("Appointments deleted successfully");
            else
                MessageBox.Show("Error!Cannot delete");
        }
    }
}
