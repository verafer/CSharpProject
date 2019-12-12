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

            if (inscripcionCurso.listaInscripcionesD.Count != 0)
            {
                inscripcionCurso.Estado = EstadoInscripcion.Confirmada;
                InscripcionCurso.Agregar(inscripcionCurso);
                MessageBox.Show("La inscripcion ha sido guardada con éxito");
                EnviarCorreo(inscripcionCurso.Alumno.Email, inscripcionCurso.Alumno);
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
                //dtgDetalleInscripcionCurso.DataSource = InscripcionCurso.ObtenerCursosDeAlumno(a);
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
            foreach (InscripcionCursoDetalle icd in inscripcionCurso.listaInscripcionesD)
            {
                if (c == icd.Curso)
                {
                    ban = 1;
                }
            }
            if (ban==0)
            {
                InscripcionCursoDetalle icd = new InscripcionCursoDetalle();
                icd.Id = 1;
                icd.Curso = c;
                icd.Precio = c.MontoTotal;
                inscripcionCurso.listaInscripcionesD.Add(icd);

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
            }

            if (cboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de documento");
                validar = true;
            }

            return validar;
        }

        private void ActualizarDataGrid()
        {
            dtgDetalleInscripcionCurso.DataSource = null;
            dtgDetalleInscripcionCurso.DataSource = inscripcionCurso.listaInscripcionesD;
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            double total = 0;

            foreach (InscripcionCursoDetalle icd in inscripcionCurso.listaInscripcionesD)
            {
                total = total + icd.Precio;
            }
            lblTotal.Text = Convert.ToString(total) + " gs.";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (inscripcionCurso.listaInscripcionesD.Count != 0)
            {
                InscripcionCursoDetalle icd = (InscripcionCursoDetalle)dtgDetalleInscripcionCurso.CurrentRow.DataBoundItem;
                inscripcionCurso.listaInscripcionesD.Remove(icd);
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

        private void EnviarCorreo(String destinatario, Alumno alumno)
        {
            try
            {
                System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();
                mmsg.To.Add(destinatario); //Destinatario
                mmsg.Subject = "Inscripcion a curso"; //Asunto
                mmsg.SubjectEncoding = System.Text.Encoding.UTF8;


                //mmsg.Bcc.Add(""); //Para enviar copia de correo
                string body = "";
                body += "<p>Buenas noches,</p><p> A continuacion, la lista de cursos a los que se ha inscripto:</p><ul>";
                
                foreach (InscripcionCursoDetalle icd in InscripcionCurso.ObtenerCursosDeAlumno(alumno))
                {
                    body += "<li>" + icd.Curso + "</li>";
                }

                body += "</ul><p>Saludos cordiales</p>";

                mmsg.Body = body;
                mmsg.BodyEncoding = System.Text.Encoding.UTF8;
                mmsg.IsBodyHtml = true;
                mmsg.From = new System.Net.Mail.MailAddress("enviarcorreo.csharp@gmail.com"); //correo que envia

                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient("smtp.gmail.com");
                //cliente.Credentials = new System.Net.NetworkCredential("verafer343@gmail.com", "siemprefuerte"); //credenciales

                cliente.Port = 587;
                cliente.EnableSsl = true;
                //cliente.Host = "smtp.gmail.com";
                cliente.UseDefaultCredentials = true;

                cliente.Credentials = new System.Net.NetworkCredential("enviarcorreo.csharp@gmail.com", "enviarcorreodesdecsharp"); //credenciales


                cliente.Send(mmsg);

                cliente.Dispose();
            }
            catch (Exception)
            {
                //throw;
                MessageBox.Show("Atencion", "Error al enviar correo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}