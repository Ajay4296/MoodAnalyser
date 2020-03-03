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
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
   
        /// <summary>
        /// Checking null reference Exception
        /// </summary>
        /// <returns></returns>
      public string AnalyseMood()
        {
            //try
            //{
                if (message == null)
                {
                    throw new MoodAnalysisException(Exception_type.Null_Exception+"");
                }
                else if (this.message == "")
                {
                    throw new MoodAnalysisException(Exception_type.Empty_Exception+"");
                }
                else if (message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                    return "HAPPY";
            //}
            //catch (MoodAnalysisException ex)
            //{
            //    return "HAPPY";
            //}
            

        }
        public override bool Equals(object obj)
        {
            if(obj==null)
            {
                return false;
            }

            if (this.GetType().Equals(((MoodAnalyser)obj).GetType()))
                return true;
            return false;


        }



    }
}
