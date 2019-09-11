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
            Console.WriteLine("Generates a random unique number between 1.9 and 2.0!\n");

            int length = 10;
            Random rand = new Random();
            
            double[] numbers = new double[length];
            for (int i = 0; i < length; i++)
            {
                // .NextDouble() returns a double >= 0.0 and less than 1.0
                // Defining range for doubles: NextDouble() * (maxNum - minNum) + minNum

                double temp = rand.NextDouble() * (2.0 - 1.9) + 1.9;
                while (numbers.Contains(temp))
                    temp = rand.NextDouble() * (2.0 - 1.9) + 1.9;

                numbers[i] = temp;
            }

            foreach (double x in numbers)
                Console.WriteLine(x);
            Console.ReadKey();
        }
        
        
    }
}
