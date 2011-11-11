//-----------------------------------------------------------------------
// <copyright file="Utils.cs" company="Zed Byt Corp">
//     Copyright Zed Byt Corp 2010
// </copyright>
//-----------------------------------------------------------------------
namespace RecalleLeSousTitre
{
    using System;
    using System.Drawing;

    /// <summary>
    /// Multiple utils
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// Calculate the time difference between the StartTime and the EndTime
        /// of the SubtitleLine and compare it to the time difference.
        /// It's an error if the calculated time difference is superior at timeDifferenceInSeconds
        /// </summary>
        /// <param name="ligne">SubtitleLine</param>
        /// <param name="timeDifferenceInSeconds">Time difference in seconds</param>
        /// <returns>True if the Time Difference is inferior at timeDifferenceInSeconds</returns>
        public static bool IsErrorBetweenStartAndEndTime(SubtitleLine ligne, int timeDifferenceInSeconds)
        {
            TimeSpan ts = new TimeSpan(0, 0, timeDifferenceInSeconds);
            TimeSpan ts2 = ligne.EndTime.Subtract(ligne.StartTime);
            if (ts.CompareTo(ts2) > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Calculate the time difference between the StartTime and the EndTime
        /// of the SubtitleLine and compare it to the time difference.
        /// It's an error if the calculated time difference is superior at timeDifferenceInSeconds
        /// </summary>
        /// <param name="ligne">SubtitleLine</param>
        /// <param name="timeDifferenceInSeconds">Time difference in seconds</param>
        /// <returns>Error is Color.Tomato, otherwise it's Color.Green</returns>
        public static Color ColorErrorBetweenStartAndEndTime(SubtitleLine ligne, int timeDifferenceInSeconds)
        {
            if (IsErrorBetweenStartAndEndTime(ligne, timeDifferenceInSeconds))
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
