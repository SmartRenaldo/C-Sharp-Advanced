namespace _09_GenericityMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = Display<string>("Tesla");
            Console.WriteLine(value);
        }

        public static T Display<T>(T value)
        {
            return value;
        }
    }
}