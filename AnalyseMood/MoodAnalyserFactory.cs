using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace AnalyseMood
{
    /// <summary>
    /// /throw exception
    /// </summary>
    public class MoodAnalyserReflactor
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
        public static string InvokeMethodUsingReflection()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type moodAnalysertype = Type.GetType("AnalyseMood.MoodAnalyser");
            MethodInfo methodInfo = moodAnalysertype.GetMethod("AnalyseMood");
            string[] stringArray = { "I am in Happy mood" };
            object objectInstance = Activator.CreateInstance(moodAnalysertype,stringArray);
            
           string method  = (string)methodInfo.Invoke(objectInstance, null);
            return method;
        }

        
       
    }
}

