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

        private float axis1;
        private float axis2;
        private float side;
        private float area;
        private float perimeter;
        private Graphics mGraph;
        private float SF;
        private Pen mPen;

        private PointF[] points = new PointF[4];

        public DeltoideGraph()
        {
            SF = Settings.Instance.ScaleFactor;
            axis1 = axis2 = side = area = perimeter = 0.0f;
        }



        public override void ComputeArea()
        {
            area = (axis1 * axis2) / 2;
        }

        public override void ComputePerimeter()
        {
            
        }

        public override void ReadData(TextBox txtAxis1, TextBox txtAxis2, TextBox txtSide)
        {
            // Implementation for reading data specific to Deltoide
            try
            {
                axis1 = float.Parse(txtAxis1.Text, System.Globalization.CultureInfo.InvariantCulture);
                axis2 = float.Parse(txtAxis2.Text, System.Globalization.CultureInfo.InvariantCulture);
                side = float.Parse(txtSide.Text, System.Globalization.CultureInfo.InvariantCulture);
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
            points[0] = new PointF(axis1 / 2,0);
            points[1] = new PointF(axis1, axis2 / 2);
            points[2] = new PointF(axis1 / 2, axis2);
            points[3] = new PointF(0, axis2 / 2);

            for (int i = 0; i < points.Length; i++)
            {
                points[i].X *= SF;
                points[i].Y *= SF;
            }
        }

        public override void InitData(TextBox txtAxis1, TextBox txtAxis2, TextBox txtSide, TextBox txtPerimeter, TextBox txtArea, PictureBox pictureCanvas)
        {
            axis1 = axis2 = side = area = perimeter = 0.0f;
            txtAxis1.Text = txtAxis2.Text = txtSide.Text = txtPerimeter.Text = txtArea.Text = "";
            txtAxis1.Focus();

            pictureCanvas.Refresh();
        }

        public override void RenderGraph(PictureBox pictureCanvas)
        {
            mGraph = pictureCanvas.CreateGraphics();
            mPen = new Pen(Color.Black, 2);

            mGraph.DrawPolygon(mPen, points);



        }
    }
}
