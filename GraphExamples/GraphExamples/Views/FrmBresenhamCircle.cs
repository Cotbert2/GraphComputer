using GraphExamples.Graphers;
using GraphExamples.Views.shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphExamples.Views
{
    public partial class FrmBresenhamCircle : BaseFrm
    {
        public FrmBresenhamCircle() : base("Bresenham Circle Drawer")
        {
            InitializeComponent();
            btnPlot.Click += btnPlot_Click;
            btnReload.Click += btn_Reload_Click;
        }

        private BresenhamGrapherCircle bresenhamGrapherCircle = new BresenhamGrapherCircle();

        private void btnPlot_Click(object sender, EventArgs e)
        {
            bresenhamGrapherCircle.readData(txtRadio, canvas);
            lbPoints.Items.Clear();
            foreach (var point in bresenhamGrapherCircle.GetPoints())
            {
                lbPoints.Items.Add($"({point.X}, {point.Y})");
            }
            txtPoints.Text = bresenhamGrapherCircle.GetPoints().Count.ToString();
        }

        private void btn_Reload_Click(object sender, EventArgs e)
        {
            canvas.Image = null;
            lbPoints.Items.Clear();
            txtPoints.Text = "0";
            txtRadio.Text = string.Empty;
            bresenhamGrapherCircle = new BresenhamGrapherCircle();
        }
    }
}
