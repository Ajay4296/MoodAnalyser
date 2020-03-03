using NUnit.Framework;
using AnalyseMood;
using System;
using System.Reflection;

namespace MoodAnalyserTest
{
    public class Tests
    {
        /// <summary>
        /// TestCase 1.1
        /// Analyses the sad mood when sad return sad.
        /// </summary>
        [Test]
        public void AnalyseMood_WhenSadReturnSad()
        {
            MoodAnalyser moodobj = new MoodAnalyser("I am in sad mood");
            string Expected = "SAD";
            Assert.AreEqual(Expected, moodobj.AnalyseMood());
        }
        /// <summary>
        /// TestCase_1.2
        /// Analyses the mood when happy mood return happy.
        /// </summary>
        [Test]
        public void AnalyseMood_WhenHappyMoodReturnHappy()
        {
            MoodAnalyser moodobj = new MoodAnalyser("I am in happy mood");
            string Expected = "HAPPY";
            Assert.AreEqual(Expected, moodobj.AnalyseMood());
        }
       /* /// <summary>
        /// TestCase-2.1
        /// Analyses the mood when null mood return happy.
        /// </summary>
        [Test]
        public void AnalyseMood_WhenNullMoodReturnHappy()
        {
            MoodAnalyser moodobj = new MoodAnalyser(null);
            string Expected = "HAPPY";
            Assert.AreEqual(Expected, moodobj.AnalyseMood());
        }*/
        /// <summary>
        /// TESTCASE_3.1
        /// Analyses the mood when null throw exception mood return happy.
        /// </summary>
        [Test]
        public void AnalyseMood_WhenNullThrowMoodAnalysisException()
        {
            MoodAnalyser mood = new MoodAnalyser(null);
            var ex = Assert.Throws<MoodAnalysisException>(() => mood.AnalyseMood());
            Assert.AreEqual(ex.msg, "Null_Exception".ToString());
        }
        /// <summary>
        /// TestCase_3.2
        /// Analyses the mood when null throw exception mood return happy.
        /// </summary>
        [Test]
        public void AnalyseMood_WhenEmptyThrowMoodAnalysisException()
        {
            MoodAnalyser mood = new MoodAnalyser("");
            var ex = Assert.Throws<MoodAnalysisException>(() => mood.AnalyseMood());
            Assert.AreEqual(ex.msg,Exception_type.Empty_Exception.ToString());
        }
        /// <summary>
        /// Testcase-4.1
        /// check two_object are equal
        /// </summary>
        [TestCase]
        public void CreatObjectUsingRef_AnalyserMoodObjectTest()
        {
            
            object obj = MoodAnalyserReflactor.CreateObjectUsingReflection("AnalyseMood.MoodAnalyser");
            MoodAnalyser mood = new MoodAnalyser();
            bool actual = mood.Equals(obj);
            bool expected = true;
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// TestCase_4.2
        /// throw exception when null
        /// </summary>
        [TestCase]
        public void CreatObjectusingRef_AnalyserMoodExceptionTest()
        {
            /*object type = MoodAnalyserReflactor.CreateObjectUsingReflection("HappyHour");
            MoodAnalyser mood = new MoodAnalyser();
            var actual = type.ToString();
            var expected = Exception_type.No_Such_class_Exception.ToString();
            Assert.AreEqual(actual, expected);*/
            var ex = Assert.Throws<MoodAnalysisException>(() => MoodAnalyserReflactor.CreateObjectUsingReflection("HappyHour"));
            Assert.AreEqual(ex.msg, Exception_type.No_Such_class_Exception.ToString());
        }
        /// <summary>
        /// UseCase_5.1
        /// Creatobjectusings the reflection pass parametrized constructer.
        /// </summary>
        [Test]
        public void CreatobjectusingReflectionPassParametrizedConstructer()
        {
            object reflactionobj = MoodAnalyserReflactor.CreateObjectUsingReflection("AnalyseMood.MoodAnalyser","I am in Happy Mood");
            MoodAnalyser mood = new MoodAnalyser();
            bool actual = mood.Equals(reflactionobj);
            bool expected = true;
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// UseCase_5.2
        /// Whens the not proper classname through exception.
        /// </summary>
        [Test]
        public void WhenNotProperClassnameThroughException()
        {
            //object Reflactionobject = MoodAnalyserReflactor.CreateObjectUsingReflection("Wrong class name", "I am in Happy Mood");
            //MoodAnalyser moodobj = new MoodAnalyser();
            //var Expected = Exception_type.No_Such_class_Exception.ToString(); 
            //Assert.AreEqual(Reflactionobject, Expected);
            var ex = Assert.Throws<MoodAnalysisException>(() => MoodAnalyserReflactor.CreateObjectUsingReflection("Wrong class name", "I am in Happy Mood"));
            Assert.AreEqual(ex.msg, Exception_type.No_Such_class_Exception.ToString());
        }
        /// <summary>
        /// UseCase_5.3
        /// Whens the not proper constructer name throw exception
        /// </summary>
        [Test]
        public void WhenNotProperConstructerNameThrowException()
        {
           object Reflactionobject = MoodAnalyserReflactor.CreateObjectUsingReflection("AnalyseMood.MoodAnalyser",123);
          MoodAnalyser moodobj = new MoodAnalyser();
             var Expected = Exception_type.No_Such_Method_Exception.ToString();
             Assert.AreEqual(Reflactionobject, Expected);
           
        }
        /// <summary>
        /// TestCse_6.1
        /// Invokes the method using reflection should return happy.
        /// </summary>
        [Test]
        public void InvokeMethodUsingReflection_shouldReturnHappy()
        {
            string actual = MoodAnalyserReflactor.InvokeMethodUsingReflection("AnalyseMood","message");
            string Expected = "HAPPY";
            Assert.AreEqual(actual, Expected);
        }

        /// <summary>
        /// TestCase_6.2
        /// Whens the method is wrong throw exception.
        /// </summary>
        [Test]
        public void WhenMethodIsWrongthrowException()
        {
            /* string actual = MoodAnalyserReflactor.InvokeMethodUsingReflection("Improper Method Name","message");
             string Expected = "HAPPY";
             Assert.AreEqual(actual, Expected);*/
            var ex = Assert.Throws<MoodAnalysisException>(() => MoodAnalyserReflactor.InvokeMethodUsingReflection("Improper Method Name","message"));
            Assert.AreEqual(ex.msg, Exception_type.No_Such_Method_Exception.ToString());

        }
        /// <summary>
        /// Sets the field value should return happy.
        /// Testcase_7.1
        /// </summary>
        [Test]
        public void SetFieldValue_shouldReturnHappy()
        {
            string actual = MoodAnalyserReflactor.InvokeMethodUsingReflection("AnalyseMood","message");
            string Expected = "HAPPY";
            Assert.AreEqual(actual, Expected);
        }
        [Test]
        public void SetImproperField_throwException()
        {
            var ex = Assert.Throws<MoodAnalysisException>(() => MoodAnalyserReflactor.InvokeMethodUsingReflection("AnalyseMood", "Improper Field Name"));
            Assert.AreEqual(ex.msg, Exception_type.No_Such_Field_Exception.ToString());
        }
        [Test]
        public void SetNullField_throwException()
        {
            var ex = Assert.Throws<MoodAnalysisException>(() => MoodAnalyserReflactor.InvokeMethodUsingReflection("AnalyseMood", null));
            Assert.AreEqual(ex.msg, Exception_type.Null_Exception.ToString());
        }




    }
}