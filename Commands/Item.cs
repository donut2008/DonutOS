using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Sys = Cosmos.System;

namespace DonutOS.Commands
{
    public class Item : Command
    {
        public Item(String name) : base(name) { }
        public override String execute(String[] args)
        {
            String response = "";
            switch(args[0])
            {
                case "/n":
                    var fileName = args[1];
                    try
                    {
                        var fileStream = File.Create(@"0:\" + args[1]);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Error creating " + args[1] + ": " + ex);
                    }
                    break;
                case "/w":
                    var stringToWrite = args[1];
                    try 
                    {
                        File.WriteAllText(@"0:\" + args[2], stringToWrite); 
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Error writing to " + args[2] + ": " + ex); 
                    }
                    break;
                case "/r":
                    try 
                    {
                        Console.WriteLine(File.ReadAllText(@"0:\" + args[2])); 
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Error reading " + args[2] + ": " + ex); 
                    }
                    break;
                case "/d":
                    try
                    {
                        Console.WriteLine("Are you sure you want to delete " + args[1] + "? You CANNOT recover the file after deleting it! (Y/N)");
                        char yesno = (char)Console.Read();
                        if (yesno.ToString() == "Y" || yesno.ToString() == "y")
                        {
                            File.Delete(@"0:\" + args[1]);
                            Console.WriteLine("File " + args[1] + "deleted successfully.");
                        }
                        else if (yesno.ToString() == "N" || yesno.ToString() == "n")
                            Console.WriteLine("Failed to delete " + args[1] + ": Operating cancelled by user.");
                        else
                            Console.WriteLine("Invalid argument, allowed arguments are Y/y/N/n.");
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine("Error deleting " + args[1] + ": " + ex); 
                    }
                    break;
            }
            return response;
        }
    }
}
