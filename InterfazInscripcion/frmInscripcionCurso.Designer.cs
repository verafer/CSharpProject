namespace InterfazInscripcion
{
    partial class frmInscripcionCurso
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstCursos = new System.Windows.Forms.ListBox();
            this.cboAlumno = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.gbxDetallesC = new System.Windows.Forms.GroupBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.rbuDistancia = new System.Windows.Forms.RadioButton();
            this.rbuPresencial = new System.Windows.Forms.RadioButton();
            this.lblModalidad = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lstExamenes = new System.Windows.Forms.ListBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.gbxDetallesC.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(629, 635);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(69, 26);
            this.btnLimpiar.TabIndex = 91;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(545, 635);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 26);
            this.btnCancelar.TabIndex = 90;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(468, 635);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 26);
            this.btnGuardar.TabIndex = 89;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(255, 635);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 43);
            this.btnEliminar.TabIndex = 88;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(135, 635);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 43);
            this.btnEditar.TabIndex = 87;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(15, 635);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 43);
            this.btnAgregar.TabIndex = 86;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstCursos
            // 
            this.lstCursos.Enabled = false;
            this.lstCursos.FormattingEnabled = true;
            this.lstCursos.ItemHeight = 16;
            this.lstCursos.Location = new System.Drawing.Point(35, 103);
            this.lstCursos.Margin = new System.Windows.Forms.Padding(4);
            this.lstCursos.Name = "lstCursos";
            this.lstCursos.Size = new System.Drawing.Size(309, 420);
            this.lstCursos.TabIndex = 85;
            this.lstCursos.SelectedIndexChanged += new System.EventHandler(this.lstCursos_SelectedIndexChanged);
            // 
            // cboAlumno
            // 
            this.cboAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlumno.FormattingEnabled = true;
            this.cboAlumno.Location = new System.Drawing.Point(148, 39);
            this.cboAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.cboAlumno.Name = "cboAlumno";
            this.cboAlumno.Size = new System.Drawing.Size(196, 24);
            this.cboAlumno.TabIndex = 95;
            this.cboAlumno.SelectedIndexChanged += new System.EventHandler(this.cboAlumno_SelectedIndexChanged);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(31, 39);
            this.lblMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(55, 17);
            this.lblMateria.TabIndex = 94;
            this.lblMateria.Text = "Alumno";
            // 
            // cboCurso
            // 
            this.cboCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(533, 39);
            this.cboCurso.Margin = new System.Windows.Forms.Padding(4);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(255, 24);
            this.cboCurso.TabIndex = 97;
            this.cboCurso.SelectedIndexChanged += new System.EventHandler(this.cboCurso_SelectedIndexChanged);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(415, 42);
            this.lblCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(45, 17);
            this.lblCurso.TabIndex = 96;
            this.lblCurso.Text = "Curso";
            // 
            // gbxDetallesC
            // 
            this.gbxDetallesC.Controls.Add(this.txtTurno);
            this.gbxDetallesC.Controls.Add(this.txtProfesor);
            this.gbxDetallesC.Controls.Add(this.txtMateria);
            this.gbxDetallesC.Controls.Add(this.dtpFechaFin);
            this.gbxDetallesC.Controls.Add(this.dtpFechaInicio);
            this.gbxDetallesC.Controls.Add(this.lblFechaFin);
            this.gbxDetallesC.Controls.Add(this.lblFechaInicio);
            this.gbxDetallesC.Controls.Add(this.rbuDistancia);
            this.gbxDetallesC.Controls.Add(this.rbuPresencial);
            this.gbxDetallesC.Controls.Add(this.lblModalidad);
            this.gbxDetallesC.Controls.Add(this.lblTurno);
            this.gbxDetallesC.Controls.Add(this.label1);
            this.gbxDetallesC.Controls.Add(this.lblProfesor);
            this.gbxDetallesC.Enabled = false;
            this.gbxDetallesC.Location = new System.Drawing.Point(418, 97);
            this.gbxDetallesC.Name = "gbxDetallesC";
            this.gbxDetallesC.Size = new System.Drawing.Size(370, 301);
            this.gbxDetallesC.TabIndex = 98;
            this.gbxDetallesC.TabStop = false;
            this.gbxDetallesC.Text = "Detalles del curso";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(140, 259);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(140, 22);
            this.dtpFechaFin.TabIndex = 94;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(140, 216);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(140, 22);
            this.dtpFechaInicio.TabIndex = 93;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(12, 259);
            this.lblFechaFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(70, 17);
            this.lblFechaFin.TabIndex = 92;
            this.lblFechaFin.Text = "Fecha Fin";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(11, 216);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(103, 17);
            this.lblFechaInicio.TabIndex = 91;
            this.lblFechaInicio.Text = "Fecha de Inicio";
            // 
            // rbuDistancia
            // 
            this.rbuDistancia.AutoSize = true;
            this.rbuDistancia.Location = new System.Drawing.Point(232, 170);
            this.rbuDistancia.Margin = new System.Windows.Forms.Padding(4);
            this.rbuDistancia.Name = "rbuDistancia";
            this.rbuDistancia.Size = new System.Drawing.Size(100, 21);
            this.rbuDistancia.TabIndex = 90;
            this.rbuDistancia.TabStop = true;
            this.rbuDistancia.Text = "A Distancia";
            this.rbuDistancia.UseVisualStyleBackColor = true;
            // 
            // rbuPresencial
            // 
            this.rbuPresencial.AutoSize = true;
            this.rbuPresencial.Location = new System.Drawing.Point(126, 170);
            this.rbuPresencial.Margin = new System.Windows.Forms.Padding(4);
            this.rbuPresencial.Name = "rbuPresencial";
            this.rbuPresencial.Size = new System.Drawing.Size(95, 21);
            this.rbuPresencial.TabIndex = 89;
            this.rbuPresencial.TabStop = true;
            this.rbuPresencial.Text = "Presencial";
            this.rbuPresencial.UseVisualStyleBackColor = true;
            // 
            // lblModalidad
            // 
            this.lblModalidad.AutoSize = true;
            this.lblModalidad.Location = new System.Drawing.Point(12, 170);
            this.lblModalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModalidad.Name = "lblModalidad";
            this.lblModalidad.Size = new System.Drawing.Size(73, 17);
            this.lblModalidad.TabIndex = 85;
            this.lblModalidad.Text = "Modalidad";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(12, 125);
            this.lblTurno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(46, 17);
            this.lblTurno.TabIndex = 84;
            this.lblTurno.Text = "Turno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 83;
            this.label1.Text = "Materia";
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(11, 79);
            this.lblProfesor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(66, 17);
            this.lblProfesor.TabIndex = 82;
            this.lblProfesor.Text = "Profesor ";
            // 
            // lstExamenes
            // 
            this.lstExamenes.FormattingEnabled = true;
            this.lstExamenes.ItemHeight = 16;
            this.lstExamenes.Location = new System.Drawing.Point(418, 439);
            this.lstExamenes.Margin = new System.Windows.Forms.Padding(4);
            this.lstExamenes.Name = "lstExamenes";
            this.lstExamenes.Size = new System.Drawing.Size(370, 84);
            this.lstExamenes.TabIndex = 99;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(140, 35);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(211, 22);
            this.txtMateria.TabIndex = 95;
            // 
            // txtProfesor
            // 
            this.txtProfesor.Location = new System.Drawing.Point(140, 79);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(211, 22);
            this.txtProfesor.TabIndex = 96;
            // 
            // txtTurno
            // 
            this.txtTurno.Location = new System.Drawing.Point(140, 125);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.Size = new System.Drawing.Size(211, 22);
            this.txtTurno.TabIndex = 97;
            // 
            // frmInscripcionCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 704);
            this.Controls.Add(this.lstExamenes);
            this.Controls.Add(this.gbxDetallesC);
            this.Controls.Add(this.cboCurso);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.cboAlumno);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstCursos);
            this.Name = "frmInscripcionCurso";
            this.Text = "Inscripciones de Cursos";
            this.Load += new System.EventHandler(this.frmInscripcionCurso_Load);
            this.gbxDetallesC.ResumeLayout(false);
            this.gbxDetallesC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstCursos;
        private System.Windows.Forms.ComboBox cboAlumno;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.GroupBox gbxDetallesC;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.RadioButton rbuDistancia;
        private System.Windows.Forms.RadioButton rbuPresencial;
        private System.Windows.Forms.Label lblModalidad;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.ListBox lstExamenes;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.TextBox txtProfesor;
        private System.Windows.Forms.TextBox txtMateria;
    }
}