using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_1_
{
    public class Student
    {
        public string StudentFirstName { get; set; }
        public string StudentLastName { get; set; }
        public string EntryDate { get; set; }

        public StudentAddress studentAddress;
        
        public Student()
        {
        }

        public Student(string name, string surename, string date, StudentAddress address)
        {
            StudentFirstName = name;
            StudentLastName = surename;
            EntryDate = date;
            studentAddress = address;
        }

        public string  GetStudentInfo()
        {
            return $"{StudentFirstName}, {StudentLastName}, {EntryDate}, {studentAddress.GetStudentAddress()}";
        }
    }
}
