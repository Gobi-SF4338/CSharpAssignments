using System;
using System.Runtime.Intrinsics.Arm;

namespace Switch;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Number1:");
        double number1 = double.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Number2:");
        double number2 = double.Parse(Console.ReadLine());

        System.Console.WriteLine("****MENU****\n1.Addition\n2.Subraction\n3.Multipication\n4.Division");

        System.Console.WriteLine("Enter the Choice:");
        int choice = int.Parse(Console.ReadLine());

        switch(choice)
        {
            case 1:
            {
                double result = number1 + number2;
                System.Console.WriteLine("Addition:" + result);
                break;
            }
            case 2:
            {
                double result = number1 - number2;
                System.Console.WriteLine("Addition:" + result);
                break;
            }
            case 3:
            {
                double result = number1 * number2;
                System.Console.WriteLine("Addition:" + result);
                break;
            }
            case 4:
            {
                double result = number1 / number2;
                System.Console.WriteLine("Addition:" + result);
                break;
            }
            default:
            {
                System.Console.WriteLine("Invaloid choice");
                break;
            }
        }
    }
}