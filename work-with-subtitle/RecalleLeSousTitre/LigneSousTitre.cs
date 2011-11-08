using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RecalleLeSousTitre
{
    public class LigneSousTitre
    {
        public int numero = 0;
        public TimeSpan TempsDebut = TimeSpan.MinValue;
        public TimeSpan TempsFin = TimeSpan.MinValue;
        public List<string> soustitre;

        public LigneSousTitre()
        {
            soustitre = new List<string>();
        }

        public List<string> ecrire()
        {
            List<string> s = new List<string>();
            s.Add(numero.ToString());
            s.Add(string.Format("{0}:{1}:{2},{3} --> {4}:{5}:{6},{7}",
                TempsDebut.Hours.ToString("00"),
                TempsDebut.Minutes.ToString("00"),
                TempsDebut.Seconds.ToString("00"),
                TempsDebut.Milliseconds.ToString("000"),
                TempsFin.Hours.ToString("00"),
                TempsFin.Minutes.ToString("00"),
                TempsFin.Seconds.ToString("00"),
                TempsFin.Milliseconds.ToString("000")));
            s.AddRange(soustitre);
            return s;
        }
    }
}
