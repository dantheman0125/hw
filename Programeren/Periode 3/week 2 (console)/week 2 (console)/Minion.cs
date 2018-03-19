using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    class Minion:Person
    {
        private string weakness;

        public Minion(string name, string weakness)
        {
            this.name = name;
            this.weakness = weakness;
        }

        public string GetWeakness()
        {
            return weakness;
        }


    }
}
