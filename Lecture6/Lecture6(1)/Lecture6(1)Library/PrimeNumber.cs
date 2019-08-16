using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6_1_Library
{
    public class PrimeNumber
    {
        public static void PrimeNumbers()
        {
            Console.WriteLine("\nInput a number to find out if it is Prime Number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 0 || number == 1)
            {
                Console.WriteLine($"\n{number} is not prime number");
                Console.ReadLine();
            }
            else
            {
                for (int a = 2; a <= number / 2; a++)
                {
                    if (number % a == 0)
                    {
                        Console.WriteLine($"\n{number} is not prime number");
                        return;
                    }
                }
                Console.WriteLine($"\n{number} is a prime number");
            }
        }  
    }
}
