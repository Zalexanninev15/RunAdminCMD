# RunAdminCMD | [Latest release](https://github.com/Zalexanninev15/RunAdminCMD/releases/latest)

![](https://github.com/Zalexanninev15/RunAdminCMD/blob/master/Logo.png?raw=true)

[![](https://img.shields.io/badge/OS-Windows-informational?logo=windows)](https://github.com/Zalexanninev15/RunAdminCMD)
[![](https://img.shields.io/badge/.NET-Framework_4.5-4E2ACD.svg)](https://www.microsoft.com/en-US/download/details.aspx?id=30653)
[![](https://img.shields.io/github/v/release/Zalexanninev15/RunAdminCMD)](https://github.com/Zalexanninev15/RunAdminCMD/releases/latest)
[![](https://img.shields.io/github/downloads/Zalexanninev15/RunAdminCMD/total.svg)](https://github.com/Zalexanninev15/RunAdminCMD/releases)
[![](https://img.shields.io/github/last-commit/Zalexanninev15/RunAdminCMD)](https://github.com/Zalexanninev15/RunAdminCMD/commits/master)
[![](https://img.shields.io/github/stars/Zalexanninev15/RunAdminCMD.svg)](https://github.com/Zalexanninev15/RunAdminCMD/stargazers)
[![](https://img.shields.io/github/forks/Zalexanninev15/RunAdminCMD.svg)](https://github.com/Zalexanninev15/RunAdminCMD/network/members)
[![](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
[![](https://img.shields.io/badge/donate-Buy_Me_a_Coffee-F94400.svg)](https://zalexanninev15.jimdofree.com/buy-me-a-coffee)

## Description
Utility for running files and scripts as Administrator. Created to quickly grant Administrator rights to BAT/CMD files

## System requirements
* **OS:** Windows 7/8/8.1/10
* **Additional:** .NET Framework 4.5

## Features
* Quickly grant Administrator rights
* Interesting (in some ways unique) settings for better working with the utility

## How to interact?

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
1. In the "list.txt" file (open using [Notepad++](https://notepad-plus-plus.org/)), enter the path to the file that needs Administrator rights (it is better to just put the desired file in the folder with the utility and just write the file name of this file).

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

Compile using [SharpDevelop](https://sourceforge.net/projects/sharpdevelop) or [Visual Studio](https://visualstudio.microsoft.com/vs)
