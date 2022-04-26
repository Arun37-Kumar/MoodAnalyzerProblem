using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyzerProblem;
using System.Reflection;

namespace MoodAnalyzerProblemUnitTest
{

    [TestClass]
    public class UnitTest1
    {

        MoodAnalyserFactory reflector;
        [TestInitialize]
        public void Setup()
        {
            reflector = new MoodAnalyserFactory();
        }


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
            Assert.AreEqual(actualMood, expected);
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
            catch (CustomException msg)
            {
                Assert.AreEqual(expected, msg.Message);
            }
        }

        [TestCategory("Reflection")]
        [TestMethod]
        [DataRow("Mood.MoodAnalysis", "MoodAnalysis", "class not found")]
        public void GivenImproperClassName_ShouldThrowCustomException(string className, string constructorName, string expected)
        {
            try
            {
                object actual = reflector.CreatemoodAnalyse(className, constructorName);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        //TC 5.1 
        [TestCategory("Reflection")]
        [TestMethod]
        [DataRow("I am in sad mood")]
        [DataRow("I am in any mood")]
        public void GivenMoodAnalyserWhenProperShouldReturnMoodAnalyserObject(string message)
        {
            MoodAnalysis expected = new MoodAnalysis(message);
            object obj = null;
            try
            {
                obj = reflector.CreateMoodAnalyseParameterObject("MoodAnalysis", "MoodAnalysis", message);
            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.Message);
            }
            obj.Equals(expected);
        }

        //TC 5.2 
        [TestCategory("Reflection")]
        [TestMethod]
        [DataRow("Mood", "I am in Happy mood", "could not find class")]
        public void GIvenClassNmaeWhenImproperShouldThrowException(string className, string message, string expexted)
        {
            MoodAnalysis expected = new MoodAnalysis(message);
            object obj = null;
            try
            {
                obj = reflector.CreateMoodAnalyseParameterObject(className, "MoodAnalysis", message);

            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expexted, ex.Message);
            }
        }

        //TC 5.3 - Method to test moodanalyser with diff constructor with parameter constructor to throw error
        [TestCategory("Reflection")]
        [TestMethod]
        [DataRow("Mood", "I am in Happy mood", "could not find constructor")]
        public void GIvenConstructorNameWhenImproperShouldThrowException(string construtorName, string message, string expexted)
        {
            MoodAnalysis expected = new MoodAnalysis(message);
            object obj;
            try
            {
                obj = reflector.CreateMoodAnalyseParameterObject("MoodAnalysis", construtorName, message);

            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expexted, ex.Message);
            }
        }

    }
}



