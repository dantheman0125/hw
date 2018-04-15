using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Proeftoets
{
    class Docenten : Mens
    {
        //class variabelen
        private List<Mens> bekenden = new List<Mens>();

        //constructor
        public Docenten(string naam, DateTime geboortedatum)
        {
            this.naam = naam;
            this.geboortedatum = geboortedatum;
        }

        public void AddBekende(Mens m)
        {
            bekenden.Add(m);
        }

        public void AllemaalEenOnvoldoende()
        {
            foreach (Mens bekend in bekenden)
            {
                if (bekend is Student)
                {
                    ((Student)bekend).Ontvangcijfer(5.4);
                }
            }
        }

        public int GetAantalBekenden()
        {
            return bekenden.Count;
        }
    }
}