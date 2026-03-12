namespace picturebox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbComputador = new System.Windows.Forms.PictureBox();
            this.pbCidade = new System.Windows.Forms.PictureBox();
            this.btnVerImg = new System.Windows.Forms.Button();
            this.pbAnexarImg = new System.Windows.Forms.PictureBox();
            this.btnAnexar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnexarImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pbComputador
            // 
            this.pbComputador.Image = ((System.Drawing.Image)(resources.GetObject("pbComputador.Image")));
            this.pbComputador.Location = new System.Drawing.Point(12, 12);
            this.pbComputador.Name = "pbComputador";
            this.pbComputador.Size = new System.Drawing.Size(181, 97);
            this.pbComputador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbComputador.TabIndex = 0;
            this.pbComputador.TabStop = false;
            // 
            // pbCidade
            // 
            this.pbCidade.Location = new System.Drawing.Point(206, 12);
            this.pbCidade.Name = "pbCidade";
            this.pbCidade.Size = new System.Drawing.Size(316, 164);
            this.pbCidade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCidade.TabIndex = 1;
            this.pbCidade.TabStop = false;
            // 
            // btnVerImg
            // 
            this.btnVerImg.AutoSize = true;
            this.btnVerImg.BackColor = System.Drawing.Color.Maroon;
            this.btnVerImg.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerImg.ForeColor = System.Drawing.Color.Gold;
            this.btnVerImg.Location = new System.Drawing.Point(334, 182);
            this.btnVerImg.Name = "btnVerImg";
            this.btnVerImg.Padding = new System.Windows.Forms.Padding(8);
            this.btnVerImg.Size = new System.Drawing.Size(188, 53);
            this.btnVerImg.TabIndex = 2;
            this.btnVerImg.Text = "Visualizar";
            this.btnVerImg.UseVisualStyleBackColor = false;
            this.btnVerImg.Click += new System.EventHandler(this.btnVerImg_Click);
            // 
            // pbAnexarImg
            // 
            this.pbAnexarImg.Location = new System.Drawing.Point(13, 116);
            this.pbAnexarImg.Name = "pbAnexarImg";
            this.pbAnexarImg.Size = new System.Drawing.Size(187, 174);
            this.pbAnexarImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnexarImg.TabIndex = 3;
            this.pbAnexarImg.TabStop = false;
            // 
            // btnAnexar
            // 
            this.btnAnexar.AutoSize = true;
            this.btnAnexar.BackColor = System.Drawing.Color.Gold;
            this.btnAnexar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnexar.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnexar.ForeColor = System.Drawing.Color.Maroon;
            this.btnAnexar.Location = new System.Drawing.Point(206, 234);
            this.btnAnexar.Name = "btnAnexar";
            this.btnAnexar.Padding = new System.Windows.Forms.Padding(8);
            this.btnAnexar.Size = new System.Drawing.Size(128, 56);
            this.btnAnexar.TabIndex = 4;
            this.btnAnexar.Text = "Anexar ";
            this.btnAnexar.UseVisualStyleBackColor = false;
            this.btnAnexar.Click += new System.EventHandler(this.btnAnexar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 302);
            this.Controls.Add(this.btnAnexar);
            this.Controls.Add(this.pbAnexarImg);
            this.Controls.Add(this.btnVerImg);
            this.Controls.Add(this.pbCidade);
            this.Controls.Add(this.pbComputador);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbComputador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnexarImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbComputador;
        private System.Windows.Forms.PictureBox pbCidade;
        private System.Windows.Forms.Button btnVerImg;
        private System.Windows.Forms.PictureBox pbAnexarImg;
        private System.Windows.Forms.Button btnAnexar;
    }
}

