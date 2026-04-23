using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pkix;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace curd
{
    public partial class frmCadastroClientes : Form
    {

        MySqlConnection conn;
        string data_source = "datasource=localhost; username=root; password=; database=db_cadastro";

        private int? codigo_cliente = null;

        public frmCadastroClientes()
        {
            InitializeComponent();
            lstCliente.View = View.Details;
            lstCliente.LabelEdit = true;
            lstCliente.AllowColumnReorder = true;
            lstCliente.FullRowSelect = true;
            lstCliente.GridLines = true;

            lstCliente.Columns.Add("Codigo", 100, HorizontalAlignment.Left);
            lstCliente.Columns.Add("Nome Completo", 180, HorizontalAlignment.Left);
            lstCliente.Columns.Add("Nome Social", 130, HorizontalAlignment.Left);
            lstCliente.Columns.Add("E-mail", 200, HorizontalAlignment.Left);
            lstCliente.Columns.Add("CPF", 100, HorizontalAlignment.Left);

            carregar_clientes();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNome.Text.Trim()) || string.IsNullOrEmpty(txtEmail.Text.Trim()) || string.IsNullOrEmpty(txtCpf.Text.Trim())) 
                {
                    MessageBox.Show("Preencha os campos", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string cpf = txtCpf.Text.Trim();

                if (!isValidCPFLength(cpf))
                {
                    MessageBox.Show("CPF Inválido, Certifique-se de que tenha 11 dígitos númericos.", "Validação CPF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                conn = new MySqlConnection(data_source);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand { Connection = conn };
                cmd.Prepare();
                if (codigo_cliente == null)
                {
                    cmd.CommandText = "INSERT INTO clientes(nome, nomesocial, email, cpf)" + "VALUES(@nomecompleto, @nomesocial, @email, @cpf)";
                    cmd.Parameters.AddWithValue("@nomecompleto", txtNome.Text.Trim());
                    cmd.Parameters.AddWithValue("@nomesocial", txtNomeSocial.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@cpf", txtCpf.Text.Trim());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Contato inserido com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    cmd.CommandText = $"UPDATE `clientes` SET nome = @nome, nomesocial = @nomesocial, email = @email, cpf = @cpf WHERE id = @id";
                    cmd.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
                    cmd.Parameters.AddWithValue("@nomesocial", txtNomeSocial.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Parameters.AddWithValue("@id", codigo_cliente);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show($"Os dados com o código {codigo_cliente} foram alrerado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                limpar_form();
                carregar_clientes();
                tbForm.SelectedIndex = 1;
            }
            catch (MySqlException ex) 
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private bool isValidCPFLength(string cpf)
        {
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            return cpf.Length == 11;
        }

        private void carregar_clientes()
        {
            string q = "SELECT * FROM clientes ORDER BY id ASC";
            carregar_cliente_query(q);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string q = "SELECT * FROM clientes WHERE nome LIKE @q OR nomesocial LIKE @q ORDER BY id ASC";
            carregar_cliente_query(q);
        }

        private void carregar_cliente_query(string q)
        {
            try
            {
                conn = new MySqlConnection(data_source);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(q, conn);
                if (q.Contains("@q"))
                {
                    cmd.Parameters.AddWithValue("@q", "%" + txtBuscar.Text + "%");
                }

                MySqlDataReader reader = cmd.ExecuteReader();
                lstCliente.Items.Clear();
                while (reader.Read()) 
                {
                    string[] row = {Convert.ToString(reader.GetInt32(0)), reader.GetString(1),
                        reader.GetString(2),reader.GetString(3), reader.GetString(4)};
                    lstCliente.Items.Add(new ListViewItem(row));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void lstCliente_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection clienteselect = lstCliente.SelectedItems;

            foreach (ListViewItem item in clienteselect) 
            {
                codigo_cliente = Convert.ToInt32(item.SubItems[0].Text);
                MessageBox.Show("Código do Cliente: " + codigo_cliente.ToString(), "Código Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = item.SubItems[1].Text;
                txtNomeSocial.Text = item.SubItems[2].Text;
                txtEmail.Text = item.SubItems[3].Text;
                txtCpf.Text = item.SubItems[4].Text;

                btnExcluir.Visible = true;
            }
        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            limpar_form();
        }
        private void excluirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            excluir_cliente();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluir_cliente();
        }

        private void excluir_cliente()
        {
            try
            {
                DialogResult opcaoDigitada = MessageBox.Show("Tem certeza que desaja excluir o registro de código" + codigo_cliente, "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (opcaoDigitada == DialogResult.Yes)
                {
                    conn = new MySqlConnection(data_source);
                    conn.Open();
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.Connection = conn;
                    cmd.Prepare();
                    cmd.CommandText = "DELETE FROM clientes WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", codigo_cliente);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Os dados do cliente foram EXCLUÍDOS!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpar_form();
                    carregar_clientes();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void limpar_form()
        {
            codigo_cliente = null;
            txtNome.Clear();
            txtNomeSocial.Clear();
            txtEmail.Clear();
            txtCpf.Clear();
            txtNome.Focus();
        }
    }
}
