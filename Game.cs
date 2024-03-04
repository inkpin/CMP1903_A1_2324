using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    public class Game
    {
        private Die[] dice; //The array of dice objects
        public int sum = 0; //V ariable to store the sum of all rolls
        int result = 0; //To store the result of individual rolls
        public List<int> DiceResultLog { get; private set; }

        public int Result //Public property allowing other classess to access the result
        {
            get { return result; }
            set { result = value; }
        }

        public Game() //Dice constructor
        {
            dice = new Die[3]; //Initialize the array with 3 dice rolls
            DiceResultLog = new List<int>(); //Initialize list to store the dice results
            for (int i = 0; i < dice.Length; i++) 
            {
                dice[i] = new Die(); //Create new dice object 3 times
            }
        }

        public void RollDice() //Method to roll the dice
        {
            for (int i = 0; i < dice.Length; i++)
            {
                result = dice[i].Roll(); //Rolling the dice
                DiceResultLog.Add(result); //Adding the result of the dice roll to the result variable
                sum += result; //Adding the result variable value to the sum variable
                Console.WriteLine($"The value of {i + 1} = {result}"); //Output
            }
            Console.WriteLine($"\nThe sum of all rolls = {sum}");
        }
        
        public void ReRoll() //Method allowing the user to reroll the dice
        {
            var ReRollResult = dice[1].Roll(); //Reroll the second dice
            sum += ReRollResult; //Updating the total sum
            Console.WriteLine($"\nThe result of the reroll is: {ReRollResult}");
            Console.WriteLine($"The new sum of all rolls = {sum}");
        }
    }
}
