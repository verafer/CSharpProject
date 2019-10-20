using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesInscripcion
{
    public enum TipoDocumento
    {
        CI,
        Pasaporte
    }

    public class Persona : Objeto
    {
        public string NroDocumento { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public Ciudad Ciudad { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public override string ToString()
        {
            return $"Nro Doc: {NroDocumento} Nombre: {Nombre} {Apellido}";
        }

        public string ObtenerNombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }

        public void ObtenerDatosBasicos()
        {
            Console.WriteLine($"\n\nId: {Id} \n{TipoDocumento}: {NroDocumento} \nNombre: {Nombre} {Apellido} \nFecha Nacimiento: {FechaNacimiento} \nDireccion: {Direccion} \nCiudad: {Ciudad} \nEmail: {Email} \nTelefono: {Telefono}");
        }
    }
}
