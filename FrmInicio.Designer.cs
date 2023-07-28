namespace PryIEFIMartinez
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.MnsMenu = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.buscarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.listadoDeTodosLosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeSociosDeudoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeSociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeSociosPorActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnsMenu
            // 
            this.MnsMenu.BackColor = System.Drawing.Color.DimGray;
            this.MnsMenu.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.MnsMenu.Location = new System.Drawing.Point(0, 0);
            this.MnsMenu.Name = "MnsMenu";
            this.MnsMenu.Size = new System.Drawing.Size(731, 26);
            this.MnsMenu.TabIndex = 0;
            this.MnsMenu.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDelSistemaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // acercaDelSistemaToolStripMenuItem
            // 
            this.acercaDelSistemaToolStripMenuItem.Name = "acercaDelSistemaToolStripMenuItem";
            this.acercaDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.acercaDelSistemaToolStripMenuItem.Text = "Acerca del Sistema";
            this.acercaDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.acercaDelSistemaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(202, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevosClientesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.buscarClientesToolStripMenuItem,
            this.consultaDeClientesToolStripMenuItem,
            this.toolStripMenuItem5,
            this.listadoDeTodosLosClientesToolStripMenuItem,
            this.listadoDeSociosDeudoresToolStripMenuItem,
            this.listadoDeSociosToolStripMenuItem,
            this.listadoDeSociosPorActividadToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
            this.clientesToolStripMenuItem.Text = "Socios";
            // 
            // agregarNuevosClientesToolStripMenuItem
            // 
            this.agregarNuevosClientesToolStripMenuItem.Name = "agregarNuevosClientesToolStripMenuItem";
            this.agregarNuevosClientesToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.agregarNuevosClientesToolStripMenuItem.Text = "Agregar nuevos socios...";
            this.agregarNuevosClientesToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevosClientesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(289, 6);
            // 
            // buscarClientesToolStripMenuItem
            // 
            this.buscarClientesToolStripMenuItem.Name = "buscarClientesToolStripMenuItem";
            this.buscarClientesToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.buscarClientesToolStripMenuItem.Text = "Buscar socios...";
            this.buscarClientesToolStripMenuItem.Click += new System.EventHandler(this.buscarClientesToolStripMenuItem_Click);
            // 
            // consultaDeClientesToolStripMenuItem
            // 
            this.consultaDeClientesToolStripMenuItem.Name = "consultaDeClientesToolStripMenuItem";
            this.consultaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.consultaDeClientesToolStripMenuItem.Text = "Consulta de socios...";
            this.consultaDeClientesToolStripMenuItem.Click += new System.EventHandler(this.consultaDeClientesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(289, 6);
            // 
            // listadoDeTodosLosClientesToolStripMenuItem
            // 
            this.listadoDeTodosLosClientesToolStripMenuItem.Name = "listadoDeTodosLosClientesToolStripMenuItem";
            this.listadoDeTodosLosClientesToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.listadoDeTodosLosClientesToolStripMenuItem.Text = "Listado de todos los socios...";
            this.listadoDeTodosLosClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTodosLosClientesToolStripMenuItem_Click);
            // 
            // listadoDeSociosDeudoresToolStripMenuItem
            // 
            this.listadoDeSociosDeudoresToolStripMenuItem.Name = "listadoDeSociosDeudoresToolStripMenuItem";
            this.listadoDeSociosDeudoresToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.listadoDeSociosDeudoresToolStripMenuItem.Text = "Listado de socios deudores...";
            this.listadoDeSociosDeudoresToolStripMenuItem.Click += new System.EventHandler(this.listadoDeSociosDeudoresToolStripMenuItem_Click);
            // 
            // listadoDeSociosToolStripMenuItem
            // 
            this.listadoDeSociosToolStripMenuItem.Name = "listadoDeSociosToolStripMenuItem";
            this.listadoDeSociosToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.listadoDeSociosToolStripMenuItem.Text = "Listado de socios por barrio...";
            this.listadoDeSociosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeSociosToolStripMenuItem_Click);
            // 
            // listadoDeSociosPorActividadToolStripMenuItem
            // 
            this.listadoDeSociosPorActividadToolStripMenuItem.Name = "listadoDeSociosPorActividadToolStripMenuItem";
            this.listadoDeSociosPorActividadToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.listadoDeSociosPorActividadToolStripMenuItem.Text = "Listado de socios por actividad...";
            this.listadoDeSociosPorActividadToolStripMenuItem.Click += new System.EventHandler(this.listadoDeSociosPorActividadToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 542);
            this.panel1.TabIndex = 1;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 542);
            this.Controls.Add(this.MnsMenu);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MnsMenu;
            this.Name = "FrmInicio";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.MnsMenu.ResumeLayout(false);
            this.MnsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnsMenu;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem buscarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeTodosLosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem listadoDeSociosDeudoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeSociosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem listadoDeSociosPorActividadToolStripMenuItem;
    }
}

