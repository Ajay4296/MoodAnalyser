using System;
using System.Collections.Generic;
using System.Text;

namespace AnalyseMood
{
        public enum Exception_type
        {
            Null_Exception,
            Empty_Exception,
            Invalid_exception,
            No_Such_class_Exception,
             No_Such_Method_Exception,
             No_Such_Field_Exception,

    }
        public class MoodAnalysisException : ApplicationException
        {
        public string msg;

            public MoodAnalysisException(string message) {

            this.msg = message;
            }
        }
    public class ConstructerMissingException : ApplicationException
    {
        public ConstructerMissingException(string message) : base(message)
        {

        }
    }

}
