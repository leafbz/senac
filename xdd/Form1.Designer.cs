namespace xdd
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelForms = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelSold = new System.Windows.Forms.Panel();
            this.btnxdd = new System.Windows.Forms.Button();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.btnArchive = new System.Windows.Forms.Button();
            this.panelArchive = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnJanela = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.panelContainer.SuspendLayout();
            this.panelForms.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelSold.SuspendLayout();
            this.panelDelete.SuspendLayout();
            this.panelArchive.SuspendLayout();
            this.panelEdit.SuspendLayout();
            this.panelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnJanela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.panelForms);
            this.panelContainer.Controls.Add(this.panelBarraTitulo);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1400, 900);
            this.panelContainer.TabIndex = 0;
            // 
            // panelForms
            // 
            this.panelForms.Controls.Add(this.button1);
            this.panelForms.Controls.Add(this.button3);
            this.panelForms.Controls.Add(this.button2);
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(0, 120);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(1400, 780);
            this.panelForms.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(10)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(307, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Livros";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(167)))), ((int)(((byte)(86)))));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(913, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 64);
            this.button3.TabIndex = 2;
            this.button3.Text = "Arquivado";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(10)))));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(588, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "Bundles";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(10)))));
            this.panelBarraTitulo.Controls.Add(this.tableLayoutPanel1);
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.btnJanela);
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.pictureBox1);
            this.panelBarraTitulo.Controls.Add(this.btnFechar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1400, 120);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(10)))));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panelSold, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelDelete, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelArchive, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelEdit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelAdd, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(200, 60);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 60);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panelSold
            // 
            this.panelSold.BackColor = System.Drawing.Color.Silver;
            this.panelSold.Controls.Add(this.btnxdd);
            this.panelSold.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSold.Location = new System.Drawing.Point(965, 5);
            this.panelSold.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.panelSold.Name = "panelSold";
            this.panelSold.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panelSold.Size = new System.Drawing.Size(230, 55);
            this.panelSold.TabIndex = 4;
            // 
            // btnxdd
            // 
            this.btnxdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(10)))));
            this.btnxdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnxdd.FlatAppearance.BorderSize = 0;
            this.btnxdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxdd.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnxdd.Image = ((System.Drawing.Image)(resources.GetObject("btnxdd.Image")));
            this.btnxdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnxdd.Location = new System.Drawing.Point(0, 0);
            this.btnxdd.Name = "btnxdd";
            this.btnxdd.Size = new System.Drawing.Size(230, 50);
            this.btnxdd.TabIndex = 1;
            this.btnxdd.Text = "xdd";
            this.btnxdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnxdd.UseVisualStyleBackColor = false;
            this.btnxdd.Click += new System.EventHandler(this.Btn_Click);
            // 
            // panelDelete
            // 
            this.panelDelete.BackColor = System.Drawing.Color.Silver;
            this.panelDelete.Controls.Add(this.btnArchive);
            this.panelDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDelete.Location = new System.Drawing.Point(725, 5);
            this.panelDelete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panelDelete.Size = new System.Drawing.Size(230, 55);
            this.panelDelete.TabIndex = 3;
            // 
            // btnArchive
            // 
            this.btnArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(10)))));
            this.btnArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnArchive.FlatAppearance.BorderSize = 0;
            this.btnArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchive.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchive.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnArchive.Image = ((System.Drawing.Image)(resources.GetObject("btnArchive.Image")));
            this.btnArchive.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnArchive.Location = new System.Drawing.Point(0, 0);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(230, 50);
            this.btnArchive.TabIndex = 1;
            this.btnArchive.Text = "Archive";
            this.btnArchive.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnArchive.UseVisualStyleBackColor = false;
            this.btnArchive.Click += new System.EventHandler(this.Btn_Click);
            // 
            // panelArchive
            // 
            this.panelArchive.BackColor = System.Drawing.Color.Silver;
            this.panelArchive.Controls.Add(this.btnEdit);
            this.panelArchive.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelArchive.Location = new System.Drawing.Point(485, 5);
            this.panelArchive.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.panelArchive.Name = "panelArchive";
            this.panelArchive.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panelArchive.Size = new System.Drawing.Size(230, 55);
            this.panelArchive.TabIndex = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(10)))));
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdit.Location = new System.Drawing.Point(0, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(230, 50);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.Btn_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.BackColor = System.Drawing.Color.Silver;
            this.panelEdit.Controls.Add(this.btnAdd);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEdit.Location = new System.Drawing.Point(245, 5);
            this.panelEdit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panelEdit.Size = new System.Drawing.Size(230, 55);
            this.panelEdit.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(10)))));
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(230, 50);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.Btn_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.Color.Silver;
            this.panelAdd.Controls.Add(this.btnHome);
            this.panelAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdd.Location = new System.Drawing.Point(5, 5);
            this.panelAdd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panelAdd.Size = new System.Drawing.Size(230, 55);
            this.panelAdd.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(38)))), ((int)(((byte)(10)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(230, 50);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1334, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(24, 24);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 4;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnJanela
            // 
            this.btnJanela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJanela.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJanela.Image = ((System.Drawing.Image)(resources.GetObject("btnJanela.Image")));
            this.btnJanela.Location = new System.Drawing.Point(1334, 12);
            this.btnJanela.Name = "btnJanela";
            this.btnJanela.Size = new System.Drawing.Size(24, 24);
            this.btnJanela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnJanela.TabIndex = 3;
            this.btnJanela.TabStop = false;
            this.btnJanela.Visible = false;
            this.btnJanela.Click += new System.EventHandler(this.btnJanela_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1304, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 24);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(1364, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(24, 24);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 0;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 900);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelForms.ResumeLayout(false);
            this.panelBarraTitulo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelSold.ResumeLayout(false);
            this.panelDelete.ResumeLayout(false);
            this.panelArchive.ResumeLayout(false);
            this.panelEdit.ResumeLayout(false);
            this.panelAdd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnJanela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnJanela;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelSold;
        private System.Windows.Forms.Button btnxdd;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Panel panelArchive;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button btnHome;
    }
}

