using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace CSharpFundamentalAssignment
{
    public class Operations
    {

        static Appointment currentAppoitment;
        static Patient currentPatient;
        public static void mainMenu()
        {
            bool mainMenuLoopBreaker = true;

            do
            {
                System.Console.WriteLine("*****MainMenu*****\na.Login\nb.Register\nc.Exit");

                System.Console.WriteLine("Enter the choice:");
                char choice = char.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 'a':
                        {
                            Login();
                            break;
                        }
                    case 'b':
                        {
                            Register();
                            break;
                        }
                    case 'c':
                        {
                            mainMenuLoopBreaker = false;
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine("Invalid Choice!");
                            break;
                        }
                }

            } while (mainMenuLoopBreaker);
        }

        public static void Register()
        {
            System.Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            System.Console.WriteLine("Enter the Name:");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter Age:");
            int age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your Gender:");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);

            Patient patient = new Patient(password, name, age, gender);

            AppointmentManager.PatientList.Add(patient);
        }

        public static void Login()
        {
            System.Console.WriteLine("Enter the Username:");
            string UserName = Console.ReadLine();
            System.Console.WriteLine("Enter the Password:");
            string password = Console.ReadLine();
            bool checkCredentials = true;

            foreach (Patient patient in AppointmentManager.PatientList)
            {
                if ((patient.Name == UserName) && (patient.Password == password))
                {
                    currentPatient = patient;
                    checkCredentials = false;
                    PatientMenu();
                }
            }
            if (checkCredentials)
            {
                System.Console.WriteLine("“Sorry, your record is invalid. Please register your profile and log in again.");
            }
        }

        public static void PatientMenu()
        {
            bool SubMenuLoopBreaker = true;
            do
            {
                System.Console.WriteLine("*****PatientMenu*****\n1.Book Appointment\n2.View Appoitment Details\n3.Edit my profile\n4.Exit");

                System.Console.WriteLine("Enter the choice:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            BookAppointment();
                            break;
                        }
                    case 2:
                        {
                            ViewAppoitmentDeatils();
                            break;
                        }
                    case 3:
                        {
                            EditMyProfile();
                            break;
                        }
                    case 4:
                        {
                            SubMenuLoopBreaker = false;
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine("Invalid Choice!");
                            break;
                        }
                }
            } while (SubMenuLoopBreaker);
        }

        public static void BookAppointment()
        {
            System.Console.WriteLine("Department List");
            foreach (Doctor doctor in AppointmentManager.DoctorsList)
            {
                System.Console.WriteLine(doctor.Department);
            }

            System.Console.WriteLine("Enter the Department which you want:");
            string department = Console.ReadLine();
            int count = 0;
            string press;

            foreach (Doctor doctor in AppointmentManager.DoctorsList)
            {
                if (department == doctor.Department)
                {
                    System.Console.WriteLine("Enter the Problem:");
                    string problem = Console.ReadLine();

                    foreach (Appointment app in AppointmentManager.AppointmentsList)
                    {
                        currentAppoitment = app;
                        if ((doctor.DoctorID == app.DoctorID) && (DateTime.Now == app.Date))
                        {
                            count++;
                        }
                    }
                    if (count >= 0 && count < 2)
                    {
                        System.Console.WriteLine($"Appointment is confirmed for the date {DateTime.Now.ToString("dd/MM/yyyy", null)}.");
                    }
                    System.Console.WriteLine("To book press “Y”, to cancel press “N”:");
                    press = Console.ReadLine();


                    if (press == "Y")
                    {
                        Appointment appointment = new Appointment(currentPatient.PatientID, doctor.DoctorID, DateTime.Now, problem);
                        AppointmentManager.AppointmentsList.Add(appointment);
                    }
                }
            }


        }

        public static void ViewAppoitmentDeatils()
        {
            foreach (Appointment appointment in AppointmentManager.AppointmentsList)
            {
                if (currentPatient.PatientID == appointment.PatientID)
                {
                    System.Console.WriteLine("AppointmentID:" + appointment.AppointmentID);
                    System.Console.WriteLine("PatientID:" + appointment.PatientID);
                    System.Console.WriteLine("DoctorID:" + appointment.DoctorID);
                    System.Console.WriteLine("Date:" + appointment.Date);
                    System.Console.WriteLine("Problem:" + appointment.Problem);
                    System.Console.WriteLine();
                }
            }
        }

        public static void EditMyProfile()
        {

            System.Console.WriteLine("Enter the Name:");
            currentPatient.Name = Console.ReadLine();
            System.Console.WriteLine("Enter the Password");
            currentPatient.Password = Console.ReadLine();
            System.Console.WriteLine("Enter the Age:");
            currentPatient.Age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Gender:");
            currentPatient.Gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            
        }

    public static void DefaultData()
    {
        Doctor doctor1 = new Doctor("Nancy", "Anaesthesiology");
        Doctor doctor2 = new Doctor("Andrew", "Cardiology");
        Doctor doctor3 = new Doctor("Janet", "Diabetology");
        Doctor doctor4 = new Doctor("Margaret", "Neonatology");
        Doctor doctor5 = new Doctor("Steven", "Nephrology");

        Patient patient1 = new Patient("welcome", "Robert", 40, Gender.Male);
        Patient patient2 = new Patient("welcome", "Laura", 36, Gender.Female);
        Patient patient3 = new Patient("welcome", "Anne", 42, Gender.Female);

        Appointment appointment1 = new Appointment("PID1001", "DID1002", new DateTime(2012, 08, 03), "Heart Problem");
        Appointment appointment2 = new Appointment("PID1001", "DID1005", new DateTime(2012, 08, 03), "Spinal cord injury");
        Appointment appointment3 = new Appointment("PID1002", "DID1002", new DateTime(2012, 08, 03), "Heart attack");

        AppointmentManager appointmentManager = new AppointmentManager();

        AppointmentManager.DoctorsList.Add(doctor1);
        AppointmentManager.DoctorsList.Add(doctor2);
        AppointmentManager.DoctorsList.Add(doctor3);
        AppointmentManager.DoctorsList.Add(doctor4);
        AppointmentManager.DoctorsList.Add(doctor5);

        AppointmentManager.PatientList.Add(patient1);
        AppointmentManager.PatientList.Add(patient2);
        AppointmentManager.PatientList.Add(patient3);

        AppointmentManager.AppointmentsList.Add(appointment1);
        AppointmentManager.AppointmentsList.Add(appointment2);
        AppointmentManager.AppointmentsList.Add(appointment3);

    }
}
}