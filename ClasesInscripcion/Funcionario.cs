using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesInscripcion
{
    public class Funcionario : Persona
    {
        public DateTime FechaIngreso { get; set; }
        public string Turno { get; set; }

        public Funcionario() { }

        public Funcionario(string nroDocumento, string tipoDocumento, DateTime fechaNacimiento, string nombre, string apellido)
        {
            this.NroDocumento = nroDocumento;
            this.TipoDocumento = tipoDocumento;
            this.FechaNacimiento = fechaNacimiento;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
    }
}
