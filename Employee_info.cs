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
    public partial class Employee_info : Form
    {
        public Employee_info()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            All_Employees a = new All_Employees();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Choose_employee c = new Choose_employee(Employee_choice.view_employee);
            c.Show();
        }
    }
}
