//-----------------------------------------------------------------------
// <copyright file="SubtitleLine.cs" company="Zed Byt Corp">
//     Copyright Zed Byt Corp 2010
// </copyright>
//-----------------------------------------------------------------------
namespace RecalleLeSousTitre
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Subtitle Line Class
    /// </summary>
    public class SubtitleLine
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SubtitleLine()
        {
            Text = new List<string>();
            Numero = 0;
            StartTime = TimeSpan.MinValue;
            EndTime = TimeSpan.MinValue;
        }

        /// <summary>
        /// Gets or sets Line number
        /// </summary>
        public int Numero { get; set; }

        /// <summary>
        /// Gets or sets Start Time
        /// </summary>
        public TimeSpan StartTime { get; set; }

        /// <summary>
        /// Gets or sets End Time
        /// </summary>
        public TimeSpan EndTime { get; set; }

        /// <summary>
        /// Gets or sets Sutitle Text
        /// </summary>
        public List<string> Text { get; set; }

        /// <summary>
        /// Gets all lines ready to be write
        /// </summary>
        /// <returns>Lines to be writed</returns>
        public List<string> GetAllLinesToWrite()
        {
            List<string> s = new List<string>();
            s.Add(Numero.ToString());
            s.Add(string.Format(
                "{0}:{1}:{2},{3} --> {4}:{5}:{6},{7}",
                StartTime.Hours.ToString("00"),
                StartTime.Minutes.ToString("00"),
                StartTime.Seconds.ToString("00"),
                StartTime.Milliseconds.ToString("000"),
                EndTime.Hours.ToString("00"),
                EndTime.Minutes.ToString("00"),
                EndTime.Seconds.ToString("00"),
                EndTime.Milliseconds.ToString("000")));
            s.AddRange(Text);
            return s;
        }
    }
}
