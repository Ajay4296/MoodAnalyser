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
                if (message == null)
                {
                    throw new MoodAnalysisException("Exception present is:-" +Exception_type.Null_Exception);
                }
                else if (this.message == "")
                {
                    throw new MoodAnalysisException("Exception present:-" +Exception_type.Empty_Exception);
                }
                else if (message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                    return "HAPPY";
            }
            catch (MoodAnalysisException ex)
            {
                return "HAPPY";
            }
            

        }
        public override bool Equals(object obj)
        {
            Type type = (Type)obj;
            if (this.GetType().Equals(type.FullName))
                return true;
            return false;


        }



    }
}
