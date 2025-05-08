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
    public class TrapezoidGraph : GraphAC

    {
        private float side1;
        private float side2;
        private float side3;
        private float side4;
        private float area;
        private float perimeter;
        private Graphics mGraph;
        private float SF;
        private Pen mPen;

        private PointF[] points = new PointF[4];

        public TrapezoidGraph()
        {
            SF = Settings.Instance.ScaleFactor;
            side1 = side2 = side3 = side4 = area = perimeter = 0.0f;
        }

        public void InitData(TextBox txtSide1, TextBox txtSide2, TextBox txtSide3, TextBox txtSide4, TextBox txtPerimeter, TextBox txtArea, PictureBox pictureCanvas)
        {
            side2 = side1 = side3 = side4 = area = perimeter = 0.0f;
            txtSide1.Text = txtSide2.Text = txtSide3.Text = txtSide4.Text = "";
            txtSide1.Focus();

            pictureCanvas.Refresh();
        }

        public override void ComputeArea()
        {
            PointF[] pointsUnScaled = new PointF[4];
            pointsUnScaled[0] = new PointF(points[0].X / SF, points[0].Y / SF);
            pointsUnScaled[1] = new PointF(points[1].X / SF, points[1].Y / SF);
            pointsUnScaled[2] = new PointF(points[2].X / SF, points[2].Y / SF);
            pointsUnScaled[3] = new PointF(points[3].X / SF, points[3].Y / SF);


                    area = 0.5f * Math.Abs(
            pointsUnScaled[0].X * pointsUnScaled[1].Y +
            pointsUnScaled[1].X * pointsUnScaled[2].Y +
            pointsUnScaled[2].X * pointsUnScaled[3].Y +
            pointsUnScaled[3].X * pointsUnScaled[0].Y
            - pointsUnScaled[1].X * pointsUnScaled[0].Y
            - pointsUnScaled[2].X * pointsUnScaled[1].Y
            - pointsUnScaled[3].X * pointsUnScaled[2].Y
            - pointsUnScaled[0].X * pointsUnScaled[3].Y
        );
        }

        public override void ComputePerimeter()
        {
            perimeter = side1 + side2 + side3 + side4;
        }

        public override void RenderData(TextBox txtPerimeter, TextBox txtArea)
        {
            perimeter = (float)Math.Round(perimeter, 2);
            area = (float)Math.Round(area, 2);
            txtPerimeter.Text = perimeter.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
            txtArea.Text = area.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        }

        public void ReadData(TextBox txtSide1, TextBox txtSide2, TextBox txtSide3, TextBox txtSide4)
        {
            try
            {
                side1 = float.Parse(txtSide1.Text, System.Globalization.CultureInfo.InvariantCulture);
                side2 = float.Parse(txtSide2.Text, System.Globalization.CultureInfo.InvariantCulture);
                side3 = float.Parse(txtSide3.Text, System.Globalization.CultureInfo.InvariantCulture);
                side4 = float.Parse(txtSide4.Text, System.Globalization.CultureInfo.InvariantCulture);
                if (side1 <= 0 || side2 <= 0 || side3 <= 0 || side4 <= 0)
                {
                    MessageBox.Show("All values must be positive.");
                    return;
                }
                computePoints();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter numeric values.");
            }
        }

        private void computePoints()
        {
            points[0] = new PointF(0, 0);
            points[1] = new PointF(side1 * SF, 0);
            points[2] = new PointF(side1 * SF + side2 * SF, side3 * SF);
            points[3] = new PointF(side2 * SF, side4 * SF);
        }

        public override void RenderGraph(PictureBox pictureCanvas)
        {
            mGraph = pictureCanvas.CreateGraphics();
            mPen = new Pen(Settings.Instance.color, 2);
            mGraph.DrawPolygon(mPen, points);

        }
    }
}
