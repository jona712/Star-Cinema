
namespace AppCine.Layers.UI.Reportes.Facturacion
{
    partial class frmFacturacion
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTableFacturacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetFacturacion = new AppCine.Layers.UI.Reportes.Facturacion.DataSetFacturacion();
            this.rpvFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTableFacturacionAdapter = new AppCine.Layers.UI.Reportes.Facturacion.DataSetFacturacionTableAdapters.DataTableFacturacionAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableFacturacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTableFacturacionBindingSource
            // 
            this.DataTableFacturacionBindingSource.DataMember = "DataTableFacturacion";
            this.DataTableFacturacionBindingSource.DataSource = this.DataSetFacturacion;
            // 
            // DataSetFacturacion
            // 
            this.DataSetFacturacion.DataSetName = "DataSetFacturacion";
            this.DataSetFacturacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvFactura
            // 
            this.rpvFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetFacturacion";
            reportDataSource1.Value = this.DataTableFacturacionBindingSource;
            this.rpvFactura.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvFactura.LocalReport.ReportEmbeddedResource = "AppCine.Layers.UI.Reportes.Facturacion.Factura.rdlc";
            this.rpvFactura.Location = new System.Drawing.Point(0, 0);
            this.rpvFactura.Name = "rpvFactura";
            this.rpvFactura.ServerReport.BearerToken = null;
            this.rpvFactura.Size = new System.Drawing.Size(800, 450);
            this.rpvFactura.TabIndex = 0;
            // 
            // DataTableFacturacionAdapter
            // 
            this.DataTableFacturacionAdapter.ClearBeforeFill = true;
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFacturacion";
            this.Text = "frmFactura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableFacturacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFacturacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DataTableFacturacionBindingSource;
        private DataSetFacturacion DataSetFacturacion;
        private DataSetFacturacionTableAdapters.DataTableFacturacionAdapter DataTableFacturacionAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer rpvFactura;
    }
}