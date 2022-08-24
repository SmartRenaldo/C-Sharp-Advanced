namespace _06_Genericity
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "aaa", "bbb", "", "rrr" };

            foreach (string item in list)
            {
                if (string.IsNullOrWhiteSpace(item))
                {
                    continue;
                }

                Console.WriteLine(item);
            }
        }
    }
}