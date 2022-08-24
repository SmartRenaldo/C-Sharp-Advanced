namespace _04_AbstractMethod
{
    public abstract class AbstractMethod
    {
        public abstract int Add(int a, int b);

        public abstract int Sub(int a, int b);

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
