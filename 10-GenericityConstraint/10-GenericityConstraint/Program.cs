namespace _10_GenericityConstraint
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Display(student);
            //Show(student); error

            Dog dog = new Dog();
            Show(dog);
            Display(dog);
            Look(dog);

            Look("sss");
            //Look(1); error
        }

        /// <summary>
        /// where T:new() : T only receives the non-paramener constructor
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        public static void Display<T>(T value) where T : new()
        {
            Console.WriteLine("Display...");
        }

        /// <summary>
        /// where T : Dog : T only receives the Dog type constructor
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        public static void Show<T>(T value) where T : Dog
        {
            Console.WriteLine("Show...");
        }

        /// <summary>
        /// where T : class : T only receives the reference type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        public static void Look<T>(T value) where T : class
        {
            Console.WriteLine("Look...");
        }

        public static void Peek<T, S, K, D>(T value) 
            where T : class
            where S : struct
            where K : class, new()
            where D : Dog
        {
            Console.WriteLine("Peek...");
        }
    }
}