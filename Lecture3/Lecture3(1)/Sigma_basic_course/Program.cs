﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigma_basic_course
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;

            Console.WriteLine("I wanna calculate something for you, please input the first digit");
            bool result = int.TryParse(Console.ReadLine(), out x);

            while ((!result) || (x > 10 || x < 0))
            {
                if (!result)
                {
                    Console.WriteLine("Sorry, I do not now how to multiply chars :(.");
                    result = inputDigit(out x);
                }

                else if (x > 10 || x < 0)
                {
                    Console.WriteLine("Sorry, I support only digits from 0 to 10 :( ");
                    result = inputDigit(out x);
                }

            }

            Console.WriteLine("Thank’s and another digit please!");
            result = int.TryParse(Console.ReadLine(), out y);

            while ((!result) || (y > 10 || y < 0))
            {
                if (!result)
                {
                    Console.WriteLine("Sorry, I do not now how to multiply chars :(.");
                    result = inputDigit(out y);
                }

                else if (y > 10 || y < 0)
                {
                    Console.WriteLine("Sorry, I support only digits from 0 to 10 :( ");
                    result = inputDigit(out y);
                }
            }

                int multiply = x * y;
                Console.WriteLine($"Here you are: {multiply}");
                Console.ReadKey();
           
                Console.ReadKey();
        }

        public static bool inputDigit(out int t)
        {
            Console.WriteLine("Try to input the first digit again:");
            return int.TryParse(Console.ReadLine(), out t);
        }
    }
}
