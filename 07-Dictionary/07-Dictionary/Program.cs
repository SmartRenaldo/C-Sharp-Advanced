namespace _07_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //key cannot be repeated
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(0, "cat");
            dictionary.Add(1, "dog");
            dictionary.Add(2, "monkey");

            foreach (KeyValuePair<int, string> pair in dictionary)
            {
                Console.WriteLine($"Key: {pair.Key.ToString()}, Vaule: {pair.Value.ToString()}");
            }

            Console.WriteLine(dictionary.ContainsValue("dog"));
            Console.WriteLine(dictionary.ContainsValue("panda"));
        }
    }
}