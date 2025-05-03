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
    public class TrapezeGraph : GraphAC
    {

        private float minorBase;
        private float majorBase;
        private float height;
        private float perimeter;
        private float area;
        private Graphics mGraph;
        private float SF;

        public TrapezeGraph()
        {
            minorBase = majorBase = height = perimeter = area = 0.0f;
            SF = Settings.Instance.ScaleFactor;
        }

        public override void ReadData(TextBox txtMinorBase, TextBox txtMajorBase, TextBox txtHeight)
        {
            // Implementation for reading data specific to Trapeze
            try
            {
                minorBase = float.Parse(txtMinorBase.Text, System.Globalization.CultureInfo.InvariantCulture);
                majorBase = float.Parse(txtMajorBase.Text, System.Globalization.CultureInfo.InvariantCulture);
                height = float.Parse(txtHeight.Text, System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter numeric values.");
            }
        }

        public override void ComputeArea()
        {
            area = ((minorBase + majorBase) / 2) * height;
        }

        private float GetSide() {
            return (float) Math.Sqrt(((majorBase - minorBase) * (majorBase - minorBase))/2 + height * height);
        }

        public override void ComputePerimeter()
        {
            perimeter = minorBase + majorBase + 2 * GetSide();
        }

        public override void RenderData(TextBox txtPerimeter, TextBox txtArea)
        {
            // Implementation for rendering data specific to Trapeze
            txtPerimeter.Text = perimeter.ToString();
            txtArea.Text = area.ToString();
        }

        public override void InitData(TextBox txtMinorBase, TextBox txtMajorBase, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox pictureCanvas)
        {
            // Initialization logic for Trapeze
            minorBase = majorBase = height = perimeter = area = 0.0f;

            txtMinorBase.Text = txtMajorBase.Text = txtHeight.Text = txtPerimeter.Text = txtArea.Text = "";

            txtMinorBase.Focus();
            pictureCanvas.Refresh();
        }

        public override void RenderGraph(PictureBox pictureCanvas)
        {
            float  aux = 0;
            if (minorBase > majorBase)
            {
                aux = (float)minorBase;
                minorBase = majorBase;
                majorBase = aux;
            }

            mGraph = pictureCanvas.CreateGraphics();
            Pen mPen = new Pen(Settings.Instance.color, 3);
            PointF[] points = new PointF[4];
            points[0] = new PointF(0, height * SF);
            points[1] = new PointF((majorBase - minorBase)/2 * SF,0);
            points[2] = new PointF(minorBase * SF + ((majorBase - minorBase)/2) *SF, 0);
            points[3] = new PointF(majorBase * SF, height * SF);
            mGraph.DrawPolygon(mPen, points);
        }
    }
}
