using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesInscripcion
{
    public class Carrera: Objeto
    {
        public string Nombre { get; set; }

        public Facultad Facultad { get; set; }

        public int CreditosRequeridos { get; set; }

        public List<Enfasis> Enfasis { get; set; }

        public int Matricula { get; set; }

        public Carrera() { }

        public void agregarCarrera() { }
    }
}
