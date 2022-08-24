namespace _04_AbstractMethod
{
    public class CalculateImpl : CalculateInterface, CalculateInterface2
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
