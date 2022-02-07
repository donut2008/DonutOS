using System;
using System.Collections.Generic;
using System.Text;

namespace DonutOS.Commands
{
    public class Help : Command
    {
        public Help(String name) : base(name) { }
        public override string execute(string[] args)
        {
            return "Welcome to DonutOS! Available commands are:\n" +
                "about - Shows information about the OS\n" +
                "help  - Shows this message";
        }
    }
}
