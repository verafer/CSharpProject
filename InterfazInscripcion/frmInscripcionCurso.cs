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
        public int ban = 0;
        public frmInscripcionCurso()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nroDoc = txtNroDocumento.Text;

            if (ValidarDatos()) { return; }

            TipoDocumento tipoDoc = (TipoDocumento)cboTipoDocumento.SelectedItem;

            if (inscripcionCurso.listaDic.Count != 0)
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

                //MessageBox.Show(InscripcionCurso.ObtenerCursosDeAlumno(a).ToString());
                dtgDetalleInscripcionCurso.DataSource = null;
                dtgDetalleInscripcionCurso.DataSource = InscripcionCurso.ObtenerCursosDeAlumno(a);
                btnAgregar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = true;

                inscripcionCurso.Alumno = a;

                ActualizarDataGrid();
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
            LimpiarFormulario();
            inscripcionCurso = new InscripcionCurso();
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
            txtNroDocumento.Text = "";
            cboTipoDocumento.SelectedItem = null;
            dtgDetalleInscripcionCurso.DataSource = null;
            lblTotal.Text = "";
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;

        }

        /*public void CursoSeleccionado(Curso c)
        {
            txtNroCurso.Text = c.NumeroCurso;
            lblDescripcionCurso.Text = Convert.ToString(c.Materia);
        }*/

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Curso c = (Curso)dtgDetalleCurso.CurrentRow.DataBoundItem;
            foreach (InscripcionCurso ic in inscripcionCurso.listaDic)
            {
                if (c == ic.Curso)
                {
                    ban = 1;
                }
            }
            if (ban==0)
            {
                InscripcionCurso icd = new InscripcionCurso();
                icd.Curso = c;

                icd.Precio = c.MontoTotal;
                icd.FechaInscripcion = DateTime.Now;
                inscripcionCurso.listaDic.Add(icd);

                ActualizarDataGrid();
            }
            else if (ban==1)
            {
                MessageBox.Show("Usted ya esta inscripto en este curso ");
            }
            ban = 0;

        }

        private Boolean ValidarDatos()
        {
            string nroDoc = txtNroDocumento.Text;
            Boolean validar = false;

            if (nroDoc == "0" || nroDoc == "")
            {
                MessageBox.Show("Debe ingresar un numero de documento");
                validar = true;
            }else if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de documento");
                validar = true;
            }

            return validar;
        }

        private void ActualizarDataGrid()
        {
            dtgDetalleInscripcionCurso.DataSource = null;
            dtgDetalleInscripcionCurso.DataSource = inscripcionCurso.listaDic;
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            double total = 0;

            foreach (InscripcionCurso icd in inscripcionCurso.listaDic)
            {
                total = total + icd.Precio;
            }
            lblTotal.Text = Convert.ToString(total) + " gs.";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (inscripcionCurso.listaDic.Count != 0)
            {
                InscripcionCurso icd = (InscripcionCurso)dtgDetalleInscripcionCurso.CurrentRow.DataBoundItem;
                inscripcionCurso.listaDic.Remove(icd);
                ActualizarDataGrid();
            }
            else
            {
                MessageBox.Show("No hay detalles por borrar");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}