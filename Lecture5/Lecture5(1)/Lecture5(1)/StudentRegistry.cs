using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_1_
{
    public static class StudentRegistry
    {

        static List<Student> registry = new List<Student>();

        static StudentRegistry()
        {

        }

        public static void AddStudent(Student student)
        {
            registry.Add(student);
        }

        public static void RemoveStudent(Student student)
        {
            registry.Remove(student);
        }

        public static string GetAllInfo()
        {
            string allInfo = string.Empty;
            int counter = 1;

            foreach (Student student in registry)
            {
                allInfo += counter.ToString() + "." + student.GetStudentInfo() + "\n";
                counter++;
            }
            return allInfo;
        }
    }
}

        
 
