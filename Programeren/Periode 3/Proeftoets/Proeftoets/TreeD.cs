using System;
using System.Collections.Generic;
using System.Text;

namespace Proeftoets
{
    class TreeD
    {
        private Docenten d;
        private TreeD jonger;
        private TreeD ouder;

        public TreeD(Docenten d)
        {
            this.d = d;
        }

        public void Add(Docenten d)
        {
            if (d.GetGeboortedatum() > this.d.GetGeboortedatum())
            {
                if (jonger == null)
                {
                    jonger = new TreeD(d);
                }
                else
                {
                    jonger.Add(d);
                }
            }
            else
            {
                if (ouder == null)
                {
                    ouder = new TreeD(d);
                }

                else
                {
                    ouder.Add(d);
                }
            }
        }

        public void EducatorUpdate()
        {
            DateTime dt = DateTime.Now.AddYears(-35);
            if (d.GetGeboortedatum() > dt)
            {
                d.AllemaalEenOnvoldoende();
                if (ouder != null)
                {
                    ouder.EducatorUpdate();
                }
            }
            if (jonger != null)
            {
                jonger.EducatorUpdate();
            }
        }
    }
}
