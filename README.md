# RunAdminCMD | [Latest release](https://github.com/Zalexanninev15/RunAdminCMD/releases/tag/1.1.1.2)
![](https://i.imgur.com/NZpREOk.png)
## Description
Utility for running files and scripts as Administrator. Created to quickly grant Administrator rights to BAT/CMD files.
## How to interact?
**Is required .NET Framework 4.0!**
### Version 1.1b ([Download](https://github.com/Zalexanninev15/RunAdminCMD/releases/download/1.1.1.2/RunAdminCMD.exe))
Run the utility's executable file with a argument that will contain the path to/name of the file to run as Administrator

**Example for cmd:**

```
RunAdminCMD C:\Windows\explorer.exe 0
```

**Example for cmd (with "spaces"):**
*If the path to/file name has "spaces", then you must put quotation marks ("")*
```
RunAdminCMD "C:\scripts wifi\Enable WiFi.cmd" 0
```
**Example for cmd (running with an argument):**

```
RunAdminCMD vcfc.bat google.com
```
*To add support to the BAT/CMD file, you need to insert the element "%1%" in the section of the script that should accept it. [Here](https://github.com/Zalexanninev15/RunAdminCMD/blob/master/PingCMD.bat) is an example using the "ping" utility in a batch script.* 

**You can't use quotation marks ("") to support "spaces" (in arguments)!**

### Version 1.1 ([Download](https://github.com/Zalexanninev15/RunAdminCMD/releases/download/1.1/RunAdminCMD.exe))
Run the utility's executable file with a argument that will contain the path to/name of the file to run as Administrator

**Example for cmd:**

```
RunAdminCMD C:\Windows\explorer.exe
```

*If the path to/file name has "spaces", then you must put quotation marks ("")*

**Example for cmd (with "spaces"):**

```
RunAdminCMD "C:\scripts wifi\Enable WiFi.cmd"
```

### Version 1.0 ([Download](https://github.com/Zalexanninev15/RunAdminCMD/releases/download/1.0/RunAdminCMD.zip))
1. In the "cmd.cfg" file (open using [Notepad++](https://notepad-plus-plus.org/)), enter the path to the file (in the first line) that needs Administrator rights (it is better to just put the desired file in the folder with the utility and just write the file name of this file).
2. Run the file "RunAdminCMD.exe" and give Administrator rights
