
namespace PryIEFIMartinez
{
    partial class FrmBusquedaSocios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusquedaSocios));
            this.LblCodCliente = new System.Windows.Forms.Label();
            this.TxtCodigoCliente = new System.Windows.Forms.TextBox();
            this.GrbDatos = new System.Windows.Forms.GroupBox();
            this.CmbActividad = new System.Windows.Forms.ComboBox();
            this.CmbBarrio = new System.Windows.Forms.ComboBox();
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblActividad = new System.Windows.Forms.Label();
            this.LblBarrio = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblSaldo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GrbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblCodCliente
            // 
            this.LblCodCliente.AutoSize = true;
            this.LblCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodCliente.Location = new System.Drawing.Point(38, 103);
            this.LblCodCliente.Name = "LblCodCliente";
            this.LblCodCliente.Size = new System.Drawing.Size(117, 13);
            this.LblCodCliente.TabIndex = 0;
            this.LblCodCliente.Text = "Còdigo del cliente: ";
            // 
            // TxtCodigoCliente
            // 
            this.TxtCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoCliente.Location = new System.Drawing.Point(169, 100);
            this.TxtCodigoCliente.Name = "TxtCodigoCliente";
            this.TxtCodigoCliente.Size = new System.Drawing.Size(235, 20);
            this.TxtCodigoCliente.TabIndex = 1;
            // 
            // GrbDatos
            // 
            this.GrbDatos.BackColor = System.Drawing.Color.DarkGray;
            this.GrbDatos.Controls.Add(this.CmbActividad);
            this.GrbDatos.Controls.Add(this.CmbBarrio);
            this.GrbDatos.Controls.Add(this.TxtSaldo);
            this.GrbDatos.Controls.Add(this.TxtDireccion);
            this.GrbDatos.Controls.Add(this.TxtNombre);
            this.GrbDatos.Controls.Add(this.LblActividad);
            this.GrbDatos.Controls.Add(this.LblBarrio);
            this.GrbDatos.Controls.Add(this.LblDireccion);
            this.GrbDatos.Controls.Add(this.LblSaldo);
            this.GrbDatos.Controls.Add(this.LblNombre);
            this.GrbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbDatos.Location = new System.Drawing.Point(36, 181);
            this.GrbDatos.Name = "GrbDatos";
            this.GrbDatos.Size = new System.Drawing.Size(368, 258);
            this.GrbDatos.TabIndex = 2;
            this.GrbDatos.TabStop = false;
            this.GrbDatos.Text = "Datos del cliente";
            // 
            // CmbActividad
            // 
            this.CmbActividad.FormattingEnabled = true;
            this.CmbActividad.Location = new System.Drawing.Point(161, 154);
            this.CmbActividad.Name = "CmbActividad";
            this.CmbActividad.Size = new System.Drawing.Size(136, 21);
            this.CmbActividad.TabIndex = 17;
            // 
            // CmbBarrio
            // 
            this.CmbBarrio.FormattingEnabled = true;
            this.CmbBarrio.Location = new System.Drawing.Point(161, 115);
            this.CmbBarrio.Name = "CmbBarrio";
            this.CmbBarrio.Size = new System.Drawing.Size(136, 21);
            this.CmbBarrio.TabIndex = 16;
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.Location = new System.Drawing.Point(161, 193);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.Size = new System.Drawing.Size(136, 20);
            this.TxtSaldo.TabIndex = 15;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(161, 77);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(136, 20);
            this.TxtDireccion.TabIndex = 14;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(161, 39);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(136, 20);
            this.TxtNombre.TabIndex = 13;
            // 
            // LblActividad
            // 
            this.LblActividad.AutoSize = true;
            this.LblActividad.Location = new System.Drawing.Point(72, 162);
            this.LblActividad.Name = "LblActividad";
            this.LblActividad.Size = new System.Drawing.Size(64, 13);
            this.LblActividad.TabIndex = 11;
            this.LblActividad.Text = "Actividad:";
            // 
            // LblBarrio
            // 
            this.LblBarrio.AutoSize = true;
            this.LblBarrio.Location = new System.Drawing.Point(72, 123);
            this.LblBarrio.Name = "LblBarrio";
            this.LblBarrio.Size = new System.Drawing.Size(44, 13);
            this.LblBarrio.TabIndex = 10;
            this.LblBarrio.Text = "Barrio:";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Location = new System.Drawing.Point(72, 84);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(65, 13);
            this.LblDireccion.TabIndex = 9;
            this.LblDireccion.Text = "Direcciòn:";
            // 
            // LblSaldo
            // 
            this.LblSaldo.AutoSize = true;
            this.LblSaldo.Location = new System.Drawing.Point(72, 200);
            this.LblSaldo.Name = "LblSaldo";
            this.LblSaldo.Size = new System.Drawing.Size(43, 13);
            this.LblSaldo.TabIndex = 5;
            this.LblSaldo.Text = "Saldo:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(72, 46);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(54, 13);
            this.LblNombre.TabIndex = 4;
            this.LblNombre.Text = "Nombre:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(329, 140);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(140, 459);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.Location = new System.Drawing.Point(237, 459);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 23);
            this.BtnModificar.TabIndex = 5;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(329, 459);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Location = new System.Drawing.Point(41, 459);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 7;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PryIEFIMartinez.Properties.Resources.buscando;
            this.pictureBox1.Location = new System.Drawing.Point(309, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FrmBusquedaSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(453, 523);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.GrbDatos);
            this.Controls.Add(this.TxtCodigoCliente);
            this.Controls.Add(this.LblCodCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBusquedaSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Socios";
            this.Load += new System.EventHandler(this.FrmBusquedaSocios_Load);
            this.GrbDatos.ResumeLayout(false);
            this.GrbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCodCliente;
        private System.Windows.Forms.TextBox TxtCodigoCliente;
        private System.Windows.Forms.GroupBox GrbDatos;
        private System.Windows.Forms.Label LblSaldo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.ComboBox CmbActividad;
        private System.Windows.Forms.ComboBox CmbBarrio;
        private System.Windows.Forms.TextBox TxtSaldo;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblActividad;
        private System.Windows.Forms.Label LblBarrio;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}