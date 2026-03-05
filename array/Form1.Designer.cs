namespace array
{
    partial class frmVetor
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
            this.lblTop = new System.Windows.Forms.Label();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.lblBase = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Navy;
            this.pnlTop.Controls.Add(this.lblTop);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(560, 100);
            this.pnlTop.TabIndex = 0;
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Nirmala Text", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.ForeColor = System.Drawing.Color.White;
            this.lblTop.Location = new System.Drawing.Point(44, 30);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(477, 37);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "Para testar o array unidirecional - vetor\r\n";
            // 
            // pnlBase
            // 
            this.pnlBase.BackColor = System.Drawing.Color.Navy;
            this.pnlBase.Controls.Add(this.lblBase);
            this.pnlBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBase.Location = new System.Drawing.Point(0, 350);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(560, 100);
            this.pnlBase.TabIndex = 1;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("Nirmala Text", 20F);
            this.lblBase.ForeColor = System.Drawing.Color.White;
            this.lblBase.Location = new System.Drawing.Point(136, 30);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(286, 37);
            this.lblBase.TabIndex = 0;
            this.lblBase.Text = "Clique no botão acima";
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTest.Font = new System.Drawing.Font("Calisto MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Location = new System.Drawing.Point(156, 165);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(242, 118);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "OK";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTest_MouseClick);
            // 
            // frmVetor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.pnlBase);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmVetor";
            this.Text = "Vetor";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBase.ResumeLayout(false);
            this.pnlBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblBase;
    }
}

