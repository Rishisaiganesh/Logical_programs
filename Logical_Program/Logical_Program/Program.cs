using System;

namespace Logical_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programs");
            Console.WriteLine("Press1: TO check Fibonacci");
            Console.WriteLine("Press2: To check the NUmber is PRIME or NOT");
            Console.WriteLine("Press3: to Reverse the number ");
            Console.WriteLine("Press4:To Check the number is Perfect");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Fibonacci fib = new Fibonacci();
                    fib.Check();
                    break;
                case 2:
                    PrimeNUmber prime = new PrimeNUmber();
                    prime.Check();
                    break;
                case 3:
                    ReversingNumber obj = new ReversingNumber();
                    obj.reverse();
                    break;
                case 4:
                    PerfectNumber per = new PerfectNumber();
                    per.perfect();
                    break;



            }
        }
    }
}
