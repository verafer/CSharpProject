using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesInscripcion
{
    public class Alumno : Persona
    {
        public static List<Alumno> listaAlumno = new List<Alumno>();
        public Alumno() { }

        public Alumno(string nroDocumento, string tipoDocumento, DateTime fechaNacimiento, string nombre, string apellido)
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

        public static List<Alumno> ObtenerAlumno()
        {
            return listaAlumno;
        }
    }
}
