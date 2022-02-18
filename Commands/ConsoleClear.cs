using System;
using System.Collections.Generic;
using System.Text;

namespace DonutOS.Commands
{
    public class ConsoleClear : Command
    {
        public ConsoleClear(String name) : base(name) { }
        public override String execute(String[] args)
        {
            Console.Clear();
            return "DonutOS version 3 developer beta build 33";
        }
    }
}
