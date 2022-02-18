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
        private CosmosVFS vfs;
        protected override void BeforeRun()
        {
            this.vfs = new CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(this.vfs);
            Console.Clear();
            this.commandManager = new CommandManager();
            Console.WriteLine("DonutOS version 3 developer beta build 37");
            
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
