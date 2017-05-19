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
    public partial class Patient_info_view : Form
    {
        Doctor_controller control_object;
        public Patient_info_view(int id)
        {
            InitializeComponent();
            control_object = new Doctor_controller();
           
            dataGridView1.DataSource = control_object.Patient_info(id);
            dataGridView1.Refresh();
            dataGridView2.DataSource = control_object.patient_diseases(id);
            dataGridView2.Refresh();
            dataGridView3.DataSource = control_object.medicine_taken(id);
            dataGridView3.Refresh();
        }

        private void Patient_info_view_Load(object sender, EventArgs e)
        {

        }
    }
}
