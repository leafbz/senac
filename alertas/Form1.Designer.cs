namespace alertas
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlerta = new System.Windows.Forms.Button();
            this.btnAlertaRobusto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(322, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alertas";
            // 
            // btnAlerta
            // 
            this.btnAlerta.BackColor = System.Drawing.Color.Sienna;
            this.btnAlerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlerta.ForeColor = System.Drawing.Color.White;
            this.btnAlerta.Location = new System.Drawing.Point(164, 167);
            this.btnAlerta.Name = "btnAlerta";
            this.btnAlerta.Size = new System.Drawing.Size(112, 49);
            this.btnAlerta.TabIndex = 1;
            this.btnAlerta.Text = "Alerta";
            this.btnAlerta.UseVisualStyleBackColor = false;
            this.btnAlerta.Click += new System.EventHandler(this.btnAlerta_Click);
            // 
            // btnAlertaRobusto
            // 
            this.btnAlertaRobusto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAlertaRobusto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlertaRobusto.Location = new System.Drawing.Point(164, 250);
            this.btnAlertaRobusto.Name = "btnAlertaRobusto";
            this.btnAlertaRobusto.Size = new System.Drawing.Size(112, 49);
            this.btnAlertaRobusto.TabIndex = 2;
            this.btnAlertaRobusto.Text = "Alerta";
            this.btnAlertaRobusto.UseVisualStyleBackColor = false;
            this.btnAlertaRobusto.Click += new System.EventHandler(this.btnAlertaRobusto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlertaRobusto);
            this.Controls.Add(this.btnAlerta);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "Form1";
            this.Text = "Alertas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAlerta;
        private System.Windows.Forms.Button btnAlertaRobusto;
    }
}

