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
    public partial class Reciptionist : Form
    {
        Login_Controller control_object;
        public Reciptionist(int id)
        {
            InitializeComponent();
            control_object = new Login_Controller();
            label1.Text = "Welcome MS." + control_object.Employee_fname(id);
        }

        private void Reciptionist_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Patient_type().Show();
        }
    }
}