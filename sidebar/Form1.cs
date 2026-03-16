using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sidebar
{
    public partial class Form1 : Form
    {
        private Boolean showPanelLivro = false;
        private Boolean showPanelBundle = false;
        private Boolean showPanelArquivado = false;
        private Boolean showPanelInventario = false;
        public Form1()
        {
            InitializeComponent();
            togglePanels();
            UCLIVRO uc = new UCLIVRO();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            foreach (var pnl in tableLayoutPanel1.Controls.OfType<Panel>())
            {
                pnl.BackColor = Color.Silver;

            }
            Button btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnAdd": 
                    addUserControl(new UCLIVRO());
                    panelAdd.BackColor = Color.DarkGreen;
                    break;
                case "btnEdit":
                    addUserControl(new UCLIVRO());
                    panelEdit.BackColor = Color.DarkGreen;
                    break;
                case "btnArch":
                    addUserControl(new UCLIVRO());
                    panelArchive.BackColor = Color.DarkGreen;
                    break;
                case "btnDelete":
                    addUserControl(new UCLIVRO());
                    panelDelete.BackColor = Color.DarkGreen;
                    break; 
                case "btnSold":
                    addUserControl(new UCLIVRO());
                    panelSold.BackColor = Color.DarkGreen;
                    break;
            }
        }
        private void btnLivros_Click(object sender, EventArgs e)
        {
            showPanelArquivado = false;
            showPanelBundle = false;
            showPanelInventario = false;
            showPanelLivro = !showPanelLivro;
            togglePanels();
            UCLIVRO uc = new UCLIVRO();
            addUserControl(uc);
        }

        private void togglePanels()
        {
            if (showPanelLivro)
            {
                panelLivros.Height = 90;
            }
            else
            {
                panelLivros.Height = 0;
            }
            if (showPanelBundle)
            {
                panelBundle.Height = 130;
            }
            else
            {
                panelBundle.Height = 0;
            }
            if (showPanelArquivado)
            {
                panelArquivo.Height = 60;
            }
            else
            {
                panelArquivo.Height = 0;
            }
            if (showPanelInventario)
            {
                panelInv.Height = 60;
            }
            else
            {
                panelInv.Height = 0;
            }
        }

        private void btnBundle_Click(object sender, EventArgs e)
        {
            showPanelArquivado = false;
            showPanelLivro = false;
            showPanelInventario = false;
            showPanelBundle = !showPanelBundle;
            togglePanels();
            UCBUNDLE uc = new UCBUNDLE();
            addUserControl (uc);
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            showPanelInventario = false;
            showPanelBundle = false;
            showPanelLivro = false;
            showPanelArquivado = !showPanelArquivado;
            togglePanels();
            UCARCHIVE uc = new UCARCHIVE();
            addUserControl(uc);
        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            showPanelArquivado = false;
            showPanelBundle = false;
            showPanelLivro = false;
            showPanelInventario = !showPanelInventario;
            togglePanels();
        }
    }
}
