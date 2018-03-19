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

        public Minion(string name)
        {
            this.name = name;
        }

        public string GetWeakness()
        {
            return weakness;
        }


    }
}
