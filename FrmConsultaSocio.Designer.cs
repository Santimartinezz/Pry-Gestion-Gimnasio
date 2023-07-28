
namespace PryIEFIMartinez
{
    partial class FrmConsultaSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaSocio));
            this.LblNombre = new System.Windows.Forms.Label();
            this.CmbNombres = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblMuestraSaldo = new System.Windows.Forms.Label();
            this.LblMuestraActividad = new System.Windows.Forms.Label();
            this.LblMuestraBarrio = new System.Windows.Forms.Label();
            this.LblMuestraDireccion = new System.Windows.Forms.Label();
            this.LblMuestraDNI = new System.Windows.Forms.Label();
            this.LblSaldo = new System.Windows.Forms.Label();
            this.LblActividad = new System.Windows.Forms.Label();
            this.LblBarrio = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblDNI = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(34, 137);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(117, 13);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre del cliente:";
            // 
            // CmbNombres
            // 
            this.CmbNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbNombres.FormattingEnabled = true;
            this.CmbNombres.Location = new System.Drawing.Point(155, 129);
            this.CmbNombres.Name = "CmbNombres";
            this.CmbNombres.Size = new System.Drawing.Size(213, 21);
            this.CmbNombres.TabIndex = 2;
            this.CmbNombres.SelectedIndexChanged += new System.EventHandler(this.CmbNombres_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblMuestraSaldo);
            this.groupBox1.Controls.Add(this.LblMuestraActividad);
            this.groupBox1.Controls.Add(this.LblMuestraBarrio);
            this.groupBox1.Controls.Add(this.LblMuestraDireccion);
            this.groupBox1.Controls.Add(this.LblMuestraDNI);
            this.groupBox1.Controls.Add(this.LblSaldo);
            this.groupBox1.Controls.Add(this.LblActividad);
            this.groupBox1.Controls.Add(this.LblBarrio);
            this.groupBox1.Controls.Add(this.LblDireccion);
            this.groupBox1.Controls.Add(this.LblDNI);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 277);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Socio";
            // 
            // LblMuestraSaldo
            // 
            this.LblMuestraSaldo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblMuestraSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMuestraSaldo.Location = new System.Drawing.Point(127, 224);
            this.LblMuestraSaldo.Name = "LblMuestraSaldo";
            this.LblMuestraSaldo.Size = new System.Drawing.Size(178, 20);
            this.LblMuestraSaldo.TabIndex = 18;
            this.LblMuestraSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblMuestraActividad
            // 
            this.LblMuestraActividad.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblMuestraActividad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMuestraActividad.Location = new System.Drawing.Point(127, 174);
            this.LblMuestraActividad.Name = "LblMuestraActividad";
            this.LblMuestraActividad.Size = new System.Drawing.Size(178, 20);
            this.LblMuestraActividad.TabIndex = 17;
            this.LblMuestraActividad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblMuestraBarrio
            // 
            this.LblMuestraBarrio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblMuestraBarrio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMuestraBarrio.Location = new System.Drawing.Point(127, 130);
            this.LblMuestraBarrio.Name = "LblMuestraBarrio";
            this.LblMuestraBarrio.Size = new System.Drawing.Size(178, 20);
            this.LblMuestraBarrio.TabIndex = 16;
            this.LblMuestraBarrio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblMuestraDireccion
            // 
            this.LblMuestraDireccion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblMuestraDireccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMuestraDireccion.Location = new System.Drawing.Point(127, 77);
            this.LblMuestraDireccion.Name = "LblMuestraDireccion";
            this.LblMuestraDireccion.Size = new System.Drawing.Size(178, 20);
            this.LblMuestraDireccion.TabIndex = 15;
            this.LblMuestraDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblMuestraDNI
            // 
            this.LblMuestraDNI.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblMuestraDNI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMuestraDNI.Location = new System.Drawing.Point(127, 27);
            this.LblMuestraDNI.Name = "LblMuestraDNI";
            this.LblMuestraDNI.Size = new System.Drawing.Size(178, 20);
            this.LblMuestraDNI.TabIndex = 14;
            this.LblMuestraDNI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSaldo
            // 
            this.LblSaldo.AutoSize = true;
            this.LblSaldo.Location = new System.Drawing.Point(25, 231);
            this.LblSaldo.Name = "LblSaldo";
            this.LblSaldo.Size = new System.Drawing.Size(43, 13);
            this.LblSaldo.TabIndex = 8;
            this.LblSaldo.Text = "Saldo:";
            // 
            // LblActividad
            // 
            this.LblActividad.AutoSize = true;
            this.LblActividad.Location = new System.Drawing.Point(25, 181);
            this.LblActividad.Name = "LblActividad";
            this.LblActividad.Size = new System.Drawing.Size(64, 13);
            this.LblActividad.TabIndex = 7;
            this.LblActividad.Text = "Actividad:";
            // 
            // LblBarrio
            // 
            this.LblBarrio.AutoSize = true;
            this.LblBarrio.Location = new System.Drawing.Point(25, 137);
            this.LblBarrio.Name = "LblBarrio";
            this.LblBarrio.Size = new System.Drawing.Size(44, 13);
            this.LblBarrio.TabIndex = 6;
            this.LblBarrio.Text = "Barrio:";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Location = new System.Drawing.Point(24, 84);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(65, 13);
            this.LblDireccion.TabIndex = 5;
            this.LblDireccion.Text = "Direccion.";
            // 
            // LblDNI
            // 
            this.LblDNI.AutoSize = true;
            this.LblDNI.Location = new System.Drawing.Point(25, 34);
            this.LblDNI.Name = "LblDNI";
            this.LblDNI.Size = new System.Drawing.Size(33, 13);
            this.LblDNI.TabIndex = 4;
            this.LblDNI.Text = "DNI:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(294, 170);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(74, 24);
            this.BtnBuscar.TabIndex = 0;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryIEFIMartinez.Properties.Resources.buscar__1_;
            this.pictureBox1.Location = new System.Drawing.Point(275, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FrmConsultaSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(405, 534);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CmbNombres);
            this.Controls.Add(this.LblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de socio";
            this.Load += new System.EventHandler(this.FrmConsultaSocio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.ComboBox CmbNombres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblSaldo;
        private System.Windows.Forms.Label LblActividad;
        private System.Windows.Forms.Label LblBarrio;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblDNI;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LblMuestraSaldo;
        private System.Windows.Forms.Label LblMuestraActividad;
        private System.Windows.Forms.Label LblMuestraBarrio;
        private System.Windows.Forms.Label LblMuestraDireccion;
        private System.Windows.Forms.Label LblMuestraDNI;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}