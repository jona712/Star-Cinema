
namespace AppCine.Layers.UI.Reportes
{
    partial class frmReporteFacturas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataTableFacturaByFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReportes = new AppCine.Layers.UI.Reportes.DataSetReportes();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.lblLimpiar = new System.Windows.Forms.Label();
            this.pnlReporteEntradas = new System.Windows.Forms.Panel();
            this.pnlFechas = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rpvReporteFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataTableFacturaByFechaAdapter = new AppCine.Layers.UI.Reportes.DataSetReportesTableAdapters.DataTableFacturaByFechaAdapter();
            this.erpErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblcompartir = new System.Windows.Forms.Label();
            this.btnCompartir = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableFacturaByFechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes)).BeginInit();
            this.pnlReporteEntradas.SuspendLayout();
            this.pnlFechas.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTableFacturaByFechaBindingSource
            // 
            this.dataTableFacturaByFechaBindingSource.DataMember = "DataTableFacturaByFecha";
            this.dataTableFacturaByFechaBindingSource.DataSource = this.dataSetReportes;
            // 
            // dataSetReportes
            // 
            this.dataSetReportes.DataSetName = "DataSetReportes";
            this.dataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFiltrar.Location = new System.Drawing.Point(394, 90);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(32, 13);
            this.lblFiltrar.TabIndex = 19;
            this.lblFiltrar.Text = "Filtrar";
            // 
            // lblLimpiar
            // 
            this.lblLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.lblLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLimpiar.Location = new System.Drawing.Point(168, 90);
            this.lblLimpiar.Name = "lblLimpiar";
            this.lblLimpiar.Size = new System.Drawing.Size(150, 19);
            this.lblLimpiar.TabIndex = 18;
            this.lblLimpiar.Text = "Limpiar";
            this.lblLimpiar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlReporteEntradas
            // 
            this.pnlReporteEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReporteEntradas.BackColor = System.Drawing.Color.Black;
            this.pnlReporteEntradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlReporteEntradas.Controls.Add(this.pnlFechas);
            this.pnlReporteEntradas.Controls.Add(this.panel1);
            this.pnlReporteEntradas.Location = new System.Drawing.Point(12, 133);
            this.pnlReporteEntradas.Name = "pnlReporteEntradas";
            this.pnlReporteEntradas.Size = new System.Drawing.Size(920, 488);
            this.pnlReporteEntradas.TabIndex = 20;
            // 
            // pnlFechas
            // 
            this.pnlFechas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlFechas.Controls.Add(this.lblUsuario);
            this.pnlFechas.Controls.Add(this.cmbUsuarios);
            this.pnlFechas.Controls.Add(this.label3);
            this.pnlFechas.Controls.Add(this.label2);
            this.pnlFechas.Controls.Add(this.dtpFechaFinal);
            this.pnlFechas.Controls.Add(this.dtpFechaInicial);
            this.pnlFechas.ForeColor = System.Drawing.Color.White;
            this.pnlFechas.Location = new System.Drawing.Point(3, 3);
            this.pnlFechas.Name = "pnlFechas";
            this.pnlFechas.Size = new System.Drawing.Size(255, 480);
            this.pnlFechas.TabIndex = 23;
            this.pnlFechas.TabStop = false;
            this.pnlFechas.Text = "Información";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(110, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Final";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(110, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Inicio";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaFinal.Location = new System.Drawing.Point(6, 238);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(235, 20);
            this.dtpFechaFinal.TabIndex = 5;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFechaInicial.Location = new System.Drawing.Point(6, 43);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(235, 20);
            this.dtpFechaInicial.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rpvReporteFactura);
            this.panel1.Location = new System.Drawing.Point(264, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 480);
            this.panel1.TabIndex = 3;
            // 
            // rpvReporteFactura
            // 
            this.rpvReporteFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetFacturaByFecha";
            reportDataSource2.Value = this.dataTableFacturaByFechaBindingSource;
            this.rpvReporteFactura.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvReporteFactura.LocalReport.ReportEmbeddedResource = "AppCine.Layers.UI.Reportes.ReporteFacturasByFecha.rdlc";
            this.rpvReporteFactura.Location = new System.Drawing.Point(0, 0);
            this.rpvReporteFactura.Name = "rpvReporteFactura";
            this.rpvReporteFactura.ServerReport.BearerToken = null;
            this.rpvReporteFactura.Size = new System.Drawing.Size(651, 480);
            this.rpvReporteFactura.TabIndex = 0;
            this.rpvReporteFactura.Visible = false;
            // 
            // dataTableFacturaByFechaAdapter
            // 
            this.dataTableFacturaByFechaAdapter.ClearBeforeFill = true;
            // 
            // erpErrores
            // 
            this.erpErrores.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(555, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Imprimir";
            // 
            // lblcompartir
            // 
            this.lblcompartir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblcompartir.AutoSize = true;
            this.lblcompartir.BackColor = System.Drawing.Color.Transparent;
            this.lblcompartir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcompartir.Location = new System.Drawing.Point(722, 90);
            this.lblcompartir.Name = "lblcompartir";
            this.lblcompartir.Size = new System.Drawing.Size(51, 13);
            this.lblcompartir.TabIndex = 24;
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
            this.btnCompartir.Location = new System.Drawing.Point(668, 12);
            this.btnCompartir.Name = "btnCompartir";
            this.btnCompartir.Size = new System.Drawing.Size(150, 75);
            this.btnCompartir.TabIndex = 23;
            this.btnCompartir.Text = "\r\n";
            this.btnCompartir.UseVisualStyleBackColor = false;
            this.btnCompartir.Visible = false;
            this.btnCompartir.Click += new System.EventHandler(this.btnCompartir_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BackgroundImage = global::AppCine.Properties.Resources.pdfNuevo;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.ForeColor = System.Drawing.Color.Gray;
            this.btnImprimir.Location = new System.Drawing.Point(501, 12);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(150, 75);
            this.btnImprimir.TabIndex = 21;
            this.btnImprimir.Text = "\r\n";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltrar.BackgroundImage = global::AppCine.Properties.Resources.Mas;
            this.btnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.ForeColor = System.Drawing.Color.Gray;
            this.btnFiltrar.Location = new System.Drawing.Point(335, 12);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(150, 75);
            this.btnFiltrar.TabIndex = 16;
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
            this.btnRegresar.TabIndex = 15;
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
            this.btnLimpiar.Location = new System.Drawing.Point(168, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 75);
            this.btnLimpiar.TabIndex = 17;
            this.btnLimpiar.Text = "\r\n";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(6, 439);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(235, 21);
            this.cmbUsuarios.TabIndex = 25;
            this.cmbUsuarios.Visible = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(110, 423);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 26;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.Visible = false;
            // 
            // frmReporteFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(944, 633);
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
            this.Name = "frmReporteFacturas";
            this.Text = "frmReporteFacturas";
            this.Load += new System.EventHandler(this.frmReporteFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableFacturaByFechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReportes)).EndInit();
            this.pnlReporteEntradas.ResumeLayout(false);
            this.pnlFechas.ResumeLayout(false);
            this.pnlFechas.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.Label lblLimpiar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel pnlReporteEntradas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.BindingSource dataTableFacturaByFechaBindingSource;
        private DataSetReportes dataSetReportes;
        private DataSetReportesTableAdapters.DataTableFacturaByFechaAdapter dataTableFacturaByFechaAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rpvReporteFactura;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.ErrorProvider erpErrores;
        private System.Windows.Forms.GroupBox pnlFechas;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcompartir;
        private System.Windows.Forms.Button btnCompartir;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Label lblUsuario;
    }
}