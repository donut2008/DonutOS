using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace DonutOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("DonutOS version 1.0");
        }

        protected override void Run()
        {
            Console.Write("Enter any text to print: ");
            var input = Console.ReadLine();
            Console.Write("Text typed: ");
            Console.WriteLine(input);
        }
    }
}
