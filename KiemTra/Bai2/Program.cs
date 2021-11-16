using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            var constructor = new Constructor(1,"a",200,2000, 1000);

            var manager = new Manager(2,"b", 5000,3000);

            var directory = new Director(3,"c", 20, 5000, 500);

            WorkerComposite rootConstructor = new WorkerComposite();
            WorkerComposite rootManager = new WorkerComposite();
            WorkerComposite rootManager2 = new WorkerComposite();
            WorkerComposite rootDirector = new WorkerComposite();
            WorkerComposite rootrootManager = new WorkerComposite();

            rootConstructor.workerComposites.Add(constructor);

            rootrootManager.workerComposites.Add(manager);
            rootrootManager.workerComposites.Add(constructor);

            rootManager.workerComposites.Add(rootrootManager);
            rootManager.workerComposites.Add(constructor);
            rootManager.workerComposites.Add(constructor);

            rootManager2.workerComposites.Add(manager);
            rootManager2.workerComposites.Add(constructor);
            rootManager2.workerComposites.Add(constructor);

            rootDirector.workerComposites.Add(directory);
            rootDirector.workerComposites.Add(rootConstructor);
            rootDirector.workerComposites.Add(rootManager);
            rootDirector.workerComposites.Add(rootManager2);

            rootDirector.showDetails();


            Console.WriteLine(rootDirector.sumPrice("Manager"));
            Console.WriteLine(rootDirector.sumPrice("Constructor"));
            Console.WriteLine(rootDirector.sumPrice("Director"));
            Console.WriteLine(rootDirector.countName("c"));






        }
    }
}
