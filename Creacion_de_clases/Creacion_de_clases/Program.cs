
using System.IO;

namespace Creacion_de_clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Angelica", "Mejía", "01/04/2005", 55111730, "Bo. La Esperanza");
            Persona persona2 = new Persona("María", "Tzoc", "01/05/2005", 49139972, "Bo. San francisco");
            Alumno estudiante1 = new Alumno("Sofia", "Lopez", "02/10/2002", 20938476, "Bo. El porvenir", 09234,"02/02/2024", "Segundo Basico", "B");
            Profesor profesor1 = new Profesor("Marco", "Tulio", "11/09/1990", 378291034, "Bo. chipilapa", 89771948, "Matemática");

            Console.WriteLine(persona1.Presentarse());
            Console.WriteLine(persona1.Nacimiento());
            Console.WriteLine(persona1.Cel());
            Console.WriteLine(persona1.Hogar());
            Console.WriteLine(persona2.Presentarse());
            Console.WriteLine(persona2.Nacimiento());
            Console.WriteLine(persona2.Cel());
            Console.WriteLine(persona2.Hogar());
            Console.WriteLine(estudiante1.Presentarse());
            Console.WriteLine(estudiante1.Nacimiento());
            Console.WriteLine(estudiante1.Cel());
            Console.WriteLine(estudiante1.Hogar());
            Console.WriteLine(estudiante1.Estudiar());
            Console.WriteLine(estudiante1.ObtenerInformacion());
            Console.WriteLine(estudiante1.Cursando());
            Console.WriteLine(profesor1.Presentarse());
            Console.WriteLine(profesor1.Nacimiento());
            Console.WriteLine(profesor1.Cel());
            Console.WriteLine(profesor1.Hogar());
            Console.WriteLine(profesor1.Enseñar());
            Console.WriteLine(profesor1.Codigo());
           
        }
    }
}

