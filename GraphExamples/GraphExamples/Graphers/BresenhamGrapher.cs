using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphExamples.Graphers
{
    public class BresenhamGrapher
    {
        private int x1, y1, x2, y2;
        private List<Point> points = new List<Point>();

        public void ReadData(TextBox x1TextBox, TextBox y1TextBox, TextBox x2TextBox, TextBox y2TextBox)
        {
            if (int.TryParse(x1TextBox.Text, out x1) &&
                int.TryParse(y1TextBox.Text, out y1) &&
                int.TryParse(x2TextBox.Text, out x2) &&
                int.TryParse(y2TextBox.Text, out y2))
            {
                ComputePoints();
            }
            else
            {
                MessageBox.Show("Please enter valid integer values for coordinates.");
            }
        }

        private void ComputePoints()
        {
            points.Clear();

            int dx = Math.Abs(x2 - x1);
            int dy = Math.Abs(y2 - y1);
            int sx = x1 < x2 ? 1 : -1;
            int sy = y1 < y2 ? 1 : -1;
            int err = dx - dy;

            int x = x1;
            int y = y1;

            while (true)
            {
                points.Add(new Point(x, y));

                if (x == x2 && y == y2)
                    break;

                int e2 = 2 * err;
                if (e2 > -dy)
                {
                    err -= dy;
                    x += sx;
                }
                if (e2 < dx)
                {
                    err += dx;
                    y += sy;
                }
            }
        }

        public async Task DrawAsync(PictureBox canvas)
        {
            Graphics g = canvas.CreateGraphics();
            g.Clear(Color.White);

            int centerX = canvas.Width / 2;
            int centerY = canvas.Height / 2;

            Pen axisPen = new Pen(Color.LightGray, 1);
            g.DrawLine(axisPen, 0, centerY, canvas.Width, centerY);
            g.DrawLine(axisPen, centerX, 0, centerX, canvas.Height);

            foreach (var p in points)
            {
                int screenX = centerX + p.X;
                int screenY = centerY - p.Y;

                g.FillRectangle(Brushes.Black, screenX, screenY, 1, 1);
                await Task.Delay(20);
            }

            g.Dispose();
        }

        public List<Point> GetPoints()
        {
            return points;
        }
    }
}
