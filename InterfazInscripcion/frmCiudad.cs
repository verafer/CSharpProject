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
    public partial class frmCiudad : Form
    {
        string modo;

        public frmCiudad()
        {
            InitializeComponent();
        }

        private void frmCiudad_Load(object sender, EventArgs e)
        {
            try
            {
                cboDepartamento.DataSource = Enum.GetValues(typeof(Departamento));
            cboDepartamento.SelectedItem = null;
            ActualizarListaCiudades();
            BloquearFormulario();
            LimpiarFormulario();
            lstCiudad.SelectedItem = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al cargar el formulario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatos())
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
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar!");
            }
        }

        private Ciudad ObtenerDatosFormulario()
        {
            try
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
            cboDepartamento.SelectedItem = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al limpiar formulario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DesbloquearFormulario()
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al desbloquear el formulario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarListaCiudades()
        {
            try
            {
                lstCiudad.DataSource = null;
            lstCiudad.DataSource = Ciudad.ObtenerCiudades();
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
                txtNombre.Enabled = false;
            cboDepartamento.Enabled = false;

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
                MessageBox.Show("Atencion", "Error al agregar Ciudad!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al editar Ciudad!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al eliminar Ciudad!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Ciudad ciudad = (Ciudad)lstCiudad.SelectedItem;

            if (ciudad != null)
            {
                txtNombre.Text = ciudad.Nombre;
                cboDepartamento.SelectedItem = ciudad.Departamento;
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al obtener ciudad!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarDatos()
        {
            try
            {
                if (cboDepartamento.SelectedItem == null)
                {
                    MessageBox.Show("Por favor seleccione un Departamento", "Error");
                    cboDepartamento.Focus();
                    return false;
                }
                if (String.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Nombre no puede estar vacio", "Error");
                    txtNombre.Focus();
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

    }
}
