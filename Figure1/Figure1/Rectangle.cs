using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figure1
{
    public class Rectangle
    {
        private float mWidth;
        private float mHeight;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20; //scale factor
        private Pen mPen; // pen for drawing


        public Rectangle()
        {
            mWidth = mHeight = mPerimeter = mArea = 0.0f;
        }


        public void ReadData(TextBox txtWidth, TextBox txtHeight) {
            try {
                mWidth = float.Parse(txtWidth.Text);
                mHeight = float.Parse(txtHeight.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter numeric values.");
            }
        }

        public void PerimeterRectangle()
        {
            mPerimeter = 2 * (mWidth + mHeight);
        }

        public void AreaRectangle()
        {
            mArea = mWidth * mHeight;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }

        public void InitializeData(TextBox txtWidth, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea,
            PictureBox pictureCanvas)
        {
            mWidth = mHeight = mPerimeter = mArea = 0.0f;

            txtWidth.Text = txtHeight.Text =txtPerimeter.Text = txtArea.Text = "";

            txtWidth.Focus();
            pictureCanvas.Refresh();
        }

        public void PlotShape(PictureBox pictureCanvas) {
            mGraph = pictureCanvas.CreateGraphics();
            mPen = new Pen(Color.Red, 3);

            mGraph.DrawRectangle(mPen, 0, 0, mWidth * SF, mHeight * SF);
        }

        public void CloseForm(Form myForm) {
            myForm.Close();
        }

    }
}
