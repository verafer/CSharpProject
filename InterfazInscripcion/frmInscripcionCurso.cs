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

            cboAlumno.DataSource = Alumno.ObtenerAlumnos();
            cboAlumno.SelectedItem = null;
            lstCursosDisponibles.DataSource = Curso.ObtenerCursos();
            lstCursosDisponibles.SelectedItem = null;
            BloquearDisponibles();
            btnGuardarCambios.Enabled = false;
            //BloquearFormulario();
            //DeshabilitarBotones();
        }

        private void cboAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAlumno.SelectedItem != null)
            {
                lstCursosInscripto.DataSource = null;
                lstCursosInscripto.DataSource = InscripcionCurso.ObtenerCursosDeAlumno((Alumno)cboAlumno.SelectedItem);
                lstCursosInscripto.Enabled = true;
                DesbloquearDisponibles();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modo = Modo.AGREGAR;
            DesbloquearFormulario();
        }


        private void BloquearDisponibles()
        {
            lstCursosDisponibles.Enabled = false;
            btnInscribir.Enabled = false;
            btnDesinscribir.Enabled = false;
            btnCancelarPendiente.Enabled = false;
            lstCursosInscripto.Enabled = false;
            lblCD.Enabled = false;
            lblCA.Enabled = false;
        }
        private void DesbloquearDisponibles()
        {
            lstCursosDisponibles.Enabled = true;
            btnInscribir.Enabled = true;
            btnDesinscribir.Enabled = true;
            btnCancelarPendiente.Enabled = false;
            lstCursosInscripto.Enabled = true;
            lblCD.Enabled = true;
            lblCA.Enabled = true;
        }

        private void BloquearFormulario()
        {
            cboAlumno.Enabled = true;
            lstCursosDisponibles.Enabled = true;
        }

        private void DesbloquearFormulario()
        {
            cboAlumno.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lstCursosDisponibles.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un curso");
                return;
            }
            if (modo == Modo.AGREGAR)
            {
                InscripcionCurso ic = new InscripcionCurso((Alumno)cboAlumno.SelectedItem, (Curso)lstCursosDisponibles.SelectedItem);
                InscripcionCurso.AgregarInscripto(ic, (Curso)lstCursosDisponibles.SelectedItem);
            }
            else if (modo == Modo.EDITAR)
            {

                if (this.lstCursosDisponibles.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Favor seleccione una fila");
                }

                else
                {
                    int indice = lstCursosDisponibles.SelectedIndex;
                   // Curso.EditarCurso(, indice);
                    ActualizarListaCursos();
                }


            }

            ActualizarListaCursos();
            BloquearFormulario();
        }




        private void ActualizarListaCursos()
        {
            lstCursosInscripto.DataSource = null;
            lstCursosInscripto.DataSource = InscripcionCurso.ObtenerCursosDeAlumno((Alumno)cboAlumno.SelectedItem);
            lstCursosInscripto.SelectedIndex = -1;
            calcularTotal();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstCursosDisponibles.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un curso");
            }
            else
            {
                InscripcionCurso.RemoverInscripto((InscripcionCurso)lstCursosDisponibles.SelectedItem);
                ActualizarListaCursos();
            }
        }

        //private void lstCursos_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (lstCursosDisponibles.SelectedItem != null)
        //    {
        //        InscripcionCurso ic= (InscripcionCurso)lstCursosDisponibles.SelectedItem;
        //        lstCursosDisponibles.SelectedItem = ic.Curso;
                
        //    }
        //}

        private void btnEditar_Click(object sender, EventArgs e)
        {
            modo = Modo.EDITAR;
            DesbloquearFormulario();
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            if (lstCursosDisponibles.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un curso");
                return;
            }
            Alumno a = (Alumno)cboAlumno.SelectedItem;
            Curso c = (Curso)lstCursosDisponibles.SelectedItem;
            foreach (InscripcionCurso icc in lstCursosInscripto.Items)
            {
                if(icc.Curso == c)
                {
                    MessageBox.Show("El alumno ya se encuentra inscripto a este curso");
                    return;
                }
            }
            InscripcionCurso ic = new InscripcionCurso(a, (Curso)lstCursosDisponibles.SelectedItem);
            InscripcionCurso.AgregarInscripto(ic, (Curso)lstCursosDisponibles.SelectedItem);
            ActualizarListaCursos();
            lstCursosInscripto.SelectedItem = ic;
        }

        private void lstCursosDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCursosInscripto.SelectedIndex = -1;
            if(lstCursosDisponibles.SelectedItem != null)
            {
                btnInscribir.Enabled = true;
                btnDesinscribir.Enabled = false;
                btnCancelarPendiente.Enabled = false;
            }
        }

        private void lstCursosInscripto_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCursosDisponibles.SelectedIndex = -1;
            if (lstCursosInscripto.SelectedItem != null)
            {

                btnGuardarCambios.Enabled = true;

                btnInscribir.Enabled = false;
                btnDesinscribir.Enabled = true;
                btnCancelarPendiente.Enabled = true;
            }
            else
            {
                btnGuardarCambios.Enabled = false;
            }
        }

        private void calcularTotal()
        {
            int total = 0;
            for (int i = 0; i < lstCursosInscripto.Items.Count; i++)
            {
                InscripcionCurso ic = (InscripcionCurso)lstCursosInscripto.Items[i];
                total += ic.Curso.MontoTotal;
            }
            nudTotal.Value = total;
        }

        private void btnDesinscribir_Click(object sender, EventArgs e)
        {
            if (lstCursosInscripto.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un curso");
                return;
            }
            else
            {
                InscripcionCurso ic = (InscripcionCurso)lstCursosInscripto.SelectedItem;
                if(ic.Estado == EstadoInscripcion.Pendiente)
                {
                    MessageBox.Show("La inscripción aún no fue confirmada. Utilice la opción 'Cancelar Inscripción Pendiente'");
                    return;
                }
                InscripcionCurso.RemoverInscripto(ic);
                ActualizarListaCursos();
            }
        }

        private void btnCancelarPendientes_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstCursosInscripto.Items.Count; i++)
            {
                InscripcionCurso ic = (InscripcionCurso)lstCursosInscripto.Items[i];
                if (ic.Estado == EstadoInscripcion.Pendiente)
                {
                    InscripcionCurso.RemoverInscripto(ic);
                }
            }
            ActualizarListaCursos();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstCursosInscripto.Items.Count; i++)
            {
                InscripcionCurso ic = (InscripcionCurso)lstCursosInscripto.Items[i];
                if (ic.Estado == EstadoInscripcion.Pendiente)
                {
                    ic.Estado = EstadoInscripcion.Confirmada;
                }
            }
            ActualizarListaCursos();
        }

        private void btnCancelarPendiente_Click(object sender, EventArgs e)
        {
            if (lstCursosInscripto.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un curso");
                return;
            }
            InscripcionCurso ic = (InscripcionCurso)lstCursosInscripto.SelectedItem;
            if(ic.Estado == EstadoInscripcion.Confirmada)
            {
                MessageBox.Show("La inscripción ya fue confirmada. Utilice la opción 'Baja Curso'");
                return;
            }
            else {
                    InscripcionCurso.RemoverInscripto(ic);
                ActualizarListaCursos();
            }
        }
    }
    }
