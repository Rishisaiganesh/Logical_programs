﻿using System;

namespace Logical_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programs");
            Console.WriteLine("Press1: TO check Fibonacci");
            Console.WriteLine("Press2: To check the NUmber is PRIME or NOT");
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



            }
        }
    }
}
