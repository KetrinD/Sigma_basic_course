using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_1_
{
    public class StudentAddress
    {
        public string StudentCountry { get; set; }
        public string StudentCity { get; set; }
        public string StudetnAddress { get; set; }

        public StudentAddress()
        {
        }
        public StudentAddress(string country, string city, string address)
        {
            StudentCountry = country;
            StudentCity = city;
            StudetnAddress = address;
        }
        public string GetStudentAddress()
        {
            return "StudentAddress: " + StudentCountry + " " + StudentCity + " " + StudetnAddress;
        }

    }

}
