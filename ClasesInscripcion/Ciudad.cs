using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesInscripcion
{
    public class Ciudad : Objeto
    {
        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
