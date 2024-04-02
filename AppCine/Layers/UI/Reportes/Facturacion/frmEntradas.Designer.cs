
namespace AppCine.Layers.UI.Reportes.Facturacion
{
    partial class frmEntradas
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
            this.DataTableEntradas_2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetFacturacion = new AppCine.Layers.UI.Reportes.Facturacion.DataSetFacturacion();
            this.rpvEntradas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTableEntradasAdapter = new AppCine.Layers.UI.Reportes.Facturacion.DataSetFacturacionTableAdapters.DataTableEntradas_2Adapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableEntradas_2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTableEntradas_2BindingSource
            // 
            this.DataTableEntradas_2BindingSource.DataMember = "DataTableEntradas_2";
            this.DataTableEntradas_2BindingSource.DataSource = this.DataSetFacturacion;
            // 
            // DataSetFacturacion
            // 
            this.DataSetFacturacion.DataSetName = "DataSetFacturacion";
            this.DataSetFacturacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvEntradas
            // 
            this.rpvEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTableEntradas_2BindingSource;
            this.rpvEntradas.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvEntradas.LocalReport.ReportEmbeddedResource = "AppCine.Layers.UI.Reportes.Facturacion.Entradas.rdlc";
            this.rpvEntradas.Location = new System.Drawing.Point(0, 0);
            this.rpvEntradas.Name = "rpvEntradas";
            this.rpvEntradas.ServerReport.BearerToken = null;
            this.rpvEntradas.Size = new System.Drawing.Size(800, 450);
            this.rpvEntradas.TabIndex = 0;
            // 
            // DataTableEntradasAdapter
            // 
            this.DataTableEntradasAdapter.ClearBeforeFill = true;
            // 
            // frmEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpvEntradas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEntradas";
            this.Text = "frmEntradas";
            this.Load += new System.EventHandler(this.frmEntradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableEntradas_2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFacturacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvEntradas;
        private DataSetFacturacion DataSetFacturacion;
        private System.Windows.Forms.BindingSource DataTableEntradas_2BindingSource;
        private DataSetFacturacionTableAdapters.DataTableEntradas_2Adapter DataTableEntradasAdapter;
    }
}