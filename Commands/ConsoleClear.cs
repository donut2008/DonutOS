using System;
using System.Collections.Generic;
using System.Text;

namespace DonutOS.Commands
{
    class ConsoleClear : Command
    {
        public ConsoleClear(String name) : base(name) { }
        public override string execute(string[] args)
        {
            Console.Clear();
            return "DonutOS version 3 developer beta build 33";
        }
    }
}
