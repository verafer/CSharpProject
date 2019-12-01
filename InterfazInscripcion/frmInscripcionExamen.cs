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
    public partial class frmInscripcionExamen : Form
    {
        public int id_alumno;
        InscripcionExamenEx inscripcionExamenEx;
        public frmInscripcionExamen()
        {
            InitializeComponent();
        }

        private void FrmInscripcionExamenExt_Load(object sender, EventArgs e)
        {
            cboTipoDocumento.DataSource = Enum.GetValues(typeof(TipoDocumento));
           // cboMateria.DataSource = Materia.ObtenerMaterias();
            cboTipoDocumento.SelectedItem = null;
           // cboMateria.SelectedItem = null;
            inscripcionExamenEx = new InscripcionExamenEx();

            LimpiarFormulario();
        }

        private void BtnBuscarAlumno_Click_1(object sender, EventArgs e)
        {
            string nroDoc = txtNroDocumento.Text;

            if (ValidarDatos()) { return; }

            TipoDocumento tipoDoc = (TipoDocumento)cboTipoDocumento.SelectedItem;

            Alumno a = Alumno.ObtenerAlumnoPorNroDoc(nroDoc, tipoDoc);

            if (a != null)
            {
                lblNombre.Text = a.Apellido + ", " + a.Nombre;
                lblFechaNac.Text = (a.FechaNacimiento).ToShortDateString();
                lblDireccion.Text = a.Direccion;
                lblCiudad.Text = Convert.ToString(a.Ciudad);
                lblEmail.Text = a.Email;
                lblTelefono.Text = a.Telefono;
                gbxDatosAlumno.Enabled = true;
                ActualizarDataGrid(a);

                inscripcionExamenEx.Alumno = a;
                
                gbxDatosAlumno.Enabled = true;
                gbxSeleccionarExamen.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se encontró un alumno que coincida con los datos ingresados");
                LimpiarFormulario();
                Limpiar();
            }
           
        }
        private void ActualizarDataGrid(Alumno a)
        {
            dtgCurso.DataSource = null;
            dtgCurso.DataSource = InscripcionCurso.ObtenerCursosDeAlumno(a);
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            InscripcionCurso c = (InscripcionCurso)dtgCurso.CurrentRow.DataBoundItem;
            InscripcionCursoDetalle icd= InscripcionCurso.ObtenerCurso(c.Id);
            Examen ex = Examen.ObtenerExamen(icd.Id);

            ValidarExamen(ex, c);

            inscripcionExamenEx.Curso = c.Curso;
        }

        private void ValidarExamen(Examen ex, InscripcionCurso c)
        {
            if (rboPrimeraP.Checked == true)
            {
                if (ex.PrimerParcial == RindioParcial.Si)
                {
                    MessageBox.Show("No se puede inscribir. El estudiante ya rindió su primer parcial");
                    Limpiar();
                }
                else if (ex.PrimerParcial == RindioParcial.No)
                {
                    MessageBox.Show("El estudiante está habilitado para rendir");
                    inscripcionExamenEx.examen = "Primer Parcial";
                    MostrarDatosCurso(c, inscripcionExamenEx.examen);
                }

            }
            else if (rboSegundaP.Checked == true)
            {
                if (ex.SegundoParcial == RindioParcial.Si)
                {
                    MessageBox.Show("No se puede inscribir. El estudiante ya rindió su segundo parcial");
                    Limpiar();
                }
                else if (ex.PrimerParcial == RindioParcial.No)
                {
                    MessageBox.Show("El estudiante está habilitado para rendir");
                    inscripcionExamenEx.examen = "Segundo Parcial";
                    MostrarDatosCurso(c, inscripcionExamenEx.examen);
                }

            }
            else if (rboTerceraP.Checked == true)
            {
                if (ex.TercerParcial == RindioParcial.Si)
                {
                    MessageBox.Show("No se puede inscribir. El estudiante ya rindió su tercer parcial");
                    Limpiar();
                }
                else if (ex.TercerParcial == RindioParcial.No)
                {
                    MessageBox.Show("El estudiante está habilitado para rendir");
                    inscripcionExamenEx.examen = "Tercer Parcial";
                    MostrarDatosCurso(c, inscripcionExamenEx.examen);
                }

            }
            else if (rboFinal.Checked == true)
            {
                if (ex.Final == RindioParcial.Si)
                {
                    MessageBox.Show("No se puede inscribir. El estudiante ya rindió su examen Final");
                    Limpiar();
                }
                else if (ex.Final == RindioParcial.No)
                {
                    MessageBox.Show("El estudiante está habilitado para rendir");
                    inscripcionExamenEx.examen = "Final";
                    MostrarDatosCurso(c, inscripcionExamenEx.examen);
                }

            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string nroDoc = txtNroDocumento.Text;

            if (ValidarDatos()) { return; }

            TipoDocumento tipoDoc = (TipoDocumento)cboTipoDocumento.SelectedItem;

            InscripcionExamenEx.Agregar(inscripcionExamenEx);
            MessageBox.Show("La inscripcion ha sido guardada con éxito!");
            LimpiarFormulario();
            Limpiar();
            inscripcionExamenEx = new InscripcionExamenEx();
            
        }

        private void Limpiar()
        {
            lblCurso.Text = "";
            lblExamenARendir.Text = "";
            lblProfesor.Text = "";
            lblPrecio.Text = "";

            gbxDatosExamen.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void LimpiarFormulario()
        {
            lblNombre.Text = "";
            lblFechaNac.Text = "";
            lblDireccion.Text = "";
            lblCiudad.Text = "";
            lblEmail.Text = "";
            lblTelefono.Text = "";
            gbxDatosAlumno.Enabled = false;
            gbxSeleccionarExamen.Enabled = false;
            gbxDatosExamen.Enabled = false;
            txtNroDocumento.Text = "";
            cboTipoDocumento.SelectedItem = null;
            dtgCurso.DataSource = null;
            btnGuardar.Enabled = false;
        }

        private Boolean ValidarDatos()
        {
            string nroDoc = txtNroDocumento.Text;
            Boolean validar = false;

            if (nroDoc == "0" || nroDoc == "")
            {
                MessageBox.Show("Debe ingresar un numero de documento");
                validar = true;
            }
            else if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de documento");
                validar = true;
            }

            return validar;
        }

        private void MostrarDatosCurso(InscripcionCurso c, string examen)
        {
            lblCurso.Text = c.Curso.ToString();
            lblExamenARendir.Text = examen;
            lblProfesor.Text = c.Curso.Profesor.ToString();
            lblPrecio.Text = "85.000 gs";

            gbxDatosExamen.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            Limpiar();
        }
    }
}
