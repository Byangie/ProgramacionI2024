namespace Desafio1_Totito
{
//Presentancion de juego totito
    internal class Program
    {

        static void Main(string[] args)
        {
            string[,,] tablero = new string[,,]
            {
                {
                    {"X", "O", "X"},
                    {" ", "O", " "},
                    {"X", "O", "X"}
                },
                {
                    {" ", " ", " "},
                    {"O", "X", "X"},
                    {" ", " ", " "}
                },
                {
                    {"O", "X", "O"},
                    {"X", "O", "X"},
                    {"O", "X", "O"}
                }
            };

            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                Console.WriteLine("Capa " + (i + 1) + ":");
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write(tablero[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
