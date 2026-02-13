using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            lblProdCalc.Text = (float.Parse(txtFirstNum.Text) + float.Parse(txtScndNum.Text)).ToString();

        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            lblProdCalc.Text = (float.Parse(txtFirstNum.Text) - float.Parse(txtScndNum.Text)).ToString();
        }
        private void btnMulti_Click(object sender, EventArgs e)
        {
            lblProdCalc.Text = (float.Parse(txtFirstNum.Text) * float.Parse(txtScndNum.Text)).ToString();
        }
        private void btnDiv_Click(object sender, EventArgs e)
        {
            lblProdCalc.Text = (float.Parse(txtFirstNum.Text) / float.Parse(txtScndNum.Text)).ToString();
        }
        
    }
}
