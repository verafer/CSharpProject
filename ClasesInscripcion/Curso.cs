using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesInscripcion
{
    public class Curso : Objeto
    {  
        public Materia Materia { get; set; }
        public string Turno { get; set; }
        public string Modalidad { get; set; }

        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public Curso() {
        }
    }
}
