namespace _005_ThreadsExample
{
    internal class BackGround
    {
        public static void Function()
        {
            for (int i = 0; i < 500; ++i)
            {
                Thread.Sleep(10);
                Console.Write(".");
            }
            Console.WriteLine("\nSecondery Finished");
        }
        

    }
}
