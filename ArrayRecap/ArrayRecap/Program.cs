using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRecap
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 3

            int length = 100;
            Random rand = new Random();

            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                int temp = rand.Next(1, 101);
                while (numbers.Contains(temp))
                    temp = rand.Next(1, 101);

                numbers[i] = temp;
            }

            foreach (int x in numbers)
                Console.Write(x + ", ");
            Console.ReadKey();
        }
        
        
    }
}
