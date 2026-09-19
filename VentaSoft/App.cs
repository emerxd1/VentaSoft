using ModuloEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using Store;
using Data;
using System.Linq;

namespace Main
{
    public partial class App : Form
    {
        private static Entidad_Usuario UserActual;
        public App(Entidad_Usuario O_user)
        {

            UserActual = O_user;
            InitializeComponent();

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 70)
            {
                panelMenu.Width = 250;
            }
            else
            {
                panelMenu.Width = 70;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show("¿Esta seguro que desea regresar al Login?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnRest.Visible = true;
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRest.Visible = false;
            btnMax.Visible = true;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnReports_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = !panelSubMenu.Visible;
        }

        private void btnReportVent_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
        }

        private void btnReporteShopping_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
        }

        private void MostrarFormularios(Form FormularioShow)
        {

            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);

            Form fH = FormularioShow;
            fH.TopLevel = false;
            fH.FormBorderStyle = FormBorderStyle.None;
            fH.BackColor = Color.White;
            fH.Anchor = (AnchorStyles)Top;
            this.PanelContenedor.Controls.Add(fH);   // 1. Primero se agrega al panel
            fH.Dock = DockStyle.Fill;                // 2. Luego se aplica el Dock
            this.PanelContenedor.Tag = fH;

            fH.BringToFront();                       // 3. Asegura que quede visible
            fH.Show();


        }
        private void btnProducts_Click(object sender, EventArgs e)

        {
            MostrarFormularios(new FrmCategory());

        }

        private void panelBarraUp_Paint(object sender, PaintEventArgs e)
        {
            lblUsuario.Text = UserActual.Nombre1;
        }


        private void App_Load(object sender, EventArgs e)
        {
            List<Entidad_Permiso> ListaPermiso = new S_Permises().Lister(UserActual.IdUsuario);

        }

        private void MenuClientes_Click(object sender, EventArgs e)
        {
            MostrarFormularios(new FrmClientes());
        }

        private void MenuEmpleados_Click(object sender, EventArgs e)
        {
            MostrarFormularios(new Frm_Users());
        }

        private void MenuVentas_Click(object sender, EventArgs e)
        {

        }

        private void MenuProducts_Click(object sender, EventArgs e)
        {
            MostrarFormularios(new FrmProducts());
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}




