using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesInscripcion
{
    public class Ciudad : Objeto
    {
        public string Nombre { get; set; }

        public static List<Ciudad> listaCiudades = new List<Ciudad>();

        public static List<Ciudad> ObtenerCiudad()
        {
            return listaCiudades;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
