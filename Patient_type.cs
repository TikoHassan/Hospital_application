﻿using System;
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
    public partial class Patient_type : Form
    {
        public Patient_type()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Add_new_Appointment().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Patient_id().Show(); 
        }
    }
}
