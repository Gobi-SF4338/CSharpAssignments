using System;

namespace DateTimeFunction;

    class Program
    {
        public static void Main(string[] args)
        {
            var date = DateTime.Today;

            Console.WriteLine(date.ToString("MMMM"));

            Console.WriteLine(date.AddDays(-3).ToString("d"));

            Console.WriteLine(DateTime.Now.ToString("hh:mm tt"));
        }
    }