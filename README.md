# RunAdminCMD | [Latest release](https://github.com/Zalexanninev15/RunAdminCMD/releases/tag/1.2.0.7)
![](https://i.imgur.com/NZpREOk.png)
## Description
Utility for running files and scripts as Administrator. Created to quickly grant Administrator rights to BAT/CMD files.
## How to interact?
**Is required .NET Framework 4.5 or 4.0!**

### Run with arguments

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
**Example for cmd (with 1 argument for other file):**

```
RunAdminCMD PingCMD.bat google.com
```
*To add support to the BAT/CMD file, you need to insert the element "%1%" in the section of the script that should accept it. [Here](https://github.com/Zalexanninev15/RunAdminCMD/blob/master/PingCMD.bat) is an example using the "ping" utility in a batch script.* 

*You can't use quotation marks ("") to support "spaces" (in arguments)!*

### Run using a file "list.txt"
1. In the "list.cfg" file (open using [Notepad++](https://notepad-plus-plus.org/)), enter the path to the file that needs Administrator rights (it is better to just put the desired file in the folder with the utility and just write the file name of this file).

2. Run the utility:

```
RunAdminCMD -f 1 0
```

*Where the second argument is a number indicating the number of the line with the desired file!*

**It is also possible to run with an argument for other file (ex: line 10, argument "-reset"):**

```
RunAdminCMD -f 10 -reset
```

**or**

**Run an argument from a list file (used the next line after the one you specified to run the file)**

**(ex.  line 10, argument in line 11):**

```
RunAdminCMD -f 10 /next
```

*To add support to the BAT/CMD file, you need to insert the element "%1%" in the section of the script that should accept it. [Here](https://github.com/Zalexanninev15/RunAdminCMD/blob/master/PingCMD.bat) is an example using the "ping" utility in a batch script.* 

*You can't use quotation marks ("") to support "spaces" (in arguments); only run an argument with "spaces" from a list file (not use quotation marks)!*

## Build

Compile using Visual Studio 2012-2019 or SharpDevelop
