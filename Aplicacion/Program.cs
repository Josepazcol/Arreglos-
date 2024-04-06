using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Tarea
{
    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    public bool Estado { get; set; } 

    public Tarea(string titulo, string descripcion = "")
    {
        Titulo = titulo;
        Descripcion = descripcion;
        Estado = false;
    }
}

public class ListaTareas
{
    private List<Tarea> tareas;

    public ListaTareas()
    {
        tareas = new List<Tarea>();
    }

    public void MostrarTareas()
    {
        Console.WriteLine("**Lista de tareas:**");
        for (int i = 0; i < tareas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tareas[i].Titulo}");
            if (!string.IsNullOrEmpty(tareas[i].Descripcion))
            {
                Console.WriteLine($"\tDescripción: {tareas[i].Descripcion}");
            }
            Console.WriteLine($"\tEstado: {(tareas[i].Estado ? "Completada" : "Pendiente")}");
        }
    }

    public void AgregarTarea()
    {
        Console.WriteLine("**Agregar nueva tarea:**");
        Console.Write("Ingrese el título de la tarea: ");
        string titulo = Console.ReadLine();

        Console.Write("Ingrese la descripción de la tarea (opcional): ");
        string descripcion = Console.ReadLine();

        tareas.Add(new Tarea(titulo, descripcion));
        Console.WriteLine("Tarea agregada correctamente.");
    }

    public void EliminarTarea()
    {
        MostrarTareas();

        Console.Write("Ingrese el número de la tarea a eliminar: ");
        int numeroTarea = int.Parse(Console.ReadLine());

        if (numeroTarea > 0 && numeroTarea <= tareas.Count)
        {
            tareas.RemoveAt(numeroTarea - 1);
            Console.WriteLine("Tarea eliminada correctamente.");
        }
        else
        {
            Console.WriteLine("Número de tarea inválido.");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ListaTareas listaTareas = new ListaTareas();

        int opcion;
        do
        {
            Console.WriteLine();
            Console.WriteLine("**Menú de tareas:**");
            Console.WriteLine("1. Mostrar tareas");
            Console.WriteLine("2. Agregar tarea");
            Console.WriteLine("3. Eliminar tarea");
            Console.WriteLine("0. Salir");
            Console.Write("Ingrese una opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    listaTareas.MostrarTareas();
                    break;
                case 2:
                    listaTareas.AgregarTarea();
                    break;
                case 3:
                    listaTareas.EliminarTarea();
                    break;
            }
        } while (opcion != 0);

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
