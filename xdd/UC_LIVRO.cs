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
    public partial class UC_LIVRO : UserControl
    {
        public UC_LIVRO()
        {
            InitializeComponent();
        }

        private void Livro_Click(object sender, EventArgs e)
        {
            FormLivro frmHome = new FormLivro();
            frmHome.Show();
        }
    }
}
