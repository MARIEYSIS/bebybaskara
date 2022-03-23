using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BASKARA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            Equacao equacao = new Equacao();
            equacao.a = Convert.ToInt32(txtA.Text);
            equacao.b = Convert.ToInt32(txtB.Text);
            equacao.c = Convert.ToInt32(txtC.Text);


            txtresultado.Text = Convert.ToString(equacao.raiz());
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtA.Text = string.Empty;
            txtB.Text = string.Empty;
            txtC.Text = string.Empty;
            txtresultado.Text = string.Empty;


            txtA.Focus();
        }
    }
}
