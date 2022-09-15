namespace _31_ThreadPool;

public class Program
{
    static void Main(string[] args)
    {
        //100 threads in pool
        Enumerable.Range(0, 100).ToList().ForEach(x =>
        {
            ThreadPool.QueueUserWorkItem((o) =>
            {
                Console.WriteLine($"Managed thread id: {Thread.CurrentThread.ManagedThreadId} started");
                Thread.Sleep(100);
                Console.WriteLine($"Managed thread id: {Thread.CurrentThread.ManagedThreadId} ended");
            });
            /*new Thread(() =>
            {
                Console.WriteLine($"Managed thread id: {Thread.CurrentThread.ManagedThreadId} started");
                Thread.Sleep(500);
                Console.WriteLine($"Managed thread id: {Thread.CurrentThread.ManagedThreadId} ended");
            }).Start();*/
        });

        Console.ReadKey();
    }
}