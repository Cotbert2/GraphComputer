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
    public partial class FrmTrapezoid : FrmTemplate
    {
        private TrapezoidGraph myTrapezoidGraph = new TrapezoidGraph();
        public FrmTrapezoid()
        {
            InitializeComponent();
            setNumberOfFields(4);
            SetFormTitle("Trapezoid");
            SetFieldLabel(0, "Side 1 (u): ");
            SetFieldLabel(1, "Side 2 (u): ");
            SetFieldLabel(2, "Side 3 (u): ");
            SetFieldLabel(3, "Side 4 (u): ");
        }

        private void FrmTrapezoid_Load(object sender, EventArgs e)
        {
            myTrapezoidGraph.InitData(txtField1, txtField2, txtField3, txtField4, txtPerimeter, txtArea, pBGraph);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            myTrapezoidGraph.InitData(txtField1, txtField2, txtField3, txtField4, txtPerimeter, txtArea, pBGraph);
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            myTrapezoidGraph.ReadData(txtField1, txtField2, txtField3, txtField4);
            myTrapezoidGraph.ComputePerimeter();
            myTrapezoidGraph.ComputeArea();
            myTrapezoidGraph.RenderData(txtPerimeter, txtArea);
            myTrapezoidGraph.RenderGraph(pBGraph);
        }
    }
}
