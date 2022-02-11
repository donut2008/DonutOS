using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using DonutOS.Commands;

namespace DonutOS
{
    public class Kernel : Sys.Kernel
    {
        private CommandManager commandManager;
        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("DonutOS version 3 developer beta build 33");
            this.commandManager = new CommandManager();
        }
        protected override void Run()
        {
            Console.Write("> ");
            String response;
            String input = Console.ReadLine();
            response = this.commandManager.processInput(input.ToLower());
            Console.WriteLine(response);
        }
    }
}
