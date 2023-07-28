﻿using System;
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
    public partial class FrmListadoSociosPorBarrio : Form
    {
        public FrmListadoSociosPorBarrio()
        {
            InitializeComponent();
        }

        private void FrmListadoSociosPorBarrio_Load(object sender, EventArgs e)
        {
            ClsBarrio Barrio = new ClsBarrio();
            Barrio.Listar(CmbBarrio);
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            Int32 cod = Convert.ToInt32(CmbBarrio.SelectedValue);
            ClsSocio x = new ClsSocio();
            x.ListarClientesDeBarrio(DgvBarrioCliente, cod);
            LblMayorSaldo.Text = x.MayorSaldo.ToString();
            LblMenorSaldo.Text = x.MenorSaldo.ToString();
            LblPromedioSaldo.Text = x.PromedioDeuda.ToString();
            LblTotalSaldos.Text = x.TotalSaldo.ToString();
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            SaveFileDialog objArchivo = new SaveFileDialog();
            objArchivo.Title = "Seleccione carpeta y escriba nombre de archivo";
            objArchivo.RestoreDirectory = true;
            objArchivo.Filter = "Archivos separado por coma|*.csv|Archivo de texto|*.txt";
            objArchivo.ShowDialog();
            Int32 idAct = Convert.ToInt32(CmbBarrio.SelectedValue);
            ClsSocio x = new ClsSocio();
            x.ReportePorBarrio(idAct, objArchivo.FileName);
            MessageBox.Show("reporte generado exitosamente!!!");
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
            printDocument1.PrinterSettings = printDialog1.PrinterSettings;
            printDocument1.Print();
            MessageBox.Show("Busque elreporte en la impresora!!!");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ClsSocio x = new ClsSocio();
            x.IdBarrio = Convert.ToInt32(CmbBarrio.SelectedValue);
            x.ImprimirPorBarrio(e);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
