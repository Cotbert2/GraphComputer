using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiguresApp.graphs.domain
{
    public abstract class GraphAC
    {
        public abstract void ReadData(TextBox txtWidth, TextBox txtHeight);
        public abstract void ComputePerimeter();
        public abstract void ComputeArea();
        public abstract void RenderData(TextBox txtPerimeter, TextBox txtArea);
        public abstract void InitData(TextBox txtWidth, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea,
            PictureBox pictureCanvas);
        public abstract void RenderGraph(PictureBox pictureCanvas);
    }
}
