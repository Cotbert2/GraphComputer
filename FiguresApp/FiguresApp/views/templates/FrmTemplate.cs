﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiguresApp
{
    public partial class FrmTemplate : Form
    {
        public FrmTemplate()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome home = new FrmHome();
            home.Show();
            this.Hide();
        }

        private void ExitProgram(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FrmTemplate_Load(object sender, EventArgs e)
        {

        }
    }
}
