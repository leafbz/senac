using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xdd
{
    public partial class frmPrincipal : Form
    {
        private Form current;
        public frmPrincipal()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        #region Funcionalidades do form
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                    {
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    }
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContainer.Region = region;
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);


            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int lx, ly;
        int sw, sh;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnJanela.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnJanela_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnJanela.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelForms.Controls.Clear();
            panelForms.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void OpenForm(Form form)
        {
            if (current != null)
            {
                current.Close();
            }
            current = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelForms.Controls.Add(form);
            panelForms.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void AbrirForm<MeuForm>() where MeuForm : Form, new()
        {
            Form form;
            form= panelForms.Controls.OfType<MeuForm>().FirstOrDefault();
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
                form.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                form.BringToFront();
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form2"]==null)
            {
                button1.BackColor = Color.FromArgb(1, 38, 10);
                button1.ForeColor = Color.FromArgb(242, 223, 167);
            }
            if (Application.OpenForms["Form3"] == null)
            {
                button2.BackColor = Color.FromArgb(1, 38, 10);
                button2.ForeColor = Color.FromArgb(242, 223, 167);
            }
            if (Application.OpenForms["Form4"] == null)
            {
                button3.BackColor = Color.FromArgb(1, 38, 10);
                button3.ForeColor = Color.FromArgb(242, 223, 167);
                button3.Image = Image.FromFile(@"C:\Users\rafael.rbrazao\Downloads\img\archive_24dp_2E4632_FILL0_wght400_GRAD0_opsz24.png");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirForm<Form2>();
            button1.BackColor = Color.FromArgb(166, 78, 27);
            button1.ForeColor = Color.FromArgb(1, 38, 10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirForm<Form3>();
            button2.BackColor = Color.FromArgb(166, 78, 27);
            button2.ForeColor = Color.FromArgb(1, 38, 10);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            UC_LIVRO uc = new UC_LIVRO();
            addUserControl(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirForm<Form4>();
            button3.BackColor = Color.FromArgb(166, 78, 27);
            button3.ForeColor = Color.FromArgb(1, 38, 10);
            button3.Image = Image.FromFile(@"C:\Users\rafael.rbrazao\Downloads\img\archive_24dp_D85C2C_FILL0_wght400_GRAD0_opsz24.png");
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            foreach (var pnl in tableLayoutPanel1.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.FromArgb(1, 38, 10);

            }
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnHome":
                    OpenForm(new frmPrincipal());
                    panelAdd.BackColor = Color.FromArgb(166, 78, 27);
                    break;
                case "btnAdd":
                    OpenForm(new Form2());
                    panelEdit.BackColor = Color.FromArgb(166, 78, 27);
                    break;
                case " btnEdit":
                    OpenForm(new Form3());
                    panelArchive.BackColor = Color.FromArgb(166, 78, 27);
                    break;
                case "btnArch":
                    OpenForm(new Form4());
                    panelDelete.BackColor = Color.FromArgb(166, 78, 27);
                    break;
                case "btnDelete":
                    AbrirForm<Form2>();
                    panelSold.BackColor = Color.FromArgb(166, 78, 27);
                    break;
            }
        }
    }
}
