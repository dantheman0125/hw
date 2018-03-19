using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    class Hero:Person,IHasStrengths
    {
        private Villain archnemisis;
        private List<string> strengths;
        private Person sidekick;

        public Hero (string name, Villain nemisis)
        {
            this.name = name;
            archnemisis = nemisis;
        }

        public Villain GetArchnemisis()
        {
            return archnemisis;
        }

        public void AddStrength(string strength)
        {
            strengths.Add(strength);
        }

        public List<string> GetStrengths()
        {
            return strengths;
        }

        public void UpdateSidekick(Person sidekick)
        {
            this.sidekick = sidekick;
        }

        public Person GetSidekick()
        {
            return sidekick;
        }
    }
}