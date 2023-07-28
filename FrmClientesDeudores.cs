using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryIEFIMartinez
{
    public partial class FrmClientesDeudores : Form
    {
        public FrmClientesDeudores()
        {
            InitializeComponent();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            ClsSocio x = new ClsSocio();
            x.ListarClientesDeudores(DgvDeudores);
            LblCantidadDeudores.Text = x.CantidadDeudores.ToString();
            LblTotalDeuda.Text = x.TotalDeuda.ToString("0.00");
            LblPromedioDeudores.Text = x.PromedioDeuda.ToString("0.00");
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
            printDocument1.PrinterSettings = printDialog1.PrinterSettings;
            printDocument1.Print();
            MessageBox.Show("Busque el reporte en la impresora!!!");
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            ClsSocio Imp = new ClsSocio();
            Imp.ImprimirDeudores(e);
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            ClsSocio objSocio = new ClsSocio();
            objSocio.ReporteClientesDeudores();
            MessageBox.Show("Reporte generado exitosamente!!");
        }
    }
}
