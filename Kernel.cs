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
            Console.WriteLine("DonutOS version 1.11");
        }

        protected override void Run()
        {
            Console.Clear();
            Console.WriteLine("Enter a username for this session: ");
            var user = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("DonutOS version 1 developer build 11\n\nRunning as user "+user);
            Console.WriteLine(user+"> ");
            var input = Console.ReadLine();
            switch(input.ToLower())
            {
                case "about":
                    {
                        Console.WriteLine("DonutOS version 1 developer beta build 11");
                        Console.WriteLine("Built by donut2008 using CosmosOS and written in C#.");
                        break;
                    }
                case "help":
                    {
                        Console.WriteLine("Available commands are:");
                        Console.WriteLine("help   - Shows this message");
                        Console.WriteLine("about  - Shows information about the OS");
                        Console.WriteLine("exit   - Shuts down the OS");
                        Console.WriteLine("reboot - Restarts the OS");
                        Console.WriteLine("whoami - Shows current user");
                        break;
                    }
                case "exit":
                    {
                        Console.Clear();
                        Console.WriteLine("Shutting down...");
                        Cosmos.System.Power.Shutdown();
                        break;
                    }
                case "reboot":
                    {
                        Console.WriteLine("Rebooting...");
                        Cosmos.System.Power.Reboot();
                        break;
                    }
                case "whoami":
                    {
                        Console.WriteLine("DonutOS\\"+user);
                        break;
                    }
                default:
                    {
                        Console.Write("Text typed: ");
                        Console.WriteLine(input);
                        break;
                    }
            }
        }
        private void CommandHandler(string input)
        {

        }
    }
}
