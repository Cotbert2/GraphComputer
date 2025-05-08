using FiguresApp.graphs.domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiguresApp.views
{
    public class StarGraph : GraphAC
    {
        private int tips;
        private float outerRadius;
        private float innerRadius;
        private float area;
        private float perimeter;
        private float steps;
        private Graphics mGraph;
        private float SF;
        private Pen mPen;

        public StarGraph()
        {
            SF = Settings.Instance.ScaleFactor;
            tips = 0;
            outerRadius = innerRadius = area = perimeter = 0.0f;
        }

        public override void ComputeArea()
        {
            area = (float)(tips * outerRadius * innerRadius * Math.Sign(Math.PI/tips));
        }

        public override void ComputePerimeter()
        {
            perimeter = (float)(2 * tips * Math.Sqrt(Math.Pow(outerRadius,2) + Math.Pow(innerRadius, 2) -2 * outerRadius * innerRadius * Math.Cos(steps)));
        }

        public override void RenderData(TextBox txtPerimeter, TextBox txtArea)
        {
            // Implementation for rendering data specific to Star
            txtPerimeter.Text = perimeter.ToString();
            txtArea.Text = area.ToString();
        }

        public override void ReadData(TextBox txtTips, TextBox txtOuterRadius, TextBox txtInnerRadius)
        {
            try
            {
                tips = int.Parse(txtTips.Text);
                outerRadius = float.Parse(txtOuterRadius.Text);
                innerRadius = float.Parse(txtInnerRadius.Text);
                if (tips <= 0 || outerRadius <= 0 || innerRadius <= 0)
                {
                    MessageBox.Show("All values must be positive.");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter numeric values.");
            }
            finally { 
                steps = (float)(Math.PI / tips);
            }
        }

        public override void InitData(TextBox txtTips, TextBox txtOuterRadius, TextBox txtInnerRadius, TextBox txtPerimeter, TextBox txtArea, PictureBox pictureCanvas)
        {
            tips = 0;
            outerRadius = innerRadius = area = perimeter = 0.0f;
            txtTips.Text = txtOuterRadius.Text = txtInnerRadius.Text = txtPerimeter.Text = txtArea.Text = "";
            txtTips.Focus();
            pictureCanvas.Refresh();
        }

        public override void RenderGraph(PictureBox pictureCanvas)
        {
            PointF canvasCenter = new PointF(
                pictureCanvas.Width / 2,
                pictureCanvas.Height / 2
            );
            List<PointF> points = new List<PointF>();

            for (int i = 0; i < 2 * tips; i++)
            {
                float angle = i * steps;
                float radius = (i % 2 == 0) ? outerRadius : innerRadius;

                points.Add(new PointF(
                    (float)(radius * Math.Cos(angle)),
                    (float)(radius * Math.Sin(angle))
                ));
            }

            List<PointF> scaledPoints = new List<PointF>();

            foreach (var point in points)
            {
                scaledPoints.Add(new PointF(point.X * SF + canvasCenter.X, point.Y * SF + canvasCenter.X));
            }

            mGraph = pictureCanvas.CreateGraphics();
            mPen = new Pen(Settings.Instance.color, 2);

            mGraph.DrawPolygon(mPen, scaledPoints.ToArray());
        }
    }
}
