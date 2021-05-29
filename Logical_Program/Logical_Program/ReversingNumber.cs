using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Program
{
    class ReversingNumber
    {
        public void reverse()
        {
            int Reverse = 0, Number, Remainder;
            Console.WriteLine("....Enter The NUmber....");
            Number = Convert.ToInt32(Console.ReadLine());
            while (Number !=0)
            {
               Remainder = Number % 10;
                Reverse = Reverse * 10 + Remainder;
                Number = 10;

            }
            Console.Write("ReversingNumber" + Reverse);

        }
    }
}
