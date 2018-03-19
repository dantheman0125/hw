using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    /// <summary>
    /// De class Villain die erft van Person en gebruik maakt van de Interface: IHasStrengths
    /// </summary>
    class Villain : Person, IHasStrengths
    {
        private List<Minion> minions;
        private List<string> strengths;

        /// <summary>
        /// De constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="Evilness"></param>
        public Villain (string name, int Evilness)
        {
            this.name = name;
            if (Evilness >= 0 && Evilness <= 100)
            {
                this.Evilness = Evilness;
            }
            else
            {
                this.Evilness = 50;
            }
            minions = new List<Minion>();
            strengths = new List<string>();
        }

        /// <summary>
        /// voor het toegevoegen van een minion aan een villain.
        /// </summary>
        /// <param name="minion"></param>
        public void AddMinion(Minion minion)
        {
            minions.Add(minion);
        }

        /// <summary>
        /// voor het weergegeven van de minion (niet de naam, maar de class)
        /// om alle minions te zien gebruik een for each loop.
        /// </summary>
        /// <returns>de class minion</returns>
        public List<Minion> GetMinions()
        {
            return minions;
        }

        /// <summary>
        /// voor het toegevoegen van een kracht aan een villain.
        /// </summary>
        /// <param name="strength"></param>
        public void AddStrength(string strength)
        {
            strengths.Add(strength);
        }

        /// <summary>
        /// voor het weergeven van de kracht.
        /// om alle sterktes te zien gebruik een for each loop
        /// </summary>
        /// <returns>laat de kracht zien</returns>
        public List<string> GetStrengths()
        {
            return strengths;
        }
    }
}