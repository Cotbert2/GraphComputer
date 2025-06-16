using GraphExamples.Graphers;
using GraphExamples.Views.shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphExamples.Views
{
    public partial class FrmFill : BaseFrm
    {
        private FillFloodGrapher grapher = new FillFloodGrapher();
        private Color currentColor = Color.Black;
        private CancellationTokenSource cts = new CancellationTokenSource();
        private Thread fillThread;

        public FrmFill() : base("Fill Polygon Drawer")
        {
            InitializeComponent();
            btnPlot.Click += btnPlot_Click;
            canvas.MouseClick += canvas_MouseClick;
            btnReload.Click += btn_Reload_Click;
        }

        public void btnPlot_Click(object sender, EventArgs e)
        {
            grapher.ReadData(txtSides, canvas, tbSize.Value);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            cts.Cancel();

            if (fillThread != null && fillThread.IsAlive)
            {
                fillThread.Join();
            }

            base.OnFormClosing(e);
        }

        public void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            cts = new CancellationTokenSource();
            grapher.SetCancellationToken(cts.Token);

            Thread thread = new Thread(() =>
            {
                grapher.Fill(e.X, e.Y, currentColor);

                canvas.Invoke((MethodInvoker)(() =>
                {
                    foreach (var pt in grapher.FilledPoints)
                    {
                        lbPoints.Items.Add($"({pt.X}, {pt.Y})");
                    }
                    txtPoints.Text = grapher.FilledPoints.Count.ToString();


                }));
            }, 1024 * 1024 * 32);

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }


        private void FrmFill_Load(object sender, EventArgs e)
        {

        }

        private void btnChooseBrush_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    currentColor = colorDialog.Color;
                    btnChooseBrush.BackColor = currentColor;
                }
            }
        }
        private void btn_Reload_Click(object sender, EventArgs e)
        {
            canvas.Image = null;
            canvas.Refresh();
            tbSize.Value = 31;
            txtSides.Text = "";
            lbPoints.Items.Clear();
            grapher = new FillFloodGrapher();

        }
    }
}
