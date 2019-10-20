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
            cboTurno.DataSource = Turno.ObtenerTurno();
            cboMateria.SelectedItem = null;
            cboProfesor.SelectedItem = null;
            cboTurno.SelectedItem = null;
            BloquearFormulario();

        }
        private void ActualizarListaCurso()
        {
            lstCurso.DataSource = null;
            lstCurso.DataSource = Curso.ObtenerCursos();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            modo = "AGREGAR";
            LimpiarFormulario();
            DesbloquearFormulario();
            txtNumeroCurso.Focus();

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (modo == "AGREGAR")
            {
                Curso curso = ObtenerCursoFormulario();
                Curso.AgregarCurso(curso);
            }
            else if (modo == "EDITAR")
            {
                int index = lstCurso.SelectedIndex;
                Curso.listaCurso[index] = ObtenerCursoFormulario();



            }

        }
        private Curso ObtenerCursoFormulario()
        {
            Curso cur = new Curso();
            cur.numeroCurso = txtNumeroCurso.Text;
            cur.Materia = (Materia)cboMateria.SelectedItem;
            cur.Profesor = (Profesor)cboProfesor.SelectedItem;
            cur.Turno = (Turno)cboTurno.SelectedItem;
            if (rbuDistancia.Checked)
            {
                cur.modalidad = Modalidad.Distancia;
            }
            else if (rbuPresencial.Checked)
            {
                cur.modalidad = Modalidad.Presencial;
            }
            cur.FechaInicio = dtpFechaInicio.Value.Date;
            cur.FechaFin = dtpFechaFin.Value.Date;
            return cur;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            modo = "EDITAR";
            DesbloquearFormulario();
            txtNumeroCurso.Focus();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
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

        private void LstCurso_Click(object sender, EventArgs e)
        {
            Curso curso = (Curso)lstCurso.SelectedItem;

            if (curso != null)
            {
                txtNumeroCurso.Text = curso.numeroCurso;

                cboMateria.SelectedItem = curso.Materia;
                cboProfesor.SelectedItem = curso.Profesor;
                cboTurno.SelectedItem = curso.Turno;
                if (curso.modalidad == Modalidad.Distancia)
                {
                    rbuDistancia.Checked = true;
                }
                else if (curso.modalidad == Modalidad.Presencial)
                {
                    rbuPresencial.Checked = true;
                }
                dtpFechaInicio.Value = curso.FechaInicio;
                dtpFechaFin.Value = curso.FechaFin;
            }
        }

    }
}
