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
        
        /// <summary>
        /// de constructor van de class Huisdier.
        /// </summary>
        /// <param name="Naam"></param>
        /// <param name="Soort"></param>
        public Huisdier(string Naam, string Soort)
        {
            this.Naam = Naam;
            this.Soort = Soort;
        }
        /// <summary>
        /// voor het opvragen van de naam van het huisdier.
        /// </summary>
        /// <returns>huisdier naam</returns>
        public string getNaam()
        {
            return Naam;
        }
        /// <summary>
        /// voor het opvragen van de soort van het huisdier.
        /// </summary>
        /// <returns>de soort</returns>
        public string getSoort()
        {
            return Soort;
        }
        /// <summary>
        /// voor het opvragen van de naam en de soort van het huisdier
        /// </summary>
        /// <returns>geeft de naam en de soort terug</returns>
        public string getBeschrijving()
        {
            return Naam + " - " + Soort;
        }
    }
}