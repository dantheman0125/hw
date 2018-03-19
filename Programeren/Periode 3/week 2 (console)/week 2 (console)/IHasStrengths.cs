using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    /// <summary>
    /// De interface IHasStrengths.
    /// Als niet iedere class hier gebruik van hoeft te maken, maar een paar wel dan stop je die hierin en niet in de Mother-Class.
    /// </summary>
    public interface IHasStrengths
    {
        /// <summary>
        /// Voor het toevoegen van een kracht.
        /// </summary>
        /// <param name="strength"></param>
        void AddStrength(string strength);
        /// <summary>
        /// voor het opvragen van een kracht.
        /// </summary>
        /// <returns>de kracht</returns>
        List<string> GetStrengths();
    }
}