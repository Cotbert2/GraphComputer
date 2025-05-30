﻿using FiguresApp.graphs;
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
    public partial class FrmRohboid : FrmTemplate
    {
        private RhomboidGraph myRhooboidGraph = new RhomboidGraph();
        public FrmRohboid()
        {
            InitializeComponent();
            SetFormTitle("Rohboid");
            setNumberOfFields(3);
            SetFieldLabel(0, "Base (u): ");
            SetFieldLabel(1, "Height (u): ");
            SetFieldLabel(2, "Side (u): ");
        }

        private void FrmRohboid_Load(object sender, EventArgs e)
        {
            myRhooboidGraph.InitData(txtField1, txtField2, txtField3, txtPerimeter, txtArea, pBGraph);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            myRhooboidGraph.InitData(txtField1, txtField2, txtField3, txtPerimeter, txtArea, pBGraph);
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            myRhooboidGraph.ReadData(txtField1, txtField2, txtField3);
            myRhooboidGraph.ComputePerimeter();
            myRhooboidGraph.ComputeArea();
            myRhooboidGraph.RenderData(txtPerimeter, txtArea);
            myRhooboidGraph.RenderGraph(pBGraph);
        }
    }
}
