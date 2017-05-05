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
    public partial class All_Employees : Form
    {
        Doctor_controller control_object;
        public All_Employees()
        {
            InitializeComponent();
            control_object = new Doctor_controller();
            dataGridView1.DataSource = control_object.view_all_emloyees();
            dataGridView1.Columns[3].HeaderText = "Type";
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
