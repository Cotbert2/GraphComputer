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
    public partial class FrmTriangle : FrmTemplate
    {

        private TriangleGraph myTriangleGraph = new TriangleGraph();
        public FrmTriangle()
        {
            InitializeComponent();
            SetFormTitle("Triangle");
            SetFieldLabel(0, "Side (u): ");
            setNumberOfFields(1);
        }

        private void FrmTriangle_Load(object sender, EventArgs e)
        {
            myTriangleGraph.InitData(txtField1, txtPerimeter, txtArea, pBGraph);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            myTriangleGraph.InitData(txtField1, txtPerimeter, txtArea, pBGraph);
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            myTriangleGraph.ReadData(txtField1);
            myTriangleGraph.ComputePerimeter();
            myTriangleGraph.ComputeArea();
            myTriangleGraph.RenderData(txtPerimeter, txtArea);

            myTriangleGraph.RenderGraph(pBGraph);
        }
    }
}
