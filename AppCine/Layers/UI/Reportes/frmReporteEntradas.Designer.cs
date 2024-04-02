
namespace AppCine.Layers.UI.Reportes
{
    partial class frmReporteEntradas
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataTableEntradaBySalaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReportes = new AppCine.Layers.UI.Reportes.DataSetReportes();
            this.DataTableEntradaByHorarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTableEntradaByPeliculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpvEntradasBySala = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.lblLimpiar = new System.Windows.Forms.Label();
            this.pnlReporteEntradas = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rpvEntradaByHorario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rpvEntradasByPelicula = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gpbTipoFiltro = new System.Windows.Forms.GroupBox();
            this.rdbHorario = new System.Windows.Forms.RadioButton();
            this.rdbPelicula = new System.Windows.Forms.RadioButton();
            this.rdbSala = new System.Windows.Forms.RadioButton();
            this.cmbFiltroBy = new System.Windows.Forms.ComboBox();
            this.erpErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataTableEntradaBySalaAdapter = new AppCine.Layers.UI.Reportes.DataSetReportesTableAdapters.DataTableEntradaBySalaAdapter();
            this.DataTableEntradaByPeliculaAdapter = new AppCine.Layers.UI.Reportes.DataSetReportesTableAdapters.DataTableEntradaByPeliculaAdapter();
            this.DataTableEntradaByHorarioAdapter = new AppCine.Layers.UI.Reportes.DataSetReportesTableAdapters.DataTableEntradaByHorarioAdapter();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.lblcompartir = new System.Windows.Forms.Label();
            this.btnCompartir = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableEntradaBySalaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableEntradaByHorarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableEntradaByPeliculaBindingSource)).BeginInit();
            this.pnlReporteEntradas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpbTipoFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTableEntradaBySalaBindingSource
            // 
            this.dataTableEntradaBySalaBindingSource.DataMember = "DataTableEntradaBySala";
            this.dataTableEntradaBySalaBindingSource.DataSource = this.dataSetReportes;
            // 
            // dataSetReportes
            // 
            this.dataSetReportes.DataSetName = "DataSetReportes";
            this.dataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTableEntradaByHorarioBindingSource
            // 
            this.DataTableEntradaByHorarioBindingSource.DataMember = "DataTableEntradaByHorario";
            this.DataTableEntradaByHorarioBindingSource.DataSource = this.dataSetReportes;
            // 
            // DataTableEntradaByPeliculaBindingSource
            // 
            this.DataTableEntradaByPeliculaBindingSource.DataMember = "DataTableEntradaByPelicula";
            this.DataTableEntradaByPeliculaBindingSource.DataSource = this.dataSetReportes;
            // 
            // rpvEntradasBySala
            // 
            this.rpvEntradasBySala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rpvEntradasBySala.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource7.Name = "DataSetEntradasBySala";
            reportDataSource7.Value = this.dataTableEntradaBySalaBindingSource;
            this.rpvEntradasBySala.LocalReport.DataSources.Add(reportDataSource7);
            this.rpvEntradasBySala.LocalReport.ReportEmbeddedResource = "AppCine.Layers.UI.Reportes.ReporteEntradasBySala.rdlc";
            this.rpvEntradasBySala.Location = new System.Drawing.Point(0, 0);
            this.rpvEntradasBySala.Name = "rpvEntradasBySala";
            this.rpvEntradasBySala.ServerReport.BearerToken = null;
            this.rpvEntradasBySala.Size = new System.Drawing.Size(564, 385);
            this.rpvEntradasBySala.TabIndex = 0;
            this.rpvEntradasBySala.Visible = false;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFiltrar.Location = new System.Drawing.Point(397, 90);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(32, 13);
            this.lblFiltrar.TabIndex = 14;
            this.lblFiltrar.Text = "Filtrar";
            // 
            // lblLimpiar
            // 
            this.lblLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLimpiar.AutoSize = true;
            this.lblLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.lblLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLimpiar.Location = new System.Drawing.Point(227, 90);
            this.lblLimpiar.Name = "lblLimpiar";
            this.lblLimpiar.Size = new System.Drawing.Size(40, 13);
            this.lblLimpiar.TabIndex = 13;
            this.lblLimpiar.Text = "Limpiar";
            // 
            // pnlReporteEntradas
            // 
            this.pnlReporteEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReporteEntradas.BackColor = System.Drawing.Color.Black;
            this.pnlReporteEntradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReporteEntradas.Controls.Add(this.panel1);
            this.pnlReporteEntradas.Controls.Add(this.gpbTipoFiltro);
            this.pnlReporteEntradas.Location = new System.Drawing.Point(12, 123);
            this.pnlReporteEntradas.Name = "pnlReporteEntradas";
            this.pnlReporteEntradas.Size = new System.Drawing.Size(887, 393);
            this.pnlReporteEntradas.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rpvEntradaByHorario);
            this.panel1.Controls.Add(this.rpvEntradasByPelicula);
            this.panel1.Controls.Add(this.rpvEntradasBySala);
            this.panel1.Location = new System.Drawing.Point(318, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 385);
            this.panel1.TabIndex = 3;
            // 
            // rpvEntradaByHorario
            // 
            this.rpvEntradaByHorario.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource8.Name = "DataSetEntradaByHorario";
            reportDataSource8.Value = this.DataTableEntradaByHorarioBindingSource;
            this.rpvEntradaByHorario.LocalReport.DataSources.Add(reportDataSource8);
            this.rpvEntradaByHorario.LocalReport.ReportEmbeddedResource = "AppCine.Layers.UI.Reportes.ReporteEntradasByHorario.rdlc";
            this.rpvEntradaByHorario.Location = new System.Drawing.Point(0, 0);
            this.rpvEntradaByHorario.Name = "rpvEntradaByHorario";
            this.rpvEntradaByHorario.ServerReport.BearerToken = null;
            this.rpvEntradaByHorario.Size = new System.Drawing.Size(564, 385);
            this.rpvEntradaByHorario.TabIndex = 17;
            this.rpvEntradaByHorario.Visible = false;
            // 
            // rpvEntradasByPelicula
            // 
            this.rpvEntradasByPelicula.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource9.Name = "DataSetEntradaByPelicula";
            reportDataSource9.Value = this.DataTableEntradaByPeliculaBindingSource;
            this.rpvEntradasByPelicula.LocalReport.DataSources.Add(reportDataSource9);
            this.rpvEntradasByPelicula.LocalReport.ReportEmbeddedResource = "AppCine.Layers.UI.Reportes.ReporteEntradasByPelicula.rdlc";
            this.rpvEntradasByPelicula.Location = new System.Drawing.Point(0, 0);
            this.rpvEntradasByPelicula.Name = "rpvEntradasByPelicula";
            this.rpvEntradasByPelicula.ServerReport.BearerToken = null;
            this.rpvEntradasByPelicula.Size = new System.Drawing.Size(564, 385);
            this.rpvEntradasByPelicula.TabIndex = 1;
            this.rpvEntradasByPelicula.Visible = false;
            // 
            // gpbTipoFiltro
            // 
            this.gpbTipoFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpbTipoFiltro.Controls.Add(this.rdbHorario);
            this.gpbTipoFiltro.Controls.Add(this.rdbPelicula);
            this.gpbTipoFiltro.Controls.Add(this.lblUsuario);
            this.gpbTipoFiltro.Controls.Add(this.rdbSala);
            this.gpbTipoFiltro.Controls.Add(this.cmbUsuarios);
            this.gpbTipoFiltro.Controls.Add(this.cmbFiltroBy);
            this.gpbTipoFiltro.ForeColor = System.Drawing.Color.White;
            this.gpbTipoFiltro.Location = new System.Drawing.Point(3, 3);
            this.gpbTipoFiltro.Name = "gpbTipoFiltro";
            this.gpbTipoFiltro.Size = new System.Drawing.Size(309, 385);
            this.gpbTipoFiltro.TabIndex = 2;
            this.gpbTipoFiltro.TabStop = false;
            this.gpbTipoFiltro.Text = "Tipo de filtro";
            // 
            // rdbHorario
            // 
            this.rdbHorario.AutoSize = true;
            this.rdbHorario.Location = new System.Drawing.Point(214, 30);
            this.rdbHorario.Name = "rdbHorario";
            this.rdbHorario.Size = new System.Drawing.Size(59, 17);
            this.rdbHorario.TabIndex = 2;
            this.rdbHorario.TabStop = true;
            this.rdbHorario.Text = "Horario";
            this.rdbHorario.UseVisualStyleBackColor = true;
            this.rdbHorario.CheckedChanged += new System.EventHandler(this.rdbHorario_CheckedChanged);
            // 
            // rdbPelicula
            // 
            this.rdbPelicula.AutoSize = true;
            this.rdbPelicula.Location = new System.Drawing.Point(122, 30);
            this.rdbPelicula.Name = "rdbPelicula";
            this.rdbPelicula.Size = new System.Drawing.Size(64, 17);
            this.rdbPelicula.TabIndex = 1;
            this.rdbPelicula.TabStop = true;
            this.rdbPelicula.Text = "Película";
            this.rdbPelicula.UseVisualStyleBackColor = true;
            this.rdbPelicula.CheckedChanged += new System.EventHandler(this.rdbPelicula_CheckedChanged);
            // 
            // rdbSala
            // 
            this.rdbSala.AutoSize = true;
            this.rdbSala.Location = new System.Drawing.Point(38, 30);
            this.rdbSala.Name = "rdbSala";
            this.rdbSala.Size = new System.Drawing.Size(46, 17);
            this.rdbSala.TabIndex = 0;
            this.rdbSala.TabStop = true;
            this.rdbSala.Text = "Sala";
            this.rdbSala.UseVisualStyleBackColor = true;
            this.rdbSala.CheckedChanged += new System.EventHandler(this.rdbSala_CheckedChanged);
            // 
            // cmbFiltroBy
            // 
            this.cmbFiltroBy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbFiltroBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroBy.FormattingEnabled = true;
            this.cmbFiltroBy.Location = new System.Drawing.Point(38, 67);
            this.cmbFiltroBy.Name = "cmbFiltroBy";
            this.cmbFiltroBy.Size = new System.Drawing.Size(235, 21);
            this.cmbFiltroBy.TabIndex = 1;
            // 
            // erpErrores
            // 
            this.erpErrores.ContainerControl = this;
            // 
            // dataTableEntradaBySalaAdapter
            // 
            this.dataTableEntradaBySalaAdapter.ClearBeforeFill = true;
            // 
            // DataTableEntradaByPeliculaAdapter
            // 
            this.DataTableEntradaByPeliculaAdapter.ClearBeforeFill = true;
            // 
            // DataTableEntradaByHorarioAdapter
            // 
            this.DataTableEntradaByHorarioAdapter.ClearBeforeFill = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltrar.BackgroundImage = global::AppCine.Properties.Resources.Mas;
            this.btnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.ForeColor = System.Drawing.Color.Gray;
            this.btnFiltrar.Location = new System.Drawing.Point(340, 12);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(150, 75);
            this.btnFiltrar.TabIndex = 10;
            this.btnFiltrar.Text = "\r\n";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.BackgroundImage = global::AppCine.Properties.Resources.Atras3;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.Color.Gray;
            this.btnRegresar.Location = new System.Drawing.Point(12, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(150, 75);
            this.btnRegresar.TabIndex = 9;
            this.btnRegresar.Text = "\r\n";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BackgroundImage = global::AppCine.Properties.Resources.Escoba;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.Gray;
            this.btnLimpiar.Location = new System.Drawing.Point(175, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 75);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "\r\n";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(560, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Imprimir";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BackgroundImage = global::AppCine.Properties.Resources.pdfNuevo;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.ForeColor = System.Drawing.Color.Gray;
            this.btnImprimir.Location = new System.Drawing.Point(505, 12);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(150, 75);
            this.btnImprimir.TabIndex = 23;
            this.btnImprimir.Text = "\r\n";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblcompartir
            // 
            this.lblcompartir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblcompartir.AutoSize = true;
            this.lblcompartir.BackColor = System.Drawing.Color.Transparent;
            this.lblcompartir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcompartir.Location = new System.Drawing.Point(724, 90);
            this.lblcompartir.Name = "lblcompartir";
            this.lblcompartir.Size = new System.Drawing.Size(51, 13);
            this.lblcompartir.TabIndex = 28;
            this.lblcompartir.Text = "Compartir";
            this.lblcompartir.Visible = false;
            // 
            // btnCompartir
            // 
            this.btnCompartir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCompartir.BackColor = System.Drawing.Color.Transparent;
            this.btnCompartir.BackgroundImage = global::AppCine.Properties.Resources.compartir;
            this.btnCompartir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCompartir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompartir.ForeColor = System.Drawing.Color.Gray;
            this.btnCompartir.Location = new System.Drawing.Point(672, 12);
            this.btnCompartir.Name = "btnCompartir";
            this.btnCompartir.Size = new System.Drawing.Size(150, 75);
            this.btnCompartir.TabIndex = 27;
            this.btnCompartir.Text = "\r\n";
            this.btnCompartir.UseVisualStyleBackColor = false;
            this.btnCompartir.Visible = false;
            this.btnCompartir.Click += new System.EventHandler(this.btnCompartir_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(134, 296);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 30;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Visible = false;
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(38, 312);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(235, 21);
            this.cmbUsuarios.TabIndex = 29;
            this.cmbUsuarios.Visible = false;
            // 
            // frmReporteEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(911, 528);
            this.Controls.Add(this.lblcompartir);
            this.Controls.Add(this.btnCompartir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.pnlReporteEntradas);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.lblLimpiar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnLimpiar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReporteEntradas";
            this.Text = "frmReporteEntradas_";
            this.Load += new System.EventHandler(this.frmReporteEntradas__Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableEntradaBySalaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableEntradaByHorarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableEntradaByPeliculaBindingSource)).EndInit();
            this.pnlReporteEntradas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gpbTipoFiltro.ResumeLayout(false);
            this.gpbTipoFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvEntradasBySala;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.Label lblLimpiar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel pnlReporteEntradas;
        private System.Windows.Forms.ErrorProvider erpErrores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource dataTableEntradaBySalaBindingSource;
        private DataSetReportes dataSetReportes;
        private DataSetReportesTableAdapters.DataTableEntradaBySalaAdapter dataTableEntradaBySalaAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rpvEntradasByPelicula;
        private System.Windows.Forms.BindingSource DataTableEntradaByPeliculaBindingSource;
        private DataSetReportesTableAdapters.DataTableEntradaByPeliculaAdapter DataTableEntradaByPeliculaAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rpvEntradaByHorario;
        private System.Windows.Forms.BindingSource DataTableEntradaByHorarioBindingSource;
        private DataSetReportesTableAdapters.DataTableEntradaByHorarioAdapter DataTableEntradaByHorarioAdapter;
        private System.Windows.Forms.GroupBox gpbTipoFiltro;
        private System.Windows.Forms.RadioButton rdbHorario;
        private System.Windows.Forms.RadioButton rdbPelicula;
        private System.Windows.Forms.RadioButton rdbSala;
        private System.Windows.Forms.ComboBox cmbFiltroBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Label lblcompartir;
        private System.Windows.Forms.Button btnCompartir;
    }
}