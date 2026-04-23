using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sidebar
{
    public partial class modal : Form
    {
        public modal()
        {
            InitializeComponent();
        }
        int i;
        private void modal_Load(object sender, EventArgs e)
        {
            i = Form1.parentY + 150;
            this.Location = new Point(Form1.parentX + 220, Form1.parentY + 150);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Instance.addUserControl(new UCLIVRO());
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.Instance.addUserControl(new UCBUNDLE());
        }
    }
}
