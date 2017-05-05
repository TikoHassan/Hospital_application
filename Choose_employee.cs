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
    public partial class Choose_employee : Form
    {
        Doctor_controller control_oject;
        Employee_choice choice;
        Choose_employee_factory choice2;
        Form f;
        public Choose_employee(Employee_choice c)
        {
            InitializeComponent();
            control_oject = new Doctor_controller();
            choice2 = new Choose_employee_factory();
            DataTable dt = control_oject.get_employees();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "User_name";
            choice = c;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f = choice2.Create_form(choice, Convert.ToInt32(comboBox1.SelectedValue));
            f.Show();
        }
    }
}
