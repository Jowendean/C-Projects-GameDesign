using System;

namespace EmployeeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an instance of each employee class
            Employee Jordan = new Employee("Ball", "Jordan", 60000);
            Boss Chelsea = new Boss("Ball", "Chelsea", 140000, "Chevorlet Corvette");
            Trainees Doug = new Trainees("Funny", "Doug", 40000, 8, 4);

            // call Lead(), Learn(), and Work() methods
            Chelsea.Lead();
            Chelsea.Pause();
            Jordan.Work();
            Jordan.Pause();
            Doug.Work();
            Doug.Learn();
            Doug.Pause();

            Console.ReadKey();
        }
    }
}
