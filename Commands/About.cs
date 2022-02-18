using System;
using System.Collections.Generic;
using System.Text;

namespace DonutOS.Commands
{
    public class About : Command
    {
        public About(String name) : base(name) { }
        public override string execute(string[] args)
        {
            return "About this OS\n\n" +
                "DonutOS\n" +
                "Version: 3\n" +
                "Build  : 37\n" +
                "Kernel : CosmosOS\n";
        }
    }
}
