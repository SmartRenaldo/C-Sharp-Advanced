namespace _03_VirtualMethod
{
    public class VirtualMethod
    {
        public virtual int Calculate(int a, int b) 
        { 
            return a + b;
        }
    }

    class VirtualMethodChild: VirtualMethod
    {
        public override int Calculate(int a, int b)
        {
            return a * b;
        }
    }

    class VirtualMethodChild2: VirtualMethod
    {
        public override int Calculate(int a, int b)
        {
            return a - b;
        }
    }
}
