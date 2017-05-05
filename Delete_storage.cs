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
    public partial class Delete_storage : Form
    {
        Storage_controller control_object;
        DataTable dt;
        public Delete_storage()
        {
            InitializeComponent();
            control_object = new Storage_controller();
            dt = control_object.get_medicine_name();
            comboBox1.DataSource=dt;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int check = control_object.Delete_row(Convert.ToInt32(comboBox1.SelectedValue));
            if (check > 0)
            {
                MessageBox.Show("Row deleted successfully");
                dt =control_object.get_medicine_name();
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "ID";
            }
            else
                MessageBox.Show("Error!while deleting");
        }
    }
}
