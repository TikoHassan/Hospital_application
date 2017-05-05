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
    public partial class Get_username_or_password : Form
    {
       Login_Controller control_object;
        public Get_username_or_password()
        {
            InitializeComponent();
            control_object = new Login_Controller();
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Write your security number");
            else
            {
                string password = control_object.get_user_password(Convert.ToInt64(textBox1.Text));
                int user_name = control_object.get_user_id(Convert.ToInt64(textBox1.Text));
                if (user_name > 0)
                {
                    textBox2.Text = Convert.ToString(user_name);
                    textBox3.Text = password;
                }
                else
                    MessageBox.Show("Wrong Security number");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
