using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            String name = txtNombre.Text;
            if (name == "")
            {
                MessageBox.Show($"Llena el nombre");
                return;
            }
             MessageBox.Show($"Hola {txtNombre.Text}");

        }

    }
}
