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
    public partial class FrmRectangle : Form
    {
        private Rectangle myRectangle = new Rectangle();
        public FrmRectangle()
        {
            InitializeComponent();
        }

        private void FrmRectangleLoad(object sender, EventArgs e)
        {
            myRectangle.InitializeData(txtWidth, txtHeight, txtPaerimeter, txtArea, canvas);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            myRectangle.ReadData(txtWidth, txtHeight);
            myRectangle.PerimeterRectangle();
            myRectangle.AreaRectangle();
            myRectangle.PrintData(txtPaerimeter, txtArea);
            myRectangle.PlotShape(canvas);
        }

        private void btnClear(object sender, EventArgs e)
        {
            myRectangle.InitializeData(txtWidth, txtHeight, txtPaerimeter, txtArea, canvas);
        }

        private void BtnExitClick(object sender, EventArgs e)
        {
            myRectangle.CloseForm(this);
        }
    }
}
