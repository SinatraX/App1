// Jay Bai
// Cs2Apps
// TINFO-200

////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date             Developer       Description of change
// 2022-02-12       Jay             Create file
// 2022-02-12       Jay             Add main string methods
// 2022-02-12       Jay             Add description of each part of the program
// 2022-02-13       Jay             Check the code and test run
// 2022-02-13       Jay             Fix the problem and run the program again
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITeacher
{
    class Program
    {
        // Generating random number
        private static Random random = new Random();
        // Multiply result
        private static int multiplyResult;
        // Repeat the same question if the answer is wrong
        private static string askQuestion;
        // Method to ask user a multiply question with two random numbers
        private static void askANewQuestion()
        {
            // Random number A and B
            int randomNumberA = Randomnumber(0, 9);
            int randomNumberB = Randomnumber(0, 9);
            // Multiply method
            multiplyResult = randomNumberA * randomNumberB;
            askQuestion = "How much is " + randomNumberA + " times " + randomNumberB + "?";
        }

        // Method for random number min/max
        public static int Randomnumber(int min, int max)
        {
            return random.Next(min, max);
        }

        // Method to a new question
        static void Main(string[] args)
        {
            bool newque = true;
            while (newque)
            {
                newque = newQuestion();
            }
        }

        // New question
        private static bool newQuestion()
        {
            askANewQuestion();
            bool correctAns = false;
            int userInput;

            // Do, while, try, if, else solution and display loops
            while (!correctAns)
            {
                Console.WriteLine(askQuestion);
                // Code to return string value
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput < 0)
                {
                    return false;
                }
                else if (userInput == multiplyResult)
                {
                    Console.WriteLine("Very good!");
                    correctAns = true;
                }
                else if (userInput != multiplyResult)
                {
                    Console.WriteLine("No. Please try again.");
                }
            }
            return true;
        }
    }
}
