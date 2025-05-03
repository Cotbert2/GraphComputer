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
    public partial class FrmElipse : FrmTemplate
    {
        private ElipseGraph myElipseGraph = new ElipseGraph();
        public FrmElipse()
        {
            InitializeComponent();
            SetFormTitle("Elipse");
            setNumberOfFields(2);
            SetFieldLabel(0, "Semi-major axis (u): ");
            SetFieldLabel(1, "Semi-minor axis (u): ");
        }

        private void FrmElipse_Load(object sender, EventArgs e)
        {
            myElipseGraph.InitData(txtField1, txtField2, txtPerimeter, txtArea, pBGraph);
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            myElipseGraph.ReadData(txtField1, txtField2);
            myElipseGraph.ComputePerimeter();
            myElipseGraph.ComputeArea();
            myElipseGraph.RenderData(txtPerimeter, txtArea);
            myElipseGraph.RenderGraph(pBGraph);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            myElipseGraph.InitData(txtField1, txtField2, txtPerimeter, txtArea, pBGraph);
        }
    }
}
