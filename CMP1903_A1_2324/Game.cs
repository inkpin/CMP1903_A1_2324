using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{

    /// <summary>
    /// Initial declaration of the class, as well as declaring variables that are needed such as a result and sum integers as well as the array for dice objects.
    /// A list is also created to log all of the dice results so that it can be compared against within the testing class.
    /// A public property is also declared allowing other classess to access the result.
    /// </summary>

    public class Game
    {
        private Die[] dice;
        public int sum = 0;
        int result = 0;
        public List<int> DiceResultLog { get; private set; }

        public int Result
        {
            get { return result; }
            set { result = value; }
        }

        /// <summary>
        /// This constructor will initialize an array with 3 dice rolls, initialize a list to store the dice results and then
        /// create a new dice object 3 times.
        /// </summary>
        public Game()
        {
            dice = new Die[3];
            DiceResultLog = new List<int>();
            for (int i = 0; i < dice.Length; i++) 
            {
                dice[i] = new Die();
            }
        }

        /// <summary>
        /// This method will roll the dice. It starts by error checking and ensuring that there are dice to be rolled. Once it enters the loop,
        /// the program ensures that the dice array is not null. It then rolls the dice and adds the result of the roll to the result variable. 
        /// The result is added to the sum and the output is displayed. The method ends by outputting the sum of all of the rolls.
        /// </summary>

        public void RollDice()
        {
            if (dice == null || dice.Length == 0)
            {
                Console.WriteLine("Error, no dice.");
                return;
            } 

            for (int i = 0; i < dice.Length; i++)
            {
                if (dice[i] == null) 
                {
                    Console.WriteLine($"Dice {i + 1} is null.");
                    continue;
                }
                result = dice[i].Roll();
                DiceResultLog.Add(result);
                sum += result;
                Console.WriteLine($"The value of {i + 1} = {result}");
            }
            Console.WriteLine($"\nThe sum of all rolls = {sum}");
        }

        /// <summary>
        /// This is essentially the same as the previous constructor, it allows the user to re roll the dice, the same error checking methods are present to ensure
        /// the user does not face any issues whilst using the program.
        /// </summary>

        public void reRollResult()
        {
            if (dice == null || dice.Length == 0)
            {
                Console.WriteLine("Error, no dice.");
                return;
            }

            for (int i = 0; i < dice.Length; i++)
            {
                if (dice[i] == null)
                {
                    Console.WriteLine($"Dice {i + 1} is null.");
                    continue;
                }
                var ReRoll = dice[i].Roll();
                sum += ReRoll;
                Console.WriteLine($"The value of {i + 1} = {ReRoll}");
            }
            Console.WriteLine($"\nThe new sum of all rolls = {sum}");
        }

    }
}
