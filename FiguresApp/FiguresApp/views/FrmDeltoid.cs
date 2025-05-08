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
    public partial class FrmDeltoid : FrmTemplate
    {
        private DeltoideGraph myDeltoidGraph = new DeltoideGraph();
        public FrmDeltoid()
        {
            InitializeComponent();
            SetFormTitle("Deltoid");
            setNumberOfFields(3);
            SetFieldLabel(0, "Side (u): ");
            SetFieldLabel(1, "Side  (u): ");
            SetFieldLabel(2, "Axis (u): ");
        }

        private void FrmDeltoid_Load(object sender, EventArgs e)
        {
            myDeltoidGraph.InitData(txtField1, txtField2, txtField3, txtPerimeter, txtArea, pBGraph);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            myDeltoidGraph.InitData(txtField1, txtField2, txtField3, txtPerimeter, txtArea, pBGraph);
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            myDeltoidGraph.ReadData(txtField1, txtField2, txtField3);
            myDeltoidGraph.ComputePerimeter();
            myDeltoidGraph.ComputeArea();
            myDeltoidGraph.RenderData(txtPerimeter, txtArea);
            myDeltoidGraph.RenderGraph(pBGraph);
        }
    }
}
