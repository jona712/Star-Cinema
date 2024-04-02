namespace AppCine.CapaInterfaz
{
    partial class frmHorarios
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lstHorarios = new System.Windows.Forms.ListBox();
            this.ptxPelicula = new System.Windows.Forms.PictureBox();
            this.erpErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDolares = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptxPelicula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.White;
            this.btnRegresar.BackgroundImage = global::AppCine.Properties.Resources.Atras1;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegresar.ForeColor = System.Drawing.Color.Gray;
            this.btnRegresar.Location = new System.Drawing.Point(12, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(160, 75);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Text = "\r\n";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lstHorarios
            // 
            this.lstHorarios.AllowDrop = true;
            this.lstHorarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstHorarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstHorarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstHorarios.Font = new System.Drawing.Font("Cambria Math", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHorarios.ForeColor = System.Drawing.Color.White;
            this.lstHorarios.FormattingEnabled = true;
            this.erpErrores.SetIconAlignment(this.lstHorarios, System.Windows.Forms.ErrorIconAlignment.TopLeft);
            this.lstHorarios.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstHorarios.IntegralHeight = false;
            this.lstHorarios.ItemHeight = 106;
            this.lstHorarios.Location = new System.Drawing.Point(339, 3);
            this.lstHorarios.Name = "lstHorarios";
            this.lstHorarios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstHorarios.ScrollAlwaysVisible = true;
            this.lstHorarios.Size = new System.Drawing.Size(699, 477);
            this.lstHorarios.TabIndex = 9;
            this.lstHorarios.SelectedIndexChanged += new System.EventHandler(this.Horarios_SelectedIndexChanged);
            // 
            // ptxPelicula
            // 
            this.ptxPelicula.BackColor = System.Drawing.Color.Transparent;
            this.ptxPelicula.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptxPelicula.Location = new System.Drawing.Point(3, 3);
            this.ptxPelicula.Name = "ptxPelicula";
            this.ptxPelicula.Size = new System.Drawing.Size(330, 302);
            this.ptxPelicula.TabIndex = 1;
            this.ptxPelicula.TabStop = false;
            // 
            // erpErrores
            // 
            this.erpErrores.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lstHorarios);
            this.panel1.Controls.Add(this.ptxPelicula);
            this.panel1.Location = new System.Drawing.Point(12, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 483);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.lblDolares);
            this.panel2.Controls.Add(this.lblPrecio);
            this.panel2.Controls.Add(this.lblClasificacion);
            this.panel2.Location = new System.Drawing.Point(3, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 169);
            this.panel2.TabIndex = 14;
            // 
            // lblDolares
            // 
            this.lblDolares.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDolares.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolares.ForeColor = System.Drawing.Color.White;
            this.lblDolares.Location = new System.Drawing.Point(0, 116);
            this.lblDolares.Name = "lblDolares";
            this.lblDolares.Size = new System.Drawing.Size(327, 36);
            this.lblDolares.TabIndex = 2;
            this.lblDolares.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecio.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(0, 65);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(327, 36);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClasificacion.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasificacion.ForeColor = System.Drawing.Color.White;
            this.lblClasificacion.Location = new System.Drawing.Point(0, 11);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(327, 36);
            this.lblClasificacion.TabIndex = 0;
            this.lblClasificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::AppCine.Properties.Resources.Cinestar_1___copia___copia;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(334, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(383, 82);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1065, 588);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHorarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHorarios";
            this.Load += new System.EventHandler(this.frmHorarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptxPelicula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox ptxPelicula;
        private System.Windows.Forms.ErrorProvider erpErrores;
        public System.Windows.Forms.ListBox lstHorarios;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblClasificacion;
        public System.Windows.Forms.Label lblDolares;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}