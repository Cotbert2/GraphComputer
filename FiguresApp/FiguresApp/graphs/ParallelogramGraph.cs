using FiguresApp.graphs.domain;
using FiguresApp.graphs.interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace FiguresApp.graphs
{
    public class ParallelogramGraph : GraphAC
    {


        private float mWidth;
        private float mHeight;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20;
        private Pen mPen;

        public ParallelogramGraph() {
            mWidth = mHeight = mPerimeter = mArea = 0.0f;
        }


        public override void ReadData(TextBox txtWidth, TextBox txtHeight)
        {
            // Implementation for reading data specific to Parallelogram
            try
            {
                mWidth = float.Parse(txtWidth.Text, CultureInfo.InvariantCulture);
                mHeight = float.Parse(txtHeight.Text, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter numeric values.");

            }
        }
        public override void ComputePerimeter()
        {
            // Implementation for computing perimeter of Parallelogram
            mPerimeter = 2 * (mWidth + mHeight);
        }
        public override void ComputeArea()
        {
            // Implementation for computing area of Parallelogram
            mArea = mWidth * mHeight;
        }
        public override void RenderData(TextBox txtPerimeter, TextBox txtArea)
        {
            // Implementation for rendering data specific to Parallelogram
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }
        public override void InitData(TextBox txtWidth, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea,
            PictureBox pictureCanvas)
        {
            // Initialization logic for Parallelogram
            mWidth = mHeight = mPerimeter = mArea = 0.0f;

            txtWidth.Text = txtHeight.Text = txtPerimeter.Text = txtArea.Text = "";

            txtWidth.Focus();
            pictureCanvas.Refresh();
        }

        public override void RenderGraph(PictureBox pictureCanvas)
        {
            // Logic to render the graph of a Parallelogram
            mGraph = pictureCanvas.CreateGraphics();
            mPen = new Pen(Settings.Instance.color, 3);

            mGraph.DrawRectangle(mPen, 0, 0, mWidth * SF, mHeight * SF);
        }
    }
}
