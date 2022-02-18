using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace DonutOS.Commands
{
    public class Dir : Command
    {
        public Dir(String name) : base(name) { }
        public override String execute(String[] args)
        {
            String response = "";
            switch(args[0])
            {
                case "/n":
                    try
                    {
                        Sys.FileSystem.VFS.VFSManager.CreateDirectory(args[1]);
                        response = "Directory \"" + args[1] + "\" created successfully.";
                        break;
                    }
                    catch(Exception ex)
                    {
                        response = "Error creating directory, " + ex.ToString();
                        break;
                    }
                case "/d":
                    try
                    {
                        Console.Write("Are you sure you want to delete the \"" + args[1] + "\" directory? (Y/N)");
                        var yn = Console.ReadLine();
                        if (yn.ToLower() == "y")
                        {
                            Sys.FileSystem.VFS.VFSManager.DeleteDirectory(args[1], true);
                            response = "Directory \"" + args[1] + "\" deleted successfully.";
                        }
                        else
                            response = "Operation cancelled by user.";
                        break;
                    }
                    catch (Exception ex)
                    {
                        response = "Error deleting directory, " + ex.ToString();
                        break;
                    }
                default:
                    response = "Unexpected argument \"" + args[0] + "\"";
                    break;
            }
            return response;
        }
    }
}
