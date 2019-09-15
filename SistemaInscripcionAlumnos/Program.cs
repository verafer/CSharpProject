using ClasesInscripcion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInscripcionAlumnos
{
    class Program
    {
        static void Main(string[] args)
        { 
            Ciudad ciudad1 = new Ciudad();
            ciudad1.Id = 1;
            ciudad1.Nombre = "Luque";

            Ciudad ciudad2 = new Ciudad();
            ciudad2.Id = 2;
            ciudad2.Nombre = "Asunción";

            Alumno alu1 = new Alumno();
            alu1.Id = 1;
            alu1.NroDocumento = "4879547";
            alu1.TipoDocumento = "CI";
            alu1.Nombre = "Romina";
            alu1.Apellido = "Vazquez";
            alu1.FechaNacimiento= DateTime.Parse("1998-07-01");
            alu1.Direccion = "Roma y Chile 1526";
            alu1.Ciudad = ciudad2;
            alu1.Email = "romina@gmail.com";
            alu1.Telefono = "0991654987";

            Profesor prof1 = new Profesor();
            prof1.Id = 1;
            prof1.NroDocumento = "2555664";
            prof1.TipoDocumento = "CI";
            prof1.Nombre = "Santiago";
            prof1.Apellido = "Santander";
            prof1.FechaNacimiento = DateTime.Parse("1972-12-11");
            prof1.Direccion = "San Cristobal 986";
            prof1.Ciudad = ciudad1;
            prof1.Email = "santiago@gmail.com";
            prof1.Telefono = "0982556645";
            prof1.NroMatricula = 22347;
            prof1.TituloObtenido = "Lic. Analisis de Sistemas";
            prof1.FechaIngreso = DateTime.Parse("2016-01-15");

            alu1.ObtenerDatosBasicos();
            prof1.ObtenerDatosBasicos();
            Console.Write(prof1);

            Console.Write("\nFin del programa. Presione una tecla para continuar");
            Console.ReadKey();
        }
    }
}
