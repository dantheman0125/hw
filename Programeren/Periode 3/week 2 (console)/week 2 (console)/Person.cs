using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    public abstract class Person
    {
        protected string name;
        protected int Evilness;

        public string GetName()
        {
            return name;
        }

        public int GetEvilness()
        {
            return Evilness;
        }

    }
}