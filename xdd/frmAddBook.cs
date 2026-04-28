using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace xdd
{
    public partial class frmAddBook : Form
    {
        private BookFormMode _mode;
        private ClassBook _selectedBook;
        private Button btnEditMode;
        private Button btnCreateCopy;

        public frmAddBook()
            : this(BookFormMode.Add)
        {
        }

        public frmAddBook(BookFormMode mode)
        {
            InitializeComponent();
            _mode = mode;
        }

        public frmAddBook(ClassBook book, BookFormMode mode)
        {
            InitializeComponent();
            _selectedBook = book;
            _mode = mode;
        }

        private void frmAddBook_Load(object sender, EventArgs e)
        {
            LoadCombos();
            EnsureModeButtons();

            txtISBN.Leave -= txtISBN_Leave;
            txtISBN.Leave += txtISBN_Leave;

            ApplyMode();
        }

        private void LoadCombos()
        {
            cmbBookType.Items.Clear();
            cmbBookType.Items.AddRange(new string[] { "PB", "TPB", "HB" });

            cmbCondition.Items.Clear();
            cmbCondition.Items.AddRange(new string[] { "NEW", "VERY GOOD", "GOOD", "ACCEPTABLE" });

            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new string[] { "AVAILABLE", "SOLD", "UNAVAILABLE" });
        }

        private void EnsureModeButtons()
        {
            if (btnEditMode == null)
            {
                btnEditMode = new Button
                {
                    Name = "btnEditMode",
                    Text = "Edit",
                    Width = btnSave.Width,
                    Height = btnSave.Height,
                    Left = btnSave.Left,
                    Top = btnSave.Top,
                    BackColor = btnSave.BackColor,
                    ForeColor = btnSave.ForeColor,
                    Font = btnSave.Font
                };
                btnEditMode.Click += btnEditMode_Click;
                Controls.Add(btnEditMode);
                btnEditMode.BringToFront();
            }

            if (btnCreateCopy == null)
            {
                btnCreateCopy = new Button
                {
                    Name = "btnCreateCopy",
                    Text = "Create Copy",
                    Width = btnSave.Width + 20,
                    Height = btnSave.Height,
                    Left = btnSave.Right + 10,
                    Top = btnSave.Top,
                    BackColor = btnSave.BackColor,
                    ForeColor = btnSave.ForeColor,
                    Font = btnSave.Font
                };
                btnCreateCopy.Click += btnCreateCopy_Click;
                Controls.Add(btnCreateCopy);
                btnCreateCopy.BringToFront();
            }
        }

        private void ApplyMode()
        {
            switch (_mode)
            {
                case BookFormMode.Add:
                    PrepareAddMode();
                    break;

                case BookFormMode.View:
                    PrepareViewMode();
                    break;

                case BookFormMode.Edit:
                    PrepareEditMode();
                    break;

                case BookFormMode.AddCopy:
                    PrepareAddCopyMode();
                    break;
            }
        }

        private void PrepareAddMode()
        {
            ClearForm(false);
            lblId.Text = GenerateNextBookId();
            txtTitleId.Text = GenerateNextTitleId();

            //SetAllFieldsReadOnly(false);
            btnSave.Text = "Save New Book";
            btnSave.Visible = true;
            btnEditMode.Visible = false;
            btnCreateCopy.Visible = false;
        }

        private void PrepareViewMode()
        {
            if (_selectedBook != null)
                FillForm(_selectedBook);

            SetAllFieldsReadOnly(true);
            btnSave.Visible = false;
            btnEditMode.Visible = true;
            btnCreateCopy.Visible = true;
        }

        private void PrepareEditMode()
        {
            if (_selectedBook != null)
                FillForm(_selectedBook);

            SetAllFieldsReadOnly(true);
            SetInventoryFieldsReadOnly(false);

            btnSave.Text = "Save Changes";
            btnSave.Visible = true;
            btnEditMode.Visible = false;
            btnCreateCopy.Visible = false;
        }

        private void PrepareAddCopyMode()
        {
            if (_selectedBook != null)
                FillForm(_selectedBook);

            lblId.Text = GenerateNextBookId();

            // Same title_id, new physical copy.
            SetAllFieldsReadOnly(true);
            SetInventoryFieldsReadOnly(false);

            cmbCondition.SelectedIndex = -1;
            cmbStatus.SelectedItem = "AVAILABLE";
            numPrice.Value = numPrice.Minimum;
            txtReasonStatus.Clear();
            txtDefectedNotes.Text = "None";

            btnSave.Text = "Save Copy";
            btnSave.Visible = true;
            btnEditMode.Visible = false;
            btnCreateCopy.Visible = false;
        }

        private void FillForm(ClassBook book)
        {
            lblId.Text = book.BookId;
            txtTitleId.Text = book.TitleId;

            txtTitle.Text = book.Title;
            txtAuthor.Text = book.Author;
            txtISBN.Text = book.ISBN;
            txtPublisher.Text = book.Publisher;
            txtLanguage.Text = book.Language;
            txtGenre.Text = book.Genre;
            txtDescription.Text = book.Description;

            SetNumericValue(numPages, book.Pages);
            SetNumericValue(numWeight, book.ApproxWeight);
            SetNumericValue(numPublicationYear, book.PublicationYear);
            SetNumericValue(numPrice, book.Price);

            cmbBookType.SelectedItem = book.BookType;
            cmbCondition.SelectedItem = book.Condition;
            cmbStatus.SelectedItem = book.Status;

            txtReasonStatus.Text = book.ReasonStatus ?? string.Empty;
            txtDefectedNotes.Text = book.DefectedNotes ?? string.Empty;
            image.Image = book.CoverImage;
        }

        private void SetNumericValue(NumericUpDown control, decimal value)
        {
            if (value < control.Minimum)
                control.Value = control.Minimum;
            else if (value > control.Maximum)
                control.Value = control.Maximum;
            else
                control.Value = value;
        }

        private void btnEditMode_Click(object sender, EventArgs e)
        {
            _mode = BookFormMode.Edit;
            ApplyMode();
        }

        private void btnCreateCopy_Click(object sender, EventArgs e)
        {
            _mode = BookFormMode.AddCopy;
            ApplyMode();
        }

        private void txtISBN_Leave(object sender, EventArgs e)
        {
            if (_mode != BookFormMode.Add)
                return;

            LoadExistingTitleByISBN(txtISBN.Text.Trim());
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            if (_mode == BookFormMode.View)
                return;

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    using (var tempImage = Image.FromFile(dlg.FileName))
                    {
                        image.Image = new Bitmap(tempImage);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_mode == BookFormMode.View)
                return;

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
                        if (_mode == BookFormMode.Add)
                        {
                            string existingTitleId = GetExistingTitleIdByISBN(book.ISBN, conn, transaction);

                            if (!string.IsNullOrWhiteSpace(existingTitleId))
                            {
                                book.TitleId = existingTitleId;
                                txtTitleId.Text = existingTitleId;
                            }
                            else
                            {
                                SaveBookTitle(book, conn, transaction);
                            }

                            InsertInventoryBook(book, conn, transaction);
                        }
                        else if (_mode == BookFormMode.AddCopy)
                        {
                            InsertInventoryBook(book, conn, transaction);
                        }
                        else if (_mode == BookFormMode.Edit)
                        {
                            UpdateInventoryBook(book, conn, transaction);
                        }

                        transaction.Commit();
                        MessageBox.Show("Book saved successfully.");

                        RefreshBookListIfOpen();

                        if (_mode == BookFormMode.Edit)
                        {
                            _selectedBook = book;
                            _mode = BookFormMode.View;
                            ApplyMode();
                        }
                        else
                        {
                            PrepareAddMode();
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error saving book: " + ex.Message);
                    }
                }
            }
        }

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
            if (string.IsNullOrWhiteSpace(lblId.Text))
            {
                MessageBox.Show("Book ID is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTitleId.Text))
            {
                MessageBox.Show("Title ID is required.");
                return false;
            }

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

            if (string.IsNullOrWhiteSpace(txtDefectedNotes.Text))
            {
                MessageBox.Show("Defected notes is required. Use 'None' if there are no defects.");
                return false;
            }

            if (cmbStatus.SelectedItem.ToString() == "UNAVAILABEL" && string.IsNullOrWhiteSpace(txtReasonStatus.Text))
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
                else
                    UpdateBookTitle(book, conn, transaction);
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

        private void UpdateBookTitle(ClassBook book, MySqlConnection conn, MySqlTransaction transaction)
        {
            string query = @"
                UPDATE book_titles
                SET
                    title = @title,
                    author = @author,
                    iSBN = @isbn,
                    pages = @pages,
                    book_type = @book_type,
                    book_approx_weight = @weight,
                    publisher = @publisher,
                    publication_year = @year,
                    book_language = @language,
                    genre = @genre,
                    book_description = @description,
                    book_image = @image
                WHERE title_id = @title_id";

            using (var cmd = new MySqlCommand(query, conn, transaction))
            {
                AddBookTitleParameters(cmd, book);
                cmd.ExecuteNonQuery();
            }
        }

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

        private void UpdateInventoryBook(ClassBook book, MySqlConnection conn, MySqlTransaction transaction)
        {
            string query = @"
                UPDATE book
                SET
                    price = @price,
                    book_condition = @condition,
                    book_status = @status,
                    reason_status = @reason_status,
                    defected_notes = @defected_notes,
                    title_id_in_book = @title_id
                WHERE book_id = @book_id";

            using (var cmd = new MySqlCommand(query, conn, transaction))
            {
                AddInventoryBookParameters(cmd, book);
                cmd.ExecuteNonQuery();
            }
        }

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

        private string GetExistingTitleIdByISBN(string isbn, MySqlConnection conn, MySqlTransaction transaction)
        {
            string query = "SELECT title_id FROM book_titles WHERE iSBN = @isbn LIMIT 1";

            using (var cmd = new MySqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@isbn", isbn);
                object result = cmd.ExecuteScalar();

                return result == null || result == DBNull.Value ? null : result.ToString();
            }
        }

        private void LoadExistingTitleByISBN(string isbn)
        {
            if (string.IsNullOrWhiteSpace(isbn))
                return;

            string query = @"
                SELECT title_id, title, author, pages, book_type, book_approx_weight,
                       publisher, publication_year, book_language, genre, book_description, book_image
                FROM book_titles
                WHERE iSBN = @isbn
                LIMIT 1";

            using (var conn = Db.GetConnection())
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@isbn", isbn);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtTitleId.Text = reader["title_id"].ToString();
                        txtTitle.Text = reader["title"].ToString();
                        txtAuthor.Text = reader["author"].ToString();
                        numPages.Value = Convert.ToDecimal(reader["pages"]);
                        cmbBookType.SelectedItem = reader["book_type"].ToString();
                        numWeight.Value = Convert.ToDecimal(reader["book_approx_weight"]);
                        txtPublisher.Text = reader["publisher"].ToString();
                        numPublicationYear.Value = Convert.ToDecimal(reader["publication_year"]);
                        txtLanguage.Text = reader["book_language"].ToString();
                        txtGenre.Text = reader["genre"].ToString();
                        txtDescription.Text = reader["book_description"].ToString();

                        if (reader["book_image"] != DBNull.Value)
                        {
                            byte[] imageBytes = (byte[])reader["book_image"];
                            using (var ms = new MemoryStream(imageBytes))
                            {
                                image.Image = Image.FromStream(new MemoryStream(ms.ToArray()));
                            }
                        }

                        MessageBox.Show("Existing title found. A new physical copy will be created.");
                    }
                }
            }
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
            string query = "SELECT MAX(CAST(SUBSTRING(title_id, 3) AS UNSIGNED)) FROM book_titles WHERE title_id LIKE 'TL%'";

            using (var conn = Db.GetConnection())
            using (var cmd = new MySqlCommand(query, conn))
            {
                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                    return "TL0001";

                int number = Convert.ToInt32(result) + 1;
                return "TL" + number.ToString("D4");
            }
        }

        private void RefreshBookListIfOpen()
        {
            if (frmPrincipal.PrincipalInstance == null)
                return;

            RefreshBookFormInside(frmPrincipal.PrincipalInstance);
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

        private void ClearForm(bool generateIds = true)
        {
            if (generateIds)
            {
                lblId.Text = GenerateNextBookId();
                txtTitleId.Text = GenerateNextTitleId();
            }
            else
            {
                lblId.Text = string.Empty;
                txtTitleId.Text = string.Empty;
            }

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

        private void SetAllFieldsReadOnly(bool readOnly)
        {
            txtTitleId.ReadOnly = true;
            txtTitle.ReadOnly = readOnly;
            txtAuthor.ReadOnly = readOnly;
            txtISBN.ReadOnly = readOnly;
            txtPublisher.ReadOnly = readOnly;
            txtLanguage.ReadOnly = readOnly;
            txtGenre.ReadOnly = readOnly;
            txtDescription.ReadOnly = readOnly;

            numPages.Enabled = !readOnly;
            numWeight.Enabled = !readOnly;
            numPublicationYear.Enabled = !readOnly;
            numPrice.Enabled = !readOnly;

            cmbBookType.Enabled = !readOnly;
            cmbCondition.Enabled = !readOnly;
            cmbStatus.Enabled = !readOnly;

            txtReasonStatus.ReadOnly = readOnly;
            txtDefectedNotes.ReadOnly = readOnly;
            btnAddImg.Enabled = !readOnly;
        }

        private void SetInventoryFieldsReadOnly(bool readOnly)
        {
            numPrice.Enabled = !readOnly;
            cmbCondition.Enabled = !readOnly;
            cmbStatus.Enabled = !readOnly;
            txtReasonStatus.ReadOnly = readOnly;
            txtDefectedNotes.ReadOnly = readOnly;
        }

        #region Round Buttons
        private void btnArchive_Paint(object sender, PaintEventArgs e) { RoundButton(sender); }
        private void btnDelete_Paint(object sender, PaintEventArgs e) { RoundButton(sender); }
        private void btnAddImg_Paint(object sender, PaintEventArgs e) { RoundButton(sender); }
        private void btnRemove_Paint(object sender, PaintEventArgs e) { RoundButton(sender); }
        private void btnCancel_Paint(object sender, PaintEventArgs e) { RoundButton(sender); }
        private void btnSave_Paint(object sender, PaintEventArgs e) { RoundButton(sender); }

        private void RoundButton(object sender)
        {
            Button btn = (Button)sender;
            int radius = 20;
            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();
                path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
                path.AddArc(new Rectangle(btn.Width - radius, 0, radius, radius), 270, 90);
                path.AddArc(new Rectangle(btn.Width - radius, btn.Height - radius, radius, radius), 0, 90);
                path.AddArc(new Rectangle(0, btn.Height - radius, radius, radius), 90, 90);
                path.CloseFigure();
                btn.Region = new Region(path);
            }
        }
        #endregion
    }
}
