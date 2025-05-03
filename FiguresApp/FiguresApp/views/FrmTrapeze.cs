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
    public partial class FrmTrapeze : FrmTemplate
    {
        private TrapezeGraph myTrapezeGraph = new TrapezeGraph();
        public FrmTrapeze()
        {
            InitializeComponent();
            SetFormTitle("Trapeze");
            setNumberOfFields(3);
            SetFieldLabel(0, "Base 1 (u): ");
            SetFieldLabel(1, "Base 2 (u): ");
            SetFieldLabel(2, "Height (u): ");
        }

        private void FrmTrapeze_Load(object sender, EventArgs e)
        {
            myTrapezeGraph.InitData(txtField1, txtField2, txtField3, txtPerimeter, txtArea, pBGraph);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            myTrapezeGraph.InitData(txtField1, txtField2, txtField3, txtPerimeter, txtArea, pBGraph);
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            myTrapezeGraph.ReadData(txtField1, txtField2, txtField3);
            myTrapezeGraph.ComputePerimeter();
            myTrapezeGraph.ComputeArea();
            myTrapezeGraph.RenderData(txtPerimeter, txtArea);
            myTrapezeGraph.RenderGraph(pBGraph);
        }
    }
}
