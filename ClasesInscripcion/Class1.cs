using System;

namespace ClasesInscripcion
{
    public class Class1
    {
        public void Saludar(string nombre)
        {
            Console.WriteLine($"Hola {nombre}! :D \n Presiona una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
