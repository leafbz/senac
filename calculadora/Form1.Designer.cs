namespace calculadora
{
    partial class frmCalculadora
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.lblProdCalc = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.txtScndNum = new System.Windows.Forms.TextBox();
            this.lblScndNum = new System.Windows.Forms.Label();
            this.txtFirstNum = new System.Windows.Forms.TextBox();
            this.lblFirstNum = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnDiv = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDiv);
            this.groupBox1.Controls.Add(this.btnMulti);
            this.groupBox1.Controls.Add(this.btnSub);
            this.groupBox1.Controls.Add(this.lblProdCalc);
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.btnSomar);
            this.groupBox1.Controls.Add(this.txtScndNum);
            this.groupBox1.Controls.Add(this.lblScndNum);
            this.groupBox1.Controls.Add(this.txtFirstNum);
            this.groupBox1.Controls.Add(this.lblFirstNum);
            this.groupBox1.Location = new System.Drawing.Point(35, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 484);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnMulti
            // 
            this.btnMulti.BackColor = System.Drawing.Color.Chocolate;
            this.btnMulti.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMulti.Location = new System.Drawing.Point(254, 172);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(150, 37);
            this.btnMulti.TabIndex = 8;
            this.btnMulti.Text = "Multiplicar";
            this.btnMulti.UseVisualStyleBackColor = false;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.DarkRed;
            this.btnSub.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.ForeColor = System.Drawing.Color.Yellow;
            this.btnSub.Location = new System.Drawing.Point(98, 215);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(150, 37);
            this.btnSub.TabIndex = 7;
            this.btnSub.Text = "Subtrair";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // lblProdCalc
            // 
            this.lblProdCalc.AutoSize = true;
            this.lblProdCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdCalc.ForeColor = System.Drawing.Color.Crimson;
            this.lblProdCalc.Location = new System.Drawing.Point(272, 248);
            this.lblProdCalc.Name = "lblProdCalc";
            this.lblProdCalc.Size = new System.Drawing.Size(29, 31);
            this.lblProdCalc.TabIndex = 6;
            this.lblProdCalc.Text = "0";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Navy;
            this.lblResult.Location = new System.Drawing.Point(167, 255);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(99, 24);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Resultado:";
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSomar.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSomar.ForeColor = System.Drawing.Color.White;
            this.btnSomar.Location = new System.Drawing.Point(98, 172);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(150, 37);
            this.btnSomar.TabIndex = 4;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // txtScndNum
            // 
            this.txtScndNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScndNum.Location = new System.Drawing.Point(171, 137);
            this.txtScndNum.Name = "txtScndNum";
            this.txtScndNum.Size = new System.Drawing.Size(150, 29);
            this.txtScndNum.TabIndex = 3;
            // 
            // lblScndNum
            // 
            this.lblScndNum.AutoSize = true;
            this.lblScndNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScndNum.ForeColor = System.Drawing.Color.Navy;
            this.lblScndNum.Location = new System.Drawing.Point(167, 110);
            this.lblScndNum.Name = "lblScndNum";
            this.lblScndNum.Size = new System.Drawing.Size(162, 24);
            this.lblScndNum.TabIndex = 2;
            this.lblScndNum.Text = "Segundo Número";
            // 
            // txtFirstNum
            // 
            this.txtFirstNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstNum.Location = new System.Drawing.Point(171, 78);
            this.txtFirstNum.Name = "txtFirstNum";
            this.txtFirstNum.Size = new System.Drawing.Size(150, 29);
            this.txtFirstNum.TabIndex = 1;
            // 
            // lblFirstNum
            // 
            this.lblFirstNum.AutoSize = true;
            this.lblFirstNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNum.ForeColor = System.Drawing.Color.Navy;
            this.lblFirstNum.Location = new System.Drawing.Point(167, 51);
            this.lblFirstNum.Name = "lblFirstNum";
            this.lblFirstNum.Size = new System.Drawing.Size(154, 24);
            this.lblFirstNum.TabIndex = 0;
            this.lblFirstNum.Text = "Primeiro Número";
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.SlateBlue;
            this.btnDiv.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.Color.Coral;
            this.btnDiv.Location = new System.Drawing.Point(254, 215);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(150, 36);
            this.btnDiv.TabIndex = 9;
            this.btnDiv.Text = "Dividir";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblFirstNum;
        private System.Windows.Forms.Label lblScndNum;
        private System.Windows.Forms.TextBox txtFirstNum;
        private System.Windows.Forms.TextBox txtScndNum;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblProdCalc;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDiv;
    }
}

