using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    class Hero:Person,IHasStrengths
    {
        private Villain archnemesis;
        private List<string> strengths;
        private Person sidekick;

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
                this.Evilness = 50;
            }
            strengths = new List<string>();
        }

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

        public Villain GetArchnemesis()
        {
            return archnemesis;
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