using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
       Stopwatch stopwatch = new Stopwatch();
        Console.WriteLine("Enter to start!");
        Console.ReadLine();
        stopwatch.Start();


  while (!Console.KeyAvailable || Console.ReadKey(true).Key != ConsoleKey.Enter)
        {
            Console.Clear();
            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Thread.Sleep(100);
        }
		
		
        TimeSpan finalTime = stopwatch.Elapsed;
        Console.Clear();
        Console.WriteLine("END: {0:00}:{1:00}:{2:00}.{3:00}",
            finalTime.Hours, finalTime.Minutes, finalTime.Seconds, finalTime.Milliseconds / 10);
        Console.WriteLine("...");
        Console.ReadLine();
    }
}
