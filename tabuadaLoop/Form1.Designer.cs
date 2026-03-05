namespace tabuadaLoop
{
    partial class frmTabuada
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
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.pnlL = new System.Windows.Forms.Panel();
            this.pnlR = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnExecutaTabuada = new System.Windows.Forms.Button();
            this.lstTabuada = new System.Windows.Forms.ListBox();
            this.pnlFundo.SuspendLayout();
            this.pnlL.SuspendLayout();
            this.pnlR.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.BackColor = System.Drawing.Color.Cyan;
            this.pnlFundo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFundo.Controls.Add(this.pnlR);
            this.pnlFundo.Controls.Add(this.pnlL);
            this.pnlFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFundo.Location = new System.Drawing.Point(0, 0);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(800, 450);
            this.pnlFundo.TabIndex = 0;
            // 
            // pnlL
            // 
            this.pnlL.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlL.Controls.Add(this.lstTabuada);
            this.pnlL.Location = new System.Drawing.Point(73, 53);
            this.pnlL.Name = "pnlL";
            this.pnlL.Size = new System.Drawing.Size(284, 338);
            this.pnlL.TabIndex = 0;
            // 
            // pnlR
            // 
            this.pnlR.BackColor = System.Drawing.Color.PeachPuff;
            this.pnlR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlR.Controls.Add(this.btnExecutaTabuada);
            this.pnlR.Controls.Add(this.txtNum);
            this.pnlR.Controls.Add(this.lblTitulo);
            this.pnlR.Location = new System.Drawing.Point(446, 53);
            this.pnlR.Name = "pnlR";
            this.pnlR.Size = new System.Drawing.Size(284, 338);
            this.pnlR.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(20, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(240, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Insira um número";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(93, 52);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 62);
            this.txtNum.TabIndex = 1;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExecutaTabuada
            // 
            this.btnExecutaTabuada.AutoSize = true;
            this.btnExecutaTabuada.BackColor = System.Drawing.Color.Cyan;
            this.btnExecutaTabuada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecutaTabuada.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutaTabuada.ForeColor = System.Drawing.Color.Black;
            this.btnExecutaTabuada.Location = new System.Drawing.Point(26, 120);
            this.btnExecutaTabuada.Name = "btnExecutaTabuada";
            this.btnExecutaTabuada.Size = new System.Drawing.Size(234, 46);
            this.btnExecutaTabuada.TabIndex = 2;
            this.btnExecutaTabuada.Text = "Gerar Tabuada";
            this.btnExecutaTabuada.UseVisualStyleBackColor = false;
            this.btnExecutaTabuada.Click += new System.EventHandler(this.btnExecutaTabuada_Click);
            // 
            // lstTabuada
            // 
            this.lstTabuada.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTabuada.FormattingEnabled = true;
            this.lstTabuada.ItemHeight = 25;
            this.lstTabuada.Location = new System.Drawing.Point(21, 17);
            this.lstTabuada.Name = "lstTabuada";
            this.lstTabuada.Size = new System.Drawing.Size(238, 304);
            this.lstTabuada.TabIndex = 0;
            // 
            // frmTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlFundo);
            this.Name = "frmTabuada";
            this.Text = "Tabuada";
            this.pnlFundo.ResumeLayout(false);
            this.pnlL.ResumeLayout(false);
            this.pnlR.ResumeLayout(false);
            this.pnlR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFundo;
        private System.Windows.Forms.Panel pnlL;
        private System.Windows.Forms.Panel pnlR;
        private System.Windows.Forms.Button btnExecutaTabuada;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListBox lstTabuada;
    }
}

