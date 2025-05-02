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
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private bool isValid()
        {
            return !(txtNumber1.Text == "" || txtNumber2.Text == "") ;
                
        }

        private bool isNumber()
        {
            return (int.TryParse(txtNumber1.Text, out _) && int.TryParse(txtNumber2.Text, out _));
        }

        private void btnAdd_click(object sender, EventArgs e)
        {
            if (!isValid() || !isNumber())
            {
                MessageBox.Show("Campos invalidos");
                return;
            }
            int num1 = Convert.ToInt32(txtNumber1.Text);
            int num2 = Convert.ToInt32(txtNumber2.Text);

            lblResult.Text = (num1 + num2).ToString();

        }

        private void btnSustract_click(object sender, EventArgs e)
        {
            if (!isValid() || !isNumber())
            {
                MessageBox.Show("Campos invalidos");
                return;
            }
            int num1 = Convert.ToInt32(txtNumber1.Text);
            int num2 = Convert.ToInt32(txtNumber2.Text);
            lblResult.Text = (num1 - num2).ToString();

        }

        private void btnDivide_click(object sender, EventArgs e)
        {
            if (!isValid() || !isNumber())
            {
                MessageBox.Show("Campos invalidos");
                return;
            }
            int num1 = Convert.ToInt32(txtNumber1.Text);
            int num2 = Convert.ToInt32(txtNumber2.Text);
            if (num2 == 0)
            {
                MessageBox.Show("No se puede dividir entre 0");
                return;
            }
            lblResult.Text = (num1 / num2).ToString();
        }

        private void btnMulti_click(object sender, EventArgs e)
        {
            if (!isValid() || !isNumber())
            {
                MessageBox.Show("Campos invalidos");
                return;
            }
            int num1 = Convert.ToInt32(txtNumber1.Text);
            int num2 = Convert.ToInt32(txtNumber2.Text);
            lblResult.Text = (num1 * num2).ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
