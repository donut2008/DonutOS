using System;
using System.Collections.Generic;
using System.Text;

namespace DonutOS.Commands
{
    public class Help : Command
    {
        public Help(String name) : base(name) { }
        public override string execute(String[] args)
        {
            return "Welcome to DonutOS! Available commands are:\n" +
                "about  - Shows information about the OS\n" +
                "help   - Shows this message\n" +
                "exit   - Shuts down the OS\n" +
                "reboot - Restarts the OS\n";
        }
    }
}
