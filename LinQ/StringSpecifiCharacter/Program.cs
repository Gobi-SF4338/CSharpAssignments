using System;

namespace StringSpecifiCharacter;

class Program
{
    public static void Main(string[] args)
    {
        string[] city = {"ABU DHABI", "AMSTERDAM", "ROME", "MADURAI", "LONDON", "NEW DELHI", "MUMBAI", "NAIROBI"};

        System.Console.WriteLine("Enter the Starting character:");
        char start = char.Parse(Console.ReadLine().ToUpper());
        System.Console.WriteLine("Enter the Ending character:");
        char end = char.Parse(Console.ReadLine().ToUpper());

        System.Console.WriteLine("The city starting with {0} and ending with {1} is:",start,end);
        for(int i=0; i<city.Length;i++)
        {
            if((city[i].StartsWith(start)) && (city[i].EndsWith(end)))
            {
                System.Console.Write(city[i]+", ");
            }
        }
    }
}