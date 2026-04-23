namespace curd
{
    partial class frmCadastroClientes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbForm = new System.Windows.Forms.TabControl();
            this.tbCadastro = new System.Windows.Forms.TabPage();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNomeSocial = new System.Windows.Forms.TextBox();
            this.lblNomeSocial = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbConsulta = new System.Windows.Forms.TabPage();
            this.lstCliente = new System.Windows.Forms.ListView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovoCadastro = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.tbForm.SuspendLayout();
            this.tbCadastro.SuspendLayout();
            this.tbConsulta.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(30, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(238, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro de Clientes";
            // 
            // tbForm
            // 
            this.tbForm.ContextMenuStrip = this.contextMenuStrip1;
            this.tbForm.Controls.Add(this.tbCadastro);
            this.tbForm.Controls.Add(this.tbConsulta);
            this.tbForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbForm.Location = new System.Drawing.Point(12, 106);
            this.tbForm.Name = "tbForm";
            this.tbForm.SelectedIndex = 0;
            this.tbForm.Size = new System.Drawing.Size(776, 286);
            this.tbForm.TabIndex = 1;
            // 
            // tbCadastro
            // 
            this.tbCadastro.Controls.Add(this.txtCpf);
            this.tbCadastro.Controls.Add(this.lblCpf);
            this.tbCadastro.Controls.Add(this.txtEmail);
            this.tbCadastro.Controls.Add(this.lblEmail);
            this.tbCadastro.Controls.Add(this.txtNomeSocial);
            this.tbCadastro.Controls.Add(this.lblNomeSocial);
            this.tbCadastro.Controls.Add(this.txtNome);
            this.tbCadastro.Controls.Add(this.lblNome);
            this.tbCadastro.Location = new System.Drawing.Point(4, 29);
            this.tbCadastro.Name = "tbCadastro";
            this.tbCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tbCadastro.Size = new System.Drawing.Size(768, 253);
            this.tbCadastro.TabIndex = 0;
            this.tbCadastro.Text = "Cadastro Cliente";
            this.tbCadastro.UseVisualStyleBackColor = true;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(144, 211);
            this.txtCpf.Mask = "###,###,###,-##";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(205, 26);
            this.txtCpf.TabIndex = 7;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCpf.Location = new System.Drawing.Point(36, 214);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(44, 20);
            this.lblCpf.TabIndex = 6;
            this.lblCpf.Text = "CPF:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(144, 157);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(292, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEmail.Location = new System.Drawing.Point(36, 160);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail:";
            // 
            // txtNomeSocial
            // 
            this.txtNomeSocial.Location = new System.Drawing.Point(144, 103);
            this.txtNomeSocial.Name = "txtNomeSocial";
            this.txtNomeSocial.Size = new System.Drawing.Size(292, 26);
            this.txtNomeSocial.TabIndex = 3;
            // 
            // lblNomeSocial
            // 
            this.lblNomeSocial.AutoSize = true;
            this.lblNomeSocial.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNomeSocial.Location = new System.Drawing.Point(36, 106);
            this.lblNomeSocial.Name = "lblNomeSocial";
            this.lblNomeSocial.Size = new System.Drawing.Size(102, 20);
            this.lblNomeSocial.TabIndex = 2;
            this.lblNomeSocial.Text = "Nome Social:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(144, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(390, 26);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNome.Location = new System.Drawing.Point(36, 52);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(55, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // tbConsulta
            // 
            this.tbConsulta.Controls.Add(this.lstCliente);
            this.tbConsulta.Controls.Add(this.btnPesquisar);
            this.tbConsulta.Controls.Add(this.txtBuscar);
            this.tbConsulta.Location = new System.Drawing.Point(4, 29);
            this.tbConsulta.Name = "tbConsulta";
            this.tbConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tbConsulta.Size = new System.Drawing.Size(768, 253);
            this.tbConsulta.TabIndex = 1;
            this.tbConsulta.Text = "Consulta";
            this.tbConsulta.UseVisualStyleBackColor = true;
            // 
            // lstCliente
            // 
            this.lstCliente.HideSelection = false;
            this.lstCliente.Location = new System.Drawing.Point(6, 38);
            this.lstCliente.MultiSelect = false;
            this.lstCliente.Name = "lstCliente";
            this.lstCliente.Size = new System.Drawing.Size(756, 209);
            this.lstCliente.TabIndex = 2;
            this.lstCliente.UseCompatibleStateImageBehavior = false;
            this.lstCliente.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstCliente_ItemSelectionChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.AutoSize = true;
            this.btnPesquisar.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(213, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(89, 30);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(6, 6);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(201, 26);
            this.txtBuscar.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(56, 397);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(103, 41);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovoCadastro
            // 
            this.btnNovoCadastro.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNovoCadastro.ForeColor = System.Drawing.Color.White;
            this.btnNovoCadastro.Location = new System.Drawing.Point(165, 397);
            this.btnNovoCadastro.Name = "btnNovoCadastro";
            this.btnNovoCadastro.Size = new System.Drawing.Size(103, 41);
            this.btnNovoCadastro.TabIndex = 4;
            this.btnNovoCadastro.Text = "Novo Cadastro";
            this.btnNovoCadastro.UseVisualStyleBackColor = false;
            this.btnNovoCadastro.Click += new System.EventHandler(this.btnNovoCadastro_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(685, 397);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(103, 41);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Visible = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 26);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click_1);
            // 
            // frmCadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovoCadastro);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.tbForm);
            this.Controls.Add(this.panel1);
            this.Name = "frmCadastroClientes";
            this.Text = "Cadastro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbForm.ResumeLayout(false);
            this.tbCadastro.ResumeLayout(false);
            this.tbCadastro.PerformLayout();
            this.tbConsulta.ResumeLayout(false);
            this.tbConsulta.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tbForm;
        private System.Windows.Forms.TabPage tbCadastro;
        private System.Windows.Forms.TabPage tbConsulta;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNomeSocial;
        private System.Windows.Forms.Label lblNomeSocial;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ListView lstCliente;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnNovoCadastro;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
    }
}

