﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DonutOS.Commands
{
    public class CommandManager
    {
        private List<Command> commands;
        public CommandManager()
        {
            this.commands = new List<Command>(5);
            this.commands.Add(new Help("help"));
            this.commands.Add(new About("about"));
        }
        public String processInput(String input)
        {
            String[] split = input.ToLower().Split(" ");
            String label = split[0];
            List<String> args = new List<String>();
            int ctr = 0;
            foreach (String s in split)
            {
                if (ctr != 0)
                    args.Add(s);
                ++ctr;
            }
            foreach (Command cmd in this.commands)
            {
                if (cmd.name.ToLower() == label.ToLower())
                    cmd.execute(args.ToArray());
            }
            return "Command \""+label+"\" not found. Type \"help\" for a list of available commands.";
        }
    }
}
