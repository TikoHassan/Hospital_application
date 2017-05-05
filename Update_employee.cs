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
    public partial class Update_employee : Form
    {
        Doctor_controller control_object;
        int us;
        public Update_employee(int id)
        {
            InitializeComponent();
            control_object = new Doctor_controller();
            us = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("Please enter all Data, If No Email Write NULL");
            else
            {
                int check = control_object.Update_employee(us,textBox1.Text,textBox2.Text,Convert.ToInt64(textBox3.Text),Convert.ToInt32(textBox4.Text));
                if (check > 0)
                {
                    MessageBox.Show("Employee is Updated Successfully");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
                else
                    MessageBox.Show("Error!Cannot update");
            }
        }
    }
}
