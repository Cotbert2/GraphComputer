using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphExamples.Config
{
    public sealed class Config
    {
        private static readonly Lazy<Config> _instance = new Lazy<Config>(() => new Config());

        public static Config Instance => _instance.Value;

        public Color Color { get; set; } = Color.Black;

        private Config() { }
    }
}
