using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonutOS.Commands
{
    public class Ls : Command
    {
        public Ls(String name) : base(name) { }
        public override string execute(string[] args)
        {
            var directory_list = Directory.GetFiles(@"0:\");
            try
            {
                foreach (var file in directory_list)
                {
                    var content = File.ReadAllText(file);

                    Console.WriteLine("File name    : " + file);
                    Console.WriteLine("File size    : " + content.Length);
                    Console.WriteLine("Content      : " + content);
                    Console.WriteLine("");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Listing files and folders failed with error" + ex);
            }
            return "";
        }
    }
}
