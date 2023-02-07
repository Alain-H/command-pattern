using System;

namespace Command_Muster
{
    class Program
    {
        static void Main(string[] args)
        {

            Invoker invoker = new Invoker();
            Console.WriteLine("\n____________doCom1_______________\n");
            invoker.doCom1();
            Console.WriteLine("\n____________doCom2_______________\n");
            invoker.doCom2();
            invoker.undo();
            invoker.doCom2();

            Console.ReadKey();
        }
    }
}
