using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    class Villain : Person, IHasStrengths
    {
        private List<Minion> minions;
        private List<string> strengths;

        public Villain (string name)
        {
            this.name = name;
        }

        public void AddMinion(Minion minion)
        {
            minions.Add(minion);
        }

        public List<Minion> GetMinions()
        {
            return minions;
        }

        public void AddStrength(string strength)
        {
            strengths.Add(strength);
        }

        public List<string> GetStrengths()
        {
            return strengths;
        }

    }
}