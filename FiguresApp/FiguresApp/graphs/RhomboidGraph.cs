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
    public class RhomboidGraph : GraphAC
    {

        private float _base;
        private float height;
        private float side;
        private float perimeter;
        private float area;
        private Graphics mGraph;
        private float SF;
        private Pen mPen;


        public RhomboidGraph()
        {
            SF = Settings.Instance.ScaleFactor;
            _base = height = side = perimeter = area = 0.0f;
        }


        public override void ComputeArea()
        {
            area = _base * height;
        }

        public override void ComputePerimeter()
        {
            perimeter = 2 * (_base + side);
        }

        public override void ReadData(TextBox txtBase, TextBox txtHeight, TextBox txtSide)
        {
            // Implementation for reading data specific to Rhomboid
            try
            {
                _base = float.Parse(txtBase.Text, System.Globalization.CultureInfo.InvariantCulture);
                height = float.Parse(txtHeight.Text, System.Globalization.CultureInfo.InvariantCulture);
                side = float.Parse(txtSide.Text, System.Globalization.CultureInfo.InvariantCulture);
                if (_base <= 0 || height <= 0 || side <= 0)
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

        public override void InitData(TextBox txtBase, TextBox txtHeight, TextBox txtSide, TextBox txtPerimeter, TextBox txtArea, PictureBox pictureCanvas)
        {
            // Initialization logic for Rhomboid
            _base = height = side = perimeter = area = 0.0f;
            txtBase.Text = txtHeight.Text = txtSide.Text = txtPerimeter.Text = txtArea.Text = "";
            
            txtBase.Focus();
            pictureCanvas.Refresh();

        }

        public override void RenderData(TextBox txtPerimeter, TextBox txtArea)
        {
            // Implementation for rendering data specific to Rhomboid
            perimeter = (float)Math.Round(perimeter, 2);
            area = (float)Math.Round(area, 2);
            txtPerimeter.Text = perimeter.ToString();
            txtArea.Text = area.ToString();
        }

        public override void RenderGraph(PictureBox pictureCanvas)
        {
            mGraph = pictureCanvas.CreateGraphics();
            mPen = new Pen(Settings.Instance.color, 3);

            PointF[] rhomboid = new PointF[4];
            rhomboid[0] = new PointF(0, height);
            rhomboid[1] = new PointF(_base , height);
            rhomboid[2] = new PointF((float) (_base + Math.Sqrt(Math.Pow(height,2) +  Math.Pow(side,2))), 0);
            rhomboid[3] = new PointF((float)Math.Sqrt(Math.Pow(height, 2) + Math.Pow(side, 2)), 0);

            for (int i = 0; i < rhomboid.Length; i++)
            {
                rhomboid[i].X *= SF;
                rhomboid[i].Y *= SF;
            }

            mGraph.DrawPolygon(mPen, rhomboid);
        }
    }
}
