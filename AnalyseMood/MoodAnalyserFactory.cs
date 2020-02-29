using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace AnalyseMood
{
   public class MoodAnalyserFactory
    {
        public static Type CreateObjectUsingReflection(string ClassName)
        {
            Type type = Type.GetType(ClassName);
            try
            {
                if (type == null)
                    throw new MoodAnalysisException("Exception" + Exception_type.No_Such_class_Exception);
                return type;
            }
            catch(MoodAnalysisException me)
            {
                Console.WriteLine(me.Message);
                return null;
            }
        }
      

    }
}
