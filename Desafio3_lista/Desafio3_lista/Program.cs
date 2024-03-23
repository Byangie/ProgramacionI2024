using System.Threading;
using System.Collections.Generic;

namespace Desafio3_lista
{
    internal class Program
    {
        static List<string> Tareas = new List<string>();
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                MostrarMenu();
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        MostrarTareas();
                        break;
                    case 2:
                        AgregarTarea();
                        break;
                    case 3:
                        EliminarTarea();
                        break;
                    case 4:
                        Console.WriteLine("Fin de la ejecucion");
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intente otra vez.");
                        break;
                }
            } while (opcion != 4);
        }

        static void MostrarMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Menu");
            Console.WriteLine("1) Mostrar tareas");
            Console.WriteLine("2) Agregar tarea");
            Console.WriteLine("3) Eliminar tarea");
            Console.WriteLine("4) Salir");
            Console.Write("Seleccione una opción: ");
        }

        static void MostrarTareas()
        {
            Console.WriteLine("Lista de tareas:");
            for (int i = 0; i < Tareas.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Tareas[i]}");
            }
        }

        static void AgregarTarea()
        {
            Console.Write("Ingrese la nueva tarea: ");
            string nuevaTarea = Console.ReadLine();
            Tareas.Add(nuevaTarea);
            Console.WriteLine("Tarea agregada correctamente.");
        }

        static void EliminarTarea()
        {
            MostrarTareas();
            Console.Write("Ingrese el número de la tarea a eliminar: ");
            int indice = int.Parse(Console.ReadLine());
            if (indice >= 1 && indice <= Tareas.Count)
            {
                Tareas.RemoveAt(indice - 1);
                Console.WriteLine("Tarea eliminada correctamente.");
            }
            else
            {
                Console.WriteLine("Número de tarea inválido.");
            }
        }
    }
    }
