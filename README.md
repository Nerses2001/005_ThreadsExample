# 005_ThreadsExample

This project provides an example of using threads in C#.

### Code Description

```csharp
using _005_ThreadsExample;

var thread = new Thread(BackGround.Function);

thread.IsBackground = false;

thread.Start();
Thread.Sleep(500);

Console.WriteLine("\n Primary thread finished");
```
This code creates a new thread and starts the BackGround.Function method in this thread. The thread.IsBackground parameter is set to false, which means this thread is not a background thread. If the parameter is set to true, when the main program thread closes, the background thread will be automatically terminated.