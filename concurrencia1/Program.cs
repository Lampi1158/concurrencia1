using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    // Método que será ejecutado por los hilos
    static void Proceso(object id)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Hilo {id}: Iteración {i}");
            Thread.Sleep(1000); // Simula un proceso que toma tiempo
        }
    }

    static void Main( string[] args)
    {
        Console.WriteLine("Inicio del programa...");
        Console.WriteLine("procesando  flujos de multiplos ");  
        Stopwatch stopwatch = Stopwatch .StartNew();  

        Proceso(1);
        Proceso(2);
        Proceso(3);

        // Crear tres hilos y asignarles la función 'Proceso'
        Thread hilo1 = new Thread(Proceso);
        Thread hilo2 = new Thread(Proceso);
        Thread hilo3 = new Thread(Proceso);
        stopwatch.Stop();
        Console.WriteLine($"Tiempo de ejecucion proceso multiple:" + $" {stopwatch.ElapsedMilliseconds} ms");

        // Iniciar los hilos con diferentes identificadores
        Console.WriteLine("procesando  flujos de multiplos ");
        Stopwatch stopwatch2 = Stopwatch.StartNew();
        hilo1.Start(1);
        hilo2.Start(2);
        hilo3.Start(3);
        
        // Esperar a que los hilos terminen
        hilo1.Join();
        hilo2.Join();
        hilo3.Join();

     stopwatch2.Stop();  
        Console.WriteLine($"Tiempo de ejecucion proceso multiple:"+$" { stopwatch2.ElapsedMilliseconds} ms");


        Console.WriteLine("fin del programa ...");

        Console.ReadLine(); 
    }

}