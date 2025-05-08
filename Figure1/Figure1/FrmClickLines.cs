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
    public partial class FrmClickLines : Form
    {
        private Drawer mDrawer = new Drawer();
        public FrmClickLines()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clickEvent(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Click at " + e.X.ToString() + "," + e.Y.ToString());
            mDrawer.AddPoint(new PointF(e.X, e.Y));
            mDrawer.ShowGraph(canvas);
        }

        private void canvas_Click(object sender, EventArgs e)
        {

        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            mDrawer.Clear();















            mDrawer.ShowGraph(canvas);
        }
    }
}
