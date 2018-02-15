using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderProgrammerenPracticumWeek1
{
    class Persoon
    {
        private string voornaam;
        private string achternaam;
        private int leeftijd;
        private List<Huisdier> huisdieren;
        /// <summary>
        /// de Constructor
        /// </summary>
        /// <param name="voornaam"></param>
        /// <param name="achternaam"></param>
        /// <param name="leeftijd"></param>
        public Persoon(string voornaam, string achternaam, int leeftijd)
        {
            this.voornaam = voornaam;
            this.achternaam = achternaam;
            this.leeftijd = leeftijd;
            huisdieren = new List<Huisdier>();
        }
        /// <summary>
        /// voor het opvragen van de voor- en achternaam
        /// </summary>
        /// <returns>voor- en achternaam</returns>
        public string getNaam()
        {
            return voornaam +" "+ achternaam;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Huisdier> getHuisdieren()
        {
            return huisdieren;
        }

        public void addHuisdier(Huisdier huisdier)
        {
            huisdieren.Add(huisdier);
        }

        public int getLeeftijd()
        {
            return leeftijd;
        }
    }
}
