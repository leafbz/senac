using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xdd
{
    public partial class frmAddBook : Form
    {
        string imagePath;
        public frmAddBook()
        {
            InitializeComponent();
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK) 
            {
                image.Image = new Bitmap(dlg.FileName);
                imagePath = dlg.FileName;
            }
        }

        private void frmAddBook_Load(object sender, EventArgs e)
        {
            cmbBookType.Items.Clear();
            cmbBookType.Items.AddRange(new string[] { "PB", "TPB", "HB" });

            //cmbCondition.Items.Clear();
            //cmbCondition.Items.AddRange(new string[] { "NEW", "VERY GOOD", "GOOD", "ACCEPTABLE" });

            //cmbStatus.Items.Clear();
            //cmbStatus.Items.AddRange(new string[] { "AVAILABLE", "SOLD", "UNAVAILABEL" });
        }
    }
}
