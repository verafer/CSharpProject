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
            txtNombreM.Text = "";
            cboProfesor.SelectedItem = 0;
            nudCreditoClase.Value = 0;
            nudCreditoParcial.Value = 0;
        }


        private void DesbloquearFormulario()
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

        private void BloquearFormulario()
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

        private void ActualizarListaMateria()
        {
            lstMateria.DataSource = null;
            lstMateria.DataSource = Materia.ObtenerMateria();
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
            ActualizarListaMateria();
            cboProfesor.DataSource = Profesor.ObtenerProfesor();
            cboProfesor.SelectedItem = null;
            BloquearFormulario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modo = "AGREGAR";
            LimpiarFormulario();
            DesbloquearFormulario();
            txtNombreM.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            modo = "EDITAR";
            DesbloquearFormulario();
            txtNombreM.Focus();
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

        private void btnGuardar_Click(object sender, EventArgs e)
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
        private Materia ObtenerDatosFormulario()
        {
            Materia materia= new Materia();

            materia.Descripcion = txtNombreM.Text;
            materia.Profesor = (Profesor)cboProfesor.SelectedItem;
            materia.creditosClases =(int) nudCreditoClase.Value;
            materia.creditosPractica = (int)nudCreditoParcial.Value;
            

            return materia;

        }

        private void LstMateria_Click(object sender, EventArgs e)
        {
            Materia materia = new Materia();
            if (materia != null)
            {
                txtNombreM.Text = materia.Descripcion;
                cboProfesor.SelectedItem = materia.Profesor;
                nudCreditoClase.Value = materia.creditosClases;
                nudCreditoParcial.Value = materia.creditosPractica;
            }





            }
    }
}
