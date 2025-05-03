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
    public partial class FrmDiamond : FrmTemplate
    {
        private DiamondGraph myDiamondGraph = new DiamondGraph();
        public FrmDiamond()
        {
            InitializeComponent();
            SetFormTitle("Diamond");
            setNumberOfFields(2);
            SetFieldLabel(0, "Diagonal 1 (u): ");
            SetFieldLabel(1, "Diagonal 2 (u): ");
        }

        private void FrmDiamond_Load(object sender, EventArgs e)
        {
            myDiamondGraph.InitData(txtField1, txtField2, txtPerimeter, txtArea, pBGraph);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            myDiamondGraph.InitData(txtField1, txtField2, txtPerimeter, txtArea, pBGraph);
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            myDiamondGraph.ReadData(txtField1, txtField2);
            myDiamondGraph.ComputePerimeter();
            myDiamondGraph.ComputeArea();
            myDiamondGraph.RenderData(txtPerimeter, txtArea);
            myDiamondGraph.RenderGraph(pBGraph);
        }
    }
}
