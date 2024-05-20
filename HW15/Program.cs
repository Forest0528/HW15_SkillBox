using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task PrintMessageAsync(string message, int delay)
    {
        await Task.Delay(delay);
        Console.WriteLine($"{message} - Поток {Thread.CurrentThread.ManagedThreadId}");
    }

    static async Task Main(string[] args)
    {
        var tasks = new[]
        {
            PrintMessageAsync("Сообщение из потока 1", 1000),
            PrintMessageAsync("Сообщение из потока 2", 2000),
            PrintMessageAsync("Сообщение из потока 3", 3000),
        };

        await Task.WhenAll(tasks);

        Console.WriteLine("Все задачи завершены.");
        Console.ReadLine();
    }
}
