using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Display the pattern like right angle triangle which repeat a number in a row:\n");

            Console.Write("Input number of rows : ");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i}");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
       
