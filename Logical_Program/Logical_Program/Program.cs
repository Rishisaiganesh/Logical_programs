using System;

namespace Logical_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programs");
            Console.WriteLine("Press1: TO check Fibonacci");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Fibonacci fib = new Fibonacci();
                    fib.Check();
                    break;


            }
        }
    }
}
