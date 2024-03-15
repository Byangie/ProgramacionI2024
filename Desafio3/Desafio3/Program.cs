namespace Desafio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ingrese numero 1");
                int nume1;
                if (!int.TryParse(Console.ReadLine(), out nume1))
                {
                    throw new Exception("Debe ingresar un número entero.");
                }

                Console.WriteLine("Ingrese numero 2");
                int nume2;
                if (!int.TryParse(Console.ReadLine(), out nume2))
                {
                    throw new Exception("Debe ingresar un número entero.");
                }

                int sumado = Suma.Sumar(nume1, nume2);
                Console.WriteLine($"La suma de numero {nume1} y numero {nume2} es : {sumado}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Ejecucion finalizada");
            }
        }
    }
}
