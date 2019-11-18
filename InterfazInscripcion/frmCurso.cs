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
            txtNumeroCurso.Text = "";
            cboMateria.SelectedItem = 0;
            cboProfesor.SelectedItem = 0;
            cboTurno.SelectedItem = 0;
            rbuDistancia.Checked = false;
            rbuPresencial.Checked = false;
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
        }
        private void DesbloquearFormulario()
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
        private void BloquearFormulario()
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
        private void LblNumeroCurso_Click(object sender, EventArgs e)
        {

        }

        private void FrmCurso_Load(object sender, EventArgs e)
        {
            ActualizarListaCurso();
            cboMateria.DataSource = Materia.ObtenerMateria();
            cboProfesor.DataSource = Profesor.ObtenerProfesor();
            cboTurno.DataSource = Enum.GetValues(typeof(Turnos));
            cboMateria.SelectedIndex = 1;
            cboProfesor.SelectedIndex =1 ;
            cboTurno.SelectedItem = null;
            BloquearFormulario();

        }
        private void ActualizarListaCurso()
        {
            lstCurso.DataSource = null;
            lstCurso.DataSource = Curso.ObtenerCursos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modo = "AGREGAR";
            LimpiarFormulario();
            DesbloquearFormulario();
            txtNumeroCurso.Focus();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var c = ObtenerCursoFormulario();

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
                    Curso.EditarCurso(c, indice);
                    ActualizarListaCurso();
                }


            }

            LimpiarFormulario();
            ActualizarListaCurso();
            BloquearFormulario();

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
                cur.Modalidad = modalidad.Distancia;
            }
            else if (rbuPresencial.Checked)
            {
                cur.Modalidad = modalidad.Presencial;
            }
            cur.FechaInicio = dtpFechaInicio.Value.Date;
            cur.FechaFin = dtpFechaFin.Value.Date;
            return cur;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            modo = "EDITAR";
            DesbloquearFormulario();
            txtNumeroCurso.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
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

        private void LstCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstCurso_Click(object sender, EventArgs e)
        {
            Curso curso = (Curso)lstCurso.SelectedItem;

            if (curso != null)
            {
                txtNumeroCurso.Text = curso.NumeroCurso;

                cboMateria.SelectedItem = curso.Materia;
                cboProfesor.SelectedItem = curso.Profesor;
                cboTurno.SelectedItem = curso.Turno;
                if (curso.Modalidad == modalidad.Distancia)
                {
                    rbuDistancia.Checked = true;
                }
                else if (curso.Modalidad == modalidad.Presencial)
                {
                    rbuPresencial.Checked = true;
                }
                dtpFechaInicio.Value = curso.FechaInicio;
                dtpFechaFin.Value = curso.FechaFin;
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
    }
}
