using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figure1
{
    public class Square
    {
        private float side;
        private float mPerimeter;
        private float mArea;
        private Graphics mGraph;
        private const float SF = 20; //scale factor
        private Pen mPen; // pen for drawing
        public Square() {
                    side  = mPerimeter = mArea = 0.0f;
        }


        public void ReadData(TextBox txtSide)
        {
            try
            {
                side = float.Parse(txtSide.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter numeric values.");
            }
        }


        public void PerimeterSquare()
        {
            mPerimeter = 4 * side;
        }

        public void AreaSquare()
        {
            mArea = side * side;
        }

        public void PrintData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = mPerimeter.ToString();
            txtArea.Text = mArea.ToString();
        }


        public void InitializeData(TextBox txtSide, TextBox txtPerimeter, TextBox txtArea,
        PictureBox pictureCanvas)
            {
                side = mPerimeter = mArea = 0.0f;
                txtSide.Text  = txtPerimeter.Text = txtArea.Text = "";

                txtSide.Focus();
                pictureCanvas.Refresh();
            }

        public void PlotShape(PictureBox pictureCanvas)
        {
            mGraph = pictureCanvas.CreateGraphics();
            mPen = new Pen(Color.Red, 3);

            mGraph.DrawRectangle(mPen, 0, 0, side * SF, side * SF);
        }

        public void CloseForm(Form myForm)
        {
            myForm.Close();
        }
    }

}
