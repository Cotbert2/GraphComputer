using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figure1
{
    public class Drawer
    {
        //list of Pointf
        private List<PointF> points;
        private Graphics mGraph;
        private Pen mPen;

        public Drawer()
        {
            points = new List<PointF>();
            points.Add(new PointF(0, 0));
        }


        public void AddPoint(PointF point)
        {
            points.Add(point);
        }

        public void DrawPoint(PointF point)
        {
            if (mGraph != null)
            {
                mPen = new Pen(Color.Red, 2);
                mGraph.DrawEllipse(mPen, point.X - 2, point.Y - 2, 5, 5);
                mPen = new Pen(Color.Green, 2);
            }
        }


        public void ShowGraph(PictureBox pictureBox)
        {
            if (mGraph != null)
            {
                mGraph.Dispose();
            }
            mGraph = pictureBox.CreateGraphics();
            mPen = new Pen(Color.Green, 2);
            mGraph.Clear(Color.White);
            for (int i = 0; i < points.Count - 1; i++)
            {
                DrawPoint(points[i]);
                mGraph.DrawLine(mPen, points[i], points[i + 1]);
            }

        }

        public void Clear()
        {
            points.Clear();
            points.Add(new PointF(0, 0));

        }

    }
}
