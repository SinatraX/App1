// Cs2Apps
// TINFO-200

////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date             Developer       Description of change
// 2022-02-12       Jay             First file creation
// 2022-02-12       Jay             Add main string methods
// 2022-02-12       Jay             Add description of each part of the program
// 2022-02-12       Jay             Debug and run the program 
// 2022-02-13       Jay             Test program and fixed while loop
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        public static int SelectedNumber = 0;
        public static Random rand = new Random();
        public static bool GameOver = false;

        // Main method 
        static void Main(string[] args)
        {
            // do/while loop
            SelectedNumber = rand.Next(1, 1001);
            int userNumber = 0;

            do
            {
                Console.WriteLine("Guess a number between 1 and 1000");
                userNumber = Convert.ToInt32(Console.ReadLine());
                GuessNumber(userNumber);
            }
            while (GameOver == false);

            Console.ReadLine();
        }

        // Output Console and loop for while, if, else 
        public static void GuessNumber(int userNumber)
        {
            int playAgain = 0;

            if (userNumber < SelectedNumber)
                Console.WriteLine("Too low. Try again.");
            else if (userNumber > SelectedNumber)
                Console.WriteLine("Too high. Try again.");
            else
            {
                Console.WriteLine("Congratulations. You guessed the number!");

                while (playAgain != 1 && playAgain != 2)
                {
                    Console.WriteLine("Press 1 to play again, 2 to quit this game");
                    playAgain = Convert.ToInt32(Console.ReadLine());
                }

                // End input method
                if (playAgain.Equals(2))
                    GameOver = true;
                else
                    SelectedNumber = rand.Next(1, 1001);
            }
        }
    }
}
