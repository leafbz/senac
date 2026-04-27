using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xdd
{
    public partial class frmPrincipal : Form
    {
        public static frmPrincipal PrincipalInstance;
        public frmPrincipal()
        {
            InitializeComponent();
            PrincipalInstance = this;
            //this.SetStyle(ControlStyles.ResizeRedraw, true);
            //this.DoubleBuffered = true;
            //this.MaximizedBounds=Screen.FromHandle(this.Handle).WorkingArea;
            //this.Text = string.Empty;
            //this.ControlBox = false;
            AbrirForm<Book>();
        }

        public void AbrirForm<MeuForm>() where MeuForm : Form, new()
        {
            Form form;
            form = panelForms.Controls.OfType<MeuForm>().FirstOrDefault();
            if (form == null)
            {
                form = new MeuForm();
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                panelForms.Controls.Clear();
                panelForms.Controls.Add(form);
                panelForms.Tag = form;
                form.Show();
                form.BringToFront();
            }
            else
            {
                form.BringToFront();
            }
        }
        public static int parentX, parentY;
        private void Btn_Click(object sender, EventArgs e)
        {
            foreach (var pnl in tableLayoutPanel1.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.FromArgb(1, 38, 10);

            }
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnBooks":
                    AbrirForm<Book>();
                    panelBook.BackColor = Color.FromArgb(166, 78, 27);
                    break;
                case "btnBundles":
                    AbrirForm<frmBundle>();
                    panelBundle.BackColor = Color.FromArgb(166, 78, 27);
                    break;
                case "btnAdd":
                    Form modalBackground = new Form();
                    using (ModalAdd modal = new ModalAdd())
                    {
                        modalBackground.StartPosition = FormStartPosition.Manual;
                        modalBackground.FormBorderStyle = FormBorderStyle.None;
                        modalBackground.Opacity = .10d;
                        modalBackground.BackColor = Color.Black;
                        modalBackground.Size = this.Size;
                        modalBackground.Location = this.Location;
                        modalBackground.ShowInTaskbar = false;
                        modalBackground.Show();
                        modal.Owner = modalBackground;

                        parentX = this.Location.X;
                        parentY = this.Location.Y;

                        modal.ShowDialog();
                        modalBackground.Dispose();
                        panelAdd.BackColor = Color.FromArgb(166, 78, 27);
                    }
                    break;
                case "btnArchive":
                    AbrirForm<frmArchive>();
                    panelArchive.BackColor = Color.FromArgb(166, 78, 27);
                    break;
                case "btnUser":
                    AbrirForm<frmRegistration>();
                    panelUser.BackColor = Color.FromArgb(166, 78, 27);
                    break;
            }
        }
    }
}
