using Main.Utilities;
using ModuloEntidades;
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
    public partial class Frm_Users : Form
    {
        public Frm_Users()
        {
            InitializeComponent();
        }

        private void Frm_Users_Load(object sender, EventArgs e)
        {
            cbEstado.Items.Add(new OptionsComboBox() { valor = 1 , texto = "Activo"} );
            cbEstado.Items.Add(new OptionsComboBox() { valor = 0 , texto = "No Activo" });
            cbEstado.ValueMember = "valor";
            cbEstado.DisplayMember = "texto";
            cbEstado.SelectedIndex = 0;


            List <Entidad_Rol> listRol = new S_Rol().Lister();


            foreach (Entidad_Rol item in listRol) {
                cbRol.Items.Add(new OptionsComboBox() { valor = item.IdRol, texto = item.Descripcion });
            }
             cbRol.ValueMember = "valor";
            cbRol.DisplayMember = "texto";
            cbRol.SelectedIndex = 0;


        }
    }
}
