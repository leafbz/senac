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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void linkVolta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowHide frm = new frmShowHide();
            frm.Show();
            this.Hide();
        }
    }
}
