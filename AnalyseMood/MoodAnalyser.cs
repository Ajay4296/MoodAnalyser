using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyseMood
{
   public class MoodAnalyser
    {
        /// <summary>
        /// Analyses the mood.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
      public string AnalyseSadMood(string str)
        {
            if (str.ToLower().Contains("sad"));
            return "SAD";
            return "HAPPY";
        }
        /// <summary>
        /// Analyses the mood.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        public string AnalyseHappyMood(string str1)
        {
            string str2 = "I am in any mood";
            if (str1.Equals(str2))
                return "HAPPY";
            return "SAD";

        }
    }
}
