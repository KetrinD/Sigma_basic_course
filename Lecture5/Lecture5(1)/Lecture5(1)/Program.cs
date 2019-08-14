using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Input student firstname");
                string firstName = Console.ReadLine();

                Console.WriteLine("Input student surename");
                string lastName = Console.ReadLine();

                Console.WriteLine("Input student's entry date");
                string date = Console.ReadLine();

                Console.WriteLine("Input student's Country");
                string country = Console.ReadLine();

                Console.WriteLine("Input student's City");
                string city = Console.ReadLine();

                Console.WriteLine("Input student's address");
                string address = Console.ReadLine();

                StudentAddress studentAddress_1 = new StudentAddress(country, city, address);
                Student student = new Student(firstName, lastName, date, studentAddress_1);
                StudentRegistry.AddStudent(student);
            }

            Console.WriteLine(StudentRegistry.GetAllInfo());
        }
    }
}
