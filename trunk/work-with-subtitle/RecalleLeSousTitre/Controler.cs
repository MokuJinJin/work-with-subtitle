﻿//-----------------------------------------------------------------------
// <copyright file="Controler.cs" company="Zed Byt Corp">
//     Copyright Zed Byt Corp 2010
// </copyright>
//-----------------------------------------------------------------------
namespace RecalleLeSousTitre
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// UI Controler
    /// </summary>
    public class Controler
    {
        /// <summary>
        /// List of every subtitle from a file
        /// </summary>
        private List<LigneSousTitre> _subTitles = new List<LigneSousTitre>();

        /// <summary>
        /// Index of the current subtitle's position 
        /// </summary>
        private int _index = 1;

        /// <summary>
        /// Index of the current error subtitle's position
        /// </summary>
        private int _errorIndex = 1;

        /// <summary>
        /// How many seconds between StartTime and EndTime 
        /// will be considerated as an error
        /// </summary>
        /// <value>10</value>
        private int _secondsError = 10;

        /// <summary>
        /// Gets or sets How many seconds between StartTime and EndTime 
        /// will be considerated as an error
        /// </summary>
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

        /// <summary>
        /// Get the current Subtitle and the sub before (-1) and after (+1)
        /// </summary>
        /// <returns>Tuple : Item1 is before, Item2 is current, Item3 is after</returns>
        public Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> GetActual()
        {
            try
            {
                LigneSousTitre l1 = _subTitles.Single(l => l.numero == _index);
                LigneSousTitre before;
                if (_index == 1)
                {
                    before = new LigneSousTitre();
                }
                else
                {
                    before = _subTitles.Single(l => l.numero == _index - 1);
                }

                LigneSousTitre after;
                if (_index == _subTitles.Count)
                {
                    after = new LigneSousTitre();
                }
                else
                {
                    after = _subTitles.Single(l => l.numero == _index + 1);
                }

                return new Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre>(before, l1, after);
            }
            catch (Exception)
            {
                return new Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre>(new LigneSousTitre(), new LigneSousTitre(), new LigneSousTitre());
            }
        }

        #region Normal
        /// <summary>
        /// Return to the first subtitle's line
        /// </summary>
        /// <returns>Tuple : Item1 is before, Item2 is current, Item3 is after</returns>
        public Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> GetFirst()
        {
            _index = 1;
            return GetActual();
        }

        /// <summary>
        /// Get the Subtitle next to the current.
        /// Current is becoming "before"
        /// </summary>
        /// <returns>Tuple : Item1 is before, Item2 is current, Item3 is after</returns>
        public Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> GetNext()
        {
            return GetNext(1);
        }

        /// <summary>
        /// Get the subtitle next, plus "pas".
        /// </summary>
        /// <param name="pas">how many next to the current subtitle</param>
        /// <returns>Tuple : Item1 is before, Item2 is current, Item3 is after</returns>
        public Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> GetNext(int pas)
        {
            if (_index < _subTitles.Count - pas)
            {
                _index += pas;
            }

            return GetActual();
        }

        /// <summary>
        /// Get the subtitle before the current.
        /// Current is becoming "after"
        /// </summary>
        /// <returns>Tuple : Item1 is before, Item2 is current, Item3 is after</returns>
        public Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> GetRewind()
        {
            return GetRewind(1);
        }

        /// <summary>
        /// Get the subtitle before, plus "pas"
        /// </summary>
        /// <param name="pas">how many before to the current subtitle</param>
        /// <returns>Tuple : Item1 is before, Item2 is current, Item3 is after</returns>
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
        /// <summary>
        /// Set the first error as current subtitle, and return it
        /// </summary>
        /// <returns>Tuple : Item1 is before, Item2 is current, Item3 is after</returns>
        public Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> GetFirstError()
        {
            _errorIndex = 1;
            return GetNextError();
        }

        /// <summary>
        /// Set the current subtitle as the error next to the current/last one
        /// </summary>
        /// <returns>Tuple : Item1 is before, Item2 is current, Item3 is after</returns>
        public Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> GetNextError()
        {
            for (int i = _errorIndex + 1; i <= _subTitles.Count; i++)
            {
                if (Utils.DiffDebutFin(_subTitles.Single(l => l.numero == i), _secondsError))
                {
                    _index = i;
                    _errorIndex = i;
                    break;
                }
            }

            return GetActual();
        }

        /// <summary>
        /// Set the current subtitle as the error before to the current/last one
        /// </summary>
        /// <returns>Tuple : Item1 is before, Item2 is current, Item3 is after</returns>
        public Tuple<LigneSousTitre, LigneSousTitre, LigneSousTitre> GetRewindError()
        {
            for (int i = _errorIndex - 1; i > 0; i--)
            {
                if (Utils.DiffDebutFin(_subTitles.Single(l => l.numero == i), _secondsError))
                {
                    _index = i;
                    _errorIndex = i;
                    break;
                }
            }

            return GetActual();
        }

        /// <summary>
        /// Calculate the number of error present is the subtitle list
        /// </summary>
        /// <returns>Numbre of error found</returns>
        public int FoundErrors()
        {
            int i = 0;
            foreach (LigneSousTitre ligne in _subTitles)
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
        /// <summary>
        /// Read the file and load every subtitle line
        /// </summary>
        /// <param name="filePath">path of the loaded file</param>
        public void ReadFile(string filePath)
        {
            _subTitles.Clear();
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

                    _subTitles.Add(l);
                    i--;
                }
            }
        }

        /// <summary>
        /// Write the current subtitle lines
        /// </summary>
        /// <param name="filePath">paht to the writed file</param>
        public void SaveFile(string filePath)
        {
            foreach (LigneSousTitre l in _subTitles)
            {
                File.AppendAllLines(filePath, l.ecrire());
            }
        }
        #endregion
    }
}