using System;using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_project
{
    public partial class Doctor : Form
    {
        Login_Controller control_object;
        int id;
        public Doctor(int user_name)
        {
            InitializeComponent();
            control_object = new Login_Controller();
            id = user_name;
            label1.Text = "Welcome Dr." + control_object.Employee_fname(user_name);
            if ((user_name / 1000) == 11)
            {
                button1.Enabled = false;
                button6.Enabled = false;
                button5.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button11.Enabled = false;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Doctor_Patient(id,Function.view_patient).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_new_doctor a = new Add_new_doctor();
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Add_new_reciptionist a = new Add_new_reciptionist();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Add_new_storage_man a = new Add_new_storage_man();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Choose_employee c = new Choose_employee(Employee_choice.update_employee);
            c.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee_info a = new Employee_info();
            a.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Fire_Employee f = new Fire_Employee();
            f.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            View_storage_info v = new View_storage_info();
            v.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            new Doctor_Patient(id,Function.finish_appointment).Show();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
