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
    public class DeltoideGraph : GraphAC
    {

        private float side1;
        private float side2;
        private float axis;
        private float area;
        private float perimeter;
        private Graphics mGraph;
        private float SF;
        private Pen mPen;

        private PointF[] points = new PointF[4];

        public DeltoideGraph()
        {
            SF = Settings.Instance.ScaleFactor;
            side1 = side2 = axis = area = perimeter = 0.0f;
        }



        public override void ComputeArea()
        {
            PointF[] pointsUnScaled = new PointF[4];
            pointsUnScaled[0] = new PointF(points[0].X / SF, points[0].Y / SF);
            pointsUnScaled[1] = new PointF(points[1].X / SF, points[1].Y / SF);
            pointsUnScaled[2] = new PointF(points[2].X / SF, points[2].Y / SF);
            pointsUnScaled[3] = new PointF(points[3].X / SF, points[3].Y / SF);
            area = ((distanceBetweenPoints(pointsUnScaled[0], pointsUnScaled[2]) * distanceBetweenPoints(pointsUnScaled[1], pointsUnScaled[2])) / 2.0f);
        }

        public override void ComputePerimeter()
        {
            perimeter = 2 * (float)(side2 + side1);
        }

        public override void ReadData(TextBox txtSide1, TextBox txtSide2, TextBox txtAxis)
        {
            // Implementation for reading data specific to Deltoide
            try
            {
                side1 = float.Parse(txtSide1.Text, System.Globalization.CultureInfo.InvariantCulture);
                side2 = float.Parse(txtSide2.Text, System.Globalization.CultureInfo.InvariantCulture);
                axis = float.Parse(txtAxis.Text, System.Globalization.CultureInfo.InvariantCulture);
                if (side1 <= 0 || side2 <= 0 || axis <= 0)
                {
                    MessageBox.Show("All values must be positive.");
                    return;
                }
                if (side1 + side2 < axis) 
                {
                    MessageBox.Show("The polygon does not exists");
                    return;
                }
                ComputePoints();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter numeric values.");
            } 
        }

        public override void RenderData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = perimeter.ToString();
            txtArea.Text = area.ToString();
        }

        private void ComputePoints() {
            float x =   (float) Math.Sqrt(side1 * side1 - Math.Pow(side2 - (axis / 2), 2));
            float y = (side1 * side1 - side2 * side2)/(2*axis);
            points[0] = new PointF(x, 0);
            points[1] = new PointF(2 * x , y + (axis/2));
            points[2] = new PointF(x ,axis);
            points[3] = new PointF(0, y + (axis / 2));

            for (int i = 0; i < points.Length; i++)
            {
                points[i].X *= SF;
                points[i].Y *= SF;
            }
        }

        private float distanceBetweenPoints(PointF p1, PointF p2)
        {
            return (float)Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }

        public override void InitData(TextBox txtSide1, TextBox txtSide2, TextBox txtAxis, TextBox txtPerimeter, TextBox txtArea, PictureBox pictureCanvas)
        {
            side1 = side2 = axis = area = perimeter = 0.0f;
            txtSide1.Text = txtSide2.Text = txtAxis.Text = txtPerimeter.Text = txtArea.Text = "";
            txtSide1.Focus();

            pictureCanvas.Refresh();
        }

        public override void RenderGraph(PictureBox pictureCanvas)
        {

            mGraph = pictureCanvas.CreateGraphics();
            mPen = new Pen(Settings.Instance.color, 2);


            mGraph.DrawPolygon(mPen, points);
        }
    }
}
