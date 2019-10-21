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
    public partial class frmInscripcionCurso : Form
    {

        public enum Modo
        {
            AGREGAR,
            EDITAR
        }

        Modo modo;

        public frmInscripcionCurso()
        {
            InitializeComponent();
        }

        private void frmInscripcionCurso_Load(object sender, EventArgs e)
        {

            cboAlumno.DataSource = Alumno.ObtenerAlumno();
            cboAlumno.SelectedItem = null;
            cboCurso.DataSource = Curso.ObtenerCursos();
            cboCurso.SelectedItem = null;
            BloquearFormulario();
            DeshabilitarBotones();
        }

        private void cboAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAlumno.SelectedItem != null)
            {
                lstCursos.DataSource = null;
                lstCursos.DataSource = InscripcionCurso.ObtenerCursosDeAlumno((Alumno)cboAlumno.SelectedItem);
                lstCursos.Enabled = true;
                HabilitarBotones();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modo = Modo.AGREGAR;
            // LimpiarFormulario();
            DesbloquearFormulario();
            DeshabilitarBotones();
        }

        private void HabilitarBotones()
        {
            btnAgregar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void DeshabilitarBotones()
        {
            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void BloquearFormulario()
        {
            cboCurso.Enabled = false;
            cboAlumno.Enabled = true;
            lstCursos.Enabled = true;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnLimpiar.Enabled = false;
        }

        private void DesbloquearFormulario()
        {
            cboCurso.Enabled = true;
            cboAlumno.Enabled = false;
            lstCursos.Enabled = false;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnLimpiar.Enabled = true;
        }

        private void LimpiarFormulario()
        {
            cboCurso.SelectedIndex = -1;
            txtMateria.Text = "";
            txtProfesor.Text = "";
            txtTurno.Text = "";
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
            DeshabilitarBotones();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboCurso.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un curso");
                return;
            }
            if (modo == Modo.AGREGAR)
            {
                InscripcionCurso ic = new InscripcionCurso((Alumno)cboAlumno.SelectedItem, (Curso)cboCurso.SelectedItem);
                InscripcionCurso.AgregarInscripto(ic, (Curso)cboCurso.SelectedItem);
            }
            else if (modo == Modo.EDITAR)
            {

                if (this.lstCursos.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Favor seleccione una fila");
                }

                else
                {
                    int indice = lstCursos.SelectedIndex;
                   // Curso.EditarCurso(, indice);
                    ActualizarListaCursos();
                }


            }

            LimpiarFormulario();
            ActualizarListaCursos();
            BloquearFormulario();
            HabilitarBotones();
        }




        private void ActualizarListaCursos()
        {
            lstCursos.DataSource = null;
            lstCursos.DataSource = InscripcionCurso.ObtenerCursosDeAlumno((Alumno)cboAlumno.SelectedItem);
            lstCursos.SelectedIndex = -1;
        }

        private void ObtenerDatosCurso()
        {
            Curso c = (Curso)cboCurso.SelectedItem;
            if(cboCurso.SelectedItem != null)
            {
                if (c.Materia != null) txtMateria.Text = c.Materia.Descripcion;
                if(c.Profesor!=null)txtProfesor.Text = c.Profesor.Nombre + " " + c.Profesor.Apellido;
                txtTurno.Text = c.Turno.ToString();
                dtpFechaInicio.Value = c.FechaInicio;
                dtpFechaFin.Value = c.FechaFin;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormulario();
            HabilitarBotones();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void cboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCurso.SelectedItem != null)
            {
                ObtenerDatosCurso();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstCursos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un curso");
            }
            else
            {
                InscripcionCurso.RemoverInscripto((InscripcionCurso)lstCursos.SelectedItem, (Curso)cboCurso.SelectedItem);
                ActualizarListaCursos();
                LimpiarFormulario();
                HabilitarBotones();
            }
        }

        private void lstCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCursos.SelectedItem != null)
            {
                InscripcionCurso ic= (InscripcionCurso)lstCursos.SelectedItem;
                cboCurso.SelectedItem = ic.Curso;
                
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            modo = Modo.EDITAR;
            DesbloquearFormulario();
        }
    }
    }
