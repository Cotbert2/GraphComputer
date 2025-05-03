using FiguresApp.graphs;
using System;
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
    public partial class FrmRectangle : FrmTemplate
    {

        private graphs.RectangleGraph myParallelogramGraph = new graphs.RectangleGraph();
        public FrmRectangle()
        {
            InitializeComponent();
            SetFormTitle("Rectangle");
            setNumberOfFields(2);
            SetFieldLabel(0, "Base (u):");
            SetFieldLabel(1, "Height (u):");
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

        private void FrmRectangle_Load(object sender, EventArgs e)
        {
            myParallelogramGraph.InitData(txtField1, txtField2, txtPerimeter, txtArea, pBGraph);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            myParallelogramGraph.InitData(txtField1, txtField2, txtPerimeter, txtArea, pBGraph);
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            myParallelogramGraph.ReadData(txtField1, txtField2);
            myParallelogramGraph.ComputePerimeter();
            myParallelogramGraph.ComputeArea();
            myParallelogramGraph.RenderData(txtPerimeter, txtArea);
            myParallelogramGraph.RenderGraph(pBGraph);
        }
    }
}
