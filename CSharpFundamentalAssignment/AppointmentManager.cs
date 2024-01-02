using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpFundamentalAssignment
{
    public class AppointmentManager
    {
        public static List<Doctor> DoctorsList { get; set; }
        public static List<Patient> PatientList { get; set; }
        public static List<Appointment> AppointmentsList { get; set; }

        public AppointmentManager()
        {
            DoctorsList = new List<Doctor>();
            PatientList = new List<Patient>();
            AppointmentsList = new List<Appointment>();
        }
    }
}