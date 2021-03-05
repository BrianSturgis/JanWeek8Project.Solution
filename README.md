<div align="left">
<img src="https://github.com/BrianSturgis.png" width="200px" height="auto" >
</div>
<p align="left"> Authored by Brian Sturgis</p>
<p align="left">Created on March 5th, 2021</p>

## Detailed Description
Please read the entire README before using application.

This application is for placing orders for a bakery.

# Setup/Installation Requirements .Net Installation
## GIT HUB
- repository location (https://github.com/BrianSturgis/JanWeek8Project.Solution
- open through a git terminal or clone editor.
- got to repo location.
- using git commands clone to local repo or click "download" and unpack on machine

## USING THIS APPLICATION
## MAC
C# and .NET programming are fully supported on Mac operating systems. We can install .NET and C# on a Mac in a few steps:

Download this .NET Core SDK (Software Development Kit) . Clicking this link will prompt a .pkg file download from Microsoft.

Open the file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.

Confirm the installation is successful by opening your terminal and running the command $ dotnet --version. You should see something like this in response: 2.2.105. This means both .NET and C# are successfully installed.

## Windows
Note on Windows Versions These Windows instructions assume you're using Windows 10. If you currently run Windows 7 or Windows 8, you may have a free upgrade available.

If you are not running Windows 10 (and cannot or do not plan to upgrade), specific installation steps may differ. However, your instructor will be available to assist with personal laptop configurations during the first week of the course.

## Installation Steps
Download either the the 64-bit .NET Core SDK (Software Development Kit). Clicking these links will prompt a .exe file download from Microsoft.

Open the file and follow the steps provided by the installer for your OS.

Confirm the installation is successful by opening a new Windows PowerShell window and running the command dotnet --version. You should see something a response like this (version numbers do not need to be the same): 2.2.105
This means .NET and C# are installed and our computer recognizes the dotnet command.

## Run Tests
Open Terminal, navigate into the "Bakery.Tests/" folder in the command line
Run the following command $"dotnet restore" to retrieve and install the packages we listed in .csproj in our application.
Then run the following command: $ dotnet test.

## KNOWN BUGS
- none yet

## Stretch goals
-animated UI

## Support and contact details
email Brian Sturgis @ <sturujisu@gmail.com>

## TESTS
```CS
test:OrderConstructor_CreatesInstanceOfOrder_Order()
expect:Assert.AreEqual(typeof(Order), newOrder.GetType());

test:GetDescription_ReturnsDescription_String()
expect: Assert.AreEqual(description, result);

test:SetDescription_SetDescription_String()
expect:Assert.AreEqual(updatedDescription, result);

test:GetAll_ReturnsEmptyList_OrderList()
expect:CollectionAssert.AreEqual(newOrder, result);

test:GetAll_ReturnsOrders_OrderList()
expect:CollectionAssert.AreEqual(newOrder, result);

test:GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
expect:Assert.AreEqual(1, result);

```

## Technologies Used
* C#
* NET
* VisualStudio Code
* Git
* GitHub
* MSTest
* coffee

### License
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE..

Copyright (c) 2020 **Brian Micheal Sturgis**