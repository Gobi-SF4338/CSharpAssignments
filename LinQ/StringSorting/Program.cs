using System;

namespace StringSorting;

class Program
{
    public static void Main(string[] args)
    {
        string[] city = {"ABU DHABI", "AMSTERDAM", "ROME", "PARIS", "CALIFORNIA", "LONDON", "NEW DELHI", "ZURICH", "NAIROBI"};

        for(int i=0;i<city.Length;i++)
        {
            string temp;
            if(city[i].Length<city[i+1].Length)
            {
                temp = city[i];
                city[i] = city[i+1];
                city[i+1] = temp;
            }
        }

        for(int i=0; i<city.Length;i++)
        {
            
        }
    }
}
