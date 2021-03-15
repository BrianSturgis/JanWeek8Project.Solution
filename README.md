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
- go to repo location.
- using git commands clone to local repo or click "download" and unpack on machine

## Setup and Installation Requirements

### Prior to Installation
* Confirm you have installed .NET installed - this will provide access to the C# language
  * [.NET for macOS](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.100-macos-x64-installer)
  * [.NET for Windows](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.102-windows-x64-installer)
* Additionally, you may want to install a REPL to allow you to practice, test, and experiment with C#. Below are instructions for the ```dotnet script``` REPL:
  * Install ```dotnet script``` by running the following terminal command: ```$ dotnet tool install -g dotnet-script```
  * **NOTE:** If you just installed .NET 5, restart the terminal. (Otherwise, you will not be able to run the following command.) 
    * Enter ```$ dotnet script``` in your terminal and a prompt will open: ```>```
    * To exit the REPL press: Ctrl +C

### Installation
* Clone the repository with the following git terminal command: ```$ git clone https://github.com/BrianSturgis/JanWeek8Project.Solution.git```
* Open the project directory in your terminal
* Navigate to the ```BakeryAdmin.Tests``` directory
    * To create ```obj``` directories in both production and test projects, run the terminal command: ```$ dotnet restore```
    * **NOTE**: Do not touch the code in either ```obj``` directory.
* To launch the program, run the terminal command: ```dotnet run```



## Run Tests
- Open Terminal, navigate into the "BakeryAdmin.Tests/" folder in the command line
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

test:Find_ReturnsCorrectOrder_Order()
expect: Assert.AreEqual(newOrder2, result);

```
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are greatly appreciated.

1. Fork the project on GirHub
    * Follow [Installation and Setup Requirements](#setup-and-installation-requirements) above
2. Create your Feature Branch: ```$ git checkout -b YourFeatureBranchName```
3. Commit your Changes ```$ git commit -m 'Feature name'```
4. Push to your feature branch on Github ```$ git push origin YourFeatureBranchName```
5. Open a Pull Request

## Technologies Used
* C#
* MSTest
* ASP.NET 5.0
* Razor


### License
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE..

Copyright (c) 2020 **Brian Micheal Sturgis**