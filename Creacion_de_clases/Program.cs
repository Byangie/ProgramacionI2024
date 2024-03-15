<<<<<<< HEAD
﻿namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("María", 30);
            Persona persona2 = new Persona("Lourdes", 20);
            Estudiante estudiante1 = new Estudiante("Angelica Mejía", 18, "0907-23-8872");
            Profesor profesor1 = new Profesor("Inge. Marco Tulio", 35, "A12345");
            Director director1 = new Director("Lic. Salavador Gonzalez", 50, "MG9823");

            Console.WriteLine(persona1.Presentarse());
            Console.WriteLine(persona2.Presentarse());
            Console.WriteLine(estudiante1.Presentarse());
            Console.WriteLine(estudiante1.Estudiar());
            Console.WriteLine(profesor1.Presentarse());
            Console.WriteLine(profesor1.Enseñar());
            Console.WriteLine(director1.Presentarse());
            Console.WriteLine(director1.Cargo());
        }

    }
        class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public string Presentarse()
        {
            return $"Hola Soy {Nombre} y tengo {Edad} años.";
        }
    }

    class Estudiante : Persona
    {
        public string Carne { get; set; }

        public Estudiante(string nombre, int edad, string carne) : base(nombre, edad)
        {
            Carne = carne;
        }

        public string Estudiar()
        {
            return $"{Nombre} está estudiando con el carné: {Carne}.";
        }
    }

    class Profesor : Persona
    {
        public string CodigoEmpleado { get; set; }

        public Profesor(string nombre, int edad, string codigoEmpleado) : base(nombre, edad)
        {
            CodigoEmpleado = codigoEmpleado;
        }

        public string Enseñar()
        {
            return $"{Nombre} está enseñando con el código de empleado {CodigoEmpleado}.";
        }
    }


    class Director : Persona
    {
        public string Matricula { get; set; }

        public Director(string nombre, int edad, string matricula) : base(nombre, edad)
        {
            Matricula = matricula;
        }

        public string Cargo()
        {
            return $"{Nombre} es el director y tiene el número de matricula:  {Matricula}.";
        }
    }


=======
﻿
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
>>>>>>> a9e4cdce7152b774782a1c7aba3e8277e6be7ea6
}

