using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace CSharpFundamentalAssignment
{
    public class Doctor
    {
        private static int s_doctorID = 1000;

        public string DoctorID { get; } 
        public string Name { get; set; }
        public string Department { get; set; }

        public Doctor(string name, string department)
        {
            s_doctorID++;
            DoctorID = "DID" + s_doctorID;
            Name = name;
            Department = department;
        }
    }
}