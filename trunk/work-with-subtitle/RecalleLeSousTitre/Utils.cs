using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RecalleLeSousTitre
{
    public static class Utils
    {
        public static bool DiffDebutFin(LigneSousTitre ligne, int seconds)
        {
            TimeSpan ts = new TimeSpan(0, 0, seconds);
            TimeSpan ts2 = ligne.TempsFin.Subtract(ligne.TempsDebut);
            if (ts.CompareTo(ts2) > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Color DiffDebutFinColor(LigneSousTitre ligne, int seconds)
        {
            if (DiffDebutFin(ligne,seconds))
            {
                return Color.Tomato;
            }
            else
            {
                return Color.Green;
            }
        }
    }
}
