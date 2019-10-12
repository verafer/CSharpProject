﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesInscripcion;

namespace InterfazInscripcion
{
    public partial class frmProfesor : Form
    {
        public frmProfesor()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            txtDireccion.Text = "";
            cboCiudad.SelectedItem = null;
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtNroDocumento.Text = "";
            cboTipoDocumento.SelectedItem = null;

            txtNroMatricula.Text = "";
            dtpFechaIngreso.Value = DateTime.Now;
            txtTituloObtenido.Text = "";
        }

        private void DesbloquearFormularios()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            dtpFechaNacimiento.Enabled = true;
            txtDireccion.Enabled = true;
            cboCiudad.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefono.Enabled = true;
            txtNroDocumento.Enabled = true;
            cboTipoDocumento.Enabled = true;

            txtNroMatricula.Enabled = true;
            dtpFechaIngreso.Enabled = true;
            txtTituloObtenido.Enabled = true;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

            lstProfesor.Enabled = false;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
        }
    }
}
