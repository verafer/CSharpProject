using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesInscripcion
{
    public enum Departamento
    {
        Central,
        Cordillera,
        Guairá
    }

    public class Ciudad : Objeto
    {
        public string Nombre { get; set; }
        public Departamento Departamento { get; set; }

        public static List<Ciudad> listaCiudades = new List<Ciudad>();

        public static void AgregarCiudad(Ciudad c)
        {
            listaCiudades.Add(c);
        }

        public static void EditarCiudad(Ciudad c, int indice)
        {
            Ciudad.listaCiudades[indice] = c;

        }
        public static void EliminarCiudad(Ciudad ciudad)
        {
            listaCiudades.Remove(ciudad);
        }

        public static List<Ciudad> ObtenerCiudad()
        {
            return listaCiudades;
        }

        public override string ToString()
        {
            return Nombre + " - " + Departamento;
        }
    }
}
