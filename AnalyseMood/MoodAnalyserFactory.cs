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

            if (type == null)
            {
                throw new MoodAnalysisException("" + Exception_type.No_Such_class_Exception);
            }
            try
            {
                var objInstance = Activator.CreateInstance(type, construct);
                if (objInstance == null)
                {
                    throw new MissingMethodException("" + Exception_type.No_Such_Method_Exception);
                }
                return objInstance;
            }

            //catch(MoodAnalysisException me)
            //{
            //    Console.WriteLine(me.Message);
            //    return Exception_type.No_Such_class_Exception.ToString();
            //}

            catch (MissingMethodException)
            {
                return Exception_type.No_Such_Method_Exception.ToString();
            }
        }

       // }
       public static string InvokeMethodUsingReflection(string methodName=null,string fieldName=null)
        {
           
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type moodAnalysertype = Type.GetType("AnalyseMood.MoodAnalyser");
            MethodInfo methodInfo = moodAnalysertype.GetMethod(methodName);


            string[] stringArray = { "I am in Happy mood" };
            object objectInstance = Activator.CreateInstance(moodAnalysertype, stringArray);

            if (fieldName != null)
            {
                FieldInfo fieldInfo = moodAnalysertype.GetField(fieldName);
                if (fieldInfo == null)
                    throw new MoodAnalysisException(Exception_type.No_Such_Field_Exception.ToString());
                fieldInfo.SetValue(objectInstance, fieldName);
            }
                if (fieldName == null)
                {
                    throw new MoodAnalysisException(Exception_type.Null_Exception.ToString());
                }
            


            if (methodInfo == null)
                {
                    throw new MoodAnalysisException(""+ Exception_type.No_Such_Method_Exception);
                }
              //  object objectInstance = Activator.CreateInstance(moodAnalysertype, stringArray);

                string method = (string)methodInfo.Invoke(objectInstance, null);
                return method;
           // }
           /* catch(MoodAnalysisException)
            {
                return "HAPPY";
            }*/

        }
       /* public static string InvokeMethodUsingReflectionField(string methodName = null, string fieldName = null)
        {
           // try
            //{
                Type moodAnalysertype = Type.GetType("AnalyseMood.MoodAnalyser");
                MethodInfo methodInfo = moodAnalysertype.GetMethod(methodName);
                string[] stringArray = { "I am in Happy mood" };
                object objectInstance = Activator.CreateInstance(moodAnalysertype, stringArray);

                if (fieldName != null)
                {
                    FieldInfo fieldInfo = moodAnalysertype.GetField(fieldName);
                    if (fieldInfo == null)
                        throw new MoodAnalysisException(Exception_type.No_Such_Field_Exception.ToString());
                    fieldInfo.SetValue(objectInstance, fieldName);
                }
                else
                {
                    throw new MoodAnalysisException(Exception_type.Null_Exception.ToString());
                }

                if (methodInfo == null)
                {
                    throw new MoodAnalysisException("" + Exception_type.No_Such_Method_Exception);
                }

                string method = (string)methodInfo.Invoke(objectInstance, null);
                return method;


            }
*/






    }
}

