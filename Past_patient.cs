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
    public partial class Past_patient : Form
    {
        Receptionist_Controller control_object;
        int patient_id;
        public Past_patient(int id)
        {
            InitializeComponent();
            control_object = new Receptionist_Controller();
            patient_id = id;
            textBox1.Enabled = false;
            DataTable dt = control_object.get_major();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Major";
            comboBox1.ValueMember = "Major";
            textBox1.Text = control_object.patient_name(id);
        }

        private void Past_patient_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = control_object.get_appointments(Convert.ToString(comboBox1.SelectedValue));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            DataTable dt2 = control_object.get_doctors(Convert.ToString(comboBox1.SelectedValue));
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "User_name";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int check = control_object.Add_new_appointment(dateTimePicker1.Value,textBox4.Text,radioButton1.Checked?"Cure":"Consult",
                patient_id,Convert.ToInt32(comboBox2.SelectedValue));
            if (check > 0)
                MessageBox.Show("Appointment added successfully");
            else
                MessageBox.Show("Error!Cannot add Appointment");
        }
    }
}
