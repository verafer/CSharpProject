using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ClasesInscripcion
{
    public class Alumno : Persona
    {
        public static List<Alumno> listaAlumno = new List<Alumno>();
        public Alumno() { }

        public Alumno(string nroDocumento, TipoDocumento tipoDocumento, DateTime fechaNacimiento, string nombre, string apellido)
        {
            this.NroDocumento = nroDocumento;
            this.TipoDocumento = tipoDocumento;
            this.FechaNacimiento = fechaNacimiento;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        public static void AgregarAlumno(Alumno a)
        {
            listaAlumno.Add(a);
        }

        public static void EditarAlumno(Alumno a, int indice)
        {
            Alumno.listaAlumno[indice] = a;

        }
        public static void EliminarAlumno(Alumno alumno)
        {
            listaAlumno.Remove(alumno);
        }

        public static List<Alumno> ObtenerAlumnos()
        {
            Alumno alumno;
            listaAlumno.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCMD = "Select * from Alumno";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    alumno = new Alumno();
                    alumno.Id = elLectorDeDatos.GetInt32(0);
                    alumno.NroDocumento = elLectorDeDatos.GetString(1);
                    alumno.TipoDocumento = (TipoDocumento)elLectorDeDatos.GetInt32(2);
                    alumno.Nombre = elLectorDeDatos.GetString(3);
                    alumno.Apellido = elLectorDeDatos.GetString(4);
                    alumno.FechaNacimiento = elLectorDeDatos.GetDateTime(5);
                    listaAlumno.Add(alumno);
                }
                return listaAlumno;
            }
        }

        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido;
        }
    }
}
