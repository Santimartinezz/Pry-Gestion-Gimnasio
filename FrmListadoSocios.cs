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
    public partial class FrmListadoSocios : Form
    {
        public FrmListadoSocios()
        {
            InitializeComponent();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            ClsSocio objSocio = new ClsSocio();
            objSocio.ListarSocios(DgvSocios);
            lblCantidad.Text = objSocio.CantidadSocios.ToString();
            lblTotalDeuda.Text = objSocio.TotalSaldo.ToString();
            lblPromedio.Text = "$" + objSocio.PromedioDeuda.ToString("0.00");
            BtnGenerarReporte.Enabled = true;
            BtnImprimir.Enabled = true;
        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            ClsSocio objSocio = new ClsSocio();
            objSocio.ReporteClientes();
            MessageBox.Show("Reporte generado exitosamente!!");
        }

        private void FrmListadoSocios_Load(object sender, EventArgs e)
        {
            BtnGenerarReporte.Enabled = false;
            BtnImprimir.Enabled = false; 
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
            printDocument1.PrinterSettings = printDialog1.PrinterSettings;
            printDocument1.Print();
            MessageBox.Show("Busque el reporte en la impresora!!!");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ClsSocio Imp = new ClsSocio();
            Imp.ImprimirTodos(e);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }




}
