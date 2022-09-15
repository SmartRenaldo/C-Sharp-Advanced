namespace _29_Thread
{
    public class Program
    {
        static void Main(string[] args)
         {
            /*for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("Main thread: " + i);
                Thread.Sleep(1000);
            }

            Console.WriteLine("BOOM!");*/

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 1");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 3");
            }).Start();

            Console.ReadLine();
        }
    }
}