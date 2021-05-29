using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Program
{
    class PrimeNUmber
    {
        public void Check()
        {
            int Number, i, N;
            Console.WriteLine("Enter the number");
            Number = Convert.ToInt32(Console.ReadLine());
            N = Number / 2;
            for (i=2; i <= N; i++)
            {
                if (Number % i == 0)
                    Console.WriteLine("This NUmber is not a prime Number");
                else
                    Console.WriteLine("This Number is a Prime NUmber");

            }


        }
    }
}
