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
    public partial class Update_Storage : Form
    {
        Storage_controller control_object;
        public Update_Storage()
        {
            InitializeComponent();
            control_object = new Storage_controller();
            DataTable dt = control_object.get_medicine_name();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int check = control_object.update_storage(Convert.ToInt32(comboBox1.SelectedValue),Convert.ToInt32(textBox1.Text));
            if (check > 0)
                MessageBox.Show("Storage updated successfully");
            else
                MessageBox.Show("Error!Cannot update");
            textBox1.Clear();
        }
    }
}
