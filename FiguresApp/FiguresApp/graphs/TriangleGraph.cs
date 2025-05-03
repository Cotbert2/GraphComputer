using FiguresApp.graphs.domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FiguresApp.graphs
{
    public class TriangleGraph : GraphAC
    {

        private float side;
        private float perimeter;
        private float area;
        private Graphics mGraph;
        private float SF;
        private Pen mPen;

        public TriangleGraph()
        {
            SF = Settings.Instance.ScaleFactor;
            side = 0.0f;
        }

        public override void ReadData(TextBox txtSide)
        {
            // Implementation for reading data specific to Triangle
            try
            {
                side = float.Parse(txtSide.Text, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter numeric values.");

            }
        }


        public override void ComputePerimeter()
        {
            perimeter = 3 * side;
        }

        public override void ComputeArea()
        {
            area = (float)(Math.Sqrt(3) / 4 * side * side);
        }

        public override void RenderData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = perimeter.ToString();
            txtArea.Text = area.ToString();
        }

        public override void InitData(TextBox txtSide, TextBox txtPerimeter, TextBox txtArea,
            PictureBox pictureCanvas)
        {
            // Initialization logic for Parallelogram
            side = perimeter = area = 0.0f;

            txtSide.Text = txtPerimeter.Text = txtArea.Text = "";

            txtSide.Focus();
            pictureCanvas.Refresh();
        }


        public override void RenderGraph (PictureBox pictureCanvas)
        {
            mGraph = pictureCanvas.CreateGraphics();
            mPen = new Pen(Settings.Instance.color, 3);
            PointF[] points = new PointF[3];

            float height = (float)(Math.Sqrt(3) * side / 2);

            points[0] = new PointF((side / 2) * SF, 0);
            points[1] = new PointF(0, height * SF);
            points[2] = new PointF(height * SF, height* SF);

            mGraph.DrawPolygon(mPen, points);
        }



    }
}
