using System;
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
        string modo;

        public frmProfesor()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modo == "AGREGAR")
            {
                Profesor profesor = ObtenerDatosFormulario();
                Profesor.AgregarProfesor(profesor);
            }
            else if (modo == "EDITAR")
            {
                int index = lstProfesor.SelectedIndex;
                Profesor p = ObtenerDatosFormulario();
                Profesor.EditarProfesor(index, p);
            }

            ActualizarListaProfesores();
            LimpiarFormulario();
            BloquearFormulario();
        }

        private Profesor ObtenerDatosFormulario()
        {
            Profesor profesor = new Profesor();

            profesor.NroDocumento = txtNroDocumento.Text;
            if (cboTipoDocumento.SelectedItem != null)
            {
                profesor.TipoDocumento = (TipoDocumento)cboTipoDocumento.SelectedItem;
            }
            else
            {
                profesor.TipoDocumento = TipoDocumento.CI;
            }
            profesor.Nombre = txtNombre.Text;
            profesor.Apellido = txtApellido.Text;
            profesor.FechaNacimiento = dtpFechaNacimiento.Value;
            profesor.Direccion = txtDireccion.Text;
            profesor.Ciudad = (Ciudad)cboCiudad.SelectedItem;
            profesor.Email = txtEmail.Text;
            profesor.Telefono = txtTelefono.Text;

            profesor.NroMatricula = txtNroMatricula.Text;
            //profesor.FechaIngreso = dtpFechaIngreso.Value;
            profesor.TituloObtenido = txtTituloObtenido.Text;

            return profesor;

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

        private void ActualizarListaProfesores()
        {
            lstProfesor.DataSource = null;
            lstProfesor.DataSource = Profesor.ObtenerProfesores();
        }

        private void BloquearFormulario()
        {
            txtNroDocumento.Enabled = false;
            cboTipoDocumento.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            dtpFechaNacimiento.Enabled = false;
            txtDireccion.Enabled = false;
            cboCiudad.Enabled = false;
            txtEmail.Enabled = false;
            txtTelefono.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;

            txtNroMatricula.Enabled = false;
            dtpFechaIngreso.Enabled = false;
            txtTituloObtenido.Enabled = false;

            btnAgregar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void DesbloquearFormulario()
        {
            txtNroDocumento.Enabled = true;
            cboTipoDocumento.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            dtpFechaNacimiento.Enabled = true;
            txtDireccion.Enabled = true;
            cboCiudad.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefono.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

            txtNroMatricula.Enabled = true;
            dtpFechaIngreso.Enabled = true;
            txtTituloObtenido.Enabled = true;

            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void frmProfesor_Load(object sender, EventArgs e)
        {
            ActualizarListaProfesores();
            cboTipoDocumento.DataSource = Enum.GetValues(typeof(TipoDocumento));
            cboCiudad.DataSource = Ciudad.ObtenerCiudades();
            cboTipoDocumento.SelectedItem = null;
            cboCiudad.SelectedItem = null;
            BloquearFormulario();
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
            modo = "EDITAR";
            DesbloquearFormulario();
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstProfesor.SelectedItems.Count > 0)
            {
                Profesor profesor = (Profesor)lstProfesor.SelectedItem;
                Profesor.EliminarProfesor(profesor);
                ActualizarListaProfesores();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Favor seleccionar de la lista para eliminar");
            }
        }

        private void lstProfesor_Click(object sender, EventArgs e)
        {
            Profesor profesor = (Profesor)lstProfesor.SelectedItem;

            if (profesor != null)
            {
                txtNroDocumento.Text = profesor.NroDocumento;
                cboTipoDocumento.SelectedItem = profesor.TipoDocumento;
                txtNombre.Text = profesor.Nombre;
                txtApellido.Text = profesor.Apellido;

                dtpFechaNacimiento.Value = profesor.FechaNacimiento;
                txtDireccion.Text = profesor.Direccion;
                cboCiudad.SelectedItem = profesor.Ciudad;
                txtEmail.Text = profesor.Email;
                txtTelefono.Text = profesor.Telefono;

                txtNroMatricula.Text = profesor.NroMatricula;
                //dtpFechaIngreso.Value = profesor.FechaIngreso;
                txtTituloObtenido.Text = profesor.TituloObtenido;

            }
        }
    }
}
