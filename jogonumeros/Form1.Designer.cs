namespace jogonumeros
{
    partial class frmJogoNumero
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnTentativa = new System.Windows.Forms.Button();
            this.lblBb = new System.Windows.Forms.Label();
            this.lblNT = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Red;
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(800, 100);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(243, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(363, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Boas vindas ao jogo de números";
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.Red;
            this.lblSubTitulo.Location = new System.Drawing.Point(291, 124);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(266, 22);
            this.lblSubTitulo.TabIndex = 1;
            this.lblSubTitulo.Text = "Insira um número de 1 a 100";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.ForeColor = System.Drawing.Color.Red;
            this.txtNum.Location = new System.Drawing.Point(374, 149);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 32);
            this.txtNum.TabIndex = 2;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(249, 295);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(357, 20);
            this.txtResultado.TabIndex = 3;
            // 
            // btnTentativa
            // 
            this.btnTentativa.BackColor = System.Drawing.Color.Red;
            this.btnTentativa.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTentativa.ForeColor = System.Drawing.Color.White;
            this.btnTentativa.Location = new System.Drawing.Point(374, 187);
            this.btnTentativa.Name = "btnTentativa";
            this.btnTentativa.Size = new System.Drawing.Size(100, 48);
            this.btnTentativa.TabIndex = 4;
            this.btnTentativa.Text = "Tentar";
            this.btnTentativa.UseVisualStyleBackColor = false;
            this.btnTentativa.Click += new System.EventHandler(this.btnTentativa_Click);
            // 
            // lblBb
            // 
            this.lblBb.AutoSize = true;
            this.lblBb.Font = new System.Drawing.Font("Dubai", 18F);
            this.lblBb.Location = new System.Drawing.Point(251, 238);
            this.lblBb.Name = "lblBb";
            this.lblBb.Size = new System.Drawing.Size(223, 40);
            this.lblBb.TabIndex = 5;
            this.lblBb.Text = "Tentativas restantes:";
            // 
            // lblNT
            // 
            this.lblNT.AutoSize = true;
            this.lblNT.Font = new System.Drawing.Font("Dubai", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNT.ForeColor = System.Drawing.Color.Red;
            this.lblNT.Location = new System.Drawing.Point(480, 238);
            this.lblNT.Name = "lblNT";
            this.lblNT.Size = new System.Drawing.Size(57, 54);
            this.lblNT.TabIndex = 6;
            this.lblNT.Text = "10";
            // 
            // frmJogoNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNT);
            this.Controls.Add(this.lblBb);
            this.Controls.Add(this.btnTentativa);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmJogoNumero";
            this.Text = "Jogo Números";
            this.Load += new System.EventHandler(this.frmJogoNumero_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnTentativa;
        private System.Windows.Forms.Label lblBb;
        private System.Windows.Forms.Label lblNT;
    }
}

