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
    public partial class frmInscripcionExamenExt : Form
    {
        public int id_alumno;
        InscripcionExamenEx inscripcionExamenEx;
        public frmInscripcionExamenExt()
        {
            InitializeComponent();
        }

        private void BtnBuscarAlumno_Click(object sender, EventArgs e)
        {
           

        }

        private void FrmInscripcionExamenExt_Load(object sender, EventArgs e)
        {
            cboTipoDocumento.DataSource = Enum.GetValues(typeof(TipoDocumento));
            cboMateria.DataSource = Materia.ObtenerMaterias();
            cboTipoDocumento.SelectedItem = null;
            cboMateria.SelectedItem = null;
        }

        private void BtnBuscarAlumno_Click_1(object sender, EventArgs e)
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
                ActualizarDataGrid(a);
               // inscripcionExamenEx.Alumno = a;
                
            }
            else
            {
                MessageBox.Show("No se encontró un alumno que coincida con los datos ingresados");
            }
           
        }
        private void ActualizarDataGrid(Alumno a)
        {
            dtgCurso.DataSource = null;
            dtgCurso.DataSource = InscripcionCurso.ObtenerCursosDeAlumno(a);
            //CalcularTotal();
        }
        private void BtnBuscarMateria_Click(object sender, EventArgs e)
        {
            
        }
    }
}
