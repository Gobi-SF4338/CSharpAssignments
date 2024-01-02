using System;

namespace OperatorsAssignments;

    public class Program
    {
        public static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            int add  = number1+number2;
            Console.WriteLine("Addition: "+add);

            int sub  = number1-number2;
            Console.WriteLine("Subbraction: "+sub);

            double div  = number1/number2;
            Console.WriteLine("Division: "+div);

            int multi  = number1*number2;
            Console.WriteLine("Multiplication: "+multi);

            int mod = number1%number2;
            Console.WriteLine("Modulus: "+mod);
        }
    } 