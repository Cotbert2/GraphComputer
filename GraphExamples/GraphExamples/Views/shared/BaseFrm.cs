using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphExamples.Config;

namespace GraphExamples.Views.shared
{
    public partial class BaseFrm : Form
    {

        public BaseFrm()
        {
            InitializeComponent();
        }

        public BaseFrm(string title)
        {
            InitializeComponent();
            this.lblTitle.Text = title;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frm = new FrmMain();
            frm.Show();
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {

        }

        private void closeForm(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            //Reload component
            //InitializeComponent();
        }

        private void BaseFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = Config.Config.Instance.Color;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Config.Config.Instance.Color = colorDialog.Color;
                }
            }
        }
    }
}
