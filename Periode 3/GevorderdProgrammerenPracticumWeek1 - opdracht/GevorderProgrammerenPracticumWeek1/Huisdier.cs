using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderProgrammerenPracticumWeek1
{
    class Huisdier
    {
        private string Naam;
        private string Soort;
        

        public Huisdier(string Naam, string Soort)
        {
            this.Naam = Naam;
            this.Soort = Soort;
        }

        public string getNaam()
        {
            return Naam;
        }

        public string getSoort()
        {
            return Soort;
        }

        public string getBeschrijving()
        {
            return Naam+" - "+Soort;
        }
    }
}
