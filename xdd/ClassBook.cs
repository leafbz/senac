using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace xdd
{
    public class ClassBook
    {
        // IDs
        public string BookId { get; set; }
        public string TitleId { get; set; }

        // book_titles
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }
        public int PublicationYear { get; set; }
        public string Publisher { get; set; }
        public int Pages { get; set; }
        public string BookType { get; set; }
        public decimal ApproxWeight { get; set; }
        public string Description { get; set; }
        public byte[] ImageBytes { get; set; }

        // book
        public decimal Price { get; set; }
        public string Condition { get; set; }
        public string Status { get; set; }
        public string ReasonStatus { get; set; }
        public string DefectedNotes { get; set; }
        public string Origin { get; set; }

        public Image CoverImage
        {
            get
            {
                if (ImageBytes == null || ImageBytes.Length == 0)
                    return null;

                using (var ms = new MemoryStream(ImageBytes))
                {
                    return Image.FromStream(ms);
                }
            }
        }

        public override string ToString()
        {
            return $"{Title} - {Author}";
        }
    }
}
