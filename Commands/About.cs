using System;
using System.Collections.Generic;
using System.Text;

namespace DonutOS.Commands
{
    public class About : Command
    {
        public About(string name) : base(name) { }
        public override string execute(string[] args)
        {
            return "About this OS\n\nKernel : CosmosOS\nBuild  : 20\nVersion: 2";
        }
    }
}
