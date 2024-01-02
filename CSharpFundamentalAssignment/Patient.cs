using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpFundamentalAssignment
{
    public enum Gender{Male,Female}
    public class Patient
    {
        private static int s_patientID = 1000;

        public string PatientID { get; } 
        public string Password { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }

        public Patient(string password, string name, int age, Gender gender)
        {
            s_patientID++;
            PatientID = "PID" + s_patientID;
            Password = password;
            Name = name;
            Age = age;
            Gender = gender;
        }

        public Patient(string patientID, string password, string name, int age, Gender gender)
        {
            PatientID = patientID;
            Password = password;
            Name = name;
            Age = age;
            Gender = gender;
        }
    }
}