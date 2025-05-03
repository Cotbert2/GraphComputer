using FiguresApp.views;
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
    public partial class FrmStar : FrmTemplate
    {

        private StarGraph myStarGraph = new StarGraph();
        public FrmStar()
        {
            InitializeComponent();
            SetFormTitle("Star");
            setNumberOfFields(3);
            SetFieldLabel(0, "Tips (u): ");
            SetFieldLabel(1, "Inner Radius (u): ");
            SetFieldLabel(2, "Outer Radius (u): ");
        }
        
        private void FrmStar_Load(object sender, EventArgs e)
        {
            myStarGraph.InitData(txtField1, txtField2, txtField3, txtPerimeter, txtArea, pBGraph);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            myStarGraph.InitData(txtField1, txtField2, txtField3, txtPerimeter, txtArea, pBGraph);
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            myStarGraph.ReadData(txtField1, txtField2, txtField3);
            myStarGraph.ComputePerimeter();
            myStarGraph.ComputeArea();
            myStarGraph.RenderData(txtPerimeter, txtArea);
            myStarGraph.RenderGraph(pBGraph);
        }
    }
}
