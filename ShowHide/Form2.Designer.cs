namespace ShowHide
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBoasVindas = new System.Windows.Forms.Label();
            this.linkVolta = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblBoasVindas
            // 
            this.lblBoasVindas.AutoSize = true;
            this.lblBoasVindas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblBoasVindas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoasVindas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBoasVindas.Location = new System.Drawing.Point(268, 211);
            this.lblBoasVindas.Name = "lblBoasVindas";
            this.lblBoasVindas.Size = new System.Drawing.Size(265, 29);
            this.lblBoasVindas.TabIndex = 0;
            this.lblBoasVindas.Text = "Boas vindas ao sistema";
            // 
            // linkVolta
            // 
            this.linkVolta.AutoSize = true;
            this.linkVolta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkVolta.Location = new System.Drawing.Point(363, 254);
            this.linkVolta.Name = "linkVolta";
            this.linkVolta.Size = new System.Drawing.Size(75, 29);
            this.linkVolta.TabIndex = 1;
            this.linkVolta.TabStop = true;
            this.linkVolta.Text = "Voltar";
            this.linkVolta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVolta_LinkClicked);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkVolta);
            this.Controls.Add(this.lblBoasVindas);
            this.Name = "frmHome";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBoasVindas;
        private System.Windows.Forms.LinkLabel linkVolta;
    }
}