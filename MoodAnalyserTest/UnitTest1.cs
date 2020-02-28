using NUnit.Framework;
using AnalyseMood;

namespace MoodAnalyserTest
{
    public class Tests
    {
        /// <summary>
        /// Analyses the sad mood when sad return sad.
        /// </summary>
        [Test]
        public void AnalyseSadMood_WhenSadReturnSad()
        {
            MoodAnalyser moodobj = new MoodAnalyser();
            string Expected = "SAD";
                Assert.AreEqual(Expected, moodobj.AnalyseSadMood("I am in sad mood"));
        }
        /// <summary>
        /// Analyses the happy mood when any mood return happy.
        /// </summary>
        [Test]
        public void AnalyseHappyMood_WhenAnyMoodReturnHappy()
        {
            MoodAnalyser moodobj = new MoodAnalyser();
            string Expected = "HAPPY";
            Assert.AreEqual(Expected, moodobj.AnalyseHappyMood("I am in any mood"));
        }


    }
}