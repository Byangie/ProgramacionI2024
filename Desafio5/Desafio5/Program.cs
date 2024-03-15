namespace Desafio5
{
    internal class Program
    {
        static int puntuacionMasAlta = 0;
        static string jugadorRecord = "";

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ingrese el nombre del jugador (o escriba 'salir' para terminar):");
                string nombreJugador = Console.ReadLine();

                if (nombreJugador.ToLower() == "salir")
                {
                    break;
                }

                Console.WriteLine("Ingrese la puntuación del jugador:");
                int puntajeObtenido;
                if (!int.TryParse(Console.ReadLine(), out puntajeObtenido))
                {
                    Console.WriteLine("Ingrese una puntuación válida.");
                    continue;
                }

                VerificarPuntuacion(puntajeObtenido, nombreJugador);
            }
        }

        static void VerificarPuntuacion(int puntajeObtenido, string nombreJugador)
        {
            if (puntajeObtenido > puntuacionMasAlta)
            {
                Console.WriteLine("La nueva puntuación más alta es " + puntajeObtenido);
                Console.WriteLine("La puntuación más alta fue lograda por " + nombreJugador);
                puntuacionMasAlta = puntajeObtenido;
                jugadorRecord = nombreJugador;
            }
            else
            {
                Console.WriteLine("La puntuación más alta de " + puntuacionMasAlta + " no se ha podido superar, y aún está en manos de " + jugadorRecord);
            }
        }
    }
}
