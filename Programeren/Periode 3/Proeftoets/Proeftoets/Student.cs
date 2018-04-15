using System;
using System.Collections.Generic;
using System.Text;

namespace Proeftoets
{
    class Student: Mens
    {
        private List<double> cijfers;

        public Student(string naam, DateTime geboortedatum)
        {
            this.naam = naam;
            this.geboortedatum = geboortedatum;
        }

        public void Ontvangcijfer(double cijfer)
        {
            cijfers.Add(cijfer);
        }

        public void Printcijfers()
        {
            cijfers.Add(3);
        }
    }
}

