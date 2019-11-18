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

        }

        private void btnBuscarAlumno_Click(object sender, EventArgs e)
        {
            string nroDoc = txtNroDocumento.Text;
            TipoDocumento tipoDoc = (TipoDocumento)cboTipoDocumento.SelectedItem; ;

            Alumno a = Alumno.ObtenerAlumnoPorNroDoc(nroDoc, tipoDoc);

            lblNombre.Text = a.Apellido + ", "+ a.Nombre;
            lblFechaNac.Text = Convert.ToString(a.FechaNacimiento);
            lblDireccion.Text = a.Direccion;
            lblCiudad.Text = Convert.ToString(a.Ciudad);
            lblEmail.Text = a.Email;
            lblTelefono.Text = a.Telefono;

        }
    }
}
