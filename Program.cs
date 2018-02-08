using System;
using System.Collections.Generic;


namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Three Basic Arrays
            //     Create an array to hold integer values 0 through 9
            //     Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            //     Create an array of length 10 that alternates between true and false values, starting with true
            int[] integerArray;
            integerArray = new int[] {0,1,2,3,4,5,6,7,8,9};
            
            string[] names = new string[4] {"Tim", "Martin", "Nikki", "Sara"};

            Boolean[] booleanArray = new Boolean[10] {true, false, true, false, true, false, true, false, true, false};
            
            int[,,] multiplicationTable = new int[10,1,10];
            for(var i = 1; i <= 10; i++)
            {
                for(var j = 1; j <= 10; j++)
                {
                    multiplicationTable[i-1,0,j-1] = i * j;
                }
            }


            // for(var i = 0; i < 10; i++)
            // {
            //     for(var j = 0; j < 10; j++)
            //     {
            //         Console.WriteLine(multiplicationTable[i,0,j]);
            //     }
            // }

            // Console.WriteLine(multiplicationTable[9,0,4]);

            List<string> flavors = new List<string>();
            flavors.Add("vanilla");
            flavors.Add("chocolate");
            flavors.Add("strawberry");
            flavors.Add("rocky road");
            flavors.Add("chocolate chip mint");
            flavors.Add("Americone Dream");
            flavors.Add("carmel swirl");

            Console.WriteLine("There are {0} flavors of ice cream", flavors.Count);

            Console.WriteLine("The third flavor is {0}", flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine("There are now {0} flavors of ice cream", flavors.Count);

            Dictionary<string,string> favorites = new Dictionary<string,string>();

            Random rand = new Random();
            foreach(var name in names)
            {
                favorites.Add(name, flavors[rand.Next(0,flavors.Count)]);
            }

            foreach (KeyValuePair<string,string> entry in favorites)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }

            // Random rand = new Random();

            // foreach (KeyValuePair<string,string> person in favorites)
            // {
            //     person.Key = flavors[rand.Next(0,flavors.Count)];
            // }

            // foreach (var entry in favorites)
            // {
            //     Console.WriteLine(entry.Key + " - " + entry.Value);
            // }

            // foreach (KeyValuePair<string,string> entry in favorites)
            // {
            //     Console.WriteLine(entry.Key + " - " + entry.Value);
            // }

        }
    }
}
