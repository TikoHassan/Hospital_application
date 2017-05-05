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
    public partial class Employee_View : Form
    {
        View_Strategy strategy;
        public Employee_View(int id,View_Strategy s)
        {
            InitializeComponent();
            strategy = s;
            DataTable dt=strategy.View_operation(id);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[3].HeaderText = "Type";
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
