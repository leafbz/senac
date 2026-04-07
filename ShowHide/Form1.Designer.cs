namespace ShowHide
{
    partial class frmShowHide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowHide));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnShowLogo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(726, 285);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(350, 240);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // btnShowLogo
            // 
            this.btnShowLogo.BackColor = System.Drawing.Color.DarkBlue;
            this.btnShowLogo.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowLogo.Location = new System.Drawing.Point(813, 580);
            this.btnShowLogo.Name = "btnShowLogo";
            this.btnShowLogo.Size = new System.Drawing.Size(177, 81);
            this.btnShowLogo.TabIndex = 1;
            this.btnShowLogo.Text = "Clique";
            this.btnShowLogo.UseVisualStyleBackColor = false;
            this.btnShowLogo.Click += new System.EventHandler(this.btnShowLogo_Click);
            // 
            // frmShowHide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1802, 811);
            this.Controls.Add(this.btnShowLogo);
            this.Controls.Add(this.pbLogo);
            this.ForeColor = System.Drawing.Color.LightCoral;
            this.Location = new System.Drawing.Point(816, 181);
            this.Name = "frmShowHide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show Hide";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnShowLogo;
    }
}

