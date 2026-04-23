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

        //#region Funcionalidades do form
        //private int tolerance = 12;
        //private const int WM_NCHITTEST = 132;
        //private const int HTBOTTOMRIGHT = 17;
        //private Rectangle sizeGripRectangle;

        //protected override void WndProc(ref Message m)
        //{
        //    switch (m.Msg)
        //    {
        //        case WM_NCHITTEST:
        //            base.WndProc(ref m);
        //            var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
        //            if (sizeGripRectangle.Contains(hitPoint))
        //            {
        //                m.Result = new IntPtr(HTBOTTOMRIGHT);
        //            }
        //            break;
        //        default:
        //            base.WndProc(ref m);
        //            break;
        //    }
        //}
        //protected override void OnSizeChanged(EventArgs e)
        //{
        //    base.OnSizeChanged(e);
        //    var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

        //    sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

        //    region.Exclude(sizeGripRectangle);
        //    this.panelContainer.Region = region;
        //    this.Invalidate();
        //}
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
        //    e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);


        //    base.OnPaint(e);
        //    ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        //}

        //private void btnFechar_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}
        //int lx, ly;
        //int sw, sh;
        //private void btnMaximizar_Click(object sender, EventArgs e)
        //{
        //    lx = this.Location.X;
        //    ly = this.Location.Y;
        //    sw = this.Size.Width;
        //    sh = this.Size.Height;
        //    btnMaximizar.Visible = false;
        //    btnJanela.Visible = true;
        //    this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        //    this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        //}

        //private void btnJanela_Click(object sender, EventArgs e)
        //{
        //    btnMaximizar.Visible = true;
        //    btnJanela.Visible = false;
        //    this.Size = new Size(sw, sh);
        //    this.Location = new Point(lx, ly);
        //}

        //private void btnMinimizar_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Minimized;
        //}

        //private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        //{
        //    ReleaseCapture();
        //    SendMessage(this.Handle, 0x112, 0xf012, 0);
        //}

        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();
        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //#endregion 

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
