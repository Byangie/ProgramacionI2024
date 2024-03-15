using System;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre: ");
            string nombreUsuario = Console.ReadLine();


            Console.WriteLine("Ingrese el primer gasto");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo gasto");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer gasto");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int SumaIngresos = Ingresos.Sumar(num1, num2, num3);
            double PromedioIngresos = Ingresos.Promedio(SumaIngresos);

            Console.WriteLine($"Hola {nombreUsuario}, en total gastaste {SumaIngresos} y promediaste {PromedioIngresos}");
        }
    }
}
