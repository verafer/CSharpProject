using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInscripcion
{
    public class InscripcionCursoDetalle
    {
        public int Id { get; set; }
        public Curso Curso { get; set; }
        public float Precio { get; set; }
        public Alumno alumno { get; set; }
        public EstadoInscripcion estado { get; set; }
        public DateTime FechaInscripcion  { get; set; }

    }
}
