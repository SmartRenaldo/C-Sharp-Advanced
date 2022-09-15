namespace _32_JoinAndIsAlive;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Main thread started");
        Thread thread1 = new Thread(Thread1Function);
        Thread thread2 = new Thread(Thread2Function);
        thread1.Start();
        thread2.Start();

        if (thread1.Join(2100))
        {
            Console.WriteLine("Thread1 Function was done within 2.1 sec");
        }
        else
        {
            Console.WriteLine("Thread1 Function was not done within 2.1 sec");
        }

        thread2.Join();

        if (thread1.IsAlive)
        {
            Console.WriteLine("Thread 1 is still doing stuff");
        }
        else
        {
            Console.WriteLine("Thread 1 isn't still doing stuff");
        }

        Console.WriteLine("Thread2 Function done");

        Console.WriteLine("Main thread ended");
    }

    public static void Thread1Function()
    {
        Console.WriteLine("Thread1 Function started");
        Thread.Sleep(2000);
    }

    public static void Thread2Function()
    {
        Console.WriteLine("Thread2 Function started");
    }
}