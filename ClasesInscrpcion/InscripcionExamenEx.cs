using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInscripcion
{
    public class InscripcionExamenEx
    {
        public Alumno Alumno { get; set; }

        public Carrera Carrera { get; set; }

        public DateTime FechaInscripcion { get; set; }

        public InscripcionExamenEx() { }

        public InscripcionExamenEx(Alumno alumno, Carrera carrera, DateTime fechaInscripcion)
        {
            this.Alumno = alumno;
            this.Carrera = carrera;
            this.FechaInscripcion = fechaInscripcion;
        }
    }
}
