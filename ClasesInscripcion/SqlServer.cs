using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace ClasesInscripcion
{
   public  class SqlServer
    {
        public static string CADENA_CONEXION = ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;
    }
}
