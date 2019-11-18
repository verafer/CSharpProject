using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesInscripcion
{
    public enum RindioParcial
    {
        Si,
        No
    }

    class Examen
    {
        /*public string detalle { get; set; }
        public bool asistio { get; set; } // Indica si el alumno asistió o no al examen*/
        public RindioParcial PrimerParcial { get; set; }
        public RindioParcial TercerParcial { get; set; }
        public RindioParcial SegundoParcial { get; set; }
        public RindioParcial Final { get; set; }
        public InscripcionCursoDetalle InscripcionCursoDetalleId { get; set; }

    }
}
