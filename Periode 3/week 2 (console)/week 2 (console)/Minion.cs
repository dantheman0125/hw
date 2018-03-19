using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    /// <summary>
    /// De class Minion die erft van Person.
    /// </summary>
    class Minion :Person
    {
        private string weakness;

        /// <summary>
        /// De constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="weakness"></param>
        public Minion(string name, string weakness)
        {
            this.name = name;
            this.weakness = weakness;
        }

        /// <summary>
        /// Voor het weergeven van de zwakte
        /// </summary>
        /// <returns>de zwakte</returns>
        public string GetWeakness()
        {
            return weakness;
        }
    }
}
