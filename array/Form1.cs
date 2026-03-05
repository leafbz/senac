using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array
{
    public partial class frmVetor : Form
    {
        public frmVetor()
        {
            InitializeComponent();
        }

        private void btnTest_MouseClick(object sender, MouseEventArgs e)
        {
            string[] pecasPC = { "Mouse", "Teclado", "Monitor", "Gabinete", "Câmera" };
            //MessageBox.Show(pecasPC[2]);
            foreach (var peca in pecasPC)
            {
                MessageBox.Show(peca);
            }
        }
    }
}
