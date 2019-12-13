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
    public partial class frmCurso : Form
    {
        string modo;
        public frmCurso()
        {
            InitializeComponent();
        }
        private void LimpiarFormulario()
        {
            try
            {

                txtNumeroCurso.Text = "";
            cboMateria.SelectedItem = 0;
            cboProfesor.SelectedItem = 0;
            cboTurno.SelectedItem = 0;
            rbuDistancia.Checked = false;
            rbuPresencial.Checked = false;
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
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
                txtNumeroCurso.Enabled = true;
            cboMateria.Enabled = true;
            cboProfesor.Enabled = true;
            cboTurno.Enabled = true;
            rbuDistancia.Enabled = true;
            rbuPresencial.Enabled = true;
            dtpFechaInicio.Enabled = true;
            dtpFechaFin.Enabled = true;
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
                txtNumeroCurso.Enabled = false;
            cboMateria.Enabled = false;
            cboProfesor.Enabled = false;
            cboTurno.Enabled = false;
            rbuDistancia.Enabled = false;
            rbuPresencial.Enabled = false;
            dtpFechaInicio.Enabled = false;
            dtpFechaFin.Enabled = false;
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
        private void LblNumeroCurso_Click(object sender, EventArgs e)
        {

        }

        private void FrmCurso_Load(object sender, EventArgs e)
        {
            try
            {
                ActualizarListaCurso();
            cboMateria.DataSource = Materia.ObtenerMaterias();
            cboProfesor.DataSource = Profesor.ObtenerProfesores();
            cboTurno.DataSource = Enum.GetValues(typeof(Turnos));
            cboMateria.SelectedIndex = 0;
            cboProfesor.SelectedIndex = 0;
            cboTurno.SelectedItem = null;
            BloquearFormulario();
                LimpiarFormulario();
            }

            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al cargar el formulario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ActualizarListaCurso()
        {
            lstCurso.DataSource = null;
            lstCurso.DataSource = Curso.ObtenerCursos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                modo = "AGREGAR";
            LimpiarFormulario();
            DesbloquearFormulario();
            txtNumeroCurso.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al agregar Curso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var c = ObtenerCursoFormulario();
                if (ValidarDatos())
                {
                    if (modo == "AGREGAR")
            {
               Curso.AgregarCurso(c);
            }
            else if (modo == "EDITAR")
            {

                if (this.lstCurso.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Favor seleccione una fila");
                }

                else
                {
                    int indice = lstCurso.SelectedIndex;
                    Curso.EditarCurso(indice, c);
                    ActualizarListaCurso();
                }


            }

            LimpiarFormulario();
            ActualizarListaCurso();
            BloquearFormulario();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar!");
            }
        }
        private Curso ObtenerCursoFormulario()
        {
            Curso cur = new Curso();
            cur.NumeroCurso = txtNumeroCurso.Text;
            cur.Materia = (Materia)cboMateria.SelectedItem;
            cur.Profesor = (Profesor)cboProfesor.SelectedItem;
            cur.Turno = (Turnos)cboTurno.SelectedItem;
            if (rbuDistancia.Checked)
            {
                cur.Modalidad = Modalidad.Distancia;
            }
            else if (rbuPresencial.Checked)
            {
                cur.Modalidad = Modalidad.Presencial;
            }
            cur.FechaInicio = dtpFechaInicio.Value.Date;
            cur.FechaFin = dtpFechaFin.Value.Date;
            return cur;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                modo = "EDITAR";
            DesbloquearFormulario();
            txtNumeroCurso.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al editar Curso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstCurso.SelectedItems.Count > 0)
            {
                Curso curso = (Curso)lstCurso.SelectedItem;
                Curso.listaCurso.Remove(curso);
                ActualizarListaCurso();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show("Favor seleccionar de la lista para eliminar");
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al eliminar curso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LstCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstCurso_Click(object sender, EventArgs e)
        {
            try
            {
                Curso curso = (Curso)lstCurso.SelectedItem;

            if (curso != null)
            {
                txtNumeroCurso.Text = curso.NumeroCurso;

                cboMateria.SelectedItem = curso.Materia;
                cboProfesor.SelectedItem = curso.Profesor;
                cboTurno.SelectedItem = curso.Turno;
                if (curso.Modalidad ==  Modalidad.Distancia)
                {
                    rbuDistancia.Checked = true;
                }
                else if (curso.Modalidad == Modalidad.Presencial)
                {
                    rbuPresencial.Checked = true;
                }
                dtpFechaInicio.Value = curso.FechaInicio;
                dtpFechaFin.Value = curso.FechaFin;
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al obtener Curso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormulario();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
        private bool ValidarDatos()
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtNumeroCurso.Text))
                {
                    MessageBox.Show("El numero curso no puede estar vacío", "Error");
                    txtNumeroCurso.Focus();
                    return false;
                }
                if (cboMateria.SelectedItem == null)
                {
                    MessageBox.Show("Por favor seleccione una Materia", "Error");
                    cboMateria.Focus();
                    return false;
                }
                if (cboProfesor.SelectedItem == null)
                {
                    MessageBox.Show("Por favor seleccione un Profesor", "Error");
                    cboProfesor.Focus();
                    return false;
                }
                if (cboTurno.SelectedItem == null)
                {
                    MessageBox.Show("Por favor seleccione un turno", "Error");
                    cboProfesor.Focus();
                    return false;
                }
                var fechaIncorrecta = new DateTime(2100, 1, 1);

                if (dtpFechaInicio.Value < DateTime.Now || dtpFechaInicio.Value > DateTime.Parse("01/01/2100") || dtpFechaInicio.Value > fechaIncorrecta)
                {
                    MessageBox.Show("Por favor ingrese una fecha Inicio correcta", "Error");
                    dtpFechaInicio.Focus();
                    return false;
                }
                if (dtpFechaFin.Value < DateTime.Now || dtpFechaFin.Value > DateTime.Parse("01/01/2100") || dtpFechaFin.Value > fechaIncorrecta)
                {
                    MessageBox.Show("Por favor ingrese una fecha de fin correcta", "Error");
                    dtpFechaFin.Focus();
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
