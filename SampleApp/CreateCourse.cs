﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleApp
{
    public partial class CreateCourse : Form
    {
        public CreateCourse()
        {
            InitializeComponent();
        }



        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("You must saved before closing?", "OK", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                /*e.Cancel = true;*/
            }
        }

        private void item_color_Click(object sender, EventArgs e)
        {

        }

        private void cl_pink_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(230, 230, 250);

        }

        private void cl_blue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(173, 216, 230);
        }
    }

}