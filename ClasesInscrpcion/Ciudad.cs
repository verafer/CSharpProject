using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
//using System.Data.SqlClient;
namespace ClasesInscripcion
{
    public class Ciudad : Objeto
    {
        public string Descripcion { get; set; }

        public static List<Ciudad> listaCiudades = new List<Ciudad>();



        public override string ToString()
        {
            //return "R. Social: " + RazonSocial +"; " + "Direcc: " + Direccion + ";" + "Contacto: " + Contacto;
            return Descripcion;
        }
    }
}
