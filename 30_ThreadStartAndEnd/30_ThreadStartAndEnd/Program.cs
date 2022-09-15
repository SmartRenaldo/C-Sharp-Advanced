namespace _30_ThreadStartAndEnd;

public class Program
{
    static void Main(string[] args)
    {
        var taskCompletionSource = new TaskCompletionSource<int>();

        var thread = new Thread(() =>
        {
            Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
            Thread.Sleep(1000);
            taskCompletionSource.TrySetResult(0);
        });

        thread.Start();
        var test = taskCompletionSource.Task.Result;
        Console.WriteLine("Task was done: {0}", test);
    }
}