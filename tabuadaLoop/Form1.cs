using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabuadaLoop
{
    public partial class frmTabuada : Form
    {
        public frmTabuada()
        {
            InitializeComponent();
        }

        private void btnExecutaTabuada_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();
            int num = Convert.ToInt32(txtNum.Text);
            for (int i = 1; i < 11; i++)
            {
                lstTabuada.Items.Add($"{num} x {i} = {num*i}");
            }
        }
    }
}
