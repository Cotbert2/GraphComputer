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
    public class DiamondGraph : GraphAC
    {

        private float majorAxis;
        private float minorAxis;
        private float perimeter;
        private float area;
        private Graphics mGraph;
        private Pen Pen;
        private float SF;

        public DiamondGraph()
        {
            majorAxis = minorAxis = perimeter = area = 0.0f;
            SF = Settings.Instance.ScaleFactor;
        }



        public override void ComputeArea()
        {
            area = (float)((majorAxis * minorAxis) / 2);
        }

        public override void ComputePerimeter()
        {
            perimeter = 2 * (float)(Math.Sqrt(Math.Pow(majorAxis, 2) + Math.Pow(minorAxis, 2)));
        }

        public override void ReadData(TextBox txtMajorAxis, TextBox txtMinorAxis)
        {
            // Implementation for reading data specific to Diamond
            try
            {
                majorAxis = float.Parse(txtMajorAxis.Text, System.Globalization.CultureInfo.InvariantCulture);
                minorAxis = float.Parse(txtMinorAxis.Text, System.Globalization.CultureInfo.InvariantCulture);
                if (majorAxis <= 0 || minorAxis <= 0)
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

        public override void InitData(TextBox txtMajorAxis, TextBox txtMinorAxis, TextBox txtPerimeter, TextBox txtArea, PictureBox pictureCanvas)
        {
            // Initialization logic for Diamond
            majorAxis = minorAxis = perimeter = area = 0.0f;

            txtMajorAxis.Text = txtMinorAxis.Text =  txtPerimeter.Text = txtArea.Text = "";
            txtMajorAxis.Focus();
            pictureCanvas.Refresh();
        }
        



        public override void RenderData(TextBox txtPerimeter, TextBox txtArea)
        {
            // Implementation for rendering data specific to Diamond
            perimeter = (float)Math.Round(perimeter, 2);
            area = (float)Math.Round(area, 2);
            txtPerimeter.Text = perimeter.ToString();
            txtArea.Text = area.ToString();
        }

        public override void RenderGraph(PictureBox pictureCanvas)
        {
            mGraph = pictureCanvas.CreateGraphics();
            Pen = new Pen(Settings.Instance.color, 3);
            PointF[] points = new PointF[4];

            points[0] = new PointF(minorAxis / 2, 0);
            points[1] = new PointF(minorAxis, majorAxis / 2);
            points[2] = new PointF(minorAxis / 2, majorAxis);
            points[3] = new PointF(0, majorAxis / 2);

            for (int i = 0; i < points.Length; i++)
            {
                points[i].X *= SF;
                points[i].Y *= SF;
            }

            mGraph.DrawPolygon(Pen, points);
        }
    }
}
