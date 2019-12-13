using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            try
            {
                if (ValidarDatos())
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
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar!");
            }
        }

        private Profesor ObtenerDatosFormulario()
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Atencion", "No se pudo obtener los datos del formulario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void LimpiarFormulario()
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al limpiar formulario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarListaProfesores()
        {
            try
            {
                lstProfesor.DataSource = null;
            lstProfesor.DataSource = Profesor.ObtenerProfesores();
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al actualizar lista de Profesor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BloquearFormulario()
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al bloquear el formulario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DesbloquearFormulario()
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al desbloquear el formulario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmProfesor_Load(object sender, EventArgs e)
        {
            try
            {
                ActualizarListaProfesores();
            cboTipoDocumento.DataSource = Enum.GetValues(typeof(TipoDocumento));
            cboCiudad.DataSource = Ciudad.ObtenerCiudades();
            cboTipoDocumento.SelectedItem = null;
            cboCiudad.SelectedItem = null;
            BloquearFormulario();
            LimpiarFormulario();
        }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al cargar el formulario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
            {
             modo = "AGREGAR";
            LimpiarFormulario();
            DesbloquearFormulario();
            txtNombre.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al agregar Profesor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                modo = "EDITAR";
            DesbloquearFormulario();
            txtNombre.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al editar Profesor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al eliminar profesor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lstProfesor_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al obtener Profesor!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarDatos()
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío", "Error");
                txtNombre.Focus();
                return false;
            }
            if (txtNombre.Text.Length < 3 || txtNombre.Text.Length > 15)
            {
                MessageBox.Show("La longitud de caracteres es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El apellido no puede estar vacío", "Error");
                txtApellido.Focus();
                return false;
            }
            if (txtApellido.Text.Length < 3 || txtApellido.Text.Length > 15)
            {
                MessageBox.Show("La longitud de caracteres es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return false;
            }
            var fechaIncorrecta = new DateTime(2100, 1, 1);

            if (dtpFechaNacimiento.Value < DateTime.Now || dtpFechaNacimiento.Value > DateTime.Parse("01/01/2100") || dtpFechaNacimiento.Value > fechaIncorrecta)
            {
                MessageBox.Show("Por favor ingrese una fecha de Nacimiento correcta", "Error");
                dtpFechaNacimiento.Focus();
                return false;
            }
            if (dtpFechaIngreso.Value < DateTime.Now || dtpFechaIngreso.Value > DateTime.Parse("01/01/2100") || dtpFechaIngreso.Value > fechaIncorrecta)
            {
                MessageBox.Show("Por favor ingrese una fecha de Ingreso correcta", "Error");
                dtpFechaIngreso.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Direccion no puede estar vacío", "Error");
                txtDireccion.Focus();
                return false;
            }

            if (cboCiudad.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione una Ciudad", "Error");
                cboCiudad.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtNroDocumento.Text))
            {
                MessageBox.Show("nro documento no puede estar vacio", "Error");
                txtNroDocumento.Focus();
                return false;
            }

            if (cboTipoDocumento.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un tipo documento", "Error");
                cboTipoDocumento.Focus();
                return false;
            }

            if (String.IsNullOrWhiteSpace(txtEmail.Text))
           {
                MessageBox.Show("Email no puede estar vacio", "Error");
               txtEmail.Focus();
               return false;
            }
            if (email_bien_escrito(txtEmail.Text)== false)
            {
                MessageBox.Show("Email no valida", "Error");
                txtEmail.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Telefono no puede estar vacio", "Error");
                txtTelefono.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtNroMatricula.Text))
            {
                MessageBox.Show("Nro Matricula no puede estar vacio", "Error");
                txtNroMatricula.Focus();
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtTituloObtenido.Text))
            {
                MessageBox.Show("Titulo Obtenido no puede estar vacio", "Error");
                txtTituloObtenido.Focus();
                return false;
            }

            return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al validar datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        private Boolean email_bien_escrito(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
