using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Tarea: Crear tareas para realizar operaciones matemáticas
        Task<int> tarea1 = new Task<int>(() =>
        {
            // 1: Sumar números
            int suma = 0;
            for (int i = 1; i <= 1000; i++)
            {
                suma += i;
            }
            return suma;
        });

        Task<int> tarea2 = new Task<int>(() =>
        {
            // 2: Multiplicar números
            int producto = 1;
            for (int i = 1; i <= 10; i++)
            {
                producto *= i;
            }
            return producto;
        });

        Task<int> tarea3 = new Task<int>(() =>
        {
            // 3: Calcular la raíz cuadrada de números
            double sumaRaices = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumaRaices += Math.Sqrt(i);
            }
            return (int)sumaRaices;
        });

        // Iniciar las tareas
        tarea1.Start();
        tarea2.Start();
        tarea3.Start();

        // Espero que todas las tareas terminen
        Task.WhenAll(tarea1, tarea2, tarea3).Wait();

        // Resultados de cada tarea
        int resultadoSuma = tarea1.Result;
        int resultadoProducto = tarea2.Result;
        int resultadoRaices = tarea3.Result;

        // Todos los resultados
        int resultadoFinal = resultadoSuma + resultadoProducto + resultadoRaices;
        Console.WriteLine($"Resultado de la suma de tareas: {resultadoFinal}");

        Console.WriteLine("Tareas completadas.");
    }
}

