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
    public partial class Book : Form
    {
        string[] Books = { "The Underground Railroad", "Alice in Wonderland", "Pequeno Manual Antirracista", "Anne of Green Gables", "The Clock House Murders: The classic japonise locked room mystery", "It Ends With Us" };
        public Book()
        {
            InitializeComponent();
            AddCards(Books);
        }
        private void AddCards(string[] itens)
        {
            cardContainer.Controls.Clear();
            foreach (var text in itens)
            {
                Card card = new Card();
                card.Detail(text);
                card.bookImg = Image.FromFile(@"C:\Users\rafael.rbrazao\Downloads\glorp-4x.png");
                cardContainer.Controls.Add(card);
            }
        }
    }
}
