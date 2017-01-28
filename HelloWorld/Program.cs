using System;

namespace HelloWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Hello, " + name + "!");
        }
    }
}