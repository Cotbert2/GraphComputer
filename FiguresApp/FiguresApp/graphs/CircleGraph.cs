using FiguresApp.graphs.domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiguresApp.graphs
{
    public class CircleGraph : GraphAC
    {

        private float ratio;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public CircleGraph()
        {
            ratio = mPerimeter = mArea = 0.0f;
        }


        public override void ReadData(TextBox txtRatio)
        {
            // Implementation for reading data specific to Circle
            try
            {
                ratio = float.Parse(txtRatio.Text, CultureInfo.InvariantCulture);
                if (ratio <= 0)
                {
                    MessageBox.Show("Ratio must be positive.");
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter numeric values.");

            }
        }
        public override void ComputePerimeter()
        {
            // Implementation for computing perimeter of Circle
            mPerimeter = 2 * (float)Math.PI * ratio;
        }
        public override void ComputeArea()
        {
            // Implementation for computing area of Circle
            mArea = (float)Math.PI * ratio * ratio;
        }
        public override void RenderData(TextBox txtPerimeter, TextBox txtArea)
        {
            // Implementation for rendering data specific to Circle
            mPerimeter = (float)Math.Round(mPerimeter, 2);
            mArea = (float)Math.Round(mArea, 2);
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        public override void InitData(TextBox txtRatio,  TextBox txtPerimeter, TextBox txtArea, PictureBox pictureCanvas)
        {
            // Initialization logic for Circle
            ratio = mPerimeter = mArea = 0.0f;

            txtRatio.Text = txtPerimeter.Text = txtArea.Text = "";

            txtRatio.Focus();
            pictureCanvas.Refresh();
        }

        public override void RenderGraph(PictureBox pictureCanvas)
        {
            // Logic to render the graph of a Circle
            mGraph = pictureCanvas.CreateGraphics();
            mPen = new Pen(Settings.Instance.color, 3);

            //circle is a ellipse with equal width and height
            mGraph.DrawEllipse(mPen, 0, 0, ratio * SF, ratio * SF);
        }
    }
}
