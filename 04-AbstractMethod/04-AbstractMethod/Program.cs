namespace _04_AbstractMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractMethodChild child = new AbstractMethodChild();
            int res1 = child.Add(4, 8);
            Console.WriteLine($"4 + 8 = {res1}");

            int res2 = child.Sub(5, 9);
            Console.WriteLine($"5 - 9 = {res2}");

            int res3 = child.Multiply(5, 9);
            Console.WriteLine($"5 * 9 = {res3}");

            CalculateImpl calculateImpl = new CalculateImpl();
            int res4 = calculateImpl.Add(9, 8);
            Console.WriteLine($"9 + 8 = {res4}");

            int res5 = calculateImpl.Sub(9, 8);
            Console.WriteLine($"9 - 8 = {res5}");
        }
    }
}