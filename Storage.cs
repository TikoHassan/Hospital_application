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
    public partial class Storage : Form
    {
        Login_Controller control_object;
        int us;
        public Storage(int id)
        {
            InitializeComponent();
            control_object = new Login_Controller();
            label1.Text = "Welcome Mr." + control_object.Employee_fname(id);
            us = id;
        }

        private void Storage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            View_storage_info v = new View_storage_info();
            v.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Storage a = new Add_Storage(us);
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Delete_storage d = new Delete_storage();
            d.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_Storage u = new Update_Storage();
            u.Show();
        }
    }
}
