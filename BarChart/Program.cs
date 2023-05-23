// Jay Bai
// Cs2Apps
// TINFO-200

////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date             Developer       Description of change
// 2022-02-11       Jay             Created new file
// 2022-02-12       Jay             Add the main method
// 2022-02-12       Jay             Write description of each methods
// 2022-02-12       Jay             Check the codes and run the program
// 2022-02-12       Jay             Debug and changed some of the code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarChart
{
    class Program
    {
        // Main method
        static void Main(string[] args)
        {
            const int INPUT = 3;
            const string STAR = "*";
            int number;
            List<int> numbers = new List<int>();

            // Input and integral numeric method
            for (int i = 0; i < INPUT; i++)
            {
                Console.WriteLine("Please enter an integer between 1 and 30:");
                number = Convert.ToInt32(Console.ReadLine());
                numbers.Add(number);
            }

            // Method for change of numeric value
            for (int i = 0; i < numbers.Count; i++)
            {
                number = numbers.ElementAt(i);
                while (number > 0)
                {
                    Console.Write(STAR);
                    number--;
                }
                Console.WriteLine();
            }

            // End
            Console.ReadLine();
        }
    }
}
