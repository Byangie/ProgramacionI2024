
namespace Creacion_de_clases
{
    internal class Salon
    {
        public string Nombre_Salon { get; set; }
        public int Capacidad { get; set; }
        public string Ubicacion { get; set; }

        public Salon(string nombre_Salon, int capacidad, string ubicacion)
        {
            this.Nombre_Salon = nombre_Salon;
            this.Capacidad = capacidad;
            this.Ubicacion = ubicacion;
        }
    }
}
