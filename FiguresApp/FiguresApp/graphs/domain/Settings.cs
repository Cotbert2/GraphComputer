using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresApp.graphs.domain
{
    public class Settings
    {

        private static Settings instance = new Settings();
        public Color color { get; set; }

        public float ScaleFactor { get; set; }

        private Settings()
        {
            color = Color.Red;
            ScaleFactor = 20.0f;

        }

        public static Settings Instance
        {
            get
            {
                return instance;
            }
        }

    }
}
