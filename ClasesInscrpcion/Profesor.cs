using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesInscripcion
{
    public class Profesor : Persona
    {
        public string NroMatricula { get; set; }
        public string TituloObtenido { get; set; }
        public DateTime FechaIngreso { get; set; }
        public static List<Profesor> listaProfesor = new List<Profesor>();

        public Profesor() { }

        public Profesor(string nroDocumento, TipoDocumento tipoDocumento, DateTime fechaNacimiento, string nombre, string apellido, DateTime fechaIngreso)
        {
            this.NroDocumento = nroDocumento;
            this.TipoDocumento = tipoDocumento;
            this.FechaNacimiento = fechaNacimiento;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaIngreso = fechaIngreso;
        }

        public static void AgregarProfesor(Profesor p)
        {
            listaProfesor.Add(p);
        }

        public static void EditarProfesor(Profesor p, int indice)
        {
            Profesor.listaProfesor[indice] = p;

        }
        public static void EliminarProfesor(Profesor profesor)
        {
            listaProfesor.Remove(profesor);
        }

        public static List<Profesor> ObtenerProfesor()
        {
            return listaProfesor;
        }

        /*public override string ToString()
        {
            return $"Nro Matricula: {NroMatricula} \nTitulo: {TituloObtenido} \nFecha de Ingreso: {FechaIngreso}\n";
        }*/

        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido;
        }
    }
}
