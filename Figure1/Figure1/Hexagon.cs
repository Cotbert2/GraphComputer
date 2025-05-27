using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figure1
{
    public class Hexagon
    {
        private float side;
        private Graphics mGraph;
        private float SF = 20;
        private Pen mPen;
        private float currentDegrees = 0;
        private float transX = 0f;
        private float transY = 0f;
        public Hexagon() { 
            side = 0;
        }


        public void ReadData(TextBox txtSide) { 
            try
            {
                side = float.Parse(txtSide.Text);
            } catch {
                MessageBox.Show("Invalid input");
            }
        }

        public void InitializeData(TextBox txtSide, PictureBox canvas)
        {
            side = 0;
            canvas.Refresh();
        }

        public void changeDegrees(int degrees)
        {

            currentDegrees += (float) (degrees * (Math.PI / 180));
        }

        public void translation(float currentX, float currentY) 
        {
            transX += currentX;
            transY += currentY;
        }

        public void scale(float newScale) {
            SF += newScale;
        }

        public void Plot(PictureBox canvas)
        {

            side *= SF;
            float centerX = side / 2f;
            float centerY = side / 2f;
            canvas.Refresh();
            float h = (float)(Math.Sqrt(3) * side) / 2;
            float widthCanvas = canvas.Width / 2f;
            float heightCanvas = canvas.Height / 2f;
            float halfSide = side / 2f;

            PointF[] points = {
                new PointF(widthCanvas - halfSide, heightCanvas - halfSide),
                new PointF(widthCanvas + halfSide, heightCanvas - halfSide),
                new PointF(widthCanvas + halfSide, heightCanvas + halfSide),
                new PointF(widthCanvas - halfSide, heightCanvas + halfSide)
            };



            for (int i = 0; i < points.Length; i++)
            {
                points[i].X += transX;
                points[i].Y += transY;
            }

            for (int i = 0; i < points.Length; i++)
            {
                points[i].X = (float)(points[i].X * Math.Cos(currentDegrees) - points[i].Y * Math.Sin(currentDegrees));
                points[i].Y = (float)(points[i].X * Math.Sin(currentDegrees) + points[i].Y * Math.Cos(currentDegrees));

                points[i] = new PointF(points[i].X - widthCanvas, points[i].Y - heightCanvas);

            }

            mGraph = canvas.CreateGraphics();
            mPen = new Pen(Color.Red, 3);
            mGraph.DrawPolygon(mPen, points);
        }
    }

}
