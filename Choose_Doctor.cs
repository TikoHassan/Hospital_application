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
    public partial class Choose_Doctor : Form
    {
        Receptionist_Controller control_object;
        View_Strategy strategy;
        public Choose_Doctor(View_Strategy s)
        {
            InitializeComponent();
            control_object = new Receptionist_Controller();
            strategy = s;
            DataTable dt = control_object.doctors_names();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "User_name";
        }

        private void Choose_Doctor_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = strategy.View_operation(Convert.ToInt32(comboBox1.SelectedValue));
            new Doctor_View(dt).Show();
        }
    }
}
