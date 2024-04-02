namespace AppCine.CapaInterfaz
{
    partial class frmPeliculas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.lblLimpiar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSinopsis = new System.Windows.Forms.RichTextBox();
            this.cmbClasificacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbEnCartelera = new System.Windows.Forms.GroupBox();
            this.rdbSi = new System.Windows.Forms.RadioButton();
            this.rdbNo = new System.Windows.Forms.RadioButton();
            this.ptxImagen = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dgvPeliculas = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSinopsis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.colClasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartelera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RutaArchivo = new System.Windows.Forms.OpenFileDialog();
            this.erpErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gpbEnCartelera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEliminar
            // 
            this.lblEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.BackColor = System.Drawing.Color.Transparent;
            this.lblEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEliminar.Location = new System.Drawing.Point(665, 90);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(43, 13);
            this.lblEliminar.TabIndex = 8;
            this.lblEliminar.Text = "Eliminar";
            this.lblEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblEliminar.Click += new System.EventHandler(this.lblEliminar_Click);
            // 
            // lblGuardar
            // 
            this.lblGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGuardar.AutoSize = true;
            this.lblGuardar.BackColor = System.Drawing.Color.Transparent;
            this.lblGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGuardar.Location = new System.Drawing.Point(433, 90);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(102, 13);
            this.lblGuardar.TabIndex = 7;
            this.lblGuardar.Text = "Guardar / Actualizar";
            this.lblGuardar.Click += new System.EventHandler(this.lblGuardar_Click);
            // 
            // lblLimpiar
            // 
            this.lblLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLimpiar.AutoSize = true;
            this.lblLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.lblLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLimpiar.Location = new System.Drawing.Point(259, 90);
            this.lblLimpiar.Name = "lblLimpiar";
            this.lblLimpiar.Size = new System.Drawing.Size(40, 13);
            this.lblLimpiar.TabIndex = 6;
            this.lblLimpiar.Text = "Limpiar";
            this.lblLimpiar.Click += new System.EventHandler(this.lblLimpiar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSinopsis);
            this.panel1.Controls.Add(this.cmbClasificacion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.gpbEnCartelera);
            this.panel1.Controls.Add(this.ptxImagen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.dgvPeliculas);
            this.panel1.Location = new System.Drawing.Point(13, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 462);
            this.panel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(634, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Poster:";
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSinopsis.Location = new System.Drawing.Point(396, 40);
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(198, 135);
            this.txtSinopsis.TabIndex = 18;
            this.txtSinopsis.Text = "";
            // 
            // cmbClasificacion
            // 
            this.cmbClasificacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasificacion.FormattingEnabled = true;
            this.cmbClasificacion.Location = new System.Drawing.Point(155, 154);
            this.cmbClasificacion.Name = "cmbClasificacion";
            this.cmbClasificacion.Size = new System.Drawing.Size(198, 21);
            this.cmbClasificacion.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(152, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Clasificación:";
            // 
            // gpbEnCartelera
            // 
            this.gpbEnCartelera.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gpbEnCartelera.Controls.Add(this.rdbSi);
            this.gpbEnCartelera.Controls.Add(this.rdbNo);
            this.gpbEnCartelera.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpbEnCartelera.Location = new System.Drawing.Point(396, 204);
            this.gpbEnCartelera.Name = "gpbEnCartelera";
            this.gpbEnCartelera.Size = new System.Drawing.Size(198, 43);
            this.gpbEnCartelera.TabIndex = 15;
            this.gpbEnCartelera.TabStop = false;
            this.gpbEnCartelera.Text = "En cartelera";
            // 
            // rdbSi
            // 
            this.rdbSi.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbSi.AutoSize = true;
            this.rdbSi.BackColor = System.Drawing.Color.Transparent;
            this.rdbSi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbSi.Location = new System.Drawing.Point(58, 14);
            this.rdbSi.Name = "rdbSi";
            this.rdbSi.Size = new System.Drawing.Size(26, 23);
            this.rdbSi.TabIndex = 13;
            this.rdbSi.TabStop = true;
            this.rdbSi.Text = "Si";
            this.rdbSi.UseVisualStyleBackColor = false;
            // 
            // rdbNo
            // 
            this.rdbNo.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbNo.AutoSize = true;
            this.rdbNo.BackColor = System.Drawing.Color.Transparent;
            this.rdbNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbNo.Location = new System.Drawing.Point(119, 14);
            this.rdbNo.Name = "rdbNo";
            this.rdbNo.Size = new System.Drawing.Size(31, 23);
            this.rdbNo.TabIndex = 14;
            this.rdbNo.TabStop = true;
            this.rdbNo.Text = "No";
            this.rdbNo.UseVisualStyleBackColor = false;
            // 
            // ptxImagen
            // 
            this.ptxImagen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptxImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptxImagen.Image = global::AppCine.Properties.Resources.agregarImagen;
            this.ptxImagen.Location = new System.Drawing.Point(637, 40);
            this.ptxImagen.Name = "ptxImagen";
            this.ptxImagen.Size = new System.Drawing.Size(185, 207);
            this.ptxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptxImagen.TabIndex = 12;
            this.ptxImagen.TabStop = false;
            this.ptxImagen.Click += new System.EventHandler(this.ptxImagen_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(393, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sinopsis:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(152, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(152, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Código:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.Location = new System.Drawing.Point(155, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(198, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtId.Location = new System.Drawing.Point(155, 40);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(198, 20);
            this.txtId.TabIndex = 1;
            // 
            // dgvPeliculas
            // 
            this.dgvPeliculas.AllowUserToAddRows = false;
            this.dgvPeliculas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPeliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeliculas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvPeliculas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeliculas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeliculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colDescripcion,
            this.colSinopsis,
            this.colImagen,
            this.colClasificacion,
            this.colCartelera});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPeliculas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPeliculas.GridColor = System.Drawing.Color.Black;
            this.erpErrores.SetIconAlignment(this.dgvPeliculas, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.dgvPeliculas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvPeliculas.Location = new System.Drawing.Point(0, 267);
            this.dgvPeliculas.MultiSelect = false;
            this.dgvPeliculas.Name = "dgvPeliculas";
            this.dgvPeliculas.ReadOnly = true;
            this.dgvPeliculas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvPeliculas.RowHeadersVisible = false;
            this.dgvPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPeliculas.Size = new System.Drawing.Size(974, 197);
            this.dgvPeliculas.TabIndex = 0;
            this.dgvPeliculas.SelectionChanged += new System.EventHandler(this.dgvPeliculas_SelectionChanged);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Código";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colDescripcion
            // 
            this.colDescripcion.DataPropertyName = "Descripcion";
            this.colDescripcion.HeaderText = "Nombre";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // colSinopsis
            // 
            this.colSinopsis.DataPropertyName = "Sinopsis";
            this.colSinopsis.HeaderText = "Sinopsis";
            this.colSinopsis.Name = "colSinopsis";
            this.colSinopsis.ReadOnly = true;
            // 
            // colImagen
            // 
            this.colImagen.DataPropertyName = "Imagen";
            this.colImagen.HeaderText = "Imagen";
            this.colImagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colImagen.Name = "colImagen";
            this.colImagen.ReadOnly = true;
            // 
            // colClasificacion
            // 
            this.colClasificacion.DataPropertyName = "Clasificacion";
            this.colClasificacion.HeaderText = "Clasificación";
            this.colClasificacion.Name = "colClasificacion";
            this.colClasificacion.ReadOnly = true;
            // 
            // colCartelera
            // 
            this.colCartelera.DataPropertyName = "Estado";
            this.colCartelera.HeaderText = "En cartelera";
            this.colCartelera.Name = "colCartelera";
            this.colCartelera.ReadOnly = true;
            // 
            // erpErrores
            // 
            this.erpErrores.ContainerControl = this;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImage = global::AppCine.Properties.Resources.Eliminar;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.Gray;
            this.erpErrores.SetIconAlignment(this.btnEliminar, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnEliminar.Location = new System.Drawing.Point(610, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 75);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "\r\n";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackgroundImage = global::AppCine.Properties.Resources.Mas;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.Gray;
            this.erpErrores.SetIconAlignment(this.btnGuardar, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnGuardar.Location = new System.Drawing.Point(410, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 75);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "\r\n";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.BackgroundImage = global::AppCine.Properties.Resources.Atras3;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.Color.Gray;
            this.erpErrores.SetIconAlignment(this.btnRegresar, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnRegresar.Location = new System.Drawing.Point(14, 12);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(150, 75);
            this.btnRegresar.TabIndex = 0;
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
            this.erpErrores.SetIconAlignment(this.btnLimpiar, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.btnLimpiar.Location = new System.Drawing.Point(206, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 75);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "\r\n";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblGuardar);
            this.Controls.Add(this.lblLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnLimpiar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPeliculas";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPeliculas";
            this.Load += new System.EventHandler(this.frmPeliculas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpbEnCartelera.ResumeLayout(false);
            this.gpbEnCartelera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog RutaArchivo;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.Label lblLimpiar;
        private System.Windows.Forms.ErrorProvider erpErrores;
        private System.Windows.Forms.PictureBox ptxImagen;
        private System.Windows.Forms.GroupBox gpbEnCartelera;
        private System.Windows.Forms.RadioButton rdbSi;
        private System.Windows.Forms.RadioButton rdbNo;
        private System.Windows.Forms.ComboBox cmbClasificacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSinopsis;
        private System.Windows.Forms.DataGridViewImageColumn colImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClasificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartelera;
        private System.Windows.Forms.RichTextBox txtSinopsis;
        private System.Windows.Forms.Label label5;
    }
}