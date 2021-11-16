using System;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {

            Factory factory = new Factory();
            Console.WriteLine(factory.GetPerson(PersonType.Rural).GetName());
            Console.WriteLine(factory.GetPerson(PersonType.Urban).GetName());
        }
    }
}
