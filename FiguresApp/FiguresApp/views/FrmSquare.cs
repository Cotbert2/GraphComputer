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
    public partial class FrmSquare : FrmTemplate
    {

        private SquareGraph mySquareGraph = new SquareGraph();
        public FrmSquare()
        {
            InitializeComponent();
            SetFormTitle("Square");
            setNumberOfFields(1);
            SetFieldLabel(0, "Side (u):");
 
        }

        private void FrmSquare_Load(object sender, EventArgs e)
        {
            mySquareGraph.InitData(txtField1, txtPerimeter, txtArea, pBGraph);
        }

        private void btnPlot_Click_1(object sender, EventArgs e)
        {
            mySquareGraph.ReadData(txtField1, txtField1);
            mySquareGraph.ComputePerimeter();
            mySquareGraph.ComputeArea();
            mySquareGraph.RenderData(txtPerimeter, txtArea);
            mySquareGraph.RenderGraph(pBGraph);
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            mySquareGraph.InitData(txtField1, txtField1, txtPerimeter, txtArea, pBGraph);
        }
    }
}
