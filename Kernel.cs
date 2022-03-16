using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using DonutOS.Commands;
using Cosmos.System.FileSystem;

namespace DonutOS
{
    public class Kernel : Sys.Kernel
    {
        private CommandManager commandManager;
        Sys.FileSystem.CosmosVFS fs = new Sys.FileSystem.CosmosVFS();
        protected override void BeforeRun()
        {
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            Console.Clear();
            this.commandManager = new CommandManager();
            Console.WriteLine("DonutOS version 4 beta build 43");
            
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
