using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcularIdade
{
    public partial class frmCalcIdade : Form
    {
        public frmCalcIdade()
        {
            InitializeComponent();
        }
        private void txtAnoAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                int nasc, hoje, idade;
                if (int.TryParse(txtAnoNasc.Text, out nasc) && int.TryParse(txtAnoAtual.Text, out hoje))
                {
                    idade = hoje - nasc;
                    lblIdade.Text = idade.ToString();
                }
                else
                {
                    MessageBox.Show("Digite números válidos");
                }
            }
        }
    }
}
