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