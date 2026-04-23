using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xdd
{
    public partial class ModalAdd : Form
    {
        public ModalAdd()
        {
            InitializeComponent();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal.PrincipalInstance.AbrirForm<frmAddBook>();
        }

        private void btnBundle_Click(object sender, EventArgs e)
        {
            this.Close();
            frmPrincipal.PrincipalInstance.AbrirForm<frmAddBundle>();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModalAdd_Load(object sender, EventArgs e)
        {
            this.Location = new Point(frmPrincipal.parentX + 920, frmPrincipal.parentY + 475);
        }
    }
}
