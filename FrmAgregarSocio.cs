using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryIEFIMartinez
{
    public partial class FrmAgregarSocio : Form
    {
        public FrmAgregarSocio()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAgregarSocio_Load(object sender, EventArgs e)
        {
            ClsBarrio B = new ClsBarrio();
            B.Listar(LstBarrio);
            ClsActividad A = new ClsActividad();
            A.Listar(LstActividad);
            
            
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            if (TxtDNI.Text != "" && TxtNombreApellido.Text != "" && TxtDireccion.Text != "" && TxtSaldo.Text != "")
                BtnCargar.Enabled = true;
                ClsSocio Sos = new ClsSocio();
                Sos.Nombre = TxtNombreApellido.Text;
                Sos.IdCliente = Convert.ToInt32(TxtDNI.Text);
                Sos.IdBarrio = Convert.ToInt32(LstBarrio.SelectedValue);
                Sos.IdBIdActividad = Convert.ToInt32(LstActividad.SelectedValue);
                Sos.Direccion = TxtDireccion.Text;
                Sos.Saldo = Convert.ToDecimal(TxtSaldo.Text);
                Sos.Agregar();
                MessageBox.Show("Datos grabados!!!");
                TxtNombreApellido.Text = "";
                TxtDNI.Text = "";
                LstBarrio.SelectedIndex = 0;
                LstBarrio.SelectedIndex = 0;
        }
    }
}
