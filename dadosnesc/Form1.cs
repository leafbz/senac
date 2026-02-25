using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dadosnesc
{
    public partial class FrmSimples : Form
    {
        public FrmSimples()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string numCadastro;
            string nomeUsuario;
            DateTime dataNasc;
            string cidade;
            bool generoF;
            bool generoM;
            bool generoNB;

            //Validar Campos
            if (string.IsNullOrWhiteSpace(txtNum.Text))
            {
                MessageBox.Show("Preencha o número cadastrado.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Preencha seu nome completo.");
                return;
            }
            if (comboBoxCidade.SelectedItem == null)
            {
                MessageBox.Show("Selecione a cidade.");
                return;
            }
            if (!rbFem.Checked && !rbMasc.Checked && !rbNb.Checked)
            {
                MessageBox.Show("Selecione o gênero.");
                return;
            }

            numCadastro = txtNum.Text;
            nomeUsuario = txtNome.Text;
            dataNasc = dateTimePicker1.Value;
            cidade = comboBoxCidade.Text;
            generoF = rbFem.Checked;
            generoM = rbMasc.Checked;
            generoNB = rbNb.Checked;

            string data = dataNasc.ToString("dd/MM/yyyy");

            string genero = "Não informado";
            if (generoF)
            {
                genero = "Feminino";
            }
            else if (generoM)
            {
                genero = "Masculino";
            }
            else
            {
                genero = "Não Binário";
            }

            MessageBox.Show($"USUÁRIO CADASTRADO!\n Número: {numCadastro}\n Nome: {nomeUsuario}\n Nascimento: {data}\n Cidade: {cidade}\n Gênero: {genero}");
        }

        private void txtNum_Enter(object sender, EventArgs e)
        {
            if (txtNum.Text == "Número Cadastrado")
            {
                txtNum.Clear();
            }
            
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "Insira seu nome")
            {
                txtNome.Clear();
            }
        }

        private void txtNum_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNum.Text))
                txtNum.Text = "Número Cadastrado";
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
                txtNome.Text = "Insira seu nome";
        }
    }
}
