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
            MoodAnalysis mood = new MoodAnalysis(message);
            //ACT
            string actual = mood.MoodAnalyser();
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
            MoodAnalysis mood = new MoodAnalysis(message);
            //ACT
            string actual = mood.MoodAnalyser();
            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestCategory("Returns happy")]
        [TestMethod]
        public void TestCase2()
        {
            string message = null;
            string expected = "happy";
            MoodAnalysis mood = new MoodAnalysis(message);

            string actualMood = mood.MoodAnalyser();
            Assert.AreEqual(actualMood,expected);
        }

        [TestCategory("Custom Exception")]
        [TestMethod]
        public void CustomException()
        {
            string message = "";
            string expected = "Mood should not be empty";

            try
            {
                MoodAnalysis moodAnalysis = new MoodAnalysis(message);
                string actual = moodAnalysis.MoodAnalyser();
                Assert.AreEqual(expected, actual);
            }
            catch(CustomException msg)
            {
                Assert.AreEqual(expected,msg.Message);
            }
        }



    }
}
