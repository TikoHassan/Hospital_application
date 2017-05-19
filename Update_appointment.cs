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
    public partial class Update_appointment : Form
    {
        Receptionist_Controller control_object;
        public Update_appointment()
        {
            InitializeComponent();
            control_object = new Receptionist_Controller();
            DataTable dt = control_object.doctors_names();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "User_name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = control_object.doctor_schedule(Convert.ToInt32(comboBox1.SelectedValue));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""||textBox2.Text==""||(radioButton1.Checked==false&&radioButton2.Checked==false))
            {
                MessageBox.Show("please fill all data");
            }
            else
            {
            int check = control_object.update_appointment(textBox2.Text,radioButton1.Checked?"Cure":"Consult",
                dateTimePicker1.Value, Convert.ToInt32(textBox1.Text), Convert.ToInt32(comboBox1.SelectedValue));
            if (check > 0)
            {
                MessageBox.Show("Appointment updated successfully");
                textBox1.Clear();
                textBox2.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
            }
            else
                MessageBox.Show("Error!Cannot update");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
