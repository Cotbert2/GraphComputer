using GraphExamples.Graphers;
using GraphExamples.Structures;
using GraphExamples.Views.shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace GraphExamples.Views
{
    public partial class FrmDDA : BaseFrm
    {

        private CircularBuffer2<Point> points = new CircularBuffer2<Point>();
        private DDAGrapher ddaGrapher = new DDAGrapher();

        public FrmDDA() : base("DDA Line Drawer")
        {
            InitializeComponent();
            canvas.Paint += canvas_Paint;
            canvas.MouseClick += canvas_MouseClick;

            btnPlot.Click += btnPlot_Click;
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            int centerX = canvas.Width/2;
            int centerY = canvas.Height/2;

            int cartesianX = e.X - centerX;
            int cartesianY = -(e.Y - centerY);

            points.Add(new Point(cartesianX, cartesianY));
            updatePointFields();
        }

        private void updatePointFields()
        {
            if (points[0] != null)
            {
                txtX1.Text = points[0].X.ToString();
                txtY1.Text = points[0].Y.ToString();
            }

            if (points[1] != null)
            {
                txtX2.Text = points[1].X.ToString();
                txtY2.Text = points[1].Y.ToString();
            }
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            ddaGrapher.ReadData(txtX1, txtY1, txtX2, txtY2);
            ddaGrapher.DrawAsync(canvas);

            listPoints.Items.Clear();
            listPoints.Items.Add("N  X        Y");
            int index = 0;
            foreach (var punto in ddaGrapher.GetPoints())
            {
                listPoints.Items.Add($"{index++}  ({punto.X}, {punto.Y})");
            }

            txtNum.Text = listPoints.Items.Count.ToString();

        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int centerX = canvas.Width / 2;
            int centerY = canvas.Height / 2;

            Pen axisPen = new Pen(Color.Gray, 1);
            g.DrawLine(axisPen, 0, centerY, canvas.Width, centerY); 
            g.DrawLine(axisPen, centerX, 0, centerX, canvas.Height); 
        }

        private void FrmADD_Load(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            canvas.Refresh();
            points = new CircularBuffer2<Point>();
            updatePointFields();
            txtNum.Text = "";
            listPoints.Items.Clear();
        }

        private void canvas_Click(object sender, EventArgs e)
        {

        }
    }
}
