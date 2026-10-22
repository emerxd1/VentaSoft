using Main.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Main
{
    public partial class FrmSales : Form
    {
        public FrmSales()
        {
            InitializeComponent();
        }

        private void FrmFrmSales_Load(object sender, EventArgs e)
        {
            DgvData.Columns["BtnEliminar"].Tag = ColorearIcono(Properties.Resources.borrar__1_, Color.Red); //icono de eliminar
            CbTipodeDocumento.Items.Add(new OptionsComboBox() { valor = "Boleta", texto = "Boleta" });

            CbTipodeDocumento.Items.Add(new OptionsComboBox() { valor = "Factura", texto = "Factura" });
            CbTipodeDocumento.ValueMember = "valor";
            CbTipodeDocumento.DisplayMember = "texto";
            CbTipodeDocumento.SelectedIndex = 0;

            TxtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy"); //Mostrar la fecha actual

            TxtidProd.Text = "0";
            TxtidProv.Text = "0";
        }

        private void lblTituloGrupo1_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmSales_Load(object sender, EventArgs e)
        {

        }
    }
}
