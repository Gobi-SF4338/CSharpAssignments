using System;

namespace ForLoop;

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] number = new int[10];
            int sum = 0;

            for(int i=0;i<number.Length;i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }

            for(int i=0;i<number.Length;i++)
            {
                sum += number[i]; 
            }

            double avg = sum/10;

            Console.WriteLine("The sum of 10 number is: "+sum);
            Console.WriteLine("The average is: "+avg);


        }
    }
