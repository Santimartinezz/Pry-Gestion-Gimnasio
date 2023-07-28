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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarSocio Agregar = new FrmAgregarSocio();
            Agregar.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoSocios ventana = new FrmListadoSocios();
            ventana.ShowDialog();

        }

        private void buscarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBusquedaSocios Busqueda = new FrmBusquedaSocios();
            Busqueda.ShowDialog();
        }

        private void listadoDeSociosDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientesDeudores clientesDeudores = new FrmClientesDeudores();
            clientesDeudores.ShowDialog();
        }

        private void listadoDeSociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoSociosPorBarrio sociosPorBarrio = new FrmListadoSociosPorBarrio();
            sociosPorBarrio.ShowDialog();
        }

        private void consultaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaSocio consultaSocio = new FrmConsultaSocio();
            consultaSocio.ShowDialog();
        }

        private void listadoDeSociosPorActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoPorActividad actividad = new FrmListadoPorActividad();
            actividad.ShowDialog();
        }

        private void acercaDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercaDelSistema Sistema = new FrmAcercaDelSistema();
            Sistema.ShowDialog();
        }
    }
}
