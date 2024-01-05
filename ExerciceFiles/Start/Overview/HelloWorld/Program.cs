using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Whate is your name");
            string str = Console.ReadLine();
            Console.WriteLine("Hello, Welcome " + str + " !");
        }
    }
}
