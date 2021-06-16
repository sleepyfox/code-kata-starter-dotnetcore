# DotNetCore 5 code kata starter repo

This repo contains nothing but a trivial failing test.

We assume that you have .NET core installed.

To check your environment is set up and works run the following commands from the console:

> `dotnet test`

You should see output similar to the following:

```bash
$ dotnet test
Test run for C:\Users\...\Code\code-kata-starter-dotnetcore\bin\Debug\netcoreapp3.1\code-kata-starter-dotnetcore.dll(.NETCoreApp,Version=v3.1)
Microsoft (R) Test Execution Command Line Tool Version 16.7.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...

A total of 1 test files matched the specified pattern.
[xUnit.net 00:00:00.37]     code_kata_starter_dotnetcore.UnitTest1.FailingTest [FAIL]
  X code_kata_starter_dotnetcore.UnitTest1.FailingTest [6ms]
  Error Message:
   Assert.Equal() Failure
Expected: 42
Actual:   54
  Stack Trace:
     at code_kata_starter_dotnetcore.UnitTest1.FailingTest() in C:\Users\...\Documents\VS Code\code-kata-starter-dotnetcore\UnitTest1.cs:line 11

Test Run Failed.
Total tests: 1
     Failed: 1
 Total time: 0.8747 Seconds
```

This means you are all ready for your code kata, enjoy!
