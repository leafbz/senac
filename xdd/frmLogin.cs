using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xdd
{
    public partial class frmLogin : Form
    {
       bool VisiblePassword = false;

        private static bool SlowEquals(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
                return false;

            int diff = 0;
            for (int i = 0; i < a.Length; i++)
            {
                diff |= a[i] ^ b[i];
            }

            return diff == 0;
        }
        public static string HashPassword(string password)
        {
            int iterations = 100_000;

            byte[] salt = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            var pbkdf2 = new Rfc2898DeriveBytes(
                password,
                salt,
                iterations,
                HashAlgorithmName.SHA256
            );

            byte[] hash = pbkdf2.GetBytes(32);

            return $"{iterations}.{Convert.ToBase64String(salt)}.{Convert.ToBase64String(hash)}";
        }


        public static class Sessao
        {
            public static int User_Id { get; set; }
            public static string Used_Name { get; set; }
            public static string User_Role { get; set; }
        }


        public static bool VerifyPassword(string password, string storedHash)
        {
            var parts = storedHash.Split('.');
            int iterations = int.Parse(parts[0]);
            byte[] salt = Convert.FromBase64String(parts[1]);
            byte[] storedHashBytes = Convert.FromBase64String(parts[2]);

            var pbkdf2 = new Rfc2898DeriveBytes(
                password,
                salt,
                iterations,
                HashAlgorithmName.SHA256
            );

            byte[] computedHash = pbkdf2.GetBytes(32);

            return SlowEquals(storedHashBytes, computedHash);
        }

        public frmLogin()
        {
            InitializeComponent();

            txtPassword.Text = "Password";
            txtPassword.UseSystemPasswordChar = false;

        }

        string data_source = "datasource=localhost; username=root; password=; database=ninelivebooks";

        private void btnEnter_Click(object sender, EventArgs e)
        {

            {
                string login = txtLogin.Text.Trim();
                string password = txtPassword.Text;

                if (txtLogin.Text == "Login" || string.IsNullOrWhiteSpace(txtLogin.Text))
                {
                    MessageBox.Show("Please enter your username or email.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (txtPassword.Text == "Password" || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please enter your password.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }


                string storedHash = null;
                int user_Id = 0;
                string user_Name = null;
                string user_Role = null;


                using (MySqlConnection conn = new MySqlConnection(data_source))

                {
                    conn.Open();


                    MySqlCommand cmd = new MySqlCommand(
                        @"SELECT user_id, user_name, user_role, user_password_hash FROM usuario WHERE user_email = @login OR user_name = @login",
                        conn
                    );

                    cmd.Parameters.AddWithValue("@login", txtLogin.Text.Trim());


                    using (var reader = cmd.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            user_Id = reader.GetInt32("user_id");
                            user_Name = reader.GetString("user_name");
                            storedHash = reader.GetString("user_password_hash");
                            user_Role = reader.GetString("user_role");
                        }

                    }

                    if (VerifyPassword(password, storedHash))
                    {

                        Sessao.User_Id = user_Id;
                        Sessao.Used_Name = user_Name;
                        Sessao.User_Role = user_Role;

                        frmPrincipal form = new frmPrincipal();
                        form.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("The username or password is incorrect.");
                    }
                }
            }
        }
        //private void lblRedefinir_Click(object sender, EventArgs e)
        //{
        //    frmResetPassword form = new frmResetPassword();
        //    form.Show();
        //    this.Hide();

        //}

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;

            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password";

            }
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            if (txtLogin.Text == "User or E-mail")
            {
                txtLogin.Text = "";

            }
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                txtLogin.Text = "User or E-mail";
            }
        }

        private void picVerSenhaLogin_Click(object sender, EventArgs e)
        {

            if (VisiblePassword)
            {
                txtPassword.UseSystemPasswordChar = true;
                picVerSenhaLogin.Image = Properties.Resources.naovisivel;
                VisiblePassword = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
                picVerSenhaLogin.Image = Properties.Resources.visivel;
                VisiblePassword = true;
            }
        }
    }
}