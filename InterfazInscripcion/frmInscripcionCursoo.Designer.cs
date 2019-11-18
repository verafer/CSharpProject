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
            this.lstCursosDisponibles = new System.Windows.Forms.ListBox();
            this.cboAlumno = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCursosInscripto = new System.Windows.Forms.ListBox();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.btnDesinscribir = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.lblCD = new System.Windows.Forms.Label();
            this.lblCA = new System.Windows.Forms.Label();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.btnCancelarPendiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCursosDisponibles
            // 
            this.lstCursosDisponibles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCursosDisponibles.Enabled = false;
            this.lstCursosDisponibles.FormattingEnabled = true;
            this.lstCursosDisponibles.ItemHeight = 20;
            this.lstCursosDisponibles.Location = new System.Drawing.Point(37, 139);
            this.lstCursosDisponibles.Margin = new System.Windows.Forms.Padding(0);
            this.lstCursosDisponibles.Name = "lstCursosDisponibles";
            this.lstCursosDisponibles.Size = new System.Drawing.Size(400, 342);
            this.lstCursosDisponibles.TabIndex = 85;
            this.lstCursosDisponibles.SelectedIndexChanged += new System.EventHandler(this.lstCursosDisponibles_SelectedIndexChanged);
            // 
            // cboAlumno
            // 
            this.cboAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlumno.FormattingEnabled = true;
            this.cboAlumno.Location = new System.Drawing.Point(104, 46);
            this.cboAlumno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboAlumno.Name = "cboAlumno";
            this.cboAlumno.Size = new System.Drawing.Size(256, 28);
            this.cboAlumno.TabIndex = 95;
            this.cboAlumno.SelectedIndexChanged += new System.EventHandler(this.cboAlumno_SelectedIndexChanged);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(33, 49);
            this.lblMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(63, 20);
            this.lblMateria.TabIndex = 94;
            this.lblMateria.Text = "Alumno";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 37);
            this.label1.TabIndex = 105;
            this.label1.Text = "Total (Gs):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstCursosInscripto
            // 
            this.lstCursosInscripto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCursosInscripto.Enabled = false;
            this.lstCursosInscripto.FormattingEnabled = true;
            this.lstCursosInscripto.ItemHeight = 20;
            this.lstCursosInscripto.Location = new System.Drawing.Point(516, 139);
            this.lstCursosInscripto.Margin = new System.Windows.Forms.Padding(0);
            this.lstCursosInscripto.Name = "lstCursosInscripto";
            this.lstCursosInscripto.Size = new System.Drawing.Size(400, 342);
            this.lstCursosInscripto.TabIndex = 104;
            this.lstCursosInscripto.SelectedIndexChanged += new System.EventHandler(this.lstCursosInscripto_SelectedIndexChanged);
            // 
            // btnInscribir
            // 
            this.btnInscribir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscribir.Location = new System.Drawing.Point(451, 272);
            this.btnInscribir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(52, 40);
            this.btnInscribir.TabIndex = 107;
            this.btnInscribir.Text = ">";
            this.btnInscribir.UseVisualStyleBackColor = true;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // btnDesinscribir
            // 
            this.btnDesinscribir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesinscribir.Location = new System.Drawing.Point(516, 496);
            this.btnDesinscribir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDesinscribir.Name = "btnDesinscribir";
            this.btnDesinscribir.Size = new System.Drawing.Size(126, 54);
            this.btnDesinscribir.TabIndex = 108;
            this.btnDesinscribir.Text = "Baja Curso";
            this.btnDesinscribir.UseVisualStyleBackColor = true;
            this.btnDesinscribir.Click += new System.EventHandler(this.btnDesinscribir_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarCambios.Location = new System.Drawing.Point(685, 616);
            this.btnGuardarCambios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(231, 76);
            this.btnGuardarCambios.TabIndex = 113;
            this.btnGuardarCambios.Text = "Confirmar Inscripciones Pendientes";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // lblCD
            // 
            this.lblCD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCD.Location = new System.Drawing.Point(37, 114);
            this.lblCD.Name = "lblCD";
            this.lblCD.Size = new System.Drawing.Size(400, 25);
            this.lblCD.TabIndex = 116;
            this.lblCD.Text = "Cursos Disponibles";
            // 
            // lblCA
            // 
            this.lblCA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCA.Location = new System.Drawing.Point(516, 114);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(400, 25);
            this.lblCA.TabIndex = 117;
            this.lblCA.Text = "Cursos del Alumno";
            // 
            // nudTotal
            // 
            this.nudTotal.Enabled = false;
            this.nudTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTotal.Location = new System.Drawing.Point(685, 569);
            this.nudTotal.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nudTotal.Name = "nudTotal";
            this.nudTotal.Size = new System.Drawing.Size(231, 39);
            this.nudTotal.TabIndex = 118;
            this.nudTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTotal.ThousandsSeparator = true;
            // 
            // btnCancelarPendiente
            // 
            this.btnCancelarPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPendiente.Location = new System.Drawing.Point(650, 496);
            this.btnCancelarPendiente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelarPendiente.Name = "btnCancelarPendiente";
            this.btnCancelarPendiente.Size = new System.Drawing.Size(188, 54);
            this.btnCancelarPendiente.TabIndex = 119;
            this.btnCancelarPendiente.Text = "Cancelar Inscripción Pendiente";
            this.btnCancelarPendiente.UseVisualStyleBackColor = true;
            this.btnCancelarPendiente.Click += new System.EventHandler(this.btnCancelarPendiente_Click);
            // 
            // frmInscripcionCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(935, 711);
            this.Controls.Add(this.btnCancelarPendiente);
            this.Controls.Add(this.nudTotal);
            this.Controls.Add(this.lblCA);
            this.Controls.Add(this.lblCD);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.btnDesinscribir);
            this.Controls.Add(this.btnInscribir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCursosInscripto);
            this.Controls.Add(this.cboAlumno);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lstCursosDisponibles);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmInscripcionCurso";
            this.Text = "Inscripciones a Cursos";
            this.Load += new System.EventHandler(this.frmInscripcionCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstCursosDisponibles;
        private System.Windows.Forms.ComboBox cboAlumno;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCursosInscripto;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Button btnDesinscribir;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Label lblCD;
        private System.Windows.Forms.Label lblCA;
        private System.Windows.Forms.NumericUpDown nudTotal;
        private System.Windows.Forms.Button btnCancelarPendiente;
    }
}