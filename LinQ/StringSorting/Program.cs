using System;

namespace StringSorting;

class Program
{
    public static void Main(string[] args)
    {
        string[] city = {"ABU DHABI", "AMSTERDAM", "ROME", "PARIS", "CALIFORNIA", "LONDON", "NEW DELHI", "ZURICH", "NAIROBI"};

        for(int i=0;i<city.Length;i++)
        {
            for(int j =0; j<city.Length;j++)
            {
                string temp;
                string first = city[i];
                string second = city[j];

                if((city[i].Length < city[j].Length) || (((city[i].Length) == (city[j].Length)) && (first[0]<second[0])))
                {
                    temp = city[i];
                    city[i] = city[j];
                    city[j] = temp;
                }
            }
            
        }

        for(int i=0; i<city.Length;i++)
        {
            Console.WriteLine(city[i]);
        }
    }
}
