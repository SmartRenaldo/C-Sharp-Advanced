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
        }
    }
}