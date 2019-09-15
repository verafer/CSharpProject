using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesInscripcion
{
    public class Profesor : Persona
    {
        public int NroMatricula { get; set; }
        public string TituloObtenido { get; set; }
        public DateTime FechaIngreso { get; set; }

        public Profesor() { }

        public Profesor(string nroDocumento, string tipoDocumento, DateTime fechaNacimiento, string nombre, string apellido)
        {
            this.NroDocumento = nroDocumento;
            this.TipoDocumento = tipoDocumento;
            this.FechaNacimiento = fechaNacimiento;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public override string ToString()
        {
            return $"Nro Matricula: {NroMatricula} \nTitulo: {TituloObtenido} \nFecha de Ingreso: {FechaIngreso}\n";
        }
    }
}
