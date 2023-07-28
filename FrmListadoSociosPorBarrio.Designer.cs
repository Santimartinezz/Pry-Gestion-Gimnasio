
namespace PryIEFIMartinez
{
    partial class FrmListadoSociosPorBarrio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoSociosPorBarrio));
            this.CmbBarrio = new System.Windows.Forms.ComboBox();
            this.LblBarrio = new System.Windows.Forms.Label();
            this.DgvBarrioCliente = new System.Windows.Forms.DataGridView();
            this.ColIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnReporte = new System.Windows.Forms.Button();
            this.LblTotalSaldos = new System.Windows.Forms.Label();
            this.LblPromedioSaldo = new System.Windows.Forms.Label();
            this.LblMenorSaldo = new System.Windows.Forms.Label();
            this.LblMayorSaldo = new System.Windows.Forms.Label();
            this.LblTituloTotal = new System.Windows.Forms.Label();
            this.LblTituloPromedio = new System.Windows.Forms.Label();
            this.LblTituloMenor = new System.Windows.Forms.Label();
            this.LblTituloMayor = new System.Windows.Forms.Label();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBarrioCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbBarrio
            // 
            this.CmbBarrio.FormattingEnabled = true;
            this.CmbBarrio.Location = new System.Drawing.Point(140, 131);
            this.CmbBarrio.Name = "CmbBarrio";
            this.CmbBarrio.Size = new System.Drawing.Size(393, 21);
            this.CmbBarrio.TabIndex = 0;
            // 
            // LblBarrio
            // 
            this.LblBarrio.AutoSize = true;
            this.LblBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBarrio.Location = new System.Drawing.Point(24, 139);
            this.LblBarrio.Name = "LblBarrio";
            this.LblBarrio.Size = new System.Drawing.Size(110, 13);
            this.LblBarrio.TabIndex = 1;
            this.LblBarrio.Text = "Seleccione barrio:";
            // 
            // DgvBarrioCliente
            // 
            this.DgvBarrioCliente.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvBarrioCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBarrioCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdCliente,
            this.ColNombre,
            this.ColSaldo});
            this.DgvBarrioCliente.Location = new System.Drawing.Point(27, 185);
            this.DgvBarrioCliente.Name = "DgvBarrioCliente";
            this.DgvBarrioCliente.Size = new System.Drawing.Size(506, 219);
            this.DgvBarrioCliente.TabIndex = 2;
            // 
            // ColIdCliente
            // 
            this.ColIdCliente.HeaderText = "IdCliente";
            this.ColIdCliente.Name = "ColIdCliente";
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre y Apellido";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.Width = 260;
            // 
            // ColSaldo
            // 
            this.ColSaldo.HeaderText = "Saldo";
            this.ColSaldo.Name = "ColSaldo";
            // 
            // BtnListar
            // 
            this.BtnListar.BackColor = System.Drawing.Color.SkyBlue;
            this.BtnListar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListar.Location = new System.Drawing.Point(440, 579);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(93, 31);
            this.BtnListar.TabIndex = 3;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = false;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // BtnReporte
            // 
            this.BtnReporte.BackColor = System.Drawing.Color.Salmon;
            this.BtnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporte.Location = new System.Drawing.Point(294, 579);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(100, 31);
            this.BtnReporte.TabIndex = 4;
            this.BtnReporte.Text = " Reporte";
            this.BtnReporte.UseVisualStyleBackColor = false;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // LblTotalSaldos
            // 
            this.LblTotalSaldos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblTotalSaldos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTotalSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalSaldos.Location = new System.Drawing.Point(467, 533);
            this.LblTotalSaldos.Name = "LblTotalSaldos";
            this.LblTotalSaldos.Size = new System.Drawing.Size(66, 20);
            this.LblTotalSaldos.TabIndex = 32;
            this.LblTotalSaldos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPromedioSaldo
            // 
            this.LblPromedioSaldo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblPromedioSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPromedioSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPromedioSaldo.Location = new System.Drawing.Point(467, 497);
            this.LblPromedioSaldo.Name = "LblPromedioSaldo";
            this.LblPromedioSaldo.Size = new System.Drawing.Size(66, 20);
            this.LblPromedioSaldo.TabIndex = 31;
            this.LblPromedioSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblMenorSaldo
            // 
            this.LblMenorSaldo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblMenorSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMenorSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMenorSaldo.Location = new System.Drawing.Point(467, 461);
            this.LblMenorSaldo.Name = "LblMenorSaldo";
            this.LblMenorSaldo.Size = new System.Drawing.Size(66, 20);
            this.LblMenorSaldo.TabIndex = 30;
            this.LblMenorSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblMayorSaldo
            // 
            this.LblMayorSaldo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblMayorSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMayorSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMayorSaldo.Location = new System.Drawing.Point(467, 425);
            this.LblMayorSaldo.Name = "LblMayorSaldo";
            this.LblMayorSaldo.Size = new System.Drawing.Size(66, 20);
            this.LblMayorSaldo.TabIndex = 29;
            this.LblMayorSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTituloTotal
            // 
            this.LblTituloTotal.AutoSize = true;
            this.LblTituloTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloTotal.Location = new System.Drawing.Point(356, 540);
            this.LblTituloTotal.Name = "LblTituloTotal";
            this.LblTituloTotal.Size = new System.Drawing.Size(100, 13);
            this.LblTituloTotal.TabIndex = 28;
            this.LblTituloTotal.Text = "Total de Saldos:";
            // 
            // LblTituloPromedio
            // 
            this.LblTituloPromedio.AutoSize = true;
            this.LblTituloPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloPromedio.Location = new System.Drawing.Point(356, 504);
            this.LblTituloPromedio.Name = "LblTituloPromedio";
            this.LblTituloPromedio.Size = new System.Drawing.Size(99, 13);
            this.LblTituloPromedio.TabIndex = 27;
            this.LblTituloPromedio.Text = "Promedio Saldo:";
            // 
            // LblTituloMenor
            // 
            this.LblTituloMenor.AutoSize = true;
            this.LblTituloMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloMenor.Location = new System.Drawing.Point(356, 468);
            this.LblTituloMenor.Name = "LblTituloMenor";
            this.LblTituloMenor.Size = new System.Drawing.Size(82, 13);
            this.LblTituloMenor.TabIndex = 26;
            this.LblTituloMenor.Text = "Menor Saldo:";
            // 
            // LblTituloMayor
            // 
            this.LblTituloMayor.AutoSize = true;
            this.LblTituloMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloMayor.Location = new System.Drawing.Point(357, 432);
            this.LblTituloMayor.Name = "LblTituloMayor";
            this.LblTituloMayor.Size = new System.Drawing.Size(81, 13);
            this.LblTituloMayor.TabIndex = 25;
            this.LblTituloMayor.Text = "Mayor Saldo:";
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackColor = System.Drawing.Color.Khaki;
            this.BtnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.Location = new System.Drawing.Point(164, 579);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(100, 31);
            this.BtnImprimir.TabIndex = 33;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(27, 579);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(100, 31);
            this.BtnSalir.TabIndex = 34;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryIEFIMartinez.Properties.Resources.lista_de_deseos;
            this.pictureBox1.Location = new System.Drawing.Point(427, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // FrmListadoSociosPorBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(567, 638);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.LblTotalSaldos);
            this.Controls.Add(this.LblPromedioSaldo);
            this.Controls.Add(this.LblMenorSaldo);
            this.Controls.Add(this.LblMayorSaldo);
            this.Controls.Add(this.LblTituloTotal);
            this.Controls.Add(this.LblTituloPromedio);
            this.Controls.Add(this.LblTituloMenor);
            this.Controls.Add(this.LblTituloMayor);
            this.Controls.Add(this.BtnReporte);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.DgvBarrioCliente);
            this.Controls.Add(this.LblBarrio);
            this.Controls.Add(this.CmbBarrio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListadoSociosPorBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Socios Por Barrio";
            this.Load += new System.EventHandler(this.FrmListadoSociosPorBarrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBarrioCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbBarrio;
        private System.Windows.Forms.Label LblBarrio;
        private System.Windows.Forms.DataGridView DgvBarrioCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaldo;
        private System.Windows.Forms.Label LblTotalSaldos;
        private System.Windows.Forms.Label LblPromedioSaldo;
        private System.Windows.Forms.Label LblMenorSaldo;
        private System.Windows.Forms.Label LblMayorSaldo;
        private System.Windows.Forms.Label LblTituloTotal;
        private System.Windows.Forms.Label LblTituloPromedio;
        private System.Windows.Forms.Label LblTituloMenor;
        private System.Windows.Forms.Label LblTituloMayor;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}