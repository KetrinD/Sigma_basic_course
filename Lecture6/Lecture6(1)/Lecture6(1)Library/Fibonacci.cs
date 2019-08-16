using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6_1_Library
{
    public class Fibonacci
    {
        // f(n) = f(n-1) + f(n-2)
        // 1, 1, 2, 3, 5, 8, 13, 21, ...
        //F(0) = 0
        //F(1) = 1

        public static int FibonacciFunc(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            else
                return FibonacciFunc(n - 1) + FibonacciFunc(n - 2);
        }

        public static void GetFibonacciFunc()
        {
            Console.Write("Function : To display the n number Fibonacci series :\n");
            Console.Write("Input number of Fibonacci Series : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe Fibonacci series of " + n + " numbers is :\n");

            for (int i = 0; i < n; i++)
            {
                Console.Write(FibonacciFunc(i) + "  ");
            }
            Console.WriteLine();
        }
    }
}
