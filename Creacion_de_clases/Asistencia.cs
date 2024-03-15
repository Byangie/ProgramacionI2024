
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Creacion_de_clases
{
    internal class Asistencia
    {   
            public string Estudiante { get; set; }
            public string Fecha { get; set; }
            public string Horario { get; set; }

            public Asistencia(string estudiante, string fecha, string horario)
            {
                this.Estudiante = estudiante;
                this.Fecha = fecha;
                this.Horario = horario;
            
        }
        public string presente()
        {
            return $"Hola Soy {Estudiante} y estoy presente";

        }

    }
}
