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
            return type;
        }
       /* public static Type CreateSecondObjectUsingReflection(string ClassName)
        {
            Type type1 = Type.GetType(ClassName);
            return type1;
        }*/

    }
}
