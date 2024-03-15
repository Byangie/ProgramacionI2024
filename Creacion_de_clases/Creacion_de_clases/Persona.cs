
using Creacion_de_clases;

namespace Creacion_de_clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Fecha_De_Nacimiento {  get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }

        public Persona(string Nombre, string Apellido, string Fecha_De_Nacimiento, int Telefono, string Direccion)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Fecha_De_Nacimiento = Fecha_De_Nacimiento;
            this.Telefono = Telefono;
            this.Direccion = Direccion; 
        }

        public string Presentarse() {
            return $"Hola Soy {Nombre} {Apellido} ";

        }

        public string Nacimiento()
        {
            return $"Soy {Nombre} y mi fecha de nacimiento es {Fecha_De_Nacimiento}";

        }

        public string Cel()
        {
            return $"Soy {Nombre} y mi número de telefono es {Telefono}";
           
        }

        public string Hogar()
        {
            return $"Soy {Nombre} y mi dirección es {Direccion}";

        }

    }
    public class Alumno : Persona
    {
        public int Carne { get; set; }
        public string Fecha_de_ingreso { get; set; }
        public string Grado { get; set; }
        public string Seccion { get; set; }

        public Alumno(string Nombre, string Apellido, string Fecha_De_Nacimiento, int Telefono, string Direccion,
            int Carne, string Fecha_de_ingreso, string Grado, string Seccion) : base(Nombre, Apellido, Fecha_De_Nacimiento, Telefono, Direccion)

        {
            this.Carne = Carne;
            this.Fecha_de_ingreso = Fecha_de_ingreso;
            this.Grado = Grado;
            this.Seccion = Seccion;
        }

        public string Estudiar()
        {
            return $"Soy {Nombre} y estoy estudiando.";
        }

        public string ObtenerInformacion()
        {
            return $"Mi Carné es {Carne}.";
        }

        public string Cursando()
        {
            return $"Estoy en {Grado} y mi seccion es {Seccion}.";
        }


    }

    public class Profesor : Persona
    {
        public int CodigoEmpleado { get; set; }
        public string Clase { get; set; }

        public Profesor(string Nombre, string Apellido, string Fecha_De_Nacimiento, int Telefono, string Direccion,
            int CodigoEmpleado, string Clase) : base(Nombre, Apellido, Fecha_De_Nacimiento, Telefono, Direccion)

        {
            this.CodigoEmpleado = CodigoEmpleado;
            this.Clase = Clase;
        }

        public string Enseñar()
        {
            return $"Soy {Nombre} e imparto clases.";
        }

        public string Codigo()
        {
            return $"Mi Codigo de empleado es {CodigoEmpleado}.";

        }
    }

    public class Trabajadores : Persona

    {
        public string Cargo { get; set; }
        public string Horarios { get; set; }

        public Trabajadores(string Nombre, string Apellido, string Fecha_De_Nacimiento, int Telefono, string Direccion,
         string Cargo, string Horarios) : base(Nombre, Apellido, Fecha_De_Nacimiento, Telefono, Direccion)
        {
            this.Cargo = Cargo;
            this.Horarios = Horarios;
        }

    } 

}

    public class Salon
{
    public string Nombre_Salon { get; set; }
    public int Capacidad { get; set; }
    public string Ubicacion { get; set; }       

    public Salon(string nombre_Salon, int capacidad, string ubicacion)
    {
        Nombre_Salon = nombre_Salon;
        Capacidad = capacidad;
        Ubicacion = ubicacion;
    }
}

public class Asistencia
{
    public string Estudiante { get; set; }
    public string Fecha { get; set; }
    public string Horario { get; set; }

    public Asistencia(string estudiante, string fecha, string horario)
    {
        Estudiante = estudiante;
        Fecha = fecha;
        Horario = horario;
    }
}