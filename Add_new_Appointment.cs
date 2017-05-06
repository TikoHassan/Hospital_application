using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Hospital_project
{
    public partial class Add_new_Appointment : Form
    {
        Receptionist_Controller control_object;
        Doctor_controller control_object2;
        public Add_new_Appointment()
        {
            InitializeComponent();
            control_object = new Receptionist_Controller();
            control_object2 = new Doctor_controller();
            DataTable dt = control_object.get_major();
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "Major";
            comboBox3.ValueMember = "Major";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ckeck=control_object.Add_new_appointment();
        }

        private void Add_new_Appointment_Load(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = control_object.get_appointments(Convert.ToString(comboBox3.SelectedValue));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            DataTable dt2 = control_object.get_doctors(Convert.ToString(comboBox3.SelectedValue));
            comboBox1.DataSource = dt2;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "User_name";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
