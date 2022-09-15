namespace _28_IEnumerableAndIEnumerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            CattiShelter cattiShelter = new CattiShelter();

            foreach (Cat cat in cattiShelter)
            {
                cat.Treat(3);
            }

            IEnumerable<double> doubles1 = GetCollection("1");

            Console.WriteLine("doubles1");
            foreach (double d in doubles1)
            {
                Console.WriteLine(d);
            }

            IEnumerable<double> doubles2 = GetCollection("2");
            Console.WriteLine("doubles2");
            foreach (double d in doubles2)
            {
                Console.WriteLine(d);
            }

            IEnumerable<double> doubles3 = GetCollection("3");
            Console.WriteLine("doubles3");
            foreach (double d in doubles3)
            {
                Console.WriteLine(d);
            }
        }

        static IEnumerable<double> GetCollection(string s)
        {
            switch (s)
            {
                case "1":
                    return new List<double>() { 1.1, 8.8, -9.7, -5.4 };

                case "2":
                    return new double[] { 5.5, 9.7, -14.8 };

                default:
                    Queue<double> queue = new Queue<double>();
                    queue.Enqueue(3.3);
                    queue.Enqueue(4.5);
                    queue.Enqueue(-6.1);
                    queue.Enqueue(-8.7);
                    queue.Enqueue(10.8);

                    return queue;
            }
        }
    }
}