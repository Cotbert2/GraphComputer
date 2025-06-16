using GraphExamples.Graphers.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace GraphExamples.Graphers
{
    public class FillFloodGrapher
    {
        private int side;
        private Stack<(int x, int y)> stack;
        private PictureBox canvas;
        private CancellationToken cancellationToken;

        public void SetCancellationToken(CancellationToken token)
        {
            this.cancellationToken = token;
        }

        private List<Point> filledPoints = new List<Point>();
        public IReadOnlyList<Point> FilledPoints => filledPoints;

        public void ReadData(TextBox txtSides, PictureBox canvas, int size)
        {
            if (int.TryParse(txtSides.Text, out side) && side > 2)
            {
                this.canvas = canvas;
                stack = new Stack<(int x, int y)>();
                filledPoints.Clear();

                if (canvas.Image == null)
                {
                    Bitmap bmp = new Bitmap(canvas.Width, canvas.Height);
                    canvas.Image = bmp;

                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.Clear(Color.White);
                    }
                }
                using (Graphics g = Graphics.FromImage(canvas.Image))
                {
                    g.DrawPolygon(
                        new Pen(Config.Config.Instance.Color, 1f),
                        PolygonUtils.centerPolygon(
                            PolygonUtils.buildPolygon(side, size),
                            canvas
                        ).ToArray()
                    );
                }

                canvas.Invalidate();
            }
            else
            {
                MessageBox.Show("Please enter a valid integer value");
            }
        }

        public void Fill(int x, int y, Color currentColor)
        {
            if (cancellationToken.IsCancellationRequested) return;

            Bitmap bmp = canvas.Image as Bitmap;
            if (bmp == null || x < 0 || x >= bmp.Width || y < 0 || y >= bmp.Height) return;

            if (bmp.GetPixel(x, y).ToArgb() != Color.White.ToArgb()) return;

            bmp.SetPixel(x, y, currentColor);
            filledPoints.Add(new Point(x, y));

            canvas.Invoke((MethodInvoker)(() =>
            {
                canvas.Invalidate();
                canvas.Update();
            }));

            Fill(x, y + 1, currentColor);
            Fill(x + 1, y, currentColor);
            Fill(x, y - 1, currentColor);
            Fill(x - 1, y, currentColor);
        }

        public List<Point> getFilledPoints()
        {
            return filledPoints;
        }
    }
}
