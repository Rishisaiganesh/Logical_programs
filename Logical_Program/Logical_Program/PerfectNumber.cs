using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Program
{
    class PerfectNumber
    {
        public int sum = 0;
        public void perfect()
        {
            Console.WriteLine("enter the number to check its perfect:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i<num; i++)
            {
                if (num % i == 0)
                    sum = sum + i;
            }
            if (sum == num)
                Console.WriteLine("Number is perfect:" + num);
            else
                Console.WriteLine("Number is not perfect:" + num);
        }
    }
}
