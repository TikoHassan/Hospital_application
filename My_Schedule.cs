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
    public partial class My_Schedule : Form
    {
        Doctor_controller control_object;
        public My_Schedule(int id)
        {
            InitializeComponent();
            control_object = new Doctor_controller();
            dataGridView1.DataSource = control_object.my_schedule(id);
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
