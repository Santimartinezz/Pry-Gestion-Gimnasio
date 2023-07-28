
namespace PryIEFIMartinez
{
    partial class FrmListadoPorActividad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoPorActividad));
            this.CmbActividad = new System.Windows.Forms.ComboBox();
            this.LblActividad = new System.Windows.Forms.Label();
            this.DgvActividad = new System.Windows.Forms.DataGridView();
            this.ColActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnReporte = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblTituloMayor = new System.Windows.Forms.Label();
            this.LblTituloMenor = new System.Windows.Forms.Label();
            this.LblTituloPromedio = new System.Windows.Forms.Label();
            this.LblTituloTotal = new System.Windows.Forms.Label();
            this.LblMayorSaldo = new System.Windows.Forms.Label();
            this.LblMenorSaldo = new System.Windows.Forms.Label();
            this.LblPromedioSaldo = new System.Windows.Forms.Label();
            this.LblTotalSaldos = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvActividad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbActividad
            // 
            this.CmbActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbActividad.FormattingEnabled = true;
            this.CmbActividad.Location = new System.Drawing.Point(120, 103);
            this.CmbActividad.Name = "CmbActividad";
            this.CmbActividad.Size = new System.Drawing.Size(415, 21);
            this.CmbActividad.TabIndex = 11;
            // 
            // LblActividad
            // 
            this.LblActividad.AutoSize = true;
            this.LblActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblActividad.Location = new System.Drawing.Point(37, 111);
            this.LblActividad.Name = "LblActividad";
            this.LblActividad.Size = new System.Drawing.Size(64, 13);
            this.LblActividad.TabIndex = 10;
            this.LblActividad.Text = "Actividad:";
            // 
            // DgvActividad
            // 
            this.DgvActividad.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvActividad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColActividad,
            this.ColNombre,
            this.ColSaldo});
            this.DgvActividad.Location = new System.Drawing.Point(40, 180);
            this.DgvActividad.Name = "DgvActividad";
            this.DgvActividad.Size = new System.Drawing.Size(495, 217);
            this.DgvActividad.TabIndex = 12;
            // 
            // ColActividad
            // 
            this.ColActividad.HeaderText = "Actividad";
            this.ColActividad.Name = "ColActividad";
            // 
            // ColNombre
            // 
            this.ColNombre.HeaderText = "Nombre y Apellido";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.Width = 250;
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
            this.BtnListar.Location = new System.Drawing.Point(460, 136);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Size = new System.Drawing.Size(75, 23);
            this.BtnListar.TabIndex = 13;
            this.BtnListar.Text = "Listar";
            this.BtnListar.UseVisualStyleBackColor = false;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // BtnReporte
            // 
            this.BtnReporte.BackColor = System.Drawing.Color.Salmon;
            this.BtnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporte.Location = new System.Drawing.Point(460, 594);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(75, 23);
            this.BtnReporte.TabIndex = 14;
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.UseVisualStyleBackColor = false;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackColor = System.Drawing.Color.Khaki;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.Location = new System.Drawing.Point(250, 594);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(75, 23);
            this.BtnImprimir.TabIndex = 15;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(40, 594);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 16;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // LblTituloMayor
            // 
            this.LblTituloMayor.AutoSize = true;
            this.LblTituloMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloMayor.Location = new System.Drawing.Point(359, 418);
            this.LblTituloMayor.Name = "LblTituloMayor";
            this.LblTituloMayor.Size = new System.Drawing.Size(81, 13);
            this.LblTituloMayor.TabIndex = 17;
            this.LblTituloMayor.Text = "Mayor Saldo:";
            // 
            // LblTituloMenor
            // 
            this.LblTituloMenor.AutoSize = true;
            this.LblTituloMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloMenor.Location = new System.Drawing.Point(358, 454);
            this.LblTituloMenor.Name = "LblTituloMenor";
            this.LblTituloMenor.Size = new System.Drawing.Size(82, 13);
            this.LblTituloMenor.TabIndex = 18;
            this.LblTituloMenor.Text = "Menor Saldo:";
            // 
            // LblTituloPromedio
            // 
            this.LblTituloPromedio.AutoSize = true;
            this.LblTituloPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloPromedio.Location = new System.Drawing.Point(358, 490);
            this.LblTituloPromedio.Name = "LblTituloPromedio";
            this.LblTituloPromedio.Size = new System.Drawing.Size(99, 13);
            this.LblTituloPromedio.TabIndex = 19;
            this.LblTituloPromedio.Text = "Promedio Saldo:";
            // 
            // LblTituloTotal
            // 
            this.LblTituloTotal.AutoSize = true;
            this.LblTituloTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloTotal.Location = new System.Drawing.Point(358, 526);
            this.LblTituloTotal.Name = "LblTituloTotal";
            this.LblTituloTotal.Size = new System.Drawing.Size(100, 13);
            this.LblTituloTotal.TabIndex = 20;
            this.LblTituloTotal.Text = "Total de Saldos:";
            // 
            // LblMayorSaldo
            // 
            this.LblMayorSaldo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblMayorSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMayorSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMayorSaldo.Location = new System.Drawing.Point(469, 411);
            this.LblMayorSaldo.Name = "LblMayorSaldo";
            this.LblMayorSaldo.Size = new System.Drawing.Size(66, 20);
            this.LblMayorSaldo.TabIndex = 21;
            this.LblMayorSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblMenorSaldo
            // 
            this.LblMenorSaldo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblMenorSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMenorSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMenorSaldo.Location = new System.Drawing.Point(469, 447);
            this.LblMenorSaldo.Name = "LblMenorSaldo";
            this.LblMenorSaldo.Size = new System.Drawing.Size(66, 20);
            this.LblMenorSaldo.TabIndex = 22;
            this.LblMenorSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPromedioSaldo
            // 
            this.LblPromedioSaldo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblPromedioSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblPromedioSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPromedioSaldo.Location = new System.Drawing.Point(469, 483);
            this.LblPromedioSaldo.Name = "LblPromedioSaldo";
            this.LblPromedioSaldo.Size = new System.Drawing.Size(66, 20);
            this.LblPromedioSaldo.TabIndex = 23;
            this.LblPromedioSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTotalSaldos
            // 
            this.LblTotalSaldos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LblTotalSaldos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTotalSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalSaldos.Location = new System.Drawing.Point(469, 519);
            this.LblTotalSaldos.Name = "LblTotalSaldos";
            this.LblTotalSaldos.Size = new System.Drawing.Size(66, 20);
            this.LblTotalSaldos.TabIndex = 24;
            this.LblTotalSaldos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pictureBox1.Image = global::PryIEFIMartinez.Properties.Resources.lista_de_deseos;
            this.pictureBox1.Location = new System.Drawing.Point(437, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // FrmListadoPorActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(583, 644);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblTotalSaldos);
            this.Controls.Add(this.LblPromedioSaldo);
            this.Controls.Add(this.LblMenorSaldo);
            this.Controls.Add(this.LblMayorSaldo);
            this.Controls.Add(this.LblTituloTotal);
            this.Controls.Add(this.LblTituloPromedio);
            this.Controls.Add(this.LblTituloMenor);
            this.Controls.Add(this.LblTituloMayor);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.BtnReporte);
            this.Controls.Add(this.BtnListar);
            this.Controls.Add(this.DgvActividad);
            this.Controls.Add(this.CmbActividad);
            this.Controls.Add(this.LblActividad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListadoPorActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado por actividad";
            this.Load += new System.EventHandler(this.FrmListadoPorActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvActividad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbActividad;
        internal System.Windows.Forms.Label LblActividad;
        private System.Windows.Forms.DataGridView DgvActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSaldo;
        private System.Windows.Forms.Label LblTituloMayor;
        private System.Windows.Forms.Label LblTituloMenor;
        private System.Windows.Forms.Label LblTituloPromedio;
        private System.Windows.Forms.Label LblTituloTotal;
        private System.Windows.Forms.Label LblMayorSaldo;
        private System.Windows.Forms.Label LblMenorSaldo;
        private System.Windows.Forms.Label LblPromedioSaldo;
        private System.Windows.Forms.Label LblTotalSaldos;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}