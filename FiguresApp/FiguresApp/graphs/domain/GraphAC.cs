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
        public virtual void ReadData(TextBox txtWidth, TextBox txtHeight) { }
        public virtual void ReadData(TextBox txtRatio) { }


        public virtual void InitData(TextBox txtWidth, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox pictureCanvas) { }
        public virtual void InitData(TextBox txtRatio, TextBox txtPerimeter, TextBox txtArea, PictureBox pictureCanvas) { }
        public virtual void InitData(TextBox txtMinorBase, TextBox txtMajorBase, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox pictureCanvas) { }


        public virtual void ReadData(TextBox txtMinorBase, TextBox txtMajorBase, TextBox txtHeight) { }


        //required methods
        public abstract void ComputePerimeter();
        public abstract void ComputeArea();
        public abstract void RenderData(TextBox txtPerimeter, TextBox txtArea);
        public abstract void RenderGraph(PictureBox pictureCanvas);
    }
}
