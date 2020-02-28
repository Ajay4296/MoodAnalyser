using NUnit.Framework;
using AnalyseMood;

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



    }
}