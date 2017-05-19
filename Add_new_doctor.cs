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
    public partial class Add_new_doctor : Form
    {
        Doctor_controller control_object;
        public Add_new_doctor()
        {
            InitializeComponent();
            control_object = new Doctor_controller();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox6.Text == "" || textBox7.Text == "" ||
                textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == ""||(radioButton1.Checked==false&&radioButton2.Checked==false))
                MessageBox.Show("Please enter all Data");
            else if (Convert.ToInt32(textBox6.Text) / 1000 != 11)
                MessageBox.Show("Please Enter correct User_name");
            else
            {
                if (textBox5.Text == "")
                    textBox5.Text = "NULL";
                int check = control_object.Add_new_employee(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox6.Text), textBox7.Text,
                    Convert.ToInt32(textBox8.Text), radioButton1.Checked ? "M" : "F", textBox5.Text,
                    Convert.ToInt64(textBox10.Text), textBox4.Text, dateTimePicker1.Value, Convert.ToInt64(textBox9.Text));
               int check2 = control_object.Add_major(Convert.ToInt32(textBox6.Text), textBox11.Text);
               if (check > 0 && check2 > 0)
               {
                   MessageBox.Show("A new Doctor is added successfully");
                   textBox1.Clear();
                   textBox2.Clear();
                   textBox3.Clear();
                   textBox4.Clear();
                   textBox5.Clear();
                   textBox6.Clear();
                   textBox7.Clear();
                   textBox8.Clear();
                   textBox9.Clear();
                   textBox10.Clear();
                   textBox11.Clear();
                   radioButton1.Checked = false;
                   radioButton2.Checked = false;
               }
               else
                   MessageBox.Show("Error!Cannot add the new doctor");
            }
        }
    }
}
