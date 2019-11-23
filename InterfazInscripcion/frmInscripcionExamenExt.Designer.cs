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
            this.label3 = new System.Windows.Forms.Label();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.btnBuscarMateria = new System.Windows.Forms.Button();
            this.dtgCurso = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnPrimeraParcial = new System.Windows.Forms.Button();
            this.btnSegundaParcial = new System.Windows.Forms.Button();
            this.btnTerceraParcial = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
            this.gbxDatosAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCurso)).BeginInit();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Materia:";
            // 
            // cboMateria
            // 
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(175, 166);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(114, 21);
            this.cboMateria.TabIndex = 61;
            // 
            // btnBuscarMateria
            // 
            this.btnBuscarMateria.Location = new System.Drawing.Point(319, 166);
            this.btnBuscarMateria.Name = "btnBuscarMateria";
            this.btnBuscarMateria.Size = new System.Drawing.Size(51, 23);
            this.btnBuscarMateria.TabIndex = 62;
            this.btnBuscarMateria.Text = "Buscar";
            this.btnBuscarMateria.UseVisualStyleBackColor = true;
            this.btnBuscarMateria.Click += new System.EventHandler(this.BtnBuscarMateria_Click);
            // 
            // dtgCurso
            // 
            this.dtgCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCurso.Location = new System.Drawing.Point(41, 214);
            this.dtgCurso.Name = "dtgCurso";
            this.dtgCurso.Size = new System.Drawing.Size(451, 121);
            this.dtgCurso.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(48, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 64;
            this.label10.Text = "TOTAL:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(127, 361);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(17, 17);
            this.lblTotal.TabIndex = 65;
            this.lblTotal.Text = "0";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(477, 398);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(66, 27);
            this.btnGuardar.TabIndex = 66;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnPrimeraParcial
            // 
            this.btnPrimeraParcial.Location = new System.Drawing.Point(513, 215);
            this.btnPrimeraParcial.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrimeraParcial.Name = "btnPrimeraParcial";
            this.btnPrimeraParcial.Size = new System.Drawing.Size(76, 27);
            this.btnPrimeraParcial.TabIndex = 67;
            this.btnPrimeraParcial.Text = "1ra Parcial";
            this.btnPrimeraParcial.UseVisualStyleBackColor = true;
            // 
            // btnSegundaParcial
            // 
            this.btnSegundaParcial.Location = new System.Drawing.Point(513, 246);
            this.btnSegundaParcial.Margin = new System.Windows.Forms.Padding(2);
            this.btnSegundaParcial.Name = "btnSegundaParcial";
            this.btnSegundaParcial.Size = new System.Drawing.Size(76, 27);
            this.btnSegundaParcial.TabIndex = 68;
            this.btnSegundaParcial.Text = "2da Parcial";
            this.btnSegundaParcial.UseVisualStyleBackColor = true;
            // 
            // btnTerceraParcial
            // 
            this.btnTerceraParcial.Location = new System.Drawing.Point(513, 277);
            this.btnTerceraParcial.Margin = new System.Windows.Forms.Padding(2);
            this.btnTerceraParcial.Name = "btnTerceraParcial";
            this.btnTerceraParcial.Size = new System.Drawing.Size(76, 27);
            this.btnTerceraParcial.TabIndex = 69;
            this.btnTerceraParcial.Text = "3ra Parcial";
            this.btnTerceraParcial.UseVisualStyleBackColor = true;
            // 
            // btnFinal
            // 
            this.btnFinal.Location = new System.Drawing.Point(513, 308);
            this.btnFinal.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(76, 27);
            this.btnFinal.TabIndex = 70;
            this.btnFinal.Text = "Final";
            this.btnFinal.UseVisualStyleBackColor = true;
            // 
            // frmInscripcionExamenExt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 436);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.btnTerceraParcial);
            this.Controls.Add(this.btnSegundaParcial);
            this.Controls.Add(this.btnPrimeraParcial);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtgCurso);
            this.Controls.Add(this.btnBuscarMateria);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.Button btnBuscarMateria;
        private System.Windows.Forms.DataGridView dtgCurso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnPrimeraParcial;
        private System.Windows.Forms.Button btnSegundaParcial;
        private System.Windows.Forms.Button btnTerceraParcial;
        private System.Windows.Forms.Button btnFinal;
    }
}