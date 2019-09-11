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

            int length = 100;
            Random rand = new Random();

            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                numbers[i] = rand.Next(1, 101);
            }

            foreach (int x in numbers)
                Console.Write(x + ", ");
            Console.ReadKey();
        }
    }
}
