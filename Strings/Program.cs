
using System;
using System.Linq;

namespace Strings;

    class Program
    {
        public static void Main(string[] args)
        {
            string word = Console.ReadLine();

            for(int i=0;i<word.Length;i++)
            {
                if(i%2!=0)
                {
                    Console.Write(word[i]);
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine();
            Console.WriteLine(word.Replace('n','N'));

            char[] array = word.ToCharArray();
            Array.Reverse(array);
            Console.WriteLine(new string(array));
            
            
            Console.WriteLine(word.Length);


            string string1 = Console.ReadLine();
            string string2 = Console.ReadLine();

            string string3 = string1.Substring(0,3) + string2.Substring(string2.Length-3);
            Console.WriteLine(string3);

            string letter = Console.ReadLine();

            string[] string4 = letter.Split(",");

            foreach(string letters in string4)
            {
                Console.WriteLine(letters);
            }
        }
    }

