﻿using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace DonutOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("DonutOS version 1.7");
        }

        protected override void Run()
        {
            Console.Write("Enter any text to print: ");
            var input = Console.ReadLine();
            switch(input.ToLower())
            {
                case "about":
                    {
                        Console.WriteLine("DonutOS version 1 developer beta build 7.");
                        Console.WriteLine("Built by donut2008 using CosmosOS and written in C#.");
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            Console.Write("Text typed: ");
            Console.WriteLine(input);
        }
    }
}
