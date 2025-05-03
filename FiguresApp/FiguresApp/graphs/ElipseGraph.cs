using FiguresApp.graphs.domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiguresApp.graphs
{
    public class ElipseGraph : GraphAC
    {

        private float minorBase;
        private float majorBase;
        private float perimeter;
        private float area;
        private Graphics mGraph;
        private Pen mPen;
        private float SF;

        public ElipseGraph() 
        {
            minorBase = majorBase = perimeter = area = 0.0f;
            SF = Settings.Instance.ScaleFactor;
        }
        public override void ComputeArea()
        {
            area = (float)(Math.PI * minorBase * majorBase);
        }

        public override void ComputePerimeter()
        {
            perimeter = (float)(2 * Math.PI * 
                (Math.Sqrt((minorBase * minorBase + majorBase * majorBase)/2)));
        }

        public override void RenderData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = perimeter.ToString();
            txtArea.Text = area.ToString();
        }

        public override void ReadData(TextBox txtMinorBase, TextBox txtMajorBase)
        {
            // Implementation for reading data specific to Elipse
            try
            {
                minorBase = float.Parse(txtMinorBase.Text, System.Globalization.CultureInfo.InvariantCulture);
                majorBase = float.Parse(txtMajorBase.Text, System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter numeric values.");
            }
        }

        public override void InitData(TextBox txtMinorBase, TextBox txtMajorBase, TextBox txtPerimeter, TextBox txtArea, PictureBox pictureCanvas)
        {
            minorBase = majorBase = perimeter = area = 0.0f;
            txtMajorBase.Text = txtMinorBase.Text = txtPerimeter.Text = txtArea.Text = "";

            txtMajorBase.Focus();
            pictureCanvas.Refresh();
        }

        public override void RenderGraph(PictureBox pictureCanvas)
        {
            mGraph = pictureCanvas.CreateGraphics();
            mPen = new Pen(Settings.Instance.color, 2);

            mGraph.DrawEllipse(mPen,new RectangleF(0,0,SF * minorBase,SF * majorBase));

        }
    }
}
