using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RunAdminCMD
{
	class Program
	{
	  public static void Main(string[] args)
		{
	  	    Console.Title = "RunAdminCMD";
			if (args.Length != 0)
			{
				if (@args[0] != "-f")
				{
			       try
			       {
			           ProcessStartInfo cmd_loader = new ProcessStartInfo();
			           //cmd_loader.Verb = "runas"; // If is not "level="requireAdministrator"" in Manifest (app.manifest)
			           cmd_loader.FileName = @args[0];
			           if (@args[1] != "0")
                       cmd_loader.Arguments = @args[1];
			        try
			        {
				        Process.Start(cmd_loader);
			        }
			        catch
			        {
				         MessageBox.Show("It is not possible to start the process \"" + @args[0] + "\" as Administrator!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			        }
			       }
			       catch 
			       {
				          MessageBox.Show("Invalid data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			       }
				}
				else
				{
					try
			        {
				 	  string[] list = System.IO.File.ReadAllLines("list.txt");
					  ProcessStartInfo cmd_loader1 = new ProcessStartInfo();
					  cmd_loader1.FileName = @list[Convert.ToInt32(args[1]) - 1];
					  if (args[2] == "/next")
					  	cmd_loader1.Arguments = @list[Convert.ToInt32(args[1])];
					  if ((@args[2] != "0") && (@args[2] != "/next"))
                        cmd_loader1.Arguments = @args[2];
					  try
					  {
					  	 Process.Start(cmd_loader1);
					  }
					  catch
			          {
					  	MessageBox.Show("It is not possible to start the process \"" + @list[Convert.ToInt32(args[1]) - 1] + "\" as Administrator!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			          }
					}
					catch 
					{
						 MessageBox.Show("Invalid data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				MessageBox.Show("RunAdminCMD v1.2-1 by Zalexanninev15", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		    Application.Exit();
		}
	}
}
