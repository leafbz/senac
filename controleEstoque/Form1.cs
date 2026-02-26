using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static controleEstoque.frmEstoque;

namespace controleEstoque
{
    public partial class frmEstoque : Form
    {
        public class Produto
        {
            public string Nome { get; set; }
            public int Quantidade { get; set; }
        }
        List<Produto> listaProdutos = new List<Produto>();
        public frmEstoque()
        {
            InitializeComponent();

            dgvEstoque.DataSource = listaProdutos;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int qtd;

            if (txtProduto.Text == "" || !int.TryParse(txtQtd.Text, out qtd))
            {
                MessageBox.Show("Preencha os dados corretamente.");
                return;
            }

            Produto p = new Produto();
            p.Nome = txtProduto.Text;
            p.Quantidade = qtd;

            listaProdutos.Add(p);

            AtualizarTabela();
            VerificarEstoque(p);

            txtProduto.Clear();
            txtQtd.Clear();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            
        }
        private void VerificarEstoque(Produto p)
        {
            {
                if (p.Quantidade < 5)
                {
                    MessageBox.Show($"Alerta: Baixo estoque do produto {p.Nome}. Reabasteça!");
                }
            }
        }
        private void btnReabastecer_Click(object sender, EventArgs e)
        {
            if (dgvEstoque.CurrentRow == null) return;

            int index = dgvEstoque.SelectedRows[0].Index;

            listaProdutos[index].Quantidade += 10;

            MessageBox.Show("Produto reabastecido com sucesso!");

            AtualizarTabela();
        }
        private void AtualizarTabela()
        {
            dgvEstoque.DataSource = null;
            dgvEstoque.DataSource = listaProdutos;
        }
    }
}