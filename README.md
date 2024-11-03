# RunAdminCMD | [Latest release](https://github.com/Zalexanninev15/RunAdminCMD/releases/latest)

![](https://github.com/Zalexanninev15/RunAdminCMD/blob/master/Logo.png?raw=true)

[![](https://img.shields.io/badge/platform-Windows-informational)](https://github.com/Zalexanninev15/RunAdminCMD)
[![](https://img.shields.io/badge/written_on-.NET_Framework_4-512BD4.svg?logo=dotnet)](https://dotnet.microsoft.com/download/dotnet-framework/net40)
[![](https://img.shields.io/badge/written_on-.NET_Framework_4.6-512BD4.svg?logo=dotnet)](https://dotnet.microsoft.com/download/dotnet-framework/net46)
[![](https://img.shields.io/badge/written_on-C%23-%23239120.svg?logo=sharp&logoColor=white)](https://github.com/Zalexanninev15/RunAdminCMD)
[![](https://img.shields.io/github/downloads/Zalexanninev15/RunAdminCMD/total.svg)](https://github.com/Zalexanninev15/RunAdminCMD/releases)
[![](https://img.shields.io/github/last-commit/Zalexanninev15/RunAdminCMD)](https://github.com/Zalexanninev15/RunAdminCMD/commits/master)
[![](https://img.shields.io/github/stars/Zalexanninev15/RunAdminCMD.svg)](https://github.com/Zalexanninev15/RunAdminCMD/stargazers)
[![](https://img.shields.io/github/forks/Zalexanninev15/RunAdminCMD.svg)](https://github.com/Zalexanninev15/RunAdminCMD/network/members)
[![](https://img.shields.io/github/issues/Zalexanninev15/RunAdminCMD.svg)](https://github.com/Zalexanninev15/RunAdminCMD/issues?q=is%3Aopen+is%3Aissue)
[![](https://img.shields.io/github/issues-closed/Zalexanninev15/RunAdminCMD.svg)](https://github.com/Zalexanninev15/RunAdminCMD/issues?q=is%3Aissue+is%3Aclosed)
[![](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
[![](https://img.shields.io/badge/Donate-FFDD00.svg?logo=buymeacoffee&logoColor=black)](https://z15.neocities.org/donate)

## Description

Utility for running files/scripts/apps as Administrator. Created to quickly grant Administrator rights to BAT/CMD files and other apps

Show the utility version:

```batch
RunAdminCMD -v
```

## Features

* Quickly grant Administrator rights

* Interesting (in some ways unique) settings for better working with the utility. You can start the files/scripts/apps and arguments to them "in old way" or run them from the **list.txt** file, as well as combine them all

## System requirements

* **OS:** Windows 7 or higher

* **Additional:** .NET Framework 4 or higher

## How to interact?

### Simple use

**- Run for file or app:**

```batch
RunAdminCMD taskmgr
```

**- Run for scripts or app with argument:**

```batch
RunAdminCMD explorer.exe C:\Windows\System32
```

***Note:*** *To add support to the BAT/CMD file, you need to insert the element **%1** (or more after it to support the arguments in its batch scripts) in the section of the script that should accept it. [Here](https://github.com/Zalexanninev15/RunAdminCMD/blob/master/PingCMD.bat) is an example using the "ping" utility in a batch script.*

**- Run a scripts or apps with arguments**

```batch
RunAdminCMD PingCMD.bat -t google.com
```

***Note:*** *To add support to the BAT/CMD file, you need to insert the element **%1** (or more after it to support the arguments in its batch scripts) in the section of the script that should accept it. [Here](https://github.com/Zalexanninev15/RunAdminCMD/blob/master/PingCMD.bat) is an example using the "ping" utility in a batch script.*

### Extended use (using variables)

**- Basics:**

1. In the **list.txt** file enter the variables with the value needed to start the file/script/app that needs Administrator rights (it is better to just put the desired file in the folder with the utility and just write the file name of this file).

Example, text in the **list.txt** file:

```ini
$ping_app=ping
$ping_arguments=-t google.com
$notepad_app=notepad
$github="I love GitHub"
```

***Note:*** *The dollar sign ($) must be present at the beginning, before the variable name*

2. Run the utility:

```batch
RunAdminCMD -f $notepad_app
```

***Notes:***

* *After argument **-f**, write a variable from the **list.txt** file with the way to the file/script/app you want to run*

* *When entering variable(s) when running RunAdminCMD to load a value from **list.txt** file, you can remove the dollar sign ($). Be sure to put this sign in the **list.txt** file itself!*

** **

**- It is also possible to run with an argument(s) (ex: variable from list.txt = $ping_app, argument = -t github.com):**

```batch
RunAdminCMD -f $ping_app -t github.com
```

**- Run with an argument(s) from the list.txt file (ex. variable from list.txt = $notepad_app, argument = "Hello World"):**

```batch
RunAdminCMD -f notepad_app "Hello World"
```

***Note:*** *When entering variable(s) when running RunAdminCMD to load a value from **list.txt** file, you can remove the dollar sign ($). Be sure to put this sign in the **list.txt** file itself!*

**- Run with an argument(s) from variable from the list.txt file (ex. variable from list.txt = $notepad_app, argument as variable from list.txt = $github)**

```batch
RunAdminCMD.exe -f $notepad_app # github
```

**- Run the script or app not from variable and with an argument(s) from variable from the list.txt file (ex: file/script/app = your value :), argument as variable from list.txt = $ping_arguments)**

```batch
RunAdminCMD.exe PingCMD.bat # ping_arguments
```

***Note:*** *To add support to the BAT/CMD file, you need to insert the element **%1** (or more after it to support the arguments in its batch scripts) in the section of the script that should accept it. [Here](https://github.com/Zalexanninev15/RunAdminCMD/blob/master/PingCMD.bat) is an example using the "ping" utility in a batch script.*

## Build

Compile using [SharpDevelop](https://sourceforge.net/projects/sharpdevelop) or [Visual Studio](https://visualstudio.microsoft.com/vs).
