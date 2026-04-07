using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowHide
{
    public partial class frmShowHide : Form
    {
        public frmShowHide()
        {
            InitializeComponent();
            pbLogo.Visible = false;
        }

        private void btnShowLogo_Click(object sender, EventArgs e)
        {
            if (pbLogo.Visible)
            {
                pbLogo.Hide();
                btnShowLogo.Text = "Ver Logo";
            }
            else 
            { 
                pbLogo.Show();
                btnShowLogo.Text = "Fechar";
            }
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            frmHome frmHome = new frmHome();
            frmHome.Show();
        }
    }
}
