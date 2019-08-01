using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int maths = 65;
            int physics = 55;
            int chemistry = 50;

            Console.WriteLine("Please input the marks for physics");
            int marksPhysics = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input the marks for chemistry");
            int marksChemistry = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input the marks for maths");
            int marksMaths = Convert.ToInt32(Console.ReadLine());

            if ((marksMaths >= 65 && marksPhysics >= 55 && marksChemistry >= 50) && ((marksMaths + marksPhysics + marksChemistry) >= 180))
            {
                Console.WriteLine("Student is admitted");
            }
            else if ((marksMaths >= 65 && marksPhysics >= 55 && marksChemistry >= 50) && ((marksMaths + marksPhysics) >= 140 || (marksMaths + marksChemistry) >= 140))
            {
                Console.WriteLine("Student is admitted");
            }
            else
            {
                Console.WriteLine("You should stop watching series and start to learning :)");
            }

            Console.ReadKey();
        }
    }
}


