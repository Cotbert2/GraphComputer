using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphExamples.Graphers
{
    public class BresenhamGrapherCircle
    {
        private List<Point> points = new List<Point>();
        public async void readData(TextBox txtRadio, PictureBox canvas)
        {
            if (!int.TryParse(txtRadio.Text, out int radius) || radius <= 0 || radius > 180)
            {
                MessageBox.Show("Insert a valid input");
                return;
            }

            if (canvas.Image == null)
            {
                canvas.Image = new Bitmap(canvas.Width, canvas.Height);
            }

            int centerX = canvas.Width / 2;
            int centerY = canvas.Height / 2;

            points = ComputeCirclePoints(centerX, centerY, radius);

            using (Graphics g = Graphics.FromImage(canvas.Image))
            {
                g.Clear(Color.White);
            }

            foreach (var point in points)
            {
                using (Graphics g = Graphics.FromImage(canvas.Image))
                {
                    g.FillRectangle(new SolidBrush(Config.Config.Instance.Color), point.X, point.Y, 1, 1);
                }

                canvas.Invalidate();
                await Task.Delay(20);
            }
        }

        public List<Point> ComputeCirclePoints(int centerX, int centerY, int radius)
        {
            List<Point> points = new List<Point>();
            int x = 0;
            int y = radius;
            int d = 3 - 2 * radius;
            while (x <= y)
            {
                points.Add(new Point(centerX + x, centerY + y));
                points.Add(new Point(centerX - x, centerY + y));
                points.Add(new Point(centerX + x, centerY - y));
                points.Add(new Point(centerX - x, centerY - y));
                points.Add(new Point(centerX + y, centerY + x));
                points.Add(new Point(centerX - y, centerY + x));
                points.Add(new Point(centerX + y, centerY - x));
                points.Add(new Point(centerX - y, centerY - x));
                if (d < 0)
                {
                    d += 4 * x + 6;
                }
                else
                {
                    d += 4 * (x - y) + 10;
                    y--;
                }
                x++;
            }
            return points;
        }

        public List<Point> GetPoints()
        {
            return points;
        }
    }
}
