using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> users = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string senha = txtSenha.Text;
            if (users.ContainsKey(user) && users[user]==senha)
            {
                MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Email ou Senha Inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string senha = txtSenha.Text;
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Campo Vazio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (users.ContainsKey(user))
            {
                MessageBox.Show("Nome de usuário inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                users.Add(user, senha);
                MessageBox.Show("Cadastro realizado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
        }
        private void ClearFields()
        {
            txtSenha.Clear();
            txtUser.Clear();
        }
    }
}
