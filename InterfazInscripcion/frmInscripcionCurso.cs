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

        InscripcionCurso inscripcionCurso;

        public frmInscripcionCurso()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (inscripcionCurso.detalle_inscripcion_cursos.Count != 0)
            {
                inscripcionCurso.Estado = EstadoInscripcion.Confirmada;
                InscripcionCurso.Agregar(inscripcionCurso);
                MessageBox.Show("La inscripcion ha sido guardada con éxito");
                LimpiarFormulario();
                inscripcionCurso = new InscripcionCurso();
            }
            else
            {
                MessageBox.Show("Debe agregar detalles para guardar");
            }
        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            string nroDoc = txtNroDocumento.Text;
            
            if (nroDoc == "0" || nroDoc == "")
            {
                MessageBox.Show("Debe ingresar un numero de documento");
                return;
            }

            if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de documento");
                return;
            }

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

                inscripcionCurso.Alumno = a;
               
            }
            else
 {
                MessageBox.Show("No se encontró un alumno que coincida con los datos ingresados");
            }
            

        }

        private void frmInscripcionCurso_Load(object sender, EventArgs e)
        {
            dtgDetalleInscripcionCurso.AutoGenerateColumns = true;
            cboTipoDocumento.DataSource = Enum.GetValues(typeof(TipoDocumento));
            cboTipoDocumento.SelectedItem = null;
            dtgDetalleCurso.AutoGenerateColumns = true;
            dtgDetalleCurso.DataSource = null;
            dtgDetalleCurso.DataSource = Curso.ObtenerCursos();
            //LimpiarFormulario();
            inscripcionCurso = new InscripcionCurso();
        }

        private void LimpiarFormulario()
        {
            throw new NotImplementedException();
        }

        /*public void CursoSeleccionado(Curso c)
        {
            txtNroCurso.Text = c.NumeroCurso;
            lblDescripcionCurso.Text = Convert.ToString(c.Materia);
        }*/
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Curso c = (Curso)dtgDetalleCurso.CurrentRow.DataBoundItem;
            InscripcionCursoDetalle icd = new InscripcionCursoDetalle();
            icd.Curso = c;
            icd.Precio = c.MontoTotal;
            inscripcionCurso.detalle_inscripcion_cursos.Add(icd);

            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            dtgDetalleInscripcionCurso.DataSource = null;
            dtgDetalleInscripcionCurso.DataSource = inscripcionCurso.detalle_inscripcion_cursos;
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            double total = 0;

            foreach (InscripcionCursoDetalle icd in inscripcionCurso.detalle_inscripcion_cursos)
            {
                total = total + icd.Precio;
            }
            lblTotal.Text = Convert.ToString(total) + " gs.";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (inscripcionCurso.detalle_inscripcion_cursos.Count != 0)
            {
                InscripcionCursoDetalle icd = (InscripcionCursoDetalle)dtgDetalleInscripcionCurso.CurrentRow.DataBoundItem;
                inscripcionCurso.detalle_inscripcion_cursos.Remove(icd);
                ActualizarDataGrid();
            }
            else
            {
                MessageBox.Show("No hay detalles por borrar");
            }
        }
    }
}
