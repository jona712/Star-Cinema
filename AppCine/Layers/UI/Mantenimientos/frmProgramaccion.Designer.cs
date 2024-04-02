namespace AppCine.CapaInterfaz
{
    partial class frmProgramaccion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblSalas = new System.Windows.Forms.Label();
            this.cmbPeliculas = new System.Windows.Forms.ComboBox();
            this.cmbHorarios = new System.Windows.Forms.ComboBox();
            this.cmbSalas = new System.Windows.Forms.ComboBox();
            this.dgvSalaPelicula = new System.Windows.Forms.DataGridView();
            this.colIdPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSinopsis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erpErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.lblGuardar = new System.Windows.Forms.Label();
            this.lblLimpiar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaPelicula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPelicula);
            this.panel1.Controls.Add(this.lblHorario);
            this.panel1.Controls.Add(this.lblSalas);
            this.panel1.Controls.Add(this.cmbPeliculas);
            this.panel1.Controls.Add(this.cmbHorarios);
            this.panel1.Controls.Add(this.cmbSalas);
            this.panel1.Controls.Add(this.dgvSalaPelicula);
            this.panel1.Location = new System.Drawing.Point(13, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 467);
            this.panel1.TabIndex = 4;
            // 
            // lblPelicula
            // 
            this.lblPelicula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.BackColor = System.Drawing.Color.Transparent;
            this.lblPelicula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPelicula.Location = new System.Drawing.Point(367, 25);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(52, 13);
            this.lblPelicula.TabIndex = 16;
            this.lblPelicula.Text = "Pelìculas:";
            // 
            // lblHorario
            // 
            this.lblHorario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHorario.AutoSize = true;
            this.lblHorario.BackColor = System.Drawing.Color.Transparent;
            this.lblHorario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHorario.Location = new System.Drawing.Point(585, 25);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(49, 13);
            this.lblHorario.TabIndex = 15;
            this.lblHorario.Text = "Horarios:";
            // 
            // lblSalas
            // 
            this.lblSalas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSalas.AutoSize = true;
            this.lblSalas.BackColor = System.Drawing.Color.Transparent;
            this.lblSalas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalas.Location = new System.Drawing.Point(148, 25);
            this.lblSalas.Name = "lblSalas";
            this.lblSalas.Size = new System.Drawing.Size(36, 13);
            this.lblSalas.TabIndex = 15;
            this.lblSalas.Text = "Salas:";
            // 
            // cmbPeliculas
            // 
            this.cmbPeliculas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbPeliculas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeliculas.FormattingEnabled = true;
            this.cmbPeliculas.Location = new System.Drawing.Point(370, 41);
            this.cmbPeliculas.Name = "cmbPeliculas";
            this.cmbPeliculas.Size = new System.Drawing.Size(194, 21);
            this.cmbPeliculas.TabIndex = 6;
            // 
            // cmbHorarios
            // 
            this.cmbHorarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbHorarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorarios.FormattingEnabled = true;
            this.cmbHorarios.Location = new System.Drawing.Point(588, 41);
            this.cmbHorarios.Name = "cmbHorarios";
            this.cmbHorarios.Size = new System.Drawing.Size(194, 21);
            this.cmbHorarios.TabIndex = 5;
            // 
            // cmbSalas
            // 
            this.cmbSalas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbSalas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalas.FormattingEnabled = true;
            this.cmbSalas.Location = new System.Drawing.Point(151, 41);
            this.cmbSalas.Name = "cmbSalas";
            this.cmbSalas.Size = new System.Drawing.Size(194, 21);
            this.cmbSalas.TabIndex = 4;
            // 
            // dgvSalaPelicula
            // 
            this.dgvSalaPelicula.AllowUserToAddRows = false;
            this.dgvSalaPelicula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSalaPelicula.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalaPelicula.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvSalaPelicula.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalaPelicula.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalaPelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaPelicula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdPelicula,
            this.colDescripcion,
            this.colSinopsis});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalaPelicula.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalaPelicula.GridColor = System.Drawing.Color.Black;
            this.dgvSalaPelicula.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvSalaPelicula.Location = new System.Drawing.Point(0, 164);
            this.dgvSalaPelicula.MultiSelect = false;
            this.dgvSalaPelicula.Name = "dgvSalaPelicula";
            this.dgvSalaPelicula.ReadOnly = true;
            this.dgvSalaPelicula.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSalaPelicula.RowHeadersVisible = false;
            this.dgvSalaPelicula.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalaPelicula.Size = new System.Drawing.Size(973, 301);
            this.dgvSalaPelicula.TabIndex = 3;
            // 
            // colIdPelicula
            // 
            this.colIdPelicula.DataPropertyName = "Sala";
            this.colIdPelicula.HeaderText = "Sala";
            this.colIdPelicula.Name = "colIdPelicula";
            this.colIdPelicula.ReadOnly = true;
            // 
            // colDescripcion
            // 
            this.colDescripcion.DataPropertyName = "Pelicula";
            this.colDescripcion.HeaderText = "Pelicula";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // colSinopsis
            // 
            this.colSinopsis.DataPropertyName = "Horario";
            this.colSinopsis.HeaderText = "Horario";
            this.colSinopsis.Name = "colSinopsis";
            this.colSinopsis.ReadOnly = true;
            // 
            // erpErrores
            // 
            this.erpErrores.ContainerControl = this;
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
            this.btnRegresar.TabIndex = 15;
            this.btnRegresar.Text = "\r\n";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(602, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 75);
            this.btnEliminar.TabIndex = 17;
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
            this.btnGuardar.Location = new System.Drawing.Point(405, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 75);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "\r\n";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.btnLimpiar.Location = new System.Drawing.Point(209, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(150, 75);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "\r\n";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // lblEliminar
            // 
            this.lblEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.BackColor = System.Drawing.Color.Transparent;
            this.lblEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEliminar.Location = new System.Drawing.Point(656, 90);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(43, 13);
            this.lblEliminar.TabIndex = 21;
            this.lblEliminar.Text = "Eliminar";
            this.lblEliminar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGuardar
            // 
            this.lblGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGuardar.AutoSize = true;
            this.lblGuardar.BackColor = System.Drawing.Color.Transparent;
            this.lblGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGuardar.Location = new System.Drawing.Point(430, 90);
            this.lblGuardar.Name = "lblGuardar";
            this.lblGuardar.Size = new System.Drawing.Size(102, 13);
            this.lblGuardar.TabIndex = 20;
            this.lblGuardar.Text = "Guardar / Actualizar";
            // 
            // lblLimpiar
            // 
            this.lblLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLimpiar.AutoSize = true;
            this.lblLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.lblLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLimpiar.Location = new System.Drawing.Point(265, 90);
            this.lblLimpiar.Name = "lblLimpiar";
            this.lblLimpiar.Size = new System.Drawing.Size(40, 13);
            this.lblLimpiar.TabIndex = 19;
            this.lblLimpiar.Text = "Limpiar";
            // 
            // frmProgramaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblGuardar);
            this.Controls.Add(this.lblLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProgramaccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProgramaccion";
            this.Load += new System.EventHandler(this.frmProgramaccion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaPelicula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpErrores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSalaPelicula;
        private System.Windows.Forms.ComboBox cmbPeliculas;
        private System.Windows.Forms.ComboBox cmbHorarios;
        private System.Windows.Forms.ComboBox cmbSalas;
        private System.Windows.Forms.Label lblPelicula;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblSalas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSinopsis;
        private System.Windows.Forms.ErrorProvider erpErrores;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblGuardar;
        private System.Windows.Forms.Label lblLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}