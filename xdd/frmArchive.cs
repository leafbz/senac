using MySql.Data.MySqlClient;
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
    public partial class frmArchive : Form
    {
        public frmArchive()
        {
            InitializeComponent();
        }

        private void frmArchive_Load(object sender, EventArgs e)
        {
            LoadArchive();
            ConfigureGrid();
        }

        private void LoadArchive()
        {
            string query = @"
                SELECT
                    b.book_id AS EntityId,
                    bt.title AS Title,
                    bt.author AS Author,
                    bt.iSBN AS ISBN,
                    b.book_status AS Status,
                    b.book_condition AS BookCondition,
                    b.price AS Price,
                    'Book Copy' AS ArchiveType
                FROM book b
                INNER JOIN book_titles bt
                    ON b.title_id_in_book = bt.title_id
                WHERE b.book_status IN ('UNAVAILABLE', 'SOLD')

                UNION ALL

                SELECT
                    bt.title_id AS EntityId,
                    bt.title AS Title,
                    bt.author AS Author,
                    bt.iSBN AS ISBN,
                    'NO COPIES' AS Status,
                    NULL AS BookCondition,
                    NULL AS Price,
                    'Book Title Without Copies' AS ArchiveType
                FROM book_titles bt
                LEFT JOIN book b
                    ON bt.title_id = b.title_id_in_book
                WHERE b.book_id IS NULL

                ORDER BY ArchiveType, Title;
            ";

            try
            {
                using (var conn = Db.GetConnection())
                using (var da = new MySqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvArchive.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading archive:\n" + ex.Message,
                    "Archive Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private ClassBook GetBookTitleById(string titleId)
        {
            string query = @"
        SELECT
            title_id,
            title,
            author,
            iSBN,
            pages,
            book_type,
            book_approx_weight,
            publisher,
            publication_year,
            book_language,
            genre,
            book_description,
            book_image
        FROM book_titles
        WHERE title_id = @title_id
        LIMIT 1;";

            using (var conn = Db.GetConnection())
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@title_id", titleId);

                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new ClassBook
                        {
                            BookId = null,

                            TitleId = reader["title_id"].ToString(),

                            Title = reader["title"].ToString(),
                            Author = reader["author"].ToString(),
                            ISBN = reader["iSBN"].ToString(),

                            Pages = Convert.ToInt32(reader["pages"]),

                            BookType = reader["book_type"].ToString(),

                            ApproxWeight =
                                Convert.ToDecimal(reader["book_approx_weight"]),

                            Publisher = reader["publisher"].ToString(),

                            PublicationYear =
                                Convert.ToInt32(reader["publication_year"]),

                            Language = reader["book_language"].ToString(),

                            Genre = reader["genre"].ToString(),

                            Description =
                                reader["book_description"].ToString(),

                            ImageBytes =
                                reader["book_image"] == DBNull.Value
                                ? null
                                : (byte[])reader["book_image"]
                        };
                    }
                }
            }

            return null;
        }

        private void ConfigureGrid()
        {
            dgvArchive.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvArchive.ReadOnly = true;

            dgvArchive.AllowUserToAddRows = false;
            dgvArchive.AllowUserToDeleteRows = false;

            dgvArchive.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArchive.MultiSelect = false;

            dgvArchive.RowHeadersVisible = false;

            dgvArchive.BackgroundColor = Color.White;
            dgvArchive.BorderStyle = BorderStyle.None;

            dgvArchive.DefaultCellStyle.SelectionBackColor = Color.FromArgb(45, 45, 48);
            dgvArchive.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvArchive.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvArchive.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvArchive.EnableHeadersVisualStyles = false;

            dgvArchive.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(30, 30, 30);

            dgvArchive.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvArchive.CellDoubleClick -= dgvArchive_CellDoubleClick;
            dgvArchive.CellDoubleClick += dgvArchive_CellDoubleClick;
        }

        private void dgvArchive_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string archiveType =
                dgvArchive.Rows[e.RowIndex]
                .Cells["ArchiveType"]
                .Value
                .ToString();

            string entityId =
                dgvArchive.Rows[e.RowIndex]
                .Cells["EntityId"]
                .Value
                .ToString();

            // Only for titles without copies
            if (archiveType == "Book Title Without Copies")
            {
                ContextMenuStrip menu = new ContextMenuStrip();

                // Add Copy

                menu.Items.Add("Add Copy", null, (s, ev) =>
                {
                    ClassBook titleOnlyBook =
                        GetBookTitleById(entityId);

                    if (titleOnlyBook != null)
                    {
                        frmAddBook frm =
                            new frmAddBook(
                                titleOnlyBook,
                                BookFormMode.AddCopy
                            );

                        frm.ShowDialog();

                        LoadArchive();
                    }
                });

                // Delete Title

                menu.Items.Add("Delete Title", null, (s, ev) =>
                {
                    DeleteBookTitle(entityId);
                });

                menu.Show(Cursor.Position);
            }
        }
        private void DeleteBookTitle(string titleId)
        {
            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();

                    // Safety Check

                    string checkQuery = @"
                SELECT COUNT(*)
                FROM book
                WHERE title_id_in_book = @title_id";

                    using (var checkCmd =
                        new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue(
                            "@title_id",
                            titleId
                        );

                        int count =
                            Convert.ToInt32(
                                checkCmd.ExecuteScalar()
                            );

                        if (count > 0)
                        {
                            MessageBox.Show(
                                "Cannot delete title because books still exist."
                            );

                            return;
                        }
                    }

                    // Confirmation

                    DialogResult result = MessageBox.Show(
                        "Delete this book title permanently?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result != DialogResult.Yes)
                        return;

                    // Delete

                    string deleteQuery = @"
                DELETE FROM book_titles
                WHERE title_id = @title_id";

                    using (var deleteCmd =
                        new MySqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue(
                            "@title_id",
                            titleId
                        );

                        deleteCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Book title deleted successfully."
                    );

                    // Refresh archive
                    LoadArchive();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error deleting title:\n" + ex.Message
                );
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadArchive();
        }
    }
}