using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyzerProblem;

namespace MoodAnalyzerProblemUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestCategory("Sad mood")]
        [DataRow("I am sad","sad")]
        [TestMethod]
        public void MoodTest()
        {
            //string message = "I am sad.";
            //string expected = "sad";

            MoodAnalysis mood = new MoodAnalysis();

            string actual = mood.Mood(message);

            Assert.AreEqual(expected,actual);

        }
    }
}
