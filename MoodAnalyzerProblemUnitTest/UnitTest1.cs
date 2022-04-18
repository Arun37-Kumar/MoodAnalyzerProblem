using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyzerProblem;

namespace MoodAnalyzerProblemUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestCategory("Sad mood")]
        [TestMethod]
        public void SadMoodTest()
        {
            //ARRANGE
            string message = "I am sad.";
            string expected = "sad";
            MoodAnalysis mood = new MoodAnalysis();
            //ACT
            string actual = mood.MoodAnalyser(message);
            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestCategory("Happy Mood")]
        [TestMethod]
        public void HappyMoodTest()
        {
            //ARRANGE
            string message = "I am happy.";
            string expected = "happy";
            MoodAnalysis mood = new MoodAnalysis();
            //ACT
            string actual = mood.MoodAnalyser(message);
            //ASSERT
            Assert.AreEqual(expected, actual);

        }
    }
}
