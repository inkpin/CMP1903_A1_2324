using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Creating instances of the game and testing class, aswell as an exit variable for exiting a loop
            Game diceGame = new Game();
            Testing debug = new Testing();
            bool exit = false;

            //Rolling the dice and then outputting the results
            Console.WriteLine("Welcome to the dice game!\n3 Dice will be rolled and the result will be shown below.\n");
            diceGame.RollDice();
            debug.Debugging(diceGame);

            //Offering the user a chance to reroll the dice
            Console.WriteLine("\nWould you like a reroll? Press any key for yes, or 'q' to exit.");
            while (!exit)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                
                if (key.KeyChar == 'q') //Checks input. Guard clause not needed as any key can be pressed for a reroll
                {
                    exit = true;
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    diceGame.ReRoll();
                    Console.WriteLine("\nWould you like a reroll? Press any key for yes, or 'q' to exit.");
                }
            }
        }
    }
}
