using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RecalleLeSousTitre
{
    class Controler
    {
        private List<LigneSousTitre> SSTitre = new List<LigneSousTitre>();

        private int _index = 1;
        private int _errorIndex = 1;
        private int _secondsError = 10;

        public int SecondsError
        {
            get
            {
                return _secondsError;
            }
            set
            {
                _secondsError = value;
            }
        }

        public Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> GetActual()
        {
            try
            {
                LigneSousTitre l1 = SSTitre.Single(l => l.numero == _index);
                LigneSousTitre lBefore;
                if (_index == 1)
                {
                    lBefore = new LigneSousTitre();
                }
                else
                {
                    lBefore = SSTitre.Single(l => l.numero == _index - 1);
                }

                LigneSousTitre lAfter;
                if (_index == SSTitre.Count)
                {
                    lAfter = new LigneSousTitre();
                }
                else
                {
                    lAfter = SSTitre.Single(l => l.numero == _index + 1);
                }

                return new Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre>(lBefore, l1, lAfter);
            }
            catch (Exception)
            {
                return new Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre>(new LigneSousTitre(), new LigneSousTitre(), new LigneSousTitre());
            }
        }

        #region Normal
        public Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> GetFirst()
        {
            _index = 1;
            return GetActual();
        }

        public Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> GetNext()
        {
            return GetNext(1);
        }

        public Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> GetNext(int pas)
        {
            if (_index < SSTitre.Count - pas)
            {
                _index += pas;
            }

            return GetActual();
        }

        public Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> GetRewind()
        {
            return GetRewind(1);
        }

        public Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> GetRewind(int pas)
        {
            if (_index > pas)
            {
                _index -= pas;
            }

            return GetActual();
        }
        #endregion

        #region Error
        public Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> GetFirstError()
        {
            _errorIndex = 1;
            return GetNextError();
        }

        public Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> GetNextError()
        {
            for (int i = _errorIndex + 1; i <= SSTitre.Count; i++)
            {
                if (Utils.DiffDebutFin(SSTitre.Single(l => l.numero == i), _secondsError))
                {
                    _index = i;
                    _errorIndex = i;
                    break;
                }
            }

            return GetActual();
        }

        public Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> GetRewindError()
        {
            for (int i = _errorIndex - 1; i > 0; i--)
            {
                if (Utils.DiffDebutFin(SSTitre.Single(l => l.numero == i), _secondsError))
                {
                    _index = i;
                    _errorIndex = i;
                    break;
                }
            }

            return GetActual();
        }

        public int FoundErrors()
        {
            int i = 0;
            foreach (LigneSousTitre ligne in SSTitre)
            {
                if (Utils.DiffDebutFin(ligne, _secondsError))
                {
                    i++;
                }
            }

            return i;
        }
        #endregion

        #region File
        public void ReadFile(string filePath)
        {
            SSTitre.Clear();
            string[] lignes = File.ReadAllLines(filePath);
            for (int i = 0; i < lignes.Length; i++)
            {
                int numLigne = 0;
                if (int.TryParse(lignes[i], out numLigne))
                {
                    LigneSousTitre l = new LigneSousTitre();
                    l.numero = numLigne;
                    i++;
                    string ligne = lignes[i].Replace(" ", string.Empty);
                    string[] temps = ligne.Split(new char[3] { '-', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                    l.TempsDebut = TimeSpan.Parse(temps[0]);
                    l.TempsFin = TimeSpan.Parse(temps[1]);
                    i++;
                    while (!int.TryParse(lignes[i], out numLigne))
                    {
                        l.soustitre.Add(lignes[i]);
                        i++;
                        if (i == lignes.Length)
                        {
                            break;
                        }
                    }

                    SSTitre.Add(l);
                    i--;
                }
            }
        }

        public void SaveFile(string filePath)
        {
            foreach (LigneSousTitre l in SSTitre)
            {
                File.AppendAllLines(filePath, l.ecrire());
            }
        }
        #endregion

    }
}
