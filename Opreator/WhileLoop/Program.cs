using System;

namespace WhileLoop;

    class Program
    {
        public static void Main(string[] args)
        {
            char var = 'Y';
            int option;

            while(var =='Y')
            {
                Console.WriteLine("Which is capital of india?");

                Console.WriteLine("1.Chennai");
                Console.WriteLine("2.Delhi");
                Console.WriteLine("3.Mumbai");
                Console.WriteLine("4.Kolkata");


                option  = int.Parse(Console.ReadLine());

                if(option==2)
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Incorrect!");
                }

                Console.WriteLine("Press Y to continue, Press N to close");
                var = char.Parse(Console.ReadLine());
            }

        }
    }