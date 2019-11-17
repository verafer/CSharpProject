using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace ClasesInscripcion
{
    class SqlServer
    {
        public static string CADENA_CONEXION = ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;
    }
}
