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
    public partial class FrmCircle : FrmTemplate
    {

        private CircleGraph mCircleGraph = new CircleGraph();
        public FrmCircle()
        {
            InitializeComponent();
            SetFormTitle("Circle");
            setNumberOfFields(1);
            SetFieldLabel(0, "Radius: ");
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

        private void FrmCircle_Load(object sender, EventArgs e)
        {
            mCircleGraph.InitData(txtField1, txtPerimeter, txtArea, pBGraph);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mCircleGraph.InitData(txtField1, txtPerimeter, txtArea, pBGraph);
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            mCircleGraph.ReadData(txtField1);
            mCircleGraph.ComputePerimeter();
            mCircleGraph.ComputeArea();
            mCircleGraph.RenderData(txtPerimeter, txtArea);
            mCircleGraph.RenderGraph(pBGraph);
        }
    }
}
