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
    public partial class FrmSemicircle : FrmTemplate
    {
        private SemicircleGraph mySemicircleGraph = new SemicircleGraph();

        public FrmSemicircle()
        {
            InitializeComponent();
            SetFormTitle("Semicircle");
            setNumberOfFields(1);
            SetFieldLabel(0, "Radius (u): ");
        }

        private void FrmSemicircle_Load(object sender, EventArgs e)
        {
            mySemicircleGraph.InitData(txtField1, txtPerimeter, txtArea, pBGraph);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mySemicircleGraph.InitData(txtField1, txtPerimeter, txtArea, pBGraph);
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            mySemicircleGraph.ReadData(txtField1);
            mySemicircleGraph.ComputePerimeter();
            mySemicircleGraph.ComputeArea();
            mySemicircleGraph.RenderData(txtPerimeter, txtArea);
            mySemicircleGraph.RenderGraph(pBGraph);
        }
    }
}
