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
        InscripcionExamen inscripcionExamenEx;
        public frmInscripcionExamen()
        {
            InitializeComponent();
        }

        private void FrmInscripcionExamenExt_Load(object sender, EventArgs e)
        {
            try
            {
                cboTipoDocumento.DataSource = Enum.GetValues(typeof(TipoDocumento));
           // cboMateria.DataSource = Materia.ObtenerMaterias();
            cboTipoDocumento.SelectedItem = null;
           // cboMateria.SelectedItem = null;
            inscripcionExamenEx = new InscripcionExamen();

            LimpiarFormulario();
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al cargar el formulario!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscarAlumno_Click_1(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Atencion", "No se pudo obtener los datos del formulario!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void ActualizarDataGrid(Alumno a)
        {
            try
            {
                dtgCurso.DataSource = null;
                dtgCurso.DataSource = InscripcionCurso.ObtenerCursosDeAlumno(a);
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al actualizar lista !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)

        {
            try
            {
                InscripcionCursoDetalle icd = (InscripcionCursoDetalle)dtgCurso.CurrentRow.DataBoundItem;
            //InscripcionCursoDetalle icd= new InscripcionCurso.Obtener(c.Id);
            //icd.ObtenerCursoAlumno(c.Id);
            Examen ex = Examen.ObtenerExamen(icd.Id);

            ValidarExamen(ex, icd);

            inscripcionExamenEx.Curso = icd.Curso;
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al consultar  !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarExamen(Examen ex, InscripcionCursoDetalle c)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al validar examen  !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nroDoc = txtNroDocumento.Text;

            if (ValidarDatos()) { return; }

            TipoDocumento tipoDoc = (TipoDocumento)cboTipoDocumento.SelectedItem;

            InscripcionExamen.Agregar(inscripcionExamenEx);
            MessageBox.Show("La inscripcion ha sido guardada con éxito!");
            LimpiarFormulario();
            Limpiar();
            inscripcionExamenEx = new InscripcionExamen();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar!");
            }
        }

        private void Limpiar()
        {
            try
            {
                lblCurso.Text = "";
            lblExamenARendir.Text = "";
            lblProfesor.Text = "";
            lblPrecio.Text = "";

            gbxDatosExamen.Enabled = false;
            btnGuardar.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo limpiar!");
            }
        }

        private void LimpiarFormulario()
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Error al limpiar formulario!");
            }
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

        private void MostrarDatosCurso(InscripcionCursoDetalle icd, string examen)
        {
            lblCurso.Text = icd.Curso.ToString();
            lblExamenARendir.Text = examen;
            lblProfesor.Text = icd.Curso.Profesor.ToString();
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
