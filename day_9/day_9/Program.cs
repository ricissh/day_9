using System;

namespace day_9
{
    class Program
    {
        static void Main(string[] args)
        {
            uzdevums teksts = new uzdevums
            Test TestaObjekts = new Test();
            int rezultats = TestaObjekts.Saskaitisana(3, 7);
            string kopa = teksts.
            Test TestaObjekts2 = new Test();

            TestaObjekts.skaitlis = 3;
            TestaObjekts2.skaitlis = 6;
            Console.WriteLine("Izvade no TestaObjekts: " + TestaObjekts.skaitlis);
            Console.WriteLine("Izvade no TestaObjekts2: " + TestaObjekts2.skaitlis);

            Console.WriteLine("Izvade no klases: " + rezultats);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}