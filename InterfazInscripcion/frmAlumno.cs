using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
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
            try
            {
                var a = ObtenerDatosFormulario();
                if (validarDatos())
                {
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
                            Alumno alumno = (Alumno)lstAlumno.SelectedItem;
                            int index = alumno.Id;

                            Alumno.EditarAlumno(a, index);
                            ActualizarListaAlumnos();
                        }
                    }

                    LimpiarFormulario();
                    ActualizarListaAlumnos();
                    BloquearFormulario();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar!");
            }
        }

        private Alumno ObtenerDatosFormulario()
        {
            try
            {
                Alumno alumno = new Alumno();

                alumno.NroDocumento = txtNroDocumento.Text;
                if (cboTipoDocumento.SelectedItem != null)
                {
                    alumno.TipoDocumento = (TipoDocumento)cboTipoDocumento.SelectedItem;
                }
                else
                {
                    alumno.TipoDocumento = TipoDocumento.CI;
                }
                alumno.Nombre = txtNombre.Text;
                alumno.Apellido = txtApellido.Text;
                alumno.FechaNacimiento = dtpFechaNacimiento.Value;
                alumno.Direccion = txtDireccion.Text;
                alumno.Ciudad = (Ciudad)cboCiudad.SelectedItem;

                if (ValidarEmail(txtEmail.Text))
                {
                    alumno.Email = txtEmail.Text;
                    //EnviarCorreo(txtEmail.Text);
                }
                else
                {
                    MessageBox.Show("Email inválido. Favor vuelva a ingresar");
                }
                alumno.Telefono = txtTelefono.Text;

                return alumno;
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "No se pudo obtener los datos del formulario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private bool validarDatos()
        {
            try
            {
                bool ban = true;
                if (txtNombre.Text.Trim() == "")
                {
                    MessageBox.Show("Favor ingresar el nombre");
                    txtNombre.Focus();
                    ban = false;
                }

                if (txtApellido.Text.Trim() == "")
                {
                    MessageBox.Show("Favor ingresar el apellido");
                    txtApellido.Focus();
                    ban = false;
                }

                if (txtDireccion.Text.Trim() == "")
                {
                    MessageBox.Show("Favor ingresar la direccion");
                    txtDireccion.Focus();
                    ban = false;
                }

                if (cboCiudad.SelectedIndex == -1)
                {
                    MessageBox.Show("Favor seleccionar la ciudad");
                    cboCiudad.Focus();
                    ban = false;
                }

                if (cboTipoDocumento.SelectedIndex == -1)
                {
                    MessageBox.Show("Favor seleccionar el tipo de documento");
                    cboTipoDocumento.Focus();
                    ban = false;
                }

                if (txtTelefono.Text.Trim() == "")
                {
                    MessageBox.Show("Favor ingresar el nro de telefono");
                    txtTelefono.Focus();
                    ban = false;
                }

                if (txtNroDocumento.Text.Trim() == "")
                {
                    MessageBox.Show("Favor ingresar el nro de documento");
                    txtNroDocumento.Focus();
                    ban = false;
                }

                if (txtEmail.Text.Trim() == "")
                {
                    MessageBox.Show("Favor ingresar el email");
                    txtEmail.Focus();
                    ban = false;
                }

                return ban;
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al validar datos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void ActualizarListaAlumnos()
        {
            try
            {
                lstAlumno.DataSource = null;
                lstAlumno.DataSource = Alumno.ObtenerAlumnos();
                lstAlumno.SelectedItem = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al actualizar lista de alumnos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                btnAgregar.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al desbloquear el formulario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                lstAlumno.SelectedItem = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al limpiar formulario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Atencion", "Error al agregar alumno!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Atencion", "Error al editar alumno!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstAlumno.SelectedItems.Count > 0)
                {
                    Alumno alumno = (Alumno)lstAlumno.SelectedItem;
                    Alumno.EliminarAlumno(alumno);
                    ActualizarListaAlumnos();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Atencion", "Favor seleccionar de la lista para eliminar", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al eliminar alumno!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            try
            {
                cboTipoDocumento.DataSource = Enum.GetValues(typeof(TipoDocumento));
                cboCiudad.DataSource = Ciudad.ObtenerCiudades();
                cboTipoDocumento.SelectedItem = null;
                cboCiudad.SelectedItem = null;
                ActualizarListaAlumnos();
                BloquearFormulario();
                LimpiarFormulario();
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al cargar el formulario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lstAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstAlumno.SelectedItem != null)
                {
                    Alumno alumno = (Alumno)lstAlumno.SelectedItem;

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
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al obtener alumno!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private Boolean ValidarEmail(String email)
        {
            try
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
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al validar correo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }
    }
}
