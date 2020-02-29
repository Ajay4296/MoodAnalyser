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
        /// <summary>
        /// TestCase-2.1
        /// Analyses the mood when null mood return happy.
        /// </summary>
        [Test]
        public void AnalyseMood_WhenNullMoodReturnHappy()
        {
            MoodAnalyser moodobj = new MoodAnalyser(null);
            string Expected = "HAPPY";
            Assert.AreEqual(Expected, moodobj.AnalyseMood());
        }
        /// <summary>
        /// TESTCASE_3.1
        /// Analyses the mood when null throw exception mood return happy.
        /// </summary>
        [Test]
        public void AnalyseMood_WhenNullThrowMoodAnalysisException()
        {
            MoodAnalyser moodobj = new MoodAnalyser(null);
            string Expected = "HAPPY";
            Assert.AreEqual(Expected, moodobj.AnalyseMood());
        }
        /// <summary>
        /// TestCase_3.2
        /// Analyses the mood when null throw exception mood return happy.
        /// </summary>
        [Test]
        public void AnalyseMood_WhenEmptyThrowMoodAnalysisException()
        {
            MoodAnalyser moodobj = new MoodAnalyser(" ");
            string Expected = "HAPPY";
            Assert.AreEqual(Expected, moodobj.AnalyseMood());
        }
        /// <summary>
        /// Testcase-4.1
        /// check two_object are equal
        /// </summary>
        [TestCase]
        public void AnalyserMoodObjectTest()
        {
            //  MoodAnalyserFactory factoryobj = new AnalyseMood.MoodAnalyserFactory();
            Type type = MoodAnalyserFactory.CreateObjectUsingReflection("AnalyseMood.MoodAnalyser");
            MoodAnalyser mood = new MoodAnalyser();
            bool actual = mood.Equals(type);
            bool expected = true;
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// TestCase_4.2
        /// throw exception when null
        /// </summary>
        [TestCase]
        public void AnalyserMoodExceptionTest()
        {
            Type type = MoodAnalyserFactory.CreateObjectUsingReflection("MoodHour");
            MoodAnalyser mood = new MoodAnalyser();
            bool actual = mood.Equals(type);
            bool expected = false;
            Assert.AreEqual(actual, expected);
        }

    }
}