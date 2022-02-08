using System;
using System.Collections.Generic;
using System.Text;

namespace DonutOS.Commands
{
    public class RestartSystem : Command
    {
        public RestartSystem(String name) : base(name) { }
        public override string execute(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Restarting...");
            Cosmos.System.Power.Reboot();
            return "";
        }
    }
}
