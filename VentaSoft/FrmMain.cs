using ModuloEntidades;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Store;

namespace Main
{
    public partial class FrmMain : Form
    {
        private static Entidad_Usuario UserActual;
        private static Entidad_Usuario Rol;

        private static UISymbolButton Usuario = null;
        public FrmMain(Entidad_Usuario O_user)
        {
            UserActual = O_user;
            Rol = O_user;

            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            MostrarFormularios(new FrmProducts());

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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (PanelMenu.Width == 190)
            {
                PanelMenu.Width = 45;
            }
            else
            {
                PanelMenu.Width = 190;
            }
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            if (submenuCompras.Height == 50)
            {
                submenuCompras.Height = 100;
            }
            else
            {
                submenuCompras.Height = 50;
            }
            MostrarFormularios(new FrmPurchase(UserActual)); //se le pasa el usuario que está comprando
        }

        /*BOTON MENU DE VENTAS*/
        private void FrmSales_Click(object sender, EventArgs e)
        {


            if (SubmenuVentas.Height == 50)
            {
                SubmenuVentas.Height = 100;
            }
            else
            {
                SubmenuVentas.Height = 50;
            }

            MostrarFormularios(new FrmSales(UserActual));
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {

            if (SubMenuReports.Height == 40)
            {
                SubMenuReports.Height = 120;
            }
            else
            {
                SubMenuReports.Height = 40;
            }
        }

        private void nightControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void Btndetallecompras_Click(object sender, EventArgs e)
        {
            MostrarFormularios(new Frm_DetalleCompra());

        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            MostrarFormularios(new FrmClientes());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            MostrarFormularios(new FrmCategory());

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            MostrarFormularios(new Frm_Users());

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            MostrarFormularios(new Frm_Proveedor());

        }

        private void Header_Paint(object sender, PaintEventArgs e)
        {
            lblUsuario.Text = UserActual.Nombre1;
            lblRol.Text = UserActual.oRol.Descripcion;
        }

        /*BOTON DE SUBMENU DE VENTAS*/
        private void btnDetallesVentas_Click(object sender, EventArgs e)
        {
            MostrarFormularios(new FrmDetallesVentas());
        }

        private void uiSymbolButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MostrarFormularios(new Dashboard());
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnReporteCompra_Click_1(object sender, EventArgs e)
        {
            MostrarFormularios(new FrmReporteCompra());

        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            MostrarFormularios(new FrmReporteVenta());
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            List<Entidad_Permiso> Permisos = new S_Permises().Lister(UserActual.IdUsuario);

            AplicarPermisos(Permisos);
        }
        private void AplicarPermisos(List<Entidad_Permiso> permisos)
        {
            var mapa = new Dictionary<string, Control>
    {
        { "MenuClientes",    panel5 },
        { "MenuCategory",    panel3 },
        { "MenuProducto",    panel4 },
        { "MenuEmpleados",   panel8 },
        { "MenuProveedores", panel9 },
        { "MenuCompras",     submenuCompras },
        { "MenuVentas",      SubmenuVentas },
        { "MenuReportes",    SubMenuReports },
        { "MenuAbout",       panel15 },
    };

            foreach (var item in mapa)
            {
                item.Value.Visible = permisos.Any(p =>
                    string.Equals(p.NombreMenu, item.Key, StringComparison.OrdinalIgnoreCase));
            }
        }
    }
}
