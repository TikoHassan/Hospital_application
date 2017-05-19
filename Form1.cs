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
    public partial class login : Form
    {
        Employee_factory choice;
        Login_Controller C;
        
        

        public login()
        {
            InitializeComponent();
            C = new Login_Controller();
            choice = new Employee_factory();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form F;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please,insert your username and password");
                return;
            }
            int User_name = C.login(Convert.ToInt32(textBox1.Text), textBox2.Text);
            int count =C.Sql_injection_prevent(Convert.ToInt32(textBox1.Text),textBox2.Text);
            if (User_name > 0 && count==1)
            {
                F = choice.Create_form(User_name);
                textBox1.Clear();
                textBox2.Clear();
                this.Hide();
                F.FormClosed += (s,ev) => this.Show();
                F.ShowDialog();
            }
            else
                MessageBox.Show("Error!Wrong user_name or password");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Get_username_or_password g = new Get_username_or_password();
            g.FormClosed += (obj, eve) => this.Show();
            g.Show();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
