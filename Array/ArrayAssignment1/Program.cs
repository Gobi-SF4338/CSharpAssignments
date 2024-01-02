using System;

namespace ArrayAssignment1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] number = new int[5];

            for(int i=0;i<number.Length;i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }

            for(int i=0;i<number.Length;i++)
            {
                for (int j = i + 1; j < number.Length; j++)
                {
                    if (number[i] > number[j])
                    {
                        int temp = number[i];
                        number[i] = number[j];
                        number[j] = temp;
                    }
                }
            }

            for(int i=0;i<number.Length;i++)
            {
               Console.Write(number[i]+" ");
            }
        }
    }
    
}