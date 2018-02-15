using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    class Villain : Person
    {
        private List<Minion> minions;
        private List<string> strengths;

        public Villain (string name)
        {
            this.name = name;
            minions = new List<Minion>();
        }

        public void AddMinion(Minion minion)
        {
            minions.Add(minion);
        }

        public List<Minion> GetMinions()
        {
            return minions;
        }
    }
}