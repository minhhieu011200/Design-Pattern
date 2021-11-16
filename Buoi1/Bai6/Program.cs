using System;

namespace Bai6
{
    class Program
    {
        public sealed class Singleton
        {
            public static Singleton Instance { get; }
            = new Singleton();
            private Singleton() { }

            public string GetName()
            {
                return "Singleton";
            }
        }


        static void Main(string[] args)
        {
            ConcretePrototype1 concretePrototype1 = new ConcretePrototype1();
            concretePrototype1.age = 10;
  

            ConcretePrototype1 clone1 = (ConcretePrototype1)concretePrototype1.Clone();
            concretePrototype1.age = 15;

            Console.WriteLine(clone1.age);
            clone1.age=15;
            Console.WriteLine(clone1.age);


        }
    }
}
