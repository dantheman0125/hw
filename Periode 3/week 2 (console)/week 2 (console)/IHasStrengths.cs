using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    public interface IHasStrengths
    {
        void AddStrength(string strength);
        List<string> GetStrengths();
    }
}