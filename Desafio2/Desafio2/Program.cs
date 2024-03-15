namespace Desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //suma
            Console.WriteLine("Suma");

            Console.WriteLine("Ingrese el primer número");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int Suma = Operaciones.Sumar(num1, num2);
            Console.WriteLine($"La suma de los dos numeros ingresados es {Suma}");

            //Resta
            Console.WriteLine("Resta");

            Console.WriteLine("Ingrese el primer número");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int num4 = Convert.ToInt32(Console.ReadLine());
            int Resta = Operaciones.Restar(num3, num4);
            Console.WriteLine($"La resta de los dos numeros ingresados es {Resta}");

            //Multiplicacion
            Console.WriteLine("Multiplicacion");

            Console.WriteLine("Ingrese el primer número");
            int num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int num6 = Convert.ToInt32(Console.ReadLine());
            int Multiplicacion = Operaciones.Multiplicar(num5, num6);
            Console.WriteLine($"La multiplicación de los dos numeros ingresados es {Multiplicacion}");

            //Division
            Console.WriteLine("Division");

            Console.WriteLine("Ingrese el primer número");
            int num7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int num8 = Convert.ToInt32(Console.ReadLine());
            int Division = Operaciones.Dividir(num7, num8);
            Console.WriteLine($"La division de los dos numeros ingresados es {Division}");

            try
            {
                Console.WriteLine($"División: {Operaciones.Dividir(num7, num8)}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
