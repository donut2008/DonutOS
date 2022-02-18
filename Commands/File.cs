using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Sys = Cosmos.System;

namespace DonutOS.Commands
{
    public class File : Command
    {
        public File(String name) : base(name) { }
        public override String execute(String[] args)
        {
            String response = "";
            int sc = 0;
            switch (args[0])
            {
                case "/n":
                    try
                    {
                        Sys.FileSystem.VFS.VFSManager.CreateFile(args[1]);
                        response = "File " + args[1] + " created successfully.";
                    }
                    catch(Exception ex)
                    {
                        response = "Could not create " + args[1] + ", " + ex.ToString();
                        break;
                    }
                    break;
                case "/d":
                    try
                    {
                        Sys.FileSystem.VFS.VFSManager.DeleteFile(args[1]);
                        response = "File " + args[1] + " removed successfully.";
                    }
                    catch (Exception ex)
                    {
                        response = "Could not remove " + args[1] + ", " + ex.ToString();
                        break;
                    }
                    break;
                case "/e":
                    try
                    {
                        FileStream fs = (FileStream)Sys.FileSystem.VFS.VFSManager.GetFile(args[1]).GetFileStream();
                        if(fs.CanWrite)
                        {
                            int ctr = 0;
                            StringBuilder sb = new StringBuilder();
                            foreach(String s in args)
                            {
                                if (ctr > 1)
                                {
                                    sb.Append(s + ' ');
                                    ++sc;
                                }
                                ++ctr;
                            }
                            String txt = sb.ToString();
                            Byte[] data = Encoding.UTF8.GetBytes(txt.Substring(0, txt.Length - 1));
                            fs.Write(data, 0, data.Length);
                            fs.Close();
                            response = "Successfully edited \"" + args[1] + "\"";
                        }
                        else
                        {
                            response = "Failed to edit \"" + args[1] + "\". The file is inaccessible.";
                            break;
                        }
                    }
                    catch(Exception ex)
                    {
                        response = "Editing \"" + args[1] + "\" failed with error " + ex.ToString();
                        break;
                    }
                    break;
                case "/r":
                    try
                    {
                        FileStream fs = (FileStream)Sys.FileSystem.VFS.VFSManager.GetFile(args[1]).GetFileStream();
                        if (fs.CanRead)
                        {
                            Byte[] data = new Byte[sc];
                            fs.Read(data, 0, data.Length);
                            response = Encoding.UTF8.GetString(data);
                            fs.Close();
                        }
                        else
                        {
                            response = "Failed to read \"" + args[1] + "\". The file is inaccessible.";
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        response = "Reading \"" + args[1] + "\" failed with error " + ex.ToString();
                        break;
                    }
                    break;
                default:
                    response = "Unknown argument \"" + args[0] + "\"";
                    break;
            }
            return response;
        }
    }
}
