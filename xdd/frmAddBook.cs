using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xdd
{
    public partial class frmAddBook : Form
    {
        public frmAddBook()
        {
            InitializeComponent();
        }
        private void frmAddBook_Load(object sender, EventArgs e)
        {
            cmbBookType.Items.Clear();
            cmbBookType.Items.AddRange(new string[] { "PB", "TPB", "HB" });

            cmbCondition.Items.Clear();
            cmbCondition.Items.AddRange(new string[] { "NEW", "VERY GOOD", "GOOD", "ACCEPTABLE" });

            // IMPORTANT: your current SQL uses the typo UNAVAILABEL.
            // If you fix the database later, change this to UNAVAILABLE.
            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new string[] { "AVAILABLE", "SOLD", "UNAVAILABEL" });

            lblId.Text = string.Empty;
            // Optional: auto-generate IDs when adding a new book.
            if (string.IsNullOrWhiteSpace(lblId.Text))
                lblId.Text = GenerateNextBookId();

            if (string.IsNullOrWhiteSpace(txtTitleId.Text))
                txtTitleId.Text = GenerateNextTitleId();
        }
        private void btnAddImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // Clone the image so the file is not locked by the app.
                    using (var tempImage = Image.FromFile(dlg.FileName))
                    {
                        image.Image = new Bitmap(tempImage);
                    }
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            ClassBook book = GetBookFromForm();

            using (var conn = Db.GetConnection())
            {
                conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        SaveBookTitle(book, conn, transaction);
                        SaveInventoryBook(book, conn, transaction);

                        transaction.Commit();
                        MessageBox.Show("Book saved successfully.");

                        RefreshBookListIfOpen();
                        ClearForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving book: " + ex.Message);
                    }
                }
            }
        }
        #region Round Buttons
        private void btnArchive_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            int radius = 20; // Ajuste o raio para mudar a curvatura

            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();
                // Canto superior esquerdo
                path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
                // Canto superior direito
                path.AddArc(new Rectangle(btn.Width - radius, 0, radius, radius), 270, 90);
                // Canto inferior direito
                path.AddArc(new Rectangle(btn.Width - radius, btn.Height - radius, radius, radius), 0, 90);
                // Canto inferior esquerdo
                path.AddArc(new Rectangle(0, btn.Height - radius, radius, radius), 90, 90);
                path.CloseFigure();

                btn.Region = new Region(path);
            }
        }

        private void btnDelete_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            int radius = 20; // Ajuste o raio para mudar a curvatura

            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();
                // Canto superior esquerdo
                path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
                // Canto superior direito
                path.AddArc(new Rectangle(btn.Width - radius, 0, radius, radius), 270, 90);
                // Canto inferior direito
                path.AddArc(new Rectangle(btn.Width - radius, btn.Height - radius, radius, radius), 0, 90);
                // Canto inferior esquerdo
                path.AddArc(new Rectangle(0, btn.Height - radius, radius, radius), 90, 90);
                path.CloseFigure();

                btn.Region = new Region(path);
            }
        }

        private void btnAddImg_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            int radius = 20; // Ajuste o raio para mudar a curvatura

            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();
                // Canto superior esquerdo
                path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
                // Canto superior direito
                path.AddArc(new Rectangle(btn.Width - radius, 0, radius, radius), 270, 90);
                // Canto inferior direito
                path.AddArc(new Rectangle(btn.Width - radius, btn.Height - radius, radius, radius), 0, 90);
                // Canto inferior esquerdo
                path.AddArc(new Rectangle(0, btn.Height - radius, radius, radius), 90, 90);
                path.CloseFigure();

                btn.Region = new Region(path);
            }
        }

        private void btnRemove_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            int radius = 20; // Ajuste o raio para mudar a curvatura

            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();
                // Canto superior esquerdo
                path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
                // Canto superior direito
                path.AddArc(new Rectangle(btn.Width - radius, 0, radius, radius), 270, 90);
                // Canto inferior direito
                path.AddArc(new Rectangle(btn.Width - radius, btn.Height - radius, radius, radius), 0, 90);
                // Canto inferior esquerdo
                path.AddArc(new Rectangle(0, btn.Height - radius, radius, radius), 90, 90);
                path.CloseFigure();

                btn.Region = new Region(path);
            }
        }

        private void btnCancel_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            int radius = 20; // Ajuste o raio para mudar a curvatura

            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();
                // Canto superior esquerdo
                path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
                // Canto superior direito
                path.AddArc(new Rectangle(btn.Width - radius, 0, radius, radius), 270, 90);
                // Canto inferior direito
                path.AddArc(new Rectangle(btn.Width - radius, btn.Height - radius, radius, radius), 0, 90);
                // Canto inferior esquerdo
                path.AddArc(new Rectangle(0, btn.Height - radius, radius, radius), 90, 90);
                path.CloseFigure();

                btn.Region = new Region(path);
            }
        }

        private void btnSave_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            int radius = 20; // Ajuste o raio para mudar a curvatura

            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();
                // Canto superior esquerdo
                path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
                // Canto superior direito
                path.AddArc(new Rectangle(btn.Width - radius, 0, radius, radius), 270, 90);
                // Canto inferior direito
                path.AddArc(new Rectangle(btn.Width - radius, btn.Height - radius, radius, radius), 0, 90);
                // Canto inferior esquerdo
                path.AddArc(new Rectangle(0, btn.Height - radius, radius, radius), 90, 90);
                path.CloseFigure();

                btn.Region = new Region(path);
            }
        }
        #endregion

    private ClassBook GetBookFromForm()
        {
            return new ClassBook
            {
                BookId = lblId.Text.Trim(),
                TitleId = txtTitleId.Text.Trim(),

                Title = txtTitle.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                ISBN = txtISBN.Text.Trim(),
                Pages = (int)numPages.Value,
                BookType = cmbBookType.SelectedItem?.ToString(),
                ApproxWeight = numWeight.Value,
                Publisher = txtPublisher.Text.Trim(),
                PublicationYear = (int)numPublicationYear.Value,
                Language = txtLanguage.Text.Trim(),
                Genre = txtGenre.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                ImageBytes = GetImageBytesFromPictureBox(),

                Price = numPrice.Value,
                Condition = cmbCondition.SelectedItem?.ToString(),
                Status = cmbStatus.SelectedItem?.ToString(),
                ReasonStatus = string.IsNullOrWhiteSpace(txtReasonStatus.Text) ? null : txtReasonStatus.Text.Trim(),
                DefectedNotes = txtDefectedNotes.Text.Trim()
            };
        }
        private byte[] GetImageBytesFromPictureBox()
        {
            if (image.Image == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                image.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private bool ValidateForm()
        {

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Title is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Author is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtISBN.Text))
            {
                MessageBox.Show("ISBN is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPublisher.Text))
            {
                MessageBox.Show("Publisher is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLanguage.Text))
            {
                MessageBox.Show("Language is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGenre.Text))
            {
                MessageBox.Show("Genre is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Description is required.");
                return false;
            }

            if (cmbBookType.SelectedIndex == -1)
            {
                MessageBox.Show("Book type is required.");
                return false;
            }

            if (cmbCondition.SelectedIndex == -1)
            {
                MessageBox.Show("Condition is required.");
                return false;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Status is required.");
                return false;
            }

            // Your SQL says defected_notes TEXT NOT NULL.
            if (string.IsNullOrWhiteSpace(txtDefectedNotes.Text))
            {
                MessageBox.Show("Defected notes is required. Use 'None' if there are no defects.");
                return false;
            }

            if (cmbStatus.SelectedItem.ToString() == "UNAVAILABEL" &&
                string.IsNullOrWhiteSpace(txtReasonStatus.Text))
            {
                MessageBox.Show("Reason status is required when the book is unavailable.");
                return false;
            }

            return true;
        }
        private void SaveBookTitle(ClassBook book, MySqlConnection conn, MySqlTransaction transaction)
        {
            string checkQuery = "SELECT COUNT(*) FROM book_titles WHERE title_id = @title_id";

            using (var checkCmd = new MySqlCommand(checkQuery, conn, transaction))
            {
                checkCmd.Parameters.AddWithValue("@title_id", book.TitleId);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count == 0)
                    InsertBookTitle(book, conn, transaction);
                //else
                //    UpdateBookTitle(book, conn, transaction);
            }
        }
        private void InsertBookTitle(ClassBook book, MySqlConnection conn, MySqlTransaction transaction)
        {
            string query = @"
                INSERT INTO book_titles
                (
                    title_id, title, author, iSBN, pages, book_type, book_approx_weight,
                    publisher, publication_year, book_language, genre, book_description, book_image
                )
                VALUES
                (
                    @title_id, @title, @author, @isbn, @pages, @book_type, @weight,
                    @publisher, @year, @language, @genre, @description, @image
                )";

            using (var cmd = new MySqlCommand(query, conn, transaction))
            {
                AddBookTitleParameters(cmd, book);
                cmd.ExecuteNonQuery();
            }
        }
        //private void UpdateBookTitle(ClassBook book, MySqlConnection conn, MySqlTransaction transaction)
        //{
        //    string query = @"
        //        UPDATE book_titles
        //        SET
        //            title = @title,
        //            author = @author,
        //            iSBN = @isbn,
        //            pages = @pages,
        //            book_type = @book_type,
        //            book_approx_weight = @weight,
        //            publisher = @publisher,
        //            publication_year = @year,
        //            book_language = @language,
        //            genre = @genre,
        //            book_description = @description,
        //            book_image = @image
        //        WHERE title_id = @title_id";

        //    using (var cmd = new MySqlCommand(query, conn, transaction))
        //    {
        //        AddBookTitleParameters(cmd, book);
        //        cmd.ExecuteNonQuery();
        //    }
        //}
        private void AddBookTitleParameters(MySqlCommand cmd, ClassBook book)
        {
            cmd.Parameters.AddWithValue("@title_id", book.TitleId);
            cmd.Parameters.AddWithValue("@title", book.Title);
            cmd.Parameters.AddWithValue("@author", book.Author);
            cmd.Parameters.AddWithValue("@isbn", book.ISBN);
            cmd.Parameters.AddWithValue("@pages", book.Pages);
            cmd.Parameters.AddWithValue("@book_type", book.BookType);
            cmd.Parameters.AddWithValue("@weight", book.ApproxWeight);
            cmd.Parameters.AddWithValue("@publisher", book.Publisher);
            cmd.Parameters.AddWithValue("@year", book.PublicationYear);
            cmd.Parameters.AddWithValue("@language", book.Language);
            cmd.Parameters.AddWithValue("@genre", book.Genre);
            cmd.Parameters.AddWithValue("@description", book.Description);
            cmd.Parameters.AddWithValue("@image", (object)book.ImageBytes ?? DBNull.Value);
        }
        private void SaveInventoryBook(ClassBook book, MySqlConnection conn, MySqlTransaction transaction)
        {
            string checkQuery = "SELECT COUNT(*) FROM book WHERE book_id = @book_id";

            using (var checkCmd = new MySqlCommand(checkQuery, conn, transaction))
            {
                checkCmd.Parameters.AddWithValue("@book_id", book.BookId);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count == 0)
                    InsertInventoryBook(book, conn, transaction);
                //else
                //    UpdateInventoryBook(book, conn, transaction);
            }
        }
        private void InsertInventoryBook(ClassBook book, MySqlConnection conn, MySqlTransaction transaction)
        {
            string query = @"
                INSERT INTO book
                (
                    book_id, price, book_condition, book_status, reason_status,
                    defected_notes, title_id_in_book
                )
                VALUES
                (
                    @book_id, @price, @condition, @status, @reason_status,
                    @defected_notes, @title_id
                )";

            using (var cmd = new MySqlCommand(query, conn, transaction))
            {
                AddInventoryBookParameters(cmd, book);
                cmd.ExecuteNonQuery();
            }
        }
        //private void UpdateInventoryBook(ClassBook book, MySqlConnection conn, MySqlTransaction transaction)
        //{
        //    string query = @"
        //        UPDATE book
        //        SET
        //            price = @price,
        //            book_condition = @condition,
        //            book_status = @status,
        //            reason_status = @reason_status,
        //            defected_notes = @defected_notes,
        //            title_id_in_book = @title_id
        //        WHERE book_id = @book_id";

        //    using (var cmd = new MySqlCommand(query, conn, transaction))
        //    {
        //        AddInventoryBookParameters(cmd, book);
        //        cmd.ExecuteNonQuery();
        //    }
        //}
        private void AddInventoryBookParameters(MySqlCommand cmd, ClassBook book)
        {
            cmd.Parameters.AddWithValue("@book_id", book.BookId);
            cmd.Parameters.AddWithValue("@price", book.Price);
            cmd.Parameters.AddWithValue("@condition", book.Condition);
            cmd.Parameters.AddWithValue("@status", book.Status);
            cmd.Parameters.AddWithValue("@reason_status", (object)book.ReasonStatus ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@defected_notes", book.DefectedNotes);
            cmd.Parameters.AddWithValue("@title_id", book.TitleId);
        }
        private string GenerateNextBookId()
        {
            string query = "SELECT MAX(CAST(SUBSTRING(book_id, 3) AS UNSIGNED)) FROM book WHERE book_id LIKE 'NL%'";

            using (var conn = Db.GetConnection())
            using (var cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                    return "NL0001";

                int number = Convert.ToInt32(result) + 1;
                return "NL" + number.ToString("D4");
            }
        }
        private string GenerateNextTitleId()
        {
            string query = "SELECT MAX(CAST(SUBSTRING(title_id, 3) AS UNSIGNED)) FROM book_titles WHERE title_id LIKE 'NL%'";

            using (var conn = Db.GetConnection())
            using (var cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                    return "NL0001";

                int number = Convert.ToInt32(result) + 1;
                return "NL" + number.ToString("D4");
            }
        }
        private void RefreshBookListIfOpen()
        {
            if (frmPrincipal.PrincipalInstance == null)
                return;

            foreach (Control control in frmPrincipal.PrincipalInstance.Controls)
            {
                RefreshBookFormInside(control);
            }
        }

        private void RefreshBookFormInside(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Book bookForm)
                {
                    bookForm.LoadBooks();
                    return;
                }

                if (control.HasChildren)
                    RefreshBookFormInside(control);
            }
        }

        private void ClearForm()
        {
            lblId.Text = GenerateNextBookId();
            txtTitleId.Text = GenerateNextTitleId();

            txtTitle.Clear();
            txtAuthor.Clear();
            txtISBN.Clear();
            txtPublisher.Clear();
            txtLanguage.Clear();
            txtGenre.Clear();
            txtDescription.Clear();

            numPages.Value = numPages.Minimum;
            numWeight.Value = numWeight.Minimum;
            numPublicationYear.Value = 2000;
            numPrice.Value = numPrice.Minimum;

            cmbBookType.SelectedIndex = -1;
            cmbCondition.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;

            txtReasonStatus.Clear();
            txtDefectedNotes.Clear();
            image.Image = null;
        }
    }
}