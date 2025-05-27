using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figure1
{
    public partial class FrmHexagono : Form
    {

        private Hexagon hexagon = new Hexagon();
        public FrmHexagono()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            hexagon.ReadData(txtSide);
            hexagon.Plot(canvas);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            hexagon.InitializeData(txtSide, canvas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //hexagon.InitializeData(txtSide, canvas);
            hexagon.changeDegrees(5);
            hexagon.ReadData(txtSide);
            hexagon.Plot(canvas);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //hexagon.InitializeData(txtSide, canvas);
            hexagon.changeDegrees(-5);
            hexagon.ReadData(txtSide);
            hexagon.Plot(canvas);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hexagon.scale(5);
            hexagon.ReadData(txtSide);
            hexagon.Plot(canvas);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            hexagon.scale(-5);
            hexagon.ReadData(txtSide);
            hexagon.Plot(canvas);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hexagon.translation(0, -5);
            hexagon.ReadData(txtSide);
            hexagon.Plot(canvas);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hexagon.translation(0, 5);
            hexagon.ReadData(txtSide);
            hexagon.Plot(canvas);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hexagon.translation(5, 0);
            hexagon.ReadData(txtSide);
            hexagon.Plot(canvas);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            hexagon.translation(-5, 0);
            hexagon.ReadData(txtSide);
            hexagon.Plot(canvas);
        }
    }
}
