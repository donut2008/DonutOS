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
            Console.Clear();
            Console.WriteLine("DonutOS version 1 developer build 19");
        }
        protected override void Run()
        {
            Console.Write("> ");
            var input = Console.ReadLine();
            switch(input.ToLower())
            {
                case "about":
                    {
                        Console.WriteLine("DonutOS version 1 developer beta build 19");
                        Console.WriteLine("Built by donut2008 using CosmosOS and written in C#.\n");
                        break;
                    }
                case "help":
                    {
                        Console.WriteLine("Available commands are:");
                        Console.WriteLine("help   - Shows this message");
                        Console.WriteLine("about  - Shows information about the OS");
                        Console.WriteLine("exit   - Shuts down the OS");
                        Console.WriteLine("reboot - Restarts the OS\n");
                        break;
                    }
                case "exit":
                    {
                        Console.WriteLine("Shutting down...\n");
                        Cosmos.System.Power.Shutdown();
                        break;
                    }
                case "reboot":
                    {
                        Console.WriteLine("Rebooting...\n");
                        Cosmos.System.Power.Reboot();
                        break;
                    }
                case "clrsc":
                    {
                        Console.WriteLine("Clearing screen...\n");
                        Console.Clear();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid command. Type \"help\" to see available commands.\n");
                        break;
                    }
            }
        }
    }
}
