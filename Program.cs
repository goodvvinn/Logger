using System;

namespace Logger
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Starter starter = new Starter();
            starter.Run();
            Console.ReadLine();
        }
    }
}
