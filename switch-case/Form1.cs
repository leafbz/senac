using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_case
{
    public partial class frmSwitch : Form
    {
        public frmSwitch()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                var codigo = Convert.ToInt16(txtCodigo.Text);
                lblDesc.Text = GetTipoCombustivel(codigo);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
            }
            txtCodigo.Clear();
        }
        private string GetTipoCombustivel(int codigo) {
            var res = "";
            switch (codigo)
            {
                case 1:
                    res = "Gasolina";
                    break;
                case 2:
                    res = "Álcool";
                    break;
                case 3:
                    res = "Flex";
                    break;
                case 4:
                    res = "Gás GNV";
                    break;
                case 5:
                    res = "Diesel";
                    break;
                case 6:
                    res = "Elétrico";
                    break;
                default:
                    res = "Inválido";
                    break;
            }
            return res;
        }
    }
}
