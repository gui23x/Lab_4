using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_004.View
{
    public partial class Telaprincipal : Form
    {
        public Telaprincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (tbxNum.Text == "")
            {
                MessageBox.Show("Ensira um Número");
            }

            else {

                int numero = 0;
                int quadrado = 0;

                numero = Convert.ToInt32(tbxNum.Text);

                quadrado = numero * numero;

                lblResultado.Text = "O número " + numero + " ao quadrado é " + quadrado.ToString();
                tbxNum.Focus();
                tbxNum.SelectAll();
            }
        }

        private void Telaprincipal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if(e.KeyChar == 13)
            {
                btnCalcular.PerformClick();
            }
        }
    }
}
