using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xdd
{
    public partial class frmAddBundle : Form
    {
        Color headerBack = Color.FromArgb(0, 60, 40);
        Color headerFore = Color.FromArgb(255, 240, 200);

        Color rowEven = Color.FromArgb(255, 245, 220);
        Color rowOdd = Color.FromArgb(255, 235, 200);

        Color gridColor = Color.FromArgb(255, 215, 160);


        MySqlConnection Conn;
        string data_source = "datasource=localhost; username=root; password=; database=ninelivebooks";

        List<Livro> livrosDisponiveis = new List<Livro>();
        List<Livro> livrosDoGrupo = new List<Livro>();


        public class Livro
        {
            public int Id_Book { get; set; }
            private string Bundle_id { get; set; }
            public string Title { get; set; }
            public string Author { get; set; }
            public string Condition { get; set; }
            public string Db { get; set; }
            public decimal Price { get; set; }
            public byte[] ImageBytes { get; set; }
            public System.Drawing.Image CoverImage
            {
                get
                {
                    if (ImageBytes == null || ImageBytes.Length == 0)
                        return null;

                    using (var ms = new MemoryStream(ImageBytes))
                    {
                        return System.Drawing.Image.FromStream(ms);
                    }
                }
            }
        }
        public static class Db
        {
            private static readonly string connectionString =
                "datasource=localhost; username=root; password=; database=ninelivebooks";

            public static MySqlConnection GetConnection()
            {
                return new MySqlConnection(connectionString);
            }
        }


        private void lstBook_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using (SolidBrush back = new SolidBrush(headerBack))
            using (SolidBrush fore = new SolidBrush(headerFore))
            {
                e.Graphics.FillRectangle(back, e.Bounds);

                TextRenderer.DrawText(
                    e.Graphics,
                    e.Header.Text,
                    new Font("Georgia", 10F, FontStyle.Bold),
                    e.Bounds,
                    headerFore,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );

                e.Graphics.DrawRectangle(new Pen(gridColor), e.Bounds);
            }
        }

        private void lstBook_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            Color back = (e.ItemIndex % 2 == 0) ? rowEven : rowOdd;

            if (e.Item.Selected)
                back = Color.FromArgb(255, 215, 160);

            e.Graphics.FillRectangle(new SolidBrush(back), e.Bounds);
        }

        private void lstBook_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            Color backColor =
                (e.ItemIndex % 2 == 0)
                    ? Color.FromArgb(255, 245, 220)
                    : Color.FromArgb(255, 235, 200);

            if (e.Item.Selected)
                backColor = Color.FromArgb(255, 215, 160);

            using (SolidBrush back = new SolidBrush(backColor))
                e.Graphics.FillRectangle(back, e.Bounds);

            Color textColor =
                e.ColumnIndex == 0
                    ? Color.FromArgb(0, 80, 60)
                    : Color.FromArgb(40, 40, 40);

            Font font =
                e.ColumnIndex == 0
                    ? new Font("Georgia", 10F, FontStyle.Bold)
                    : new Font("Georgia", 10F);

            TextRenderer.DrawText(
                e.Graphics,
                e.SubItem.Text,
                font,
                e.Bounds,
                textColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter
            );

            using (Pen pen = new Pen(Color.FromArgb(255, 215, 160)))
                e.Graphics.DrawRectangle(pen, e.Bounds);
        }
        private void lstBookBundle_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using (SolidBrush back = new SolidBrush(headerBack))
            using (SolidBrush fore = new SolidBrush(headerFore))
            {
                e.Graphics.FillRectangle(back, e.Bounds);

                TextRenderer.DrawText(
                    e.Graphics,
                    e.Header.Text,
                    new Font("Georgia", 10F, FontStyle.Bold),
                    e.Bounds,
                    headerFore,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );

                e.Graphics.DrawRectangle(new Pen(gridColor), e.Bounds);
            }
        }

        private void lstBookBundle_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            Color back = (e.ItemIndex % 2 == 0) ? rowEven : rowOdd;

            if (e.Item.Selected)
                back = Color.FromArgb(255, 215, 160);

            e.Graphics.FillRectangle(new SolidBrush(back), e.Bounds);
        }

        private void lstBookBundle_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            Color backColor =
                (e.ItemIndex % 2 == 0)
                    ? Color.FromArgb(255, 245, 220)
                    : Color.FromArgb(255, 235, 200);

            if (e.Item.Selected)
                backColor = Color.FromArgb(255, 215, 160);

            using (SolidBrush back = new SolidBrush(backColor))
                e.Graphics.FillRectangle(back, e.Bounds);

            Color textColor =
                e.ColumnIndex == 0
                    ? Color.FromArgb(0, 80, 60)
                    : Color.FromArgb(40, 40, 40);

            Font font =
                e.ColumnIndex == 0
                    ? new Font("Georgia", 10F, FontStyle.Bold)
                    : new Font("Georgia", 10F);

            TextRenderer.DrawText(
                e.Graphics,
                e.SubItem.Text,
                font,
                e.Bounds,
                textColor,
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter
            );

            using (Pen pen = new Pen(Color.FromArgb(255, 215, 160)))
                e.Graphics.DrawRectangle(pen, e.Bounds);
        }


        public frmAddBundle()
        {
            InitializeComponent();
            lstBook.BackColor = Color.FromArgb(255, 245, 220);
            lstBook.BorderStyle = BorderStyle.FixedSingle;
            lstBookBundle.BackColor = Color.FromArgb(255, 245, 220);
            lstBookBundle.BorderStyle = BorderStyle.FixedSingle;

            lstBook.View = View.Details;


            lstBook.MultiSelect = true;
            lstBook.AllowColumnReorder = true;
            lstBook.FullRowSelect = true;
            lstBook.GridLines = true;
            lstBook.HideSelection = false;
            lstBook.OwnerDraw = true;
            lstBook.HoverSelection = false;
            lstBook.Activation = ItemActivation.Standard;

            lstBookBundle.View = View.Details;

            lstBookBundle.MultiSelect = true;
            lstBookBundle.AllowColumnReorder = true;
            lstBookBundle.FullRowSelect = true;
            lstBookBundle.HideSelection = false;
            lstBookBundle.GridLines = true;
            lstBookBundle.OwnerDraw = true;
            lstBookBundle.HoverSelection = false;
            lstBookBundle.Activation = ItemActivation.Standard;


            lstBook.Columns.Add("ID", 100, HorizontalAlignment.Left);
            lstBook.Columns.Add("Title", 200, HorizontalAlignment.Left);
            lstBook.Columns.Add("Author", 150, HorizontalAlignment.Left);
            lstBook.Columns.Add("Condition", 125, HorizontalAlignment.Left);
            lstBook.Columns.Add("Price", 107, HorizontalAlignment.Left);

            lstBookBundle.Columns.Add("ID", 100, HorizontalAlignment.Left);
            lstBookBundle.Columns.Add("Title", 182, HorizontalAlignment.Left);
            lstBookBundle.Columns.Add("Author", 150, HorizontalAlignment.Left);
            lstBookBundle.Columns.Add("Price", 100, HorizontalAlignment.Left);


            lstBook.DrawColumnHeader += lstBook_DrawColumnHeader;
            lstBook.DrawItem += lstBook_DrawItem;
            lstBook.DrawSubItem += lstBook_DrawSubItem;

            lstBookBundle.DrawColumnHeader += lstBookBundle_DrawColumnHeader;
            lstBookBundle.DrawItem += lstBookBundle_DrawItem;
            lstBookBundle.DrawSubItem += lstBookBundle_DrawSubItem;


            this.Load += frmBundle_Load;


        }




    }
}
