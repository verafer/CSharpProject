namespace InterfazInscripcion
{
    partial class frmExamen
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
            this.gbxDatosExamen = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblExamenARendir = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxSeleccionarExamen = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.rboFinal = new System.Windows.Forms.RadioButton();
            this.rboTerceraP = new System.Windows.Forms.RadioButton();
            this.rboSegundaP = new System.Windows.Forms.RadioButton();
            this.rboPrimeraP = new System.Windows.Forms.RadioButton();
            this.dtgCurso = new System.Windows.Forms.DataGridView();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarAlumno = new System.Windows.Forms.Button();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.gbxDatosAlumno = new System.Windows.Forms.GroupBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxDatosExamen.SuspendLayout();
            this.gbxSeleccionarExamen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCurso)).BeginInit();
            this.gbxDatosAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDatosExamen
            // 
            this.gbxDatosExamen.Controls.Add(this.label3);
            this.gbxDatosExamen.Controls.Add(this.lblProfesor);
            this.gbxDatosExamen.Controls.Add(this.lblPrecio);
            this.gbxDatosExamen.Controls.Add(this.label21);
            this.gbxDatosExamen.Controls.Add(this.label20);
            this.gbxDatosExamen.Controls.Add(this.lblCurso);
            this.gbxDatosExamen.Controls.Add(this.lblExamenARendir);
            this.gbxDatosExamen.Controls.Add(this.label4);
            this.gbxDatosExamen.Location = new System.Drawing.Point(26, 365);
            this.gbxDatosExamen.Name = "gbxDatosExamen";
            this.gbxDatosExamen.Size = new System.Drawing.Size(502, 111);
            this.gbxDatosExamen.TabIndex = 85;
            this.gbxDatosExamen.TabStop = false;
            this.gbxDatosExamen.Text = "Datos del examen a rendir:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Profesor:";
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(103, 38);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(10, 13);
            this.lblProfesor.TabIndex = 32;
            this.lblProfesor.Text = "-";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(102, 85);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(10, 13);
            this.lblPrecio.TabIndex = 30;
            this.lblPrecio.Text = "-";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 13);
            this.label21.TabIndex = 16;
            this.label21.Text = "Curso:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 61);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 13);
            this.label20.TabIndex = 20;
            this.label20.Text = "Examen a rendir:";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(103, 16);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(10, 13);
            this.lblCurso.TabIndex = 27;
            this.lblCurso.Text = "-";
            // 
            // lblExamenARendir
            // 
            this.lblExamenARendir.AutoSize = true;
            this.lblExamenARendir.Location = new System.Drawing.Point(102, 61);
            this.lblExamenARendir.Name = "lblExamenARendir";
            this.lblExamenARendir.Size = new System.Drawing.Size(10, 13);
            this.lblExamenARendir.TabIndex = 28;
            this.lblExamenARendir.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Precio:";
            // 
            // gbxSeleccionarExamen
            // 
            this.gbxSeleccionarExamen.Controls.Add(this.btnConsultar);
            this.gbxSeleccionarExamen.Controls.Add(this.rboFinal);
            this.gbxSeleccionarExamen.Controls.Add(this.rboTerceraP);
            this.gbxSeleccionarExamen.Controls.Add(this.rboSegundaP);
            this.gbxSeleccionarExamen.Controls.Add(this.rboPrimeraP);
            this.gbxSeleccionarExamen.Enabled = false;
            this.gbxSeleccionarExamen.Location = new System.Drawing.Point(26, 300);
            this.gbxSeleccionarExamen.Name = "gbxSeleccionarExamen";
            this.gbxSeleccionarExamen.Size = new System.Drawing.Size(502, 48);
            this.gbxSeleccionarExamen.TabIndex = 84;
            this.gbxSeleccionarExamen.TabStop = false;
            this.gbxSeleccionarExamen.Text = "Seleccionar examen a rendir:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(421, 14);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(76, 27);
            this.btnConsultar.TabIndex = 70;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // rboFinal
            // 
            this.rboFinal.AutoSize = true;
            this.rboFinal.Location = new System.Drawing.Point(349, 19);
            this.rboFinal.Name = "rboFinal";
            this.rboFinal.Size = new System.Drawing.Size(47, 17);
            this.rboFinal.TabIndex = 72;
            this.rboFinal.TabStop = true;
            this.rboFinal.Text = "Final";
            this.rboFinal.UseVisualStyleBackColor = true;
            // 
            // rboTerceraP
            // 
            this.rboTerceraP.AutoSize = true;
            this.rboTerceraP.Location = new System.Drawing.Point(238, 19);
            this.rboTerceraP.Name = "rboTerceraP";
            this.rboTerceraP.Size = new System.Drawing.Size(91, 17);
            this.rboTerceraP.TabIndex = 73;
            this.rboTerceraP.TabStop = true;
            this.rboTerceraP.Text = "Tercer Parcial";
            this.rboTerceraP.UseVisualStyleBackColor = true;
            // 
            // rboSegundaP
            // 
            this.rboSegundaP.AutoSize = true;
            this.rboSegundaP.Location = new System.Drawing.Point(106, 19);
            this.rboSegundaP.Name = "rboSegundaP";
            this.rboSegundaP.Size = new System.Drawing.Size(103, 17);
            this.rboSegundaP.TabIndex = 74;
            this.rboSegundaP.TabStop = true;
            this.rboSegundaP.Text = "Segundo Parcial";
            this.rboSegundaP.UseVisualStyleBackColor = true;
            // 
            // rboPrimeraP
            // 
            this.rboPrimeraP.AutoSize = true;
            this.rboPrimeraP.Location = new System.Drawing.Point(4, 19);
            this.rboPrimeraP.Name = "rboPrimeraP";
            this.rboPrimeraP.Size = new System.Drawing.Size(89, 17);
            this.rboPrimeraP.TabIndex = 71;
            this.rboPrimeraP.TabStop = true;
            this.rboPrimeraP.Text = "Primer Parcial";
            this.rboPrimeraP.UseVisualStyleBackColor = true;
            // 
            // dtgCurso
            // 
            this.dtgCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCurso.Location = new System.Drawing.Point(26, 173);
            this.dtgCurso.Name = "dtgCurso";
            this.dtgCurso.Size = new System.Drawing.Size(502, 121);
            this.dtgCurso.TabIndex = 83;
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(327, 6);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(114, 21);
            this.cboTipoDocumento.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Tipo Documento";
            // 
            // btnBuscarAlumno
            // 
            this.btnBuscarAlumno.Location = new System.Drawing.Point(462, 4);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Size = new System.Drawing.Size(51, 23);
            this.btnBuscarAlumno.TabIndex = 80;
            this.btnBuscarAlumno.Text = "Buscar";
            this.btnBuscarAlumno.UseVisualStyleBackColor = true;
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(121, 6);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(83, 20);
            this.txtNroDocumento.TabIndex = 79;
            // 
            // gbxDatosAlumno
            // 
            this.gbxDatosAlumno.Controls.Add(this.lblCiudad);
            this.gbxDatosAlumno.Controls.Add(this.label11);
            this.gbxDatosAlumno.Controls.Add(this.lblFechaNac);
            this.gbxDatosAlumno.Controls.Add(this.label2);
            this.gbxDatosAlumno.Controls.Add(this.lblDireccion);
            this.gbxDatosAlumno.Controls.Add(this.lblNombre);
            this.gbxDatosAlumno.Controls.Add(this.lblEmail);
            this.gbxDatosAlumno.Controls.Add(this.lblTelefono);
            this.gbxDatosAlumno.Controls.Add(this.label9);
            this.gbxDatosAlumno.Controls.Add(this.label8);
            this.gbxDatosAlumno.Controls.Add(this.label7);
            this.gbxDatosAlumno.Controls.Add(this.label6);
            this.gbxDatosAlumno.Enabled = false;
            this.gbxDatosAlumno.Location = new System.Drawing.Point(26, 45);
            this.gbxDatosAlumno.Name = "gbxDatosAlumno";
            this.gbxDatosAlumno.Size = new System.Drawing.Size(502, 109);
            this.gbxDatosAlumno.TabIndex = 78;
            this.gbxDatosAlumno.TabStop = false;
            this.gbxDatosAlumno.Text = "Datos del alumno";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(356, 49);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(10, 13);
            this.lblCiudad.TabIndex = 32;
            this.lblCiudad.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(286, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Ciudad:";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(355, 25);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(10, 13);
            this.lblFechaNac.TabIndex = 30;
            this.lblFechaNac.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Fecha Nac:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(74, 49);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(10, 13);
            this.lblDireccion.TabIndex = 28;
            this.lblDireccion.Text = "-";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(74, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(10, 13);
            this.lblNombre.TabIndex = 27;
            this.lblNombre.Text = "-";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(74, 71);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(10, 13);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "-";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(356, 71);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(10, 13);
            this.lblTelefono.TabIndex = 25;
            this.lblTelefono.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Teléfono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Nº Doc Alumno:";
            // 
            // frmExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 558);
            this.Controls.Add(this.gbxDatosExamen);
            this.Controls.Add(this.gbxSeleccionarExamen);
            this.Controls.Add(this.dtgCurso);
            this.Controls.Add(this.cboTipoDocumento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscarAlumno);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.gbxDatosAlumno);
            this.Controls.Add(this.label1);
            this.Name = "frmExamen";
            this.Text = "Examen";
            this.gbxDatosExamen.ResumeLayout(false);
            this.gbxDatosExamen.PerformLayout();
            this.gbxSeleccionarExamen.ResumeLayout(false);
            this.gbxSeleccionarExamen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCurso)).EndInit();
            this.gbxDatosAlumno.ResumeLayout(false);
            this.gbxDatosAlumno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDatosExamen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblExamenARendir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxSeleccionarExamen;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.RadioButton rboFinal;
        private System.Windows.Forms.RadioButton rboTerceraP;
        private System.Windows.Forms.RadioButton rboSegundaP;
        private System.Windows.Forms.RadioButton rboPrimeraP;
        private System.Windows.Forms.DataGridView dtgCurso;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscarAlumno;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.GroupBox gbxDatosAlumno;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}