using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryIEFIMartinez
{
    public partial class FrmBusquedaSocios : Form
    {
        public FrmBusquedaSocios()
        {
            InitializeComponent();
        }


        private void limpiar()
        {
            TxtCodigoCliente.Text = "";
            TxtNombre.Text = "";
            TxtDireccion.Text = "";
            TxtSaldo.Text = "";
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;
            BtnGuardar.Enabled = false;
        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Int32 id = Convert.ToInt32(TxtCodigoCliente.Text);
            ClsSocio cli = new ClsSocio();
            cli.Nombre = TxtNombre.Text;    
            cli.Direccion = TxtDireccion.Text;
            cli.IdBarrio = Convert.ToInt32(CmbBarrio.SelectedValue);
            cli.IdBIdActividad = Convert.ToInt32(CmbActividad.SelectedValue);
            cli.Saldo = Convert.ToDecimal(TxtSaldo.Text);
            cli.Modificar(Convert.ToInt32(id));
            MessageBox.Show("Dato grabado exitosamente!!!");
            limpiar();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = false;
            BtnModificar.Enabled = false;
            BtnGuardar.Enabled = true;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            
               Int32 id = Convert.ToInt32(TxtCodigoCliente.Text);
               ClsSocio cli = new ClsSocio();
               cli.Eliminar(id);
               MessageBox.Show("Dato eliminado exitosamente!!!");
               limpiar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Int32 IdCliente = Convert.ToInt32(TxtCodigoCliente.Text);
            ClsSocio x = new ClsSocio();
            x.Buscar(IdCliente);
            if (x.IdCliente != 0)
            {
                TxtNombre.Text = x.Nombre;
                TxtSaldo.Text = x.Saldo.ToString();
                TxtDireccion.Text = x.Direccion.ToString();
                CmbBarrio.SelectedValue = Convert.ToString(x.IdBarrio);
                CmbActividad.SelectedValue = Convert.ToString(x.IdBIdActividad);
                BtnModificar.Enabled = true;
                BtnEliminar.Enabled = true;
            }
            else
            {
                limpiar();
                MessageBox.Show("Dato no encontrado!!!");
            }
        }

        private void FrmBusquedaSocios_Load(object sender, EventArgs e)
        {
            limpiar();
            ClsBarrio ObjBarrio = new ClsBarrio();
            ObjBarrio.Listar(CmbBarrio);
            ClsActividad ObjActividad = new ClsActividad();
            ObjActividad.Listar(CmbActividad);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
