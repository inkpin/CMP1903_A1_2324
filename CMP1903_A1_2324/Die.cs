using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{

    /// <summary>
    /// This class creates a random instance, creates a property of the roll and then assigns the rolls their values.
    /// </summary>

    internal class Die
    {
        private static Random random = new Random();

        public int LastRoll {  get; private set; }

        public int Roll()
        {
            LastRoll = random.Next(1,7);
            return LastRoll;
        }
    }
}
