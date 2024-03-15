namespace Desafio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Registro de usuario
            Console.WriteLine("Registro de usuario:");
            Console.WriteLine("Ingrese un nombre de usuario:");
            string nombreUsuario = Console.ReadLine();
            Console.WriteLine("Ingrese una contraseña:");
            string contraseñaUsuario = Console.ReadLine();

           

            // Inicio de sesión
            Console.WriteLine("\nInicio de sesión:");
            Console.WriteLine("Ingrese su nombre de usuario:");
            string nombreUsuarioIngresado = Console.ReadLine();
            Console.WriteLine("Ingrese su contraseña:");
            string contraseñaIngresada = Console.ReadLine();

            if (nombreUsuario == nombreUsuarioIngresado && contraseñaUsuario == contraseñaIngresada)
                {
                Console.WriteLine($"Hola, {nombreUsuarioIngresado}, has iniciado sesión correctamente.");
            }
            else
            {
                Console.WriteLine("Nombre de usuario o contraseña incorrectos.");
            }
        }
    }
}
