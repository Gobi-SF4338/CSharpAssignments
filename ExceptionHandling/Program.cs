using System;

namespace ExceptionHandling;

class Program
{
    public static void Main(string[] args)
    {
            System.Console.WriteLine("Enter number1:");
            int number1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter number2:");
            int number2 = int.Parse(Console.ReadLine());
            
            try
            {
                double divisionResult = number1/number2;
                System.Console.WriteLine("result:" + divisionResult);
            }
            catch(Exception exe)
            {
                System.Console.WriteLine(exe.Message);
            }
    }
}