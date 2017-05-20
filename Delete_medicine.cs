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
    public partial class Delete_medicine : Form
    {
        Doctor_controller control_object;
        public Delete_medicine()
        {
            InitializeComponent();
            control_object = new Doctor_controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Please fill all the data");
            else
            {
                int check = control_object.delete_medicine(Convert.ToInt32(textBox1.Text), textBox2.Text);
                if (check > 0)
                    MessageBox.Show("Information deleted successfully");
                else
                    MessageBox.Show("Error!Cannot delete");
            }
        }

        private void Delete_medicine_Load(object sender, EventArgs e)
        {

        }
    }
}
