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
    public partial class Card : UserControl
    {
        private string text = "Label";
        public string customText { get { return text; } set { text = value; } }
        private Image bookImage;
        public Image bookImg { get { return bookImage; } set { bookImage = value; pictureBox1.Image = value; } }

        public event EventHandler CardClicked;
        public Card()
        {
            InitializeComponent();
            this.Click += (s, e) => CardClicked?.Invoke(this, e);
        }
        public void Detail(string text)
        {
            customText = text;
        }

        private void Card_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(244, 244, 244);
        }

        private void Card_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void Card_Paint(object sender, PaintEventArgs e)
        {
            label1.Text = customText;
        }
    }
}
