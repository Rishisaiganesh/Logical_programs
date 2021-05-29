using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Program
{
    class Fibonacci
    {
        public void Check()
        {
            int FirstNumber = 0, SecondNumber = 1, ThirdNumber, i, Number;
            Console.WriteLine("Enter the Number of elements");
            Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FirstNumber + "" + "" + SecondNumber);
            for(i=2; i<= Number; i++)
            {
                ThirdNumber = FirstNumber + SecondNumber;
                Console.WriteLine(ThirdNumber + "");
                FirstNumber = SecondNumber;
                SecondNumber = ThirdNumber;

            }
        }
    }
}
