﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figure1
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSquare.Instance.MdiParent = this;
            FrmSquare.Instance.Show();
        }

        private void rectanguloToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmRectangle.Instance.MdiParent = this;
            FrmRectangle.Instance.Show();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
