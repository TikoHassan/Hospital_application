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
            radioButton3.Checked = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""||textBox2.Text==""||textBox3.Text==""||textBox4.Text==""||textBox5.Text==""||textBox6.Text==""||(radioButton1.Checked==false&&radioButton2.Checked==false))
            {
                MessageBox.Show("Please fill all data");
            }
            else
            {
            int check = control_object.Add_new_patient(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text),
                textBox5.Text, dateTimePicker1.Value, radioButton1.Checked ? "M" : "F");
            int check2 = control_object.Add_new_appointment(dateTimePicker2.Value,textBox6.Text,
                radioButton3.Checked?"New":"NULL",Convert.ToInt32(textBox4.Text),Convert.ToInt32(comboBox1.SelectedValue));
            if (check > 0 && check2 > 0)
            {
                MessageBox.Show("Appointment added successfully");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
            }
            else
                MessageBox.Show("Error!Cannot add Appointemt");
        }
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
