namespace InterfazInscripcion
{
    partial class frmMateria
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
            this.lstMateria = new System.Windows.Forms.ListBox();
            this.cboProfesor = new System.Windows.Forms.ComboBox();
            this.lblPofesor = new System.Windows.Forms.Label();
            this.lblNombreM = new System.Windows.Forms.Label();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.lblCreditoParcial = new System.Windows.Forms.Label();
            this.lblCreditosClase = new System.Windows.Forms.Label();
            this.nudCreditoClase = new System.Windows.Forms.NumericUpDown();
            this.nudCreditoParcial = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreditoClase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreditoParcial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(148, 243);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(52, 21);
            this.btnLimpiar.TabIndex = 73;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(85, 243);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 21);
            this.btnCancelar.TabIndex = 72;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(27, 243);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(52, 21);
            this.btnGuardar.TabIndex = 71;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(402, 289);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 35);
            this.btnEliminar.TabIndex = 70;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(312, 289);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 35);
            this.btnEditar.TabIndex = 69;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(222, 289);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(84, 35);
            this.btnAgregar.TabIndex = 68;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // lstMateria
            // 
            this.lstMateria.FormattingEnabled = true;
            this.lstMateria.Location = new System.Drawing.Point(253, 12);
            this.lstMateria.Name = "lstMateria";
            this.lstMateria.Size = new System.Drawing.Size(233, 251);
            this.lstMateria.TabIndex = 67;
            // 
            // cboProfesor
            // 
            this.cboProfesor.FormattingEnabled = true;
            this.cboProfesor.Location = new System.Drawing.Point(107, 77);
            this.cboProfesor.Name = "cboProfesor";
            this.cboProfesor.Size = new System.Drawing.Size(138, 21);
            this.cboProfesor.TabIndex = 77;
            // 
            // lblPofesor
            // 
            this.lblPofesor.AutoSize = true;
            this.lblPofesor.Location = new System.Drawing.Point(12, 80);
            this.lblPofesor.Name = "lblPofesor";
            this.lblPofesor.Size = new System.Drawing.Size(46, 13);
            this.lblPofesor.TabIndex = 76;
            this.lblPofesor.Text = "Profesor";
            // 
            // lblNombreM
            // 
            this.lblNombreM.AutoSize = true;
            this.lblNombreM.Location = new System.Drawing.Point(12, 37);
            this.lblNombreM.Name = "lblNombreM";
            this.lblNombreM.Size = new System.Drawing.Size(82, 13);
            this.lblNombreM.TabIndex = 75;
            this.lblNombreM.Text = "Nombre Materia";
            this.lblNombreM.Click += new System.EventHandler(this.LblNumeroCurso_Click);
            // 
            // txtNombreM
            // 
            this.txtNombreM.Location = new System.Drawing.Point(107, 34);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(138, 20);
            this.txtNombreM.TabIndex = 74;
            // 
            // lblCreditoParcial
            // 
            this.lblCreditoParcial.AutoSize = true;
            this.lblCreditoParcial.Location = new System.Drawing.Point(12, 168);
            this.lblCreditoParcial.Name = "lblCreditoParcial";
            this.lblCreditoParcial.Size = new System.Drawing.Size(95, 13);
            this.lblCreditoParcial.TabIndex = 78;
            this.lblCreditoParcial.Text = "Creditos de Parcial";
            // 
            // lblCreditosClase
            // 
            this.lblCreditosClase.AutoSize = true;
            this.lblCreditosClase.Location = new System.Drawing.Point(12, 125);
            this.lblCreditosClase.Name = "lblCreditosClase";
            this.lblCreditosClase.Size = new System.Drawing.Size(89, 13);
            this.lblCreditosClase.TabIndex = 79;
            this.lblCreditosClase.Text = "Creditos de Clase";
            // 
            // nudCreditoClase
            // 
            this.nudCreditoClase.Location = new System.Drawing.Point(107, 123);
            this.nudCreditoClase.Name = "nudCreditoClase";
            this.nudCreditoClase.Size = new System.Drawing.Size(79, 20);
            this.nudCreditoClase.TabIndex = 80;
            this.nudCreditoClase.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // nudCreditoParcial
            // 
            this.nudCreditoParcial.Location = new System.Drawing.Point(107, 161);
            this.nudCreditoParcial.Name = "nudCreditoParcial";
            this.nudCreditoParcial.Size = new System.Drawing.Size(79, 20);
            this.nudCreditoParcial.TabIndex = 81;
            // 
            // frmMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 351);
            this.Controls.Add(this.nudCreditoParcial);
            this.Controls.Add(this.nudCreditoClase);
            this.Controls.Add(this.lblCreditosClase);
            this.Controls.Add(this.lblCreditoParcial);
            this.Controls.Add(this.cboProfesor);
            this.Controls.Add(this.lblPofesor);
            this.Controls.Add(this.lblNombreM);
            this.Controls.Add(this.txtNombreM);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstMateria);
            this.Name = "frmMateria";
            this.Text = "Materia";
            ((System.ComponentModel.ISupportInitialize)(this.nudCreditoClase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCreditoParcial)).EndInit();
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
        private System.Windows.Forms.ListBox lstMateria;
        private System.Windows.Forms.ComboBox cboProfesor;
        private System.Windows.Forms.Label lblPofesor;
        private System.Windows.Forms.Label lblNombreM;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.Label lblCreditoParcial;
        private System.Windows.Forms.Label lblCreditosClase;
        private System.Windows.Forms.NumericUpDown nudCreditoClase;
        private System.Windows.Forms.NumericUpDown nudCreditoParcial;
    }
}