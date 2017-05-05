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
    public partial class Add_Storage : Form
    {
        Storage_controller control_object;
        int us;
        public Add_Storage(int id)
        {
            InitializeComponent();
            control_object = new Storage_controller();
            us = id;
        }

        private void Add_Storage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("Please fill all the data");
            else
            {
                int check = control_object.Add_Storage(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), us);
                if (check > 0)
                    MessageBox.Show("Storage added Successfully");
                else
                    MessageBox.Show("Error!cannot add the new storage");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
        }
    }
}
