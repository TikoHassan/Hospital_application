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
    public partial class Diseases_form : Form
    {
        Doctor_controller control_object;
        public Diseases_form()
        {
            InitializeComponent();
            control_object = new Doctor_controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Please Enter Patient ID");
            else if (textBox2.Text == "")
                MessageBox.Show("Please Enter disease");
            else
            {
                int check = control_object.Add_disease(Convert.ToInt32(textBox1.Text),textBox2.Text);
                if (check > 0)
                {
                    MessageBox.Show("Disease added succssfully");
                    textBox2.Clear();
                }
                else
                    MessageBox.Show("Error!Cannot add new disease");
            }
        }
    }
}
