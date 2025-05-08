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
    public class SemicircleGraph : GraphAC
    {
        private float radius;
        private float area;
        private float perimeter;
        private Graphics mGraph;
        private float SF;
        private Pen mPen;

        public SemicircleGraph() 
        {
            radius = area = perimeter = 0.0f;
            SF = Settings.Instance.ScaleFactor;
        }

        public override void ComputeArea()
        {
            area = (float)(Math.PI * radius * radius / 2);
        }

        public override void ComputePerimeter()
        {
            perimeter = (float)(Math.PI * radius * 2 + 2 * radius);
        }

        public override void RenderData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text =  perimeter.ToString();
            txtArea.Text = area.ToString();
        }

        public override void ReadData(TextBox txtRadius)
        {
            try
            {
                radius = float.Parse(txtRadius.Text, System.Globalization.CultureInfo.InvariantCulture);
                if (radius <= 0)
                {
                    MessageBox.Show("All values must be positive.");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter numeric values.");
            }
        }

        public override void InitData(TextBox txtRatio, TextBox txtPerimeter, TextBox txtArea, PictureBox pictureCanvas)
        {
            radius = area = perimeter = 0.0f;
            txtRatio.Text = txtPerimeter.Text = txtArea.Text = "";

            txtRatio.Focus();
            pictureCanvas.Refresh();
        }

        public override void RenderGraph(PictureBox pictureCanvas)
        {
            mGraph = pictureCanvas.CreateGraphics();
            mPen = new Pen(Settings.Instance.color, 2);
            PointF[] line = new PointF[2];
            line[0] = new PointF(0, radius * SF);
            line[1] = new PointF(2 * radius * SF, radius * SF);

            mGraph.DrawLine(mPen, line[0], line[1]);
            mGraph.DrawArc(mPen, 0, 0, 2 *radius * SF,2 * radius * SF, 0, 180);
        }
    }
}
