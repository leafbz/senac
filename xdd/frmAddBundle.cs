using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            public string Id_Book { get; set; }
            private string Bundle_id { get; set; }
            public decimal ApproxWeight { get; set; }
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
            lstBook.AllowColumnReorder = false;
            lstBook.FullRowSelect = true;
            lstBook.GridLines = true;
            lstBook.HideSelection = false;
            lstBook.OwnerDraw = true;
            lstBook.HoverSelection = false;
            lstBook.Activation = ItemActivation.Standard;
            lstBook.ColumnWidthChanging += (s, e) =>
            {
                e.Cancel = true;
                e.NewWidth = lstBook.Columns[e.ColumnIndex].Width;
            };

            lstBookBundle.View = View.Details;

            lstBookBundle.MultiSelect = true;
            lstBookBundle.AllowColumnReorder = false;
            lstBookBundle.FullRowSelect = true;
            lstBookBundle.HideSelection = false;
            lstBookBundle.GridLines = true;
            lstBookBundle.OwnerDraw = true;
            lstBookBundle.HoverSelection = false;
            lstBookBundle.Activation = ItemActivation.Standard;
            lstBookBundle.Activation = ItemActivation.Standard;
            lstBookBundle.ColumnWidthChanging += (s, e) =>
            {
                e.Cancel = true;
                e.NewWidth = lstBook.Columns[e.ColumnIndex].Width;
            };


            lstBook.Columns.Add("ID", 126, HorizontalAlignment.Left);
            lstBook.Columns.Add("Title", 250, HorizontalAlignment.Left);
            lstBook.Columns.Add("Author", 170, HorizontalAlignment.Left);
            lstBook.Columns.Add("Condition", 135, HorizontalAlignment.Left);
            lstBook.Columns.Add("Price", 115, HorizontalAlignment.Left);

            lstBookBundle.Columns.Add("ID", 126, HorizontalAlignment.Left);
            lstBookBundle.Columns.Add("Title", 220, HorizontalAlignment.Left);
            lstBookBundle.Columns.Add("Author", 160, HorizontalAlignment.Left);
            lstBookBundle.Columns.Add("Price", 115, HorizontalAlignment.Left);


            lstBook.DrawColumnHeader += lstBook_DrawColumnHeader;
            lstBook.DrawItem += lstBook_DrawItem;
            lstBook.DrawSubItem += lstBook_DrawSubItem;

            lstBookBundle.DrawColumnHeader += lstBookBundle_DrawColumnHeader;
            lstBookBundle.DrawItem += lstBookBundle_DrawItem;
            lstBookBundle.DrawSubItem += lstBookBundle_DrawSubItem;


            this.Load += frmAddBundle_Load;
        }
        private string GenerateNextBundleId()
        {
            string query = @"
                SELECT MAX(CAST(SUBSTRING(bundle_id, 4) AS UNSIGNED))
                FROM bundle
                WHERE bundle_id LIKE 'NLB%'";


            using (var conn = Db.GetConnection())
            using (var cmd = new MySqlCommand(query, conn))
            {
                conn.Open();

                object result = cmd.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                    return "NLB0001";

                int number = Convert.ToInt32(result) + 1;
                return "NLB" + number.ToString("D4");
            }
        }

        private void frmAddBundle_Load(object sender, EventArgs e)
        {
            BuscarLivrosDoBanco();
            CarregarLivrosBanco();

        }
        private void BuscarLivrosDoBanco()
        {
            livrosDisponiveis.Clear();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(data_source))
                {
                    conn.Open();

                    string sql = @"
                SELECT 
                    bt.title_id,
                    b.price,
                    b.book_condition,
                    bt.title,
                    bt.book_approx_weight,
                    bt.author
                FROM book b
                LEFT JOIN book_titles bt
                    ON b.title_id_in_book = bt.title_id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        
                        decimal price = 0;

                        
                        decimal.TryParse(
                            reader["price"]?.ToString()?.Replace(",", "."),
                            NumberStyles.Any,
                            CultureInfo.InvariantCulture,
                            out price
                        );

                        Livro livro = new Livro
                        {
                            Id_Book = reader["title_id"]?.ToString() ?? "",
                            Title = reader["title"]?.ToString() ?? "",
                            Author = reader["author"]?.ToString() ?? "",
                            Condition = reader["book_condition"]?.ToString() ?? "",
                            ApproxWeight = Convert.ToDecimal(reader["book_approx_weight"]),
                            Price = price
                        };

                        livrosDisponiveis.Add(livro);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "ERROR:" + ex.Message,
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void CarregarLivrosBanco()
        {
            lstBook.Items.Clear();

            foreach (var livro in livrosDisponiveis)
            {
                ListViewItem item = new ListViewItem(livro.Id_Book);
                item.SubItems.Add(livro.Title);
                item.SubItems.Add(livro.Author);
                item.SubItems.Add(livro.Condition);
                item.SubItems.Add(livro.Price.ToString("C"));
                item.Tag = livro;

                lstBook.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstBook.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select a book.");
                return;
            }

            foreach (ListViewItem item in lstBook.SelectedItems)
            {
                Livro livro = (Livro)item.Tag;

                if (livrosDoGrupo.Any(l => l.Id_Book == livro.Id_Book))
                    continue;

                livrosDoGrupo.Add(livro);
            }
            UpdateBundleWeight();
            CarregarLivrosGrupo();
        }
        private void CarregarLivrosGrupo()
        {
            lstBookBundle.Items.Clear();

            foreach (var livro in livrosDoGrupo)
            {
                ListViewItem item = new ListViewItem(livro.Id_Book.ToString());
                item.SubItems.Add(livro.Title);
                item.SubItems.Add(livro.Author);
                item.SubItems.Add(livro.Price.ToString("C"));

                item.Tag = livro;

                lstBookBundle.Items.Add(item);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pesquisarLivros();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length >= 2)
                btnSearch.PerformClick();
        }


        private void pesquisarLivros()
        {
            livrosDisponiveis.Clear();

            string sql = @" SELECT  
            bt.title_id,
            b.price,
            b.book_condition,
            bt.title,
            bt.author
        FROM book b
        INNER JOIN book_titles bt ON b.title_id_in_book = bt.title_id WHERE bt.title LIKE @q OR bt.author LIKE @q OR bt.title_id LIKE @q ORDER BY bt.title ASC";
            ;

            using (MySqlConnection conn = new MySqlConnection(data_source))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@q", "%" + txtSearch.Text.Trim() + "%");

                try
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Livro livro = new Livro
                            {
                                Id_Book = reader["title_id"].ToString(),
                                Title = reader["title"].ToString(),
                                Author = reader["author"].ToString(),
                                Condition = reader["book_condition"].ToString(),
                                Price = Convert.ToDecimal(reader["price"]),
                                

                            };

                            livrosDisponiveis.Add(livro);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error ");
                }

                finally
                {

                    if (Conn != null && Conn.State == ConnectionState.Open)
                    {
                        Conn.Close();
                    }

                }
                CarregarLivrosBanco();

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (lstBookBundle.SelectedItems.Count == 0)
                return;

            foreach (ListViewItem item in lstBookBundle.SelectedItems)
            {
                Livro livro = (Livro)item.Tag;
                livrosDoGrupo.Remove(livro);
            }
            UpdateBundleWeight();
            CarregarLivrosGrupo();
        }
        private void clear_itens()
        {
            txtBundleName.Text = string.Empty;
            txtTheme.Text = "";
            cbStatus.Text = null;
            txtDescription.Text = "";
            picImage.Image = null;
            numPrice.Text = "0.00";
            txtWeight.Text = "0.0 g";
            livrosDoGrupo.Clear();
            txtBundleName.Focus();
            UpdateBundleWeight();
            CarregarLivrosGrupo();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear_itens();
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    picImage.Image = new Bitmap(dlg.FileName);
                }
            }
        }
        private byte[] GetImageBytesFromPictureBox()
        {
            if (picImage.Image == null)
                return null;

            using (MemoryStream ms = new MemoryStream())
            {
                picImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void LoadImageFromReader(MySqlDataReader reader)
        {
            if (reader["bundle_image"] != DBNull.Value)
            {
                byte[] imageBytes = (byte[])reader["bundle_image"];

                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    picImage.Image = System.Drawing.Image.FromStream(new MemoryStream(ms.ToArray()));
                }
            }
        }

        private void btnClearImg_Click(object sender, EventArgs e)
        {
            picImage.Image = null;
        }

        private void BtnSaveBundle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBundleName.Text.Trim()) || string.IsNullOrEmpty(numPrice.Text.Trim()) || string.IsNullOrEmpty(cbStatus.Text.Trim()) ||
                    string.IsNullOrEmpty(txtWeight.Text.Trim()))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (lstBookBundle.Items.Count == 0)
                {
                    MessageBox.Show("Add books to bundle.");
                    return;
                }

                string idBundle = SalvarBundle();
                SalvarLivrosDoBundle(idBundle);

                MessageBox.Show("Bundle salvo com sucesso!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"An error has occurred. Please try again. + {ex.Number} : {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string SalvarBundle()
        {
            string bundleId = GenerateNextBundleId();

            using (MySqlConnection conn = new MySqlConnection(data_source))
            {
                conn.Open();

                string sql = @"
            INSERT INTO bundle 
            (bundle_id, bundle_name, bundle_status, bundle_theme, 
             bundle_price, bundle_approx_weight, bundle_description, 
             bundle_image, bundle_created_at)
            VALUES 
            (@bundle_id, @bundle_name, @bundle_status, @bundle_theme,
             @bundle_price, @bundle_approx_weight, @bundle_description,
             @bundle_image, NOW());
        ";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@bundle_id", bundleId);
                    cmd.Parameters.AddWithValue("@bundle_name", txtBundleName.Text.Trim());
                    cmd.Parameters.AddWithValue("@bundle_status", cbStatus.Text.Trim());
                    cmd.Parameters.AddWithValue("@bundle_theme", txtTheme.Text.Trim());
                    cmd.Parameters.AddWithValue("@bundle_price", decimal.Parse(numPrice.Text));
                    cmd.Parameters.AddWithValue("@bundle_approx_weight", GetBundleTotalWeight());
                    cmd.Parameters.AddWithValue("@bundle_description", txtDescription.Text.Trim());
                    cmd.Parameters.AddWithValue("@bundle_image", GetImageBytesFromPictureBox());

                    cmd.ExecuteNonQuery();
                }
            }
            return bundleId;
        }
        private void SalvarLivrosDoBundle(string idBundle)
        {

            using (MySqlConnection conn = new MySqlConnection(data_source))
            {
                conn.Open();

                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        foreach (ListViewItem item in lstBookBundle.Items)
                        {
                            Livro livro = (Livro)item.Tag;

                            string sql = @"
                        INSERT INTO bundle_book (bundle_id_in_bundle_book, title_id_in_bundle_book)
                        VALUES (@bundle_id, @title_id)";

                            using (MySqlCommand cmd = new MySqlCommand(sql, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@bundle_id", idBundle);
                                cmd.Parameters.AddWithValue("@title_id", livro.Id_Book);

                                cmd.ExecuteNonQuery();
                            }
                        }

                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }
        private void UpdateBundleWeight()
        {
            decimal totalWeight = 0;

            foreach (Livro livro in livrosDoGrupo)
            {
                totalWeight += livro.ApproxWeight;
            }
            txtWeight.Text = totalWeight.ToString("0.0 g", CultureInfo.InvariantCulture);

        }
    
        private decimal GetBundleTotalWeight()
        {
            decimal total = 0;

            foreach (Livro livro in livrosDoGrupo)
                total += livro.ApproxWeight;

            return total;
        }
    }
}

