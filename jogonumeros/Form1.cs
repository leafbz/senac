using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogonumeros
{
    public partial class frmJogoNumero : Form
    {
        int rndNum;
        int nt = 10;
        int palpite;
        bool ganhou = false;
        string dica;
        public frmJogoNumero()
        {
            InitializeComponent();
        }

        private void frmJogoNumero_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            rndNum = rnd.Next(1,101);
        }

        private void btnTentativa_Click(object sender, EventArgs e)
        {
            if (ganhou)
            {
                txtResultado.Text = "Você acertou o número! Reinicie para jogar novamente.";
                return;
            }
            if (nt == 0)
            {
                txtResultado.Text = "O jogo acabou";
                return;
            }
            if (!int.TryParse(txtNum.Text, out palpite) || palpite < 1 || palpite > 100) 
            {
                txtResultado.Text = "Insira um número válido";
                return;
            }

            nt--;
            lblNT.Text = nt.ToString();

            if (palpite == rndNum)
            {
                ganhou = true;
                dica = "Parabéns, você acertou!";
            }
            else if (palpite < rndNum)
            {
                dica = "O número que você digitou é menor, digite um número maior";
            }
            else
            {
                dica = "O número que você digitou é maior, digite um número menor";
            }
            txtResultado.Text = dica;
        }
    }
}
