using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace AnalyseMood
{
    /// <summary>
    /// /throw exception
    /// </summary>
    public class MoodAnalyserFactory
    {
        public static object CreateObjectUsingReflection(string ClassName, params object[] construct)
        {
            Type type = Type.GetType(ClassName);
            try
            {
                if (type == null)
                {
                    throw new MoodAnalysisException("Exception" + Exception_type.No_Such_class_Exception);
                }
              var objInstance = Activator.CreateInstance(type,construct);
                if(objInstance==null)
                {
                    throw new ConstructerMissingException("Exception" + Exception_type.No_Such_Method_Exception);
                }
               return objInstance;
            }
            catch(MoodAnalysisException me)
            {
                Console.WriteLine(me.Message);
                return Exception_type.No_Such_class_Exception.ToString();
            }
           
            catch (MissingMethodException)
            {
                return Exception_type.No_Such_Method_Exception.ToString();
            }

        }

        
       
    }
}

