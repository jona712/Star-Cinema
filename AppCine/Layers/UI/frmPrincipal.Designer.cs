namespace AppCine.CapaUI
{
    partial class frmPrincipal
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQueVer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCine = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPeliculas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProgramacion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReporteEntradas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportesFacturas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGraficos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlEscritorio = new System.Windows.Forms.Panel();
            this.mnuBandera = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.AutoSize = false;
            this.mnuPrincipal.BackColor = System.Drawing.Color.White;
            this.mnuPrincipal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInicio,
            this.mnuCompras,
            this.mnuMantenimientos,
            this.mnuReportes,
            this.mnuInfo,
            this.mnuBandera});
            this.mnuPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.MdiWindowListItem = this.mnuInicio;
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(914, 40);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "mnsPrincipal";
            // 
            // mnuInicio
            // 
            this.mnuInicio.BackColor = System.Drawing.Color.White;
            this.mnuInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnuInicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogin,
            this.mnuSalir2});
            this.mnuInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mnuInicio.Image = global::AppCine.Properties.Resources.Inicio2;
            this.mnuInicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuInicio.Name = "mnuInicio";
            this.mnuInicio.Size = new System.Drawing.Size(89, 36);
            this.mnuInicio.Text = "Inicio";
            // 
            // mnuLogin
            // 
            this.mnuLogin.Image = global::AppCine.Properties.Resources.Login;
            this.mnuLogin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuLogin.Name = "mnuLogin";
            this.mnuLogin.Size = new System.Drawing.Size(196, 38);
            this.mnuLogin.Text = "Login";
            this.mnuLogin.Click += new System.EventHandler(this.mnuLogin_Click);
            // 
            // mnuSalir2
            // 
            this.mnuSalir2.Image = global::AppCine.Properties.Resources.Atras2;
            this.mnuSalir2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuSalir2.Name = "mnuSalir2";
            this.mnuSalir2.Size = new System.Drawing.Size(196, 38);
            this.mnuSalir2.Text = "Salir";
            this.mnuSalir2.Click += new System.EventHandler(this.mnuSalir2_Click);
            // 
            // mnuCompras
            // 
            this.mnuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQueVer});
            this.mnuCompras.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mnuCompras.Image = global::AppCine.Properties.Resources.Tickets2;
            this.mnuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuCompras.Name = "mnuCompras";
            this.mnuCompras.Size = new System.Drawing.Size(112, 36);
            this.mnuCompras.Text = "Compras";
            // 
            // mnuQueVer
            // 
            this.mnuQueVer.Image = global::AppCine.Properties.Resources.Reproducir;
            this.mnuQueVer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuQueVer.Name = "mnuQueVer";
            this.mnuQueVer.Size = new System.Drawing.Size(211, 38);
            this.mnuQueVer.Text = "¿Qué quieres ver?";
            this.mnuQueVer.Click += new System.EventHandler(this.quéQuieresVerToolStripMenuItem_Click);
            // 
            // mnuMantenimientos
            // 
            this.mnuMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCine,
            this.mnuUsuarios,
            this.mnuPeliculas,
            this.mnuProgramacion});
            this.mnuMantenimientos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mnuMantenimientos.Image = global::AppCine.Properties.Resources.Ajuste;
            this.mnuMantenimientos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuMantenimientos.Name = "mnuMantenimientos";
            this.mnuMantenimientos.Size = new System.Drawing.Size(160, 36);
            this.mnuMantenimientos.Text = "Mantenimientos";
            // 
            // mnuCine
            // 
            this.mnuCine.Image = global::AppCine.Properties.Resources.cine;
            this.mnuCine.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuCine.Name = "mnuCine";
            this.mnuCine.Size = new System.Drawing.Size(196, 38);
            this.mnuCine.Text = "Cine";
            this.mnuCine.Click += new System.EventHandler(this.mnuCine_Click);
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.Image = global::AppCine.Properties.Resources.Usuarios2;
            this.mnuUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnuUsuarios.Size = new System.Drawing.Size(196, 38);
            this.mnuUsuarios.Text = "Usuarios";
            this.mnuUsuarios.Click += new System.EventHandler(this.mnuUsuarios_Click);
            // 
            // mnuPeliculas
            // 
            this.mnuPeliculas.Image = global::AppCine.Properties.Resources.Pelicula;
            this.mnuPeliculas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuPeliculas.Name = "mnuPeliculas";
            this.mnuPeliculas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnuPeliculas.Size = new System.Drawing.Size(196, 38);
            this.mnuPeliculas.Text = "Películas";
            this.mnuPeliculas.Click += new System.EventHandler(this.mnuPeliculas_Click);
            // 
            // mnuProgramacion
            // 
            this.mnuProgramacion.Image = global::AppCine.Properties.Resources.Reloj;
            this.mnuProgramacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuProgramacion.Name = "mnuProgramacion";
            this.mnuProgramacion.Size = new System.Drawing.Size(196, 38);
            this.mnuProgramacion.Text = "Programación";
            this.mnuProgramacion.Click += new System.EventHandler(this.mnuCartelera_Click);
            // 
            // mnuReportes
            // 
            this.mnuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReporteEntradas,
            this.mnuReportesFacturas,
            this.mnuGraficos});
            this.mnuReportes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mnuReportes.Image = global::AppCine.Properties.Resources.Archivo21;
            this.mnuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuReportes.Name = "mnuReportes";
            this.mnuReportes.Size = new System.Drawing.Size(112, 36);
            this.mnuReportes.Text = "Reportes";
            // 
            // mnuReporteEntradas
            // 
            this.mnuReporteEntradas.Image = global::AppCine.Properties.Resources.Pelicula;
            this.mnuReporteEntradas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuReporteEntradas.Name = "mnuReporteEntradas";
            this.mnuReporteEntradas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnuReporteEntradas.Size = new System.Drawing.Size(151, 38);
            this.mnuReporteEntradas.Text = "Entradas";
            this.mnuReporteEntradas.Click += new System.EventHandler(this.mnuReporteEntradas_Click);
            // 
            // mnuReportesFacturas
            // 
            this.mnuReportesFacturas.Image = global::AppCine.Properties.Resources.Reportes1;
            this.mnuReportesFacturas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuReportesFacturas.Name = "mnuReportesFacturas";
            this.mnuReportesFacturas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnuReportesFacturas.Size = new System.Drawing.Size(151, 38);
            this.mnuReportesFacturas.Text = "Facturas";
            this.mnuReportesFacturas.Click += new System.EventHandler(this.mnuReportesFacturas_Click);
            // 
            // mnuGraficos
            // 
            this.mnuGraficos.Image = global::AppCine.Properties.Resources.Grafico;
            this.mnuGraficos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuGraficos.Name = "mnuGraficos";
            this.mnuGraficos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnuGraficos.Size = new System.Drawing.Size(151, 38);
            this.mnuGraficos.Text = "Gráficos";
            this.mnuGraficos.Click += new System.EventHandler(this.mnuGraficos_Click);
            // 
            // mnuInfo
            // 
            this.mnuInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mnuInfo.Image = global::AppCine.Properties.Resources.InforIcon;
            this.mnuInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuInfo.Name = "mnuInfo";
            this.mnuInfo.Size = new System.Drawing.Size(95, 36);
            this.mnuInfo.Text = "Ayuda";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(32, 19);
            // 
            // pnlEscritorio
            // 
            this.pnlEscritorio.BackColor = System.Drawing.Color.Transparent;
            this.pnlEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEscritorio.Location = new System.Drawing.Point(0, 40);
            this.pnlEscritorio.Name = "pnlEscritorio";
            this.pnlEscritorio.Size = new System.Drawing.Size(914, 503);
            this.pnlEscritorio.TabIndex = 1;
            // 
            // mnuBandera
            // 
            this.mnuBandera.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBandera.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mnuBandera.Image = global::AppCine.Properties.Resources.costaRica;
            this.mnuBandera.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuBandera.Name = "mnuBandera";
            this.mnuBandera.Size = new System.Drawing.Size(65, 36);
            this.mnuBandera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mnuBandera.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 543);
            this.Controls.Add(this.pnlEscritorio);
            this.Controls.Add(this.mnuPrincipal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuQueVer;
        private System.Windows.Forms.ToolStripMenuItem mnuPeliculas;
        private System.Windows.Forms.ToolStripMenuItem mnuProgramacion;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir2;
        private System.Windows.Forms.ToolStripMenuItem mnuLogin;
        public System.Windows.Forms.ToolStripMenuItem mnuMantenimientos;
        public System.Windows.Forms.ToolStripMenuItem mnuReportes;
        public System.Windows.Forms.MenuStrip mnuPrincipal;
        public System.Windows.Forms.ToolStripMenuItem mnuCompras;
        public System.Windows.Forms.ToolStripMenuItem mnuInicio;
        public System.Windows.Forms.Panel pnlEscritorio;
        private System.Windows.Forms.ToolStripMenuItem mnuReporteEntradas;
        private System.Windows.Forms.ToolStripMenuItem mnuReportesFacturas;
        public System.Windows.Forms.ToolStripMenuItem mnuInfo;
        private System.Windows.Forms.ToolStripMenuItem mnuGraficos;
        private System.Windows.Forms.ToolStripMenuItem mnuCine;
        public System.Windows.Forms.ToolStripMenuItem mnuBandera;
    }
}