using System;

namespace Debugging
{
    class Program
    {
        static int x = 0;
        static int y = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Debugging!");

            x = 2;
            y = 2;
            Console.WriteLine("Inside Main");

            ChangeValues();

            x = 10;
            y = 20;
            Console.WriteLine("Inside Main Again");
        }

        public static void ChangeValues()
        {
            x = 4;
            y = 5;
            Console.WriteLine("Inside Change Values");
        }
    }
}
