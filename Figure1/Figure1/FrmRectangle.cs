using Figure1.Properties;
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

        public static FrmRectangle instance = new FrmRectangle();


        public static FrmRectangle Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new FrmRectangle();
                }
                return instance;
            }
        }

        //close form
        public void CloseForm(Form form)
        {
            form.Close();
        }







        private Rectangle myRectangle = new Rectangle();
        public FrmRectangle()
        {
            InitializeComponent();
            //this.IsMdiContainer = true;
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
