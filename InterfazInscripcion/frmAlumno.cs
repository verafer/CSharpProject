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
    public partial class frmAlumno : Form
    {
        string modo;

        public frmAlumno()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var a = ObtenerDatosFormulario();

            if (modo == "AGREGAR")
            {
                Alumno.AgregarAlumno(a);
            }
            else if (modo == "EDITAR")
            {

                if (this.lstAlumno.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Favor seleccione una fila");
                }

                else
                {
                    int indice = lstAlumno.SelectedIndex;
                    Alumno.EditarAlumno(a, indice);
                    ActualizarListaAlumnos();
                }


            }

            LimpiarFormulario();
            ActualizarListaAlumnos();
            BloquearFormulario();
        }

        private Alumno ObtenerDatosFormulario()
        {
            Alumno alumno = new Alumno();

            alumno.NroDocumento = txtNroDocumento.Text;
            alumno.TipoDocumento = (TipoDocumento)cboTipoDocumento.SelectedItem;
            alumno.Nombre = txtNombre.Text;
            alumno.Apellido = txtApellido.Text;
            alumno.FechaNacimiento = dtpFechaNacimiento.Value;
            alumno.Direccion = txtDireccion.Text;
            alumno.Ciudad = (Ciudad)cboCiudad.SelectedItem;
            alumno.Email = txtEmail.Text;
            alumno.Telefono = txtTelefono.Text;

            return alumno;

        }

        private void ActualizarListaAlumnos()
        {
            lstAlumno.DataSource = null;
            lstAlumno.DataSource = Alumno.ObtenerAlumno();
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

            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
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

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;

            lstAlumno.Enabled = false;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
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
            if (lstAlumno.SelectedItems.Count > 0)
            {
                Alumno alumno = (Alumno)lstAlumno.SelectedItem;
                Alumno.listaAlumno.Remove(alumno);
                ActualizarListaAlumnos();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Favor seleccionar de la lista para eliminar");
            }
        }

        private void lstAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumno = (Alumno)lstAlumno.SelectedItem;

            if (alumno != null)
            {
                txtNroDocumento.Text = alumno.NroDocumento;
                cboTipoDocumento.SelectedItem = alumno.TipoDocumento;
                txtNombre.Text = alumno.Nombre;
                txtApellido.Text = alumno.Apellido;

                dtpFechaNacimiento.Value = alumno.FechaNacimiento;
                txtDireccion.Text = alumno.Direccion;
                cboCiudad.SelectedItem = alumno.Ciudad;
                txtEmail.Text = alumno.Email;
                txtTelefono.Text = alumno.Telefono;
            }
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            ActualizarListaAlumnos();
            cboTipoDocumento.DataSource = Enum.GetValues(typeof(TipoDocumento));
            cboCiudad.DataSource = Ciudad.ObtenerCiudad();
            cboTipoDocumento.SelectedItem = null;
            cboCiudad.SelectedItem = null;
            BloquearFormulario();
        }
    }
}
