﻿namespace _02_Descructor
{
    public class Dog:IDisposable
    {
        public Dog()
        {
            Console.WriteLine("I'm a dog");
        }

        public static void Bark()
        {
            Console.WriteLine("Wang");
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        ~Dog()
        {
            Console.WriteLine("Dispose");
        }
    }
}