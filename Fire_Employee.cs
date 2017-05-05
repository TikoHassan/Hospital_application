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
    public partial class Fire_Employee : Form
    {
        Doctor_controller control_object;
        Storage_controller control_obj;
        DataTable dt;
        public Fire_Employee()
        {
            InitializeComponent();
            control_object = new Doctor_controller();
            control_obj = new Storage_controller();
             dt= control_object.get_employees();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "User_name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(comboBox1.SelectedValue) / 1000 == 13)
            {
                int check2 = control_obj.set_storage_man(Convert.ToInt32(comboBox1.SelectedValue));
            }
           int check= control_object.fire_employee(Convert.ToInt32(comboBox1.SelectedValue));
           if (check > 0)
           {
               MessageBox.Show("Emloyee is fired successfully");
               dt = control_object.get_employees();
               comboBox1.DataSource = dt;
               comboBox1.DisplayMember = "Name";
               comboBox1.ValueMember = "User_name";
           }
           else
               MessageBox.Show("Error!Cannot delete");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
