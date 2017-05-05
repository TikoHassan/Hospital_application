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
    public partial class View_storage_info : Form
    {
        Storage_controller control_object;
        public View_storage_info()
        {
            InitializeComponent();
            control_object = new Storage_controller();
            DataTable dt = control_object.view_storage_info();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
