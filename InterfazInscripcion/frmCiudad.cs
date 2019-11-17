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
    public partial class frmCiudad : Form
    {
        string modo;

        public frmCiudad()
        {
            InitializeComponent();
        }

        private void frmCiudad_Load(object sender, EventArgs e)
        {
            cboDepartamento.DataSource = Enum.GetValues(typeof(Departamento));
            cboDepartamento.SelectedItem = null;
            ActualizarListaCiudades();
            BloquearFormulario();
            LimpiarFormulario();
            lstCiudad.SelectedItem = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modo == "AGREGAR")
            {
                Ciudad ciudad = ObtenerDatosFormulario();
                if (ciudad != null)
                    Ciudad.AgregarCiudad(ciudad);
            }
            else if (modo == "EDITAR")
            {
                Ciudad ciudad = (Ciudad)lstCiudad.SelectedItem;
                int index = ciudad.Id;

                Ciudad nueva_ciudad = ObtenerDatosFormulario();
                if( nueva_ciudad != null)
                Ciudad.EditarCiudad(nueva_ciudad, index);
            }

            ActualizarListaCiudades();
            LimpiarFormulario();
            BloquearFormulario();
        }

        private Ciudad ObtenerDatosFormulario()
        {
            if (txtNombre.Text == "" || cboDepartamento.SelectedItem == null)
            {
                MessageBox.Show("Favor completar todos los campos");
                return null;
            }

            Ciudad ciudad = new Ciudad();

            ciudad.Nombre = txtNombre.Text;
            ciudad.Departamento = (Departamento)cboDepartamento.SelectedItem;

            return ciudad;
        }

        private void LimpiarFormulario()
        {
            txtNombre.Text = "";
            cboDepartamento.SelectedItem = null;
        }

        private void DesbloquearFormulario()
        {
            txtNombre.Enabled = true;
            cboDepartamento.Enabled = true;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;
            
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
        }

        private void ActualizarListaCiudades()
        {
            lstCiudad.DataSource = null;
            lstCiudad.DataSource = Ciudad.ObtenerCiudades();
        }

        private void BloquearFormulario()
        {
            txtNombre.Enabled = false;
            cboDepartamento.Enabled = false;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            btnAgregar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormulario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modo = "AGREGAR";
            LimpiarFormulario();
            DesbloquearFormulario();
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstCiudad.SelectedItems.Count > 0)
            {

                modo = "EDITAR";
                DesbloquearFormulario();
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Favor seleccionar de la lista para editar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstCiudad.SelectedItems.Count > 0)
            {
                Ciudad ciudad = (Ciudad)lstCiudad.SelectedItem;
                Ciudad.EliminarCiudad(ciudad);
                ActualizarListaCiudades();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Favor seleccionar de la lista para eliminar");
            }
        }

        private void lstCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ciudad ciudad = (Ciudad)lstCiudad.SelectedItem;

            if (ciudad != null)
            {
                txtNombre.Text = ciudad.Nombre;
                cboDepartamento.SelectedItem = ciudad.Departamento;
            }
        }
    }
}
