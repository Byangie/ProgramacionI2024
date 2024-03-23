namespace Desafio2_Compras
{
    internal class Program
    {
        static void TotalComprasDescuento(int[,] MontoCompras)
        {
            for (int i = 0; i < MontoCompras.GetLength(0); i++)
            {
                int TotalCompra = 0;
                for (int j = 0; j < MontoCompras.GetLength(1); j++)
                {
                    TotalCompra += MontoCompras[i, j];
                }

                double descuento = 0;
                
                if (TotalCompra >= 100 && TotalCompra <= 1000)
                {
                    descuento = 0.1;
                }
                else if (TotalCompra > 1000)
                {
                    descuento = 0.2;
                }
                if (descuento == 0 || (TotalCompra >= 0 && TotalCompra < 100))
                {
                    Console.WriteLine($"Cliente {i + 1}: Total Compra {TotalCompra}, No hay descuento");
                }
                else
                {
                    double TotalDescuento = TotalCompra - (TotalCompra * descuento);
                    Console.WriteLine($"Cliente {i + 1}: Total Compra {TotalCompra}, Descuento = {descuento * 100}%, Total con Descuento = {TotalDescuento}");
                }

            }

        }
        static void Main(string[] args)
        {
            int[,] MontoCompras = new int[,]
            {
                { 50, 100, 150, 200, 250},
                { 500, 1000, 1500, 2000, 2500},
                {100, 200, 300, 400, 500 },
                {10, 20, 30, 10, 10 } ,
                { 400, 800, 1600, 3200, 6400}
            };
            TotalComprasDescuento(MontoCompras);
        }
    }
}
