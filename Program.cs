using _005_ThreadsExample;

var thread = new Thread(BackGround.Function);

thread.IsBackground = false;

thread.Start();
Thread.Sleep(500);

Console.WriteLine("\n Primary finished");