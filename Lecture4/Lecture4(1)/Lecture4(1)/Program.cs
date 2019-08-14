using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4_1_
{
    class Program
    {
        enum Days
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        static void Main(string[] args)
        {
            string[][] input = new string[4][]
                {
                 new string [] {"John and Mary have a discussion","1"},
                 new string [] {"John and Mary interview","3"},
                 new string [] {"F2F","4"},
                 new string [] {"General meeting","7"}
                };

            Console.Write("Do it with FOREACH \n");

            foreach (string[] row in input)
            {
                foreach (string st in row)
                {
                    string events = st;
                    if (events.Length > 10)
                    {
                        events = events.Substring(0, 10) + "...";
                    }
                    int date = int.Parse(st);
                    Days day = (Days)date;
                    Console.Write($"{events} on {day} \n".ToLower());
                }
                Console.WriteLine();
            }


            Console.Write("\n");


            // OR one FOR

            Console.Write("Do it with one FOR \n"); 

            for (int i = 0; i < input.GetLength(0); i++)
            {
                string events = input[i][0];

                if (events.Length > 10)
                {
                    events = events.Substring(0, 10) + "...";
                }

                int date = int.Parse(input[i][1]);
                Days day = (Days)date;

                Console.Write($"{events} on {day} \n".ToLower());
            }

            Console.Write("\n");

            // OR two FOR

            Console.Write("Do it with two FOR \n");

            for (int i = 0; i < input.Length; i++)
            { 
                for (int j = 0; j < input[i].Length-1; j++)
                {
                    string events = input[i][0];
                    if (events.Length > 10)
                    {
                        events = events.Substring(0, 10) + "...";
                    }
                    int date = int.Parse(input[i][1]);
                    Days day = (Days)date;
                    Console.Write($"{events} on {day} \n".ToLower());
                }
            }
            Console.Write("\n");


            Console.ReadKey();
        }
    }
}
