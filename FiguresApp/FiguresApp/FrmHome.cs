using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FiguresApp
{
    public partial class FrmHome : Form
    {
    private PrivateFontCollection privateFonts = new PrivateFontCollection();
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }


        private void btnTriangle(object sender, EventArgs e)
        {
            FrmTriangle triangle = new FrmTriangle();
            triangle.Show();
            this.Hide();

        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            FrmSquare square = new FrmSquare();
            square.Show();
            this.Hide();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            FrmRectangle rectangle = new FrmRectangle();
            rectangle.Show();
            this.Hide();
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            FrmCircle circle = new FrmCircle();
            circle.Show();
            this.Hide();
        }

        private void btnElipse_Click(object sender, EventArgs e)
        {
            FrmElipse elipse = new FrmElipse();
            elipse.Show();
            this.Hide();
        }

        private void btnSemicircle_Click(object sender, EventArgs e)
        {
            FrmSemicircle semicircle = new FrmSemicircle();
            semicircle.Show();
            this.Hide();
        }

        private void btnTrapaze_Click(object sender, EventArgs e)
        {
            FrmTrapeze trapeze = new FrmTrapeze();
            trapeze.Show();
            this.Hide();
        }

        private void btnTrapezoid_Click(object sender, EventArgs e)
        {
            FrmTrapezoid trapezoid = new FrmTrapezoid();
            trapezoid.Show();
            this.Hide();
        }

        private void btnDiamod_Click(object sender, EventArgs e)
        {
            FrmDiamond diamond = new FrmDiamond();
            diamond.Show();
            this.Hide();
        }

        private void btnRohboid_Click(object sender, EventArgs e)
        {
            FrmRohboid rohboid = new FrmRohboid();
            rohboid.Show();
            this.Hide();
        }

        private void btnDeltoid_Click(object sender, EventArgs e)
        {
            FrmDeltoid deltoid = new FrmDeltoid();
            deltoid.Show();
            this.Hide();
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            FrmStar star = new FrmStar();
            star.Show();
            this.Hide();
        }

        private void ExitProgram(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
