using System;
using System.Collections.Generic;
using System.Text;

namespace Proeftoets
{
    public abstract class Mens
    {
        protected string naam;
        protected DateTime geboortedatum;

        public DateTime GetGeboortedatum()
        {
            return geboortedatum;
        }

        public string GetNaam()
        {
            return naam;
        }

    }
}
