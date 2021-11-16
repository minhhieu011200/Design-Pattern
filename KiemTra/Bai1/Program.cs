using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            FruitJuice banana = new FruitJuice(0.3,15,2000,"Yellow");
            banana.print();
            Console.WriteLine(banana.harvest());
            Console.WriteLine(banana.total());

            FruitJuice Strawberry = new FruitJuice(0.01, 106, 150, "Red");
            Strawberry.print();
            Console.WriteLine(Strawberry.harvest());
            Console.WriteLine(Strawberry.total());

            FruitJuice Mango = new FruitJuice(0.7, 7 , 7000, "Green");
            Mango.print();
            Console.WriteLine(Mango.harvest());
            Console.WriteLine(Mango.total());
        }
    }
}
