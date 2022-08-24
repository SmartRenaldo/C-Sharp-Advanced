namespace _08_SelfDefinedGenericity
{
    class Program
    {
        static void Main(string[] args)
        {
            Doge<string> doge1 = new Doge<string>("Dogecoin");
            Console.WriteLine(doge1.GetValue());

            Doge<int> doge2 = new Doge<int>(2);
            Console.WriteLine(doge2.GetValue());
        }
    }
}