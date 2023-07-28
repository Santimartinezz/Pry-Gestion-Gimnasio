using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryIEFIMartinez
{
    public partial class FrmConsultaSocio : Form
    {
        public FrmConsultaSocio()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ClsSocio nombre = new ClsSocio();
            nombre.CosultaSocio(Convert.ToInt32(CmbNombres.SelectedValue));
            Int32 DNI = nombre.IdCliente;
            LblMuestraDNI.Text = Convert.ToString(DNI);
            LblMuestraDireccion.Text = nombre.Direccion;
            
            LblMuestraActividad.Text = nombre.IdBIdActividad.ToString();
            LblMuestraSaldo.Text = nombre.Saldo.ToString();

            ClsBarrio Barrio = new ClsBarrio();
            Barrio.llenarBarrio(LblMuestraBarrio, nombre.IdBarrio);

            ClsActividad Actividad = new ClsActividad();
            Actividad.llenarActividad(LblMuestraActividad, nombre.IdBIdActividad);
        }

        private void FrmConsultaSocio_Load(object sender, EventArgs e)
        {
            ClsSocio x = new ClsSocio();
            x.Listar(CmbNombres);
        }

        private void CmbNombres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
