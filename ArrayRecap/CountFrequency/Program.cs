using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 2
            int length = 10;
            Random rand = new Random();

            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                numbers[i] = rand.Next(1, 11);
            }

            foreach (int x in numbers)
                Console.Write(x + ", ");

            // Finding frequency
            var dict = new Dictionary<int, int>();
            foreach (int x in numbers)
            {
                if (!dict.ContainsKey(x))
                {
                    dict.Add(x, 0);
                }
                dict[x]++;
            }

            Console.WriteLine("\n");
            foreach (var kvp in dict)
            {
                if (kvp.Value > 1)
                    Console.WriteLine("{0} repeats {1} times", kvp.Key, kvp.Value);
            }

            Console.ReadKey();
        }
    }
}
