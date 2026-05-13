namespace NineLivesBooks
{
    partial class FrmBundleDetails
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
            this.lblBundleName = new System.Windows.Forms.Label();
            this.lblTheme = new System.Windows.Forms.Label();
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCreatedAt = new System.Windows.Forms.Label();
            this.lblUpdatedAt = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvBooksBundle = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.picBundle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksBundle)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBundle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBundleName
            // 
            this.lblBundleName.AutoSize = true;
            this.lblBundleName.Location = new System.Drawing.Point(21, 306);
            this.lblBundleName.Name = "lblBundleName";
            this.lblBundleName.Size = new System.Drawing.Size(74, 13);
            this.lblBundleName.TabIndex = 0;
            this.lblBundleName.Text = "Bundle Name:";
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Location = new System.Drawing.Point(21, 329);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(43, 13);
            this.lblTheme.TabIndex = 1;
            this.lblTheme.Text = "Theme:";
            // 
            // lblTotalBooks
            // 
            this.lblTotalBooks.AutoSize = true;
            this.lblTotalBooks.Location = new System.Drawing.Point(21, 353);
            this.lblTotalBooks.Name = "lblTotalBooks";
            this.lblTotalBooks.Size = new System.Drawing.Size(67, 13);
            this.lblTotalBooks.TabIndex = 2;
            this.lblTotalBooks.Text = "Total Books:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(22, 376);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(61, 13);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(22, 399);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status: ";
            // 
            // lblCreatedAt
            // 
            this.lblCreatedAt.AutoSize = true;
            this.lblCreatedAt.Location = new System.Drawing.Point(23, 421);
            this.lblCreatedAt.Name = "lblCreatedAt";
            this.lblCreatedAt.Size = new System.Drawing.Size(60, 13);
            this.lblCreatedAt.TabIndex = 5;
            this.lblCreatedAt.Text = "Created At:";
            // 
            // lblUpdatedAt
            // 
            this.lblUpdatedAt.AutoSize = true;
            this.lblUpdatedAt.Location = new System.Drawing.Point(24, 446);
            this.lblUpdatedAt.Name = "lblUpdatedAt";
            this.lblUpdatedAt.Size = new System.Drawing.Size(64, 13);
            this.lblUpdatedAt.TabIndex = 6;
            this.lblUpdatedAt.Text = "Updated At:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(27, 136);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(106, 35);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.Paint += new System.Windows.Forms.PaintEventHandler(this.btnBack_Paint);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(353, 136);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 35);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.Paint += new System.Windows.Forms.PaintEventHandler(this.btnEdit_Paint);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(487, 136);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(106, 35);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            this.btnRemove.Paint += new System.Windows.Forms.PaintEventHandler(this.btnRemove_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(631, 136);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 35);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.Paint += new System.Windows.Forms.PaintEventHandler(this.btnDelete_Paint);
            // 
            // dgvBooksBundle
            // 
            this.dgvBooksBundle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooksBundle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvBooksBundle.Location = new System.Drawing.Point(12, 254);
            this.dgvBooksBundle.Name = "dgvBooksBundle";
            this.dgvBooksBundle.Size = new System.Drawing.Size(725, 440);
            this.dgvBooksBundle.TabIndex = 11;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ISBN";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Title";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Author";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Condition";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Price";
            this.Column6.Name = "Column6";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.picBundle);
            this.panel2.Controls.Add(this.lblUpdatedAt);
            this.panel2.Controls.Add(this.lblBundleName);
            this.panel2.Controls.Add(this.lblTheme);
            this.panel2.Controls.Add(this.lblTotalBooks);
            this.panel2.Controls.Add(this.lblTotalPrice);
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.lblCreatedAt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(790, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 740);
            this.panel2.TabIndex = 13;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(0, 614);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(321, 126);
            this.txtDescription.TabIndex = 8;
            // 
            // picBundle
            // 
            this.picBundle.Location = new System.Drawing.Point(83, 119);
            this.picBundle.Name = "picBundle";
            this.picBundle.Size = new System.Drawing.Size(144, 143);
            this.picBundle.TabIndex = 7;
            this.picBundle.TabStop = false;
            // 
            // FrmBundleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 740);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvBooksBundle);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBack);
            this.Name = "FrmBundleDetails";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooksBundle)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBundle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBundleName;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCreatedAt;
        private System.Windows.Forms.Label lblUpdatedAt;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvBooksBundle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picBundle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox txtDescription;
    }
}