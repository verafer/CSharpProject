namespace InterfazInscripcion
{
    partial class frmInscripcionExamenExt
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
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgCurso = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.rboPrimeraP = new System.Windows.Forms.RadioButton();
            this.rboFinal = new System.Windows.Forms.RadioButton();
            this.rboTerceraP = new System.Windows.Forms.RadioButton();
            this.rboSegundaP = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.gbxDatosAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCurso)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscarAlumno
            // 
            this.btnBuscarAlumno.Location = new System.Drawing.Point(477, 10);
            this.btnBuscarAlumno.Name = "btnBuscarAlumno";
            this.btnBuscarAlumno.Size = new System.Drawing.Size(51, 23);
            this.btnBuscarAlumno.TabIndex = 57;
            this.btnBuscarAlumno.Text = "Buscar";
            this.btnBuscarAlumno.UseVisualStyleBackColor = true;
            this.btnBuscarAlumno.Click += new System.EventHandler(this.BtnBuscarAlumno_Click_1);
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(136, 12);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(83, 20);
            this.txtNroDocumento.TabIndex = 56;
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
            this.gbxDatosAlumno.Location = new System.Drawing.Point(41, 51);
            this.gbxDatosAlumno.Name = "gbxDatosAlumno";
            this.gbxDatosAlumno.Size = new System.Drawing.Size(502, 109);
            this.gbxDatosAlumno.TabIndex = 55;
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
            this.label1.Location = new System.Drawing.Point(38, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nº Doc Alumno:";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(342, 12);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(114, 21);
            this.cboTipoDocumento.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Tipo Documento";
            // 
            // dtgCurso
            // 
            this.dtgCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCurso.Location = new System.Drawing.Point(30, 179);
            this.dtgCurso.Name = "dtgCurso";
            this.dtgCurso.Size = new System.Drawing.Size(451, 121);
            this.dtgCurso.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 442);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 64;
            this.label10.Text = "TOTAL:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(110, 442);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(17, 17);
            this.lblTotal.TabIndex = 65;
            this.lblTotal.Text = "0";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(499, 437);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(66, 27);
            this.btnGuardar.TabIndex = 66;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(499, 274);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(76, 27);
            this.btnConsultar.TabIndex = 70;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // rboPrimeraP
            // 
            this.rboPrimeraP.AutoSize = true;
            this.rboPrimeraP.Location = new System.Drawing.Point(499, 180);
            this.rboPrimeraP.Name = "rboPrimeraP";
            this.rboPrimeraP.Size = new System.Drawing.Size(95, 17);
            this.rboPrimeraP.TabIndex = 71;
            this.rboPrimeraP.TabStop = true;
            this.rboPrimeraP.Text = "Primera Parcial";
            this.rboPrimeraP.UseVisualStyleBackColor = true;
            // 
            // rboFinal
            // 
            this.rboFinal.AutoSize = true;
            this.rboFinal.Location = new System.Drawing.Point(499, 249);
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
            this.rboTerceraP.Location = new System.Drawing.Point(499, 226);
            this.rboTerceraP.Name = "rboTerceraP";
            this.rboTerceraP.Size = new System.Drawing.Size(97, 17);
            this.rboTerceraP.TabIndex = 73;
            this.rboTerceraP.TabStop = true;
            this.rboTerceraP.Text = "Tercera Parcial";
            this.rboTerceraP.UseVisualStyleBackColor = true;
            // 
            // rboSegundaP
            // 
            this.rboSegundaP.AutoSize = true;
            this.rboSegundaP.Location = new System.Drawing.Point(499, 203);
            this.rboSegundaP.Name = "rboSegundaP";
            this.rboSegundaP.Size = new System.Drawing.Size(103, 17);
            this.rboSegundaP.TabIndex = 74;
            this.rboSegundaP.TabStop = true;
            this.rboSegundaP.Text = "Segunda Parcial";
            this.rboSegundaP.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(30, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 109);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del examen a rendir:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Ciudad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(355, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(286, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Fecha Nac:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(74, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(74, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "-";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(74, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(10, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(356, 71);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(10, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "-";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(286, 71);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Teléfono:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 22;
            this.label19.Text = "Email:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(7, 49);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 20;
            this.label20.Text = "Dirección:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(7, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 13);
            this.label21.TabIndex = 16;
            this.label21.Text = "Nombre:";
            // 
            // frmInscripcionExamenExt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 475);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rboSegundaP);
            this.Controls.Add(this.rboTerceraP);
            this.Controls.Add(this.rboFinal);
            this.Controls.Add(this.rboPrimeraP);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtgCurso);
            this.Controls.Add(this.cboTipoDocumento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscarAlumno);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.gbxDatosAlumno);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInscripcionExamenExt";
            this.Text = "Inscripcion Examen Extraordinario";
            this.Load += new System.EventHandler(this.FrmInscripcionExamenExt_Load);
            this.gbxDatosAlumno.ResumeLayout(false);
            this.gbxDatosAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCurso)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgCurso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.RadioButton rboPrimeraP;
        private System.Windows.Forms.RadioButton rboFinal;
        private System.Windows.Forms.RadioButton rboTerceraP;
        private System.Windows.Forms.RadioButton rboSegundaP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}