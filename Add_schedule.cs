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
    public partial class Add_schedule : Form
    {
        Receptionist_Controller control_object;
        public Add_schedule()
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
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                MessageBox.Show("Please fill all data");
            else
            {
                int check = control_object.Add_schedule(Convert.ToInt32(comboBox1.SelectedValue),textBox2.Text,textBox3.Text,textBox1.Text);
                if (check > 0)
                    MessageBox.Show("Schedule added successfully");
                else
                    MessageBox.Show("Error!Cannot Add");
            }

        }
    }
}
