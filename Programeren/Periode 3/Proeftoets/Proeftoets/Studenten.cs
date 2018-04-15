using System;
using System.Collections.Generic;
using System.Text;

namespace Proeftoets
{
    class Studenten
    {
        private Student s;
        private Studenten next;

        public Studenten (Student s)
        {
            this.s = s;
            next = null;
        }

        public void Add (Student s)
        {
            if (next == null)
                next = new Studenten(s);

            else
                next.Add(s);
        }

        public void printCijfers()
        {
            s.Printcijfers();
            if (next != null)
                next.printCijfers();
        }
    }
}