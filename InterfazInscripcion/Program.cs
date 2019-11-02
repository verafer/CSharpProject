using ClasesInscripcion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazInscripcion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Se crean los objetos aqui para facilitar las pruebas a falta de BD
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                Alumno alumno = new Alumno("123123", TipoDocumento.CI, DateTime.Now, $"El nombre {i}", $"Apellido {i}");
                Alumno.AgregarAlumno(alumno);
            }
            for (int i = 0; i < 5; i++)
            {
                Profesor p = new Profesor("123123",TipoDocumento.CI,DateTime.Now,$"{i}Fulano",$"{i}Fulanito", DateTime.Now);
                Profesor.AgregarProfesor(p);
            }
            for (int i = 0; i < 5; i++)
            {
                Materia materia = new Materia(i,$"Materia N*{i}", Profesor.ObtenerProfesor()[rnd.Next(0,4)]);
                Materia.AgregarMateria(materia);
            }
            for (int i = 0; i < 5; i++)
            {
                Curso curso = new Curso($"{i}{i}{i}{i}",Materia.ObtenerMateria()[rnd.Next(0, 4)],DiasSemana.M, Turnos.Noche, Profesor.ObtenerProfesor()[rnd.Next(0, 4)], modalidad.Presencial,DateTime.Now,DateTime.Now.AddMonths(6));
                Curso.AgregarCurso(curso);
            }
            Application.Run(new frmMenu());
        }
    }
}
