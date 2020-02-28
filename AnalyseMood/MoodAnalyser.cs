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
        /// Checking null reference Exception
        /// </summary>
        /// <returns></returns>
      public string AnalyseMood()
        {
            try
            {
                if (message != null)
                {
                    if (message.ToLower().Contains("sad"))
                        return "SAD";
                    else
                        return "HAPPY";
                }
                else
                    throw new NullReferenceException();
                

            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("null message have passed");
                return "HAPPY";
            }
        }
       
    }
}
