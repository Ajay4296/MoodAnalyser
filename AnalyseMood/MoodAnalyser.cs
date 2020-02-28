using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyseMood
{
   public class MoodAnalyser
    {
        public string message;
        /// <summary>
        /// non_paramatrized_Constructer
        /// </summary>
        public MoodAnalyser()
        {

        }
        /// <summary>
        /// </summary>
        /// <param name="str"></param>
        public MoodAnalyser(string str)
        {
            message = str;
        }
        /// <summary>
        /// Analyses the mood.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
      public string AnalyseMood()
        {
            if (message.ToLower().Contains("sad"))
            return "SAD";
            return "HAPPY";
        }
       
    }
}
