using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiguresApp.graphs
{
    public class SquareGraph : RectangleGraph
    {
        public SquareGraph()
        {
        }

        public override void ReadData(TextBox txtSide)
        {
            base.ReadData(txtSide, txtSide);
        }



        public override void InitData(TextBox txtSide, TextBox txtPerimeter, TextBox txtArea,
    PictureBox pictureCanvas)
        {
            base.InitData(txtSide, txtSide, txtPerimeter, txtArea, pictureCanvas);
        }


    }


}
