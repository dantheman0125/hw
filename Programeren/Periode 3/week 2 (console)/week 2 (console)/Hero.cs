using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    /// <summary>
    /// De class Hero die erft van Person en gebruik maakt van de Interface: IHasStrengths
    /// </summary>
    class Hero :Person,IHasStrengths
    {
        private Villain archnemesis;
        private List<string> strengths;
        private Person sidekick;

        /// <summary>
        /// De 1e constructor
        /// Als er 3 parameters worden ingevoerd, wordt er gebruik gemaakt van de constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="nemisis"></param>
        /// <param name="Evilness"></param>
        public Hero(string name, Villain nemisis, int Evilness)
        {
            this.name = name;
            archnemesis = nemisis;
            if (Evilness >= 0 && Evilness <= 100)
            {
                this.Evilness = Evilness;
            }
            else
            {
                Random random = new Random();
                this.Evilness = random.Next(0, 101);
            }
            strengths = new List<string>();
        }
        /// <summary>
        /// De 2e Constructor
        /// Als er 4 parameters worden ingevoerd, wordt er gebruik gemaakt van de constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="nemisis"></param>
        /// <param name="sidekick"></param>
        /// <param name="Evilness"></param>
        public Hero(string name, Villain nemisis, Person sidekick, int Evilness)
        {
            this.name = name;
            archnemesis = nemisis;
            if (Evilness >= 0 && Evilness <= 100)
            {
                this.Evilness = Evilness;
            }
            else
            {
                this.Evilness = 50;
            }
            this.sidekick = sidekick;
            strengths = new List<string>();
        }

        /// <summary>
        /// Voor het weergeven van zijn aartsvijand.
        /// </summary>
        /// <returns>de aartsvijand</returns>
        public Villain GetArchnemesis()
        {
            return archnemesis;
        }

        /// <summary>
        /// voor het toegevoegen van een kracht aan een Hero.
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

        /// <summary>
        /// Voor het aanpassen van een hulpje.
        /// </summary>
        /// <param name="sidekick"></param>
        public void UpdateSidekick(Person sidekick)
        {
            this.sidekick = sidekick;
        }

        /// <summary>
        /// voor het weergegeven van de minion (niet de naam, maar de class)
        /// om alle minions te zien gebruik een for each loop.
        /// </summary>
        /// <returns>de sidekick</returns>
        public Person GetSidekick()
        {
            return sidekick;
        }
    }
}