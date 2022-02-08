using System;
using System.Collections.Generic;
using System.Text;
using Cosmos;

namespace DonutOS.Commands
{
    public class ShutdownSystem : Command
    {
        public ShutdownSystem(String name) : base(name) { }
        public override string execute(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Shutting down...");
            Cosmos.System.Power.Shutdown();
            return "";
        }
    }
}
