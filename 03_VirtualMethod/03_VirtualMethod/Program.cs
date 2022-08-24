namespace _03_VirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualMethod method = new VirtualMethod();
            int res = method.Calculate(2, 5);
            Console.WriteLine($"2 + 5 = {res}");

            VirtualMethodChild child = new VirtualMethodChild();
            int res2 = child.Calculate(2, 5);
            Console.WriteLine($"2 * 5 = {res2}");

            VirtualMethodChild2 child2 = new VirtualMethodChild2();
            int res3 = child2.Calculate(2, 5);
            Console.WriteLine($"2 - 5 = {res3}");
        }
    }
}