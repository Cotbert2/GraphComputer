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
    public partial class FrmSquare : Form
    {

        private Square mySquare= new Square();

        public FrmSquare()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            mySquare.ReadData(txtSide);
            mySquare.PerimeterSquare();
            mySquare.AreaSquare();
            mySquare.PrintData(txtPerimeter, txtArea);

            mySquare.PlotShape(canvas);
        }

        private void frmLoad(object sender, EventArgs e)
        {
            mySquare.InitializeData(txtSide, txtPerimeter, txtArea, canvas);

        }

        private void btnExitClick(object sender, EventArgs e)
        {
            mySquare.CloseForm(this);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            mySquare.InitializeData(txtSide, txtPerimeter, txtArea, canvas);
        }
    }
}
