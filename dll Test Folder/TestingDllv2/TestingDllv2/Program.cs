using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2AssemblyTesting;


namespace TestingDllv2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle Buick = new Vehicle("Buick", 4, 160);
            if (Buick is IDrivable)
            {
                Buick.Move();
                Buick.Stop();
            }
            else
            {
                Console.WriteLine("The {0} cant be driven", Buick.Brand);
            }
            Console.WriteLine("//////////////////");

            Class1 val = new Class1();
            Console.WriteLine("\nTesting dll reference file");
            if (val.AuthCalc("Grant", "password"))
            {
                Console.WriteLine("dll reference works");
            }
            else
            {
                Console.WriteLine("dll reference works");
            }
            Console.WriteLine("Testing dll reference file\n");

            IElectronicDevice TV = Remote.getDevice();
            ButtonClass btn = new ButtonClass(TV);
            TV.Type();
            btn.Execute();
            btn.Undo();

            Console.ReadLine();
        }
    }
}

