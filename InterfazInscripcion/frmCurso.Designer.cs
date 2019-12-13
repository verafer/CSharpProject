namespace InterfazInscripcion
{
    partial class frmCurso
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
            this.lstCurso = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNumeroCurso = new System.Windows.Forms.Label();
            this.txtNumeroCurso = new System.Windows.Forms.TextBox();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.cboProfesor = new System.Windows.Forms.ComboBox();
            this.cboTurno = new System.Windows.Forms.ComboBox();
            this.rbuPresencial = new System.Windows.Forms.RadioButton();
            this.rbuDistancia = new System.Windows.Forms.RadioButton();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lstCurso
            // 
            this.lstCurso.FormattingEnabled = true;
            this.lstCurso.Location = new System.Drawing.Point(286, 12);
            this.lstCurso.Name = "lstCurso";
            this.lstCurso.Size = new System.Drawing.Size(256, 251);
            this.lstCurso.TabIndex = 27;
            this.lstCurso.Click += new System.EventHandler(this.lstCurso_Click);
            this.lstCurso.SelectedIndexChanged += new System.EventHandler(this.LstCurso_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(467, 288);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 35);
            this.btnEliminar.TabIndex = 63;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(377, 288);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 35);
            this.btnEditar.TabIndex = 62;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(287, 288);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 35);
            this.btnAgregar.TabIndex = 61;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(167, 279);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(52, 21);
            this.btnLimpiar.TabIndex = 66;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(104, 279);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 21);
            this.btnCancelar.TabIndex = 65;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(46, 279);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(52, 21);
            this.btnGuardar.TabIndex = 64;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblNumeroCurso
            // 
            this.lblNumeroCurso.AutoSize = true;
            this.lblNumeroCurso.Location = new System.Drawing.Point(7, 28);
            this.lblNumeroCurso.Name = "lblNumeroCurso";
            this.lblNumeroCurso.Size = new System.Drawing.Size(91, 13);
            this.lblNumeroCurso.TabIndex = 68;
            this.lblNumeroCurso.Text = "Número del Curso";
            this.lblNumeroCurso.Click += new System.EventHandler(this.LblNumeroCurso_Click);
            // 
            // txtNumeroCurso
            // 
            this.txtNumeroCurso.Location = new System.Drawing.Point(109, 25);
            this.txtNumeroCurso.Name = "txtNumeroCurso";
            this.txtNumeroCurso.Size = new System.Drawing.Size(148, 20);
            this.txtNumeroCurso.TabIndex = 67;
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(12, 101);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(49, 13);
            this.lblProfesor.TabIndex = 69;
            this.lblProfesor.Text = "Profesor ";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(12, 65);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateria.TabIndex = 70;
            this.lblMateria.Text = "Materia";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(13, 138);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(35, 13);
            this.lblTurno.TabIndex = 71;
            this.lblTurno.Text = "Turno";
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.Location = new System.Drawing.Point(13, 175);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(56, 13);
            this.lblModalidad.TabIndex = 72;
            this.lblModalidad.Text = "Modalidad";
            // 
            // cboMateria
            // 
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(109, 62);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(148, 21);
            this.cboMateria.TabIndex = 73;
            // 
            // cboProfesor
            // 
            this.cboProfesor.FormattingEnabled = true;
            this.cboProfesor.Location = new System.Drawing.Point(109, 98);
            this.cboProfesor.Name = "cboProfesor";
            this.cboProfesor.Size = new System.Drawing.Size(148, 21);
            this.cboProfesor.TabIndex = 74;
            // 
            // cboTurno
            // 
            this.cboTurno.FormattingEnabled = true;
            this.cboTurno.Location = new System.Drawing.Point(109, 135);
            this.cboTurno.Name = "cboTurno";
            this.cboTurno.Size = new System.Drawing.Size(148, 21);
            this.cboTurno.TabIndex = 75;
            // 
            // rbuPresencial
            // 
            this.rbuPresencial.AutoSize = true;
            this.rbuPresencial.Location = new System.Drawing.Point(98, 175);
            this.rbuPresencial.Name = "rbuPresencial";
            this.rbuPresencial.Size = new System.Drawing.Size(74, 17);
            this.rbuPresencial.TabIndex = 76;
            this.rbuPresencial.TabStop = true;
            this.rbuPresencial.Text = "Presencial";
            this.rbuPresencial.UseVisualStyleBackColor = true;
            // 
            // rbuDistancia
            // 
            this.rbuDistancia.AutoSize = true;
            this.rbuDistancia.Location = new System.Drawing.Point(178, 175);
            this.rbuDistancia.Name = "rbuDistancia";
            this.rbuDistancia.Size = new System.Drawing.Size(79, 17);
            this.rbuDistancia.TabIndex = 77;
            this.rbuDistancia.TabStop = true;
            this.rbuDistancia.Text = "A Distancia";
            this.rbuDistancia.UseVisualStyleBackColor = true;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(12, 212);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(80, 13);
            this.lblFechaInicio.TabIndex = 78;
            this.lblFechaInicio.Text = "Fecha de Inicio";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(13, 247);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(54, 13);
            this.lblFechaFin.TabIndex = 79;
            this.lblFechaFin.Text = "Fecha Fin";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(109, 212);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(106, 20);
            this.dtpFechaInicio.TabIndex = 80;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(109, 247);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(106, 20);
            this.dtpFechaFin.TabIndex = 81;
            // 
            // frmCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 362);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.rbuDistancia);
            this.Controls.Add(this.rbuPresencial);
            this.Controls.Add(this.cboTurno);
            this.Controls.Add(this.cboProfesor);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.lblModalidad);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.lblNumeroCurso);
            this.Controls.Add(this.txtNumeroCurso);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstCurso);
            this.MaximizeBox = false;
            this.Name = "frmCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curso";
            this.Load += new System.EventHandler(this.FrmCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCurso;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNumeroCurso;
        private System.Windows.Forms.TextBox txtNumeroCurso;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.ComboBox cboProfesor;
        private System.Windows.Forms.ComboBox cboTurno;
        private System.Windows.Forms.RadioButton rbuPresencial;
        private System.Windows.Forms.RadioButton rbuDistancia;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
    }
}