using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RunAdminCMD
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "RunAdminCMD";
            if (args.Length != 0)
            {
                ProcessStartInfo cmd_loader = new ProcessStartInfo();
                if (args[0].ToLower() != "-f" && args[0].ToLower() != "-v")
                {
                    try
                    {
                        cmd_loader.FileName = args[0];
                        if (args.Length >= 2)
                        {
                            if (args[1] == "#")
                            {
                                if (File.Exists("list.txt"))
                                    cmd_loader.Arguments = FindValue(args[2].StartsWith("$") ? args[2].Remove(0, 1) : args[2]);
                                else
                                {
                                    MessageBox.Show("File list.txt not exists!",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                                    Application.Exit();
                                }
                            }
                            else
                            {
                                for (int i = 1; i < args.Length; i++)
                                    cmd_loader.Arguments += (args.Length - i) == 1 ? args[i] : args[i] + " ";
                            }
                        }
                        try { Process.Start(cmd_loader);  }
                        catch(Exception ex)
                        {
                            MessageBox.Show("It is not possible to start the process \"" + args[0] + "\" " +
                            "as Administrator!\nError: " + ex.Message,
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Invalid data!\nError: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    switch(args[0].ToLower())
                    {
                        case "-f":
                            {
                                try
                                {
                                    string runThis = FindValue(args[1].StartsWith("$") ? args[1].Remove(0, 1) : args[1]);
                                    if (File.Exists("list.txt"))
                                    {
                                        cmd_loader.FileName = runThis;
                                        if (args.Length >= 3)
                                        {
                                            if (args[2] == "#")
                                                cmd_loader.Arguments = FindValue(args[3].StartsWith("$") ? args[3].Remove(0, 1) : args[3]);
                                            else
                                            {
                                                for (int i = 2; i < args.Length; i++)
                                                    cmd_loader.Arguments += (args.Length - i) == 1 ? args[i] : args[i] + " ";
                                            }
                                        }
                                        try { Process.Start(cmd_loader); }
                                        catch(Exception ex)
                                        {
                                            MessageBox.Show("It is not possible to start the process \"" +
                                            runThis + "\" as Administrator!\nError: " + ex.Message,
                                            "Warning",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("File list.txt not exists!",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                                    }
                                }
                                catch(Exception ex)
                                {
                                    MessageBox.Show("Invalid data!\nError: " + ex.Message,
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                                }
                                break;
                            }
                        case "-v":
                            {
                                ShowAbout();
                                break;
                            }
                    }
                }
            }
            else
                ShowAbout();
            Application.Exit();
        }

        public static void ShowAbout()
        {
            Console.WriteLine("RunAdminCMD" +
            "\nVersion: " + Application.ProductVersion +
            "\nAuthor: Zalexanninev15" +
            "\nGitHub: https://github.com/Zalexanninev15/RunAdminCMD" +
            "\nLicense: MIT" +
            "\nHow to interact: https://github.com/Zalexanninev15/RunAdminCMD#how-to-interact");
            Console.ReadLine();
        }

        public static string FindValue(string variable)
        {
            string[] list = File.ReadAllLines("list.txt");
            foreach (string item in list)
            {
                if (item.StartsWith("$" + variable + "="))
                    return item.Remove(0, variable.Length + 2);
            }
            return null;
        }
    }
}