using ClasesInscripcion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazInscripcion
{

    public partial class frmMateria : Form
    {
        string modo;
        public frmMateria()
        {
            InitializeComponent();
        }

        private void LimpiarFormulario()
        {
            try
            {
                txtNombreM.Text = "";
                cboProfesor.SelectedItem = 0;
                nudCreditoClase.Value = 0;
                nudCreditoParcial.Value = 0;
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
                txtNombreM.Enabled = true;
                cboProfesor.Enabled = true;
                nudCreditoClase.Enabled = true;
                nudCreditoParcial.Enabled = true;
                btnCancelar.Enabled = true;

                btnGuardar.Enabled = true;
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

        private void BloquearFormulario()
        {
            try
            {
                txtNombreM.Enabled = false;
                cboProfesor.Enabled = false;
                nudCreditoClase.Enabled = false;
                nudCreditoParcial.Enabled = false;
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
                btnLimpiar.Enabled = false;

                btnAgregar.Enabled = true;
                btnEliminar.Enabled = true;
                btnEditar.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al bloquear el formulario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarListaMateria()
        {
            try
            {
                lstMateria.DataSource = null;
                lstMateria.DataSource = Materia.ObtenerMaterias();
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al actualizar lista de Materia!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LblNumeroCurso_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmMateria_Load(object sender, EventArgs e)
        {
            try
            {
                ActualizarListaMateria();
                cboProfesor.DataSource = Profesor.ObtenerProfesores();
                cboProfesor.SelectedItem = null;
                BloquearFormulario();
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al cargar el formulario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                modo = "AGREGAR";
                LimpiarFormulario();
                DesbloquearFormulario();
                txtNombreM.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al agregar Materia!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                modo = "EDITAR";
                DesbloquearFormulario();
                txtNombreM.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al editar Materia!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormulario();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstMateria.SelectedItems.Count > 0)
                {
                    Materia materia = (Materia)lstMateria.SelectedItem;
                    Materia.listaMateria.Remove(materia);
                    ActualizarListaMateria();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Favor seleccionar de la lista para eliminar");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al eliminar Materia!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatos())
                {
                    var m = ObtenerDatosFormulario();

                    if (modo == "AGREGAR")
                    {
                        Materia.AgregarMateria(m);
                    }
                    else if (modo == "EDITAR")
                    {

                        if (this.lstMateria.SelectedItems.Count == 0)
                        {
                            MessageBox.Show("Favor seleccione una fila");
                        }

                        else
                        {
                            int indice = lstMateria.SelectedIndex;
                            Materia.EditarMateria(m, indice);
                            ActualizarListaMateria();
                        }


                    }

                    LimpiarFormulario();
                    ActualizarListaMateria();
                    BloquearFormulario();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar!");
            }
        }
        private Materia ObtenerDatosFormulario()
        {
            try
            {
                Materia materia = new Materia();

                materia.Descripcion = txtNombreM.Text;
                materia.Profesor = (Profesor)cboProfesor.SelectedItem;
                materia.creditosClases = (int)nudCreditoClase.Value;
                materia.creditosPractica = (int)nudCreditoParcial.Value;


                return materia;
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "No se pudo obtener los datos del formulario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void LstMateria_Click(object sender, EventArgs e)
        {
            try
            {
                Materia materia = (Materia)lstMateria.SelectedItem;
                if (materia != null)
                {
                    txtNombreM.Text = materia.Descripcion;
                    cboProfesor.SelectedItem = materia.Profesor;
                    nudCreditoClase.Value = materia.creditosClases;
                    nudCreditoParcial.Value = materia.creditosPractica;
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al obtener Materia!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private bool ValidarDatos()
            {
                try
                {
                    if (String.IsNullOrWhiteSpace(txtNombreM.Text))
                    {
                        MessageBox.Show("El nombre no puede estar vacío", "Error");
                        txtNombreM.Focus();
                        return false;
                    }
                if (cboProfesor.SelectedItem == null)
                {
                    MessageBox.Show("Por favor seleccione una profesor", "Error");
                    cboProfesor.Focus();
                    return false;
                }
                if (nudCreditoClase.Value==0)
                {
                    MessageBox.Show(" credito de clase no puede estar vacío", "Error");
                    txtNombreM.Focus();
                    return false;
                }
                if (nudCreditoParcial.Value == 0)
                {
                    MessageBox.Show(" credito de parcial no puede estar vacío", "Error");
                    txtNombreM.Focus();
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
