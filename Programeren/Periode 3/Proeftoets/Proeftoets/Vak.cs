using System;
using System.Collections.Generic;
using System.Text;

namespace Proeftoets
{
    class Vak
    {
        private Docenten docent;
        private Studenten studenten;

        public Vak (Docenten d)
        {
            docent = d;
        }

        public void Add (Student s)
        {
            if (studenten == null)
                studenten = new Studenten(s);
            else
                studenten.Add(s);
        }

        public void printCijfers()
        {
            if (studenten != null)
                studenten.printCijfers();
        }
    }
}
