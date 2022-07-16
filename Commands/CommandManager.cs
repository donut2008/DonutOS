using System;
using System.Collections.Generic;
using System.Text;

namespace DonutOS.Commands
{
    public class CommandManager
    {
        private List<Command> commands;
        public CommandManager()
        {
            this.commands = new List<Command>();
            this.commands.Add(new Help("help"));
            this.commands.Add(new About("about"));
            this.commands.Add(new ShutdownSystem("exit"));
            this.commands.Add(new RestartSystem("reboot"));
            this.commands.Add(new ConsoleClear("cls"));
            this.commands.Add(new Item("item"));
            this.commands.Add(new Dir("dir"));
        }
        public String processInput(String input)
        {
            String[] split = input.ToLower().Split(' ');
            String label = split[0];
            List<String> args = new List<String>();
            int ctr = 0;
            foreach(String s in split)
            {
                if (ctr != 0)
                    args.Add(s);
                ++ctr;
            }
            foreach(Command cmd in this.commands)
            {
                if (cmd.name.ToLower() == label)
                    return cmd.execute(args.ToArray());
            }
            return "Command \"" + label + "\" not found. Type \"help\" for a list of available commands.\n";
        }
    }
}
