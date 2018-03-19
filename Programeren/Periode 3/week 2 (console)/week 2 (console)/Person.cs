using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    /// <summary>
    /// De mother class: Person
    /// </summary>
    public abstract class Person
    {
        private List<Minion> minions;
        //private Villain villain;
        //private Hero hero;
        //private Minion minion;

        protected string name;
        protected int Evilness;
        /// <summary>
        /// voor het opvragen van de naam.
        /// </summary>
        /// <returns>de naam van de "person"</returns>
        public string GetName()
        {
            return name;
        }
        /// <summary>
        /// voor het opvragen van het level van slechtheid.
        /// </summary>
        /// <returns>de slechtheid op een schaal van 1 op 100</returns>
        public int GetEvilness()
        {
            return Evilness;
        }

        /*
        private Minion Minion()
        {
            return minion;
        }

        private Villain Villain()
        {
            return villain;
        }

        private Hero Hero()
        {
            return hero;
        }
        */
    }
}