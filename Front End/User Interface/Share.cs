﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface_AM
{
    public partial class Share : Form
    {
        public Share()
        {
            InitializeComponent();
            label2.Text = Main.selected;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}