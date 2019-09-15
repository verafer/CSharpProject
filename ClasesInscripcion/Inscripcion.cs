using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesInscripcion
{
    class Inscripcion
    {
        public Alumno Alumno { get; set; }

        public Carrera Carrera { get; set; }

        public DateTime FechaInscripcion { get; set; }

        public Inscripcion() { }

        public Inscripcion(Alumno alumno, Carrera carrera, DateTime fechaInscripcion) { }
    }
}
