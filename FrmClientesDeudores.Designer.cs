
namespace PryIEFIMartinez
{
    partial class FrmClientesDeudores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientesDeudores));
            this.LblDatos = new System.Windows.Forms.Label();
            this.DgvDeudores = new System.Windows.Forms.DataGridView();
            this.ColDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnReporte = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblPromedio = new System.Windows.Forms.Label();
            this.LblTotalDeuda = new System.Windows.Forms.Label();
            this.LblCantidadDeudores = new System.Windows.Forms.Label();
            this.LblPromedioDeudores = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDeudores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblDatos
            // 
            this.LblDatos.AutoSize = true;
            this.LblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatos.Location = new System.Drawing.Point(49, 126);
            this.LblDatos.Name = "LblDatos";
            this.LblDatos.Size = new System.Drawing.Size(166, 13);
            this.LblDatos.TabIndex = 0;
            this.LblDatos.Text = "Datos de clientes deudores:";
            // 
            // DgvDeudores
            // 
            this.DgvDeudores.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDeudores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDNI,
            this.ColNombre,
            this.ColSaldo});
            this.DgvDeudores.Location = new System.Drawing.Point(52, 153);
            this.DgvDeudores.Name = "DgvDeudores";
            this.DgvDeudores.Size = new System.Drawing.Size(593, 225);
            this.DgvDeudores.TabIndex = 1;
            // 
            // ColDNI
            // 
            this.ColDNI.HeaderText = "DNI";
            this.ColDNI.Name = "ColDNI";
            this.ColDNI.Width = 150;
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre y Apellido ";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.Width = 250;
            // 
            // ColSaldo
            // 
            this.ColSaldo.HeaderText = "Saldo";
            this.ColSaldo.Name = "ColSaldo";
            this.ColSaldo.Width = 150;
            // 
            // BtnListar
            // 
            this.BtnListar.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListar.Location = new System.Drawing.Point(570, 536);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(74, 33);
            this.BtnListar.TabIndex = 2;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = false;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // BtnReporte
            // 
            this.BtnReporte.BackColor = System.Drawing.Color.Salmon;
            this.BtnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporte.Location = new System.Drawing.Point(311, 536);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(74, 33);
            this.BtnReporte.TabIndex = 3;
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.UseVisualStyleBackColor = false;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackColor = System.Drawing.Color.Khaki;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.Location = new System.Drawing.Point(52, 536);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(74, 33);
            this.BtnImprimir.TabIndex = 4;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(370, 402);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(97, 13);
            this.LblTotal.TabIndex = 5;
            this.LblTotal.Text = "Total de deuda:";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(370, 436);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(135, 13);
            this.LblCantidad.TabIndex = 6;
            this.LblCantidad.Text = "Cantidad de deudores:";
            // 
            // LblPromedio
            // 
            this.LblPromedio.AutoSize = true;
            this.LblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPromedio.Location = new System.Drawing.Point(370, 470);
            this.LblPromedio.Name = "LblPromedio";
            this.LblPromedio.Size = new System.Drawing.Size(120, 13);
            this.LblPromedio.TabIndex = 7;
            this.LblPromedio.Text = "Promedio de deuda:";
            // 
            // LblTotalDeuda
            // 
            this.LblTotalDeuda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LblTotalDeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalDeuda.Location = new System.Drawing.Point(522, 396);
            this.LblTotalDeuda.Name = "LblTotalDeuda";
            this.LblTotalDeuda.Size = new System.Drawing.Size(123, 25);
            this.LblTotalDeuda.TabIndex = 8;
            this.LblTotalDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCantidadDeudores
            // 
            this.LblCantidadDeudores.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LblCantidadDeudores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCantidadDeudores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadDeudores.Location = new System.Drawing.Point(522, 430);
            this.LblCantidadDeudores.Name = "LblCantidadDeudores";
            this.LblCantidadDeudores.Size = new System.Drawing.Size(123, 25);
            this.LblCantidadDeudores.TabIndex = 9;
            this.LblCantidadDeudores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPromedioDeudores
            // 
            this.LblPromedioDeudores.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LblPromedioDeudores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPromedioDeudores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPromedioDeudores.Location = new System.Drawing.Point(522, 464);
            this.LblPromedioDeudores.Name = "LblPromedioDeudores";
            this.LblPromedioDeudores.Size = new System.Drawing.Size(123, 25);
            this.LblPromedioDeudores.TabIndex = 10;
            this.LblPromedioDeudores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryIEFIMartinez.Properties.Resources.pedir_prestado;
            this.pictureBox1.Location = new System.Drawing.Point(523, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FrmClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(715, 619);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblPromedioDeudores);
            this.Controls.Add(this.LblCantidadDeudores);
            this.Controls.Add(this.LblTotalDeuda);
            this.Controls.Add(this.LblPromedio);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.BtnReporte);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.DgvDeudores);
            this.Controls.Add(this.LblDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClientesDeudores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes deudores";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDeudores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDatos;
        private System.Windows.Forms.DataGridView DgvDeudores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaldo;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblPromedio;
        private System.Windows.Forms.Label LblTotalDeuda;
        private System.Windows.Forms.Label LblCantidadDeudores;
        private System.Windows.Forms.Label LblPromedioDeudores;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}