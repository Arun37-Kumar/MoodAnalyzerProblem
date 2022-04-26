using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyzerProblem;

namespace MoodAnalyzerProblemUnitTest
{
    [TestClass]
    public class UnitTest2
    {
        MoodAnalyserFactory reflector;
        [TestInitialize]
        public void Setup()
        {
            reflector = new MoodAnalyserFactory();
        }


        //UC 6.1,6.2
        [TestCategory("Reflection")]
        [TestMethod]
        [DataRow("HAPPY")]
        [DataRow("Method not found")]
        public void ReflectionReturnMethod(string expected)
        {
            try
            {
                string actual = reflector.InvokeAnalyseMood("happy", "AnalyseMood");
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        //UC 7.1 
        [TestCategory("Reflection")]
        [TestMethod]
        [DataRow("happy", "happy", "message")]
        [DataRow("sad", "sad", "message")]
        public void SetHappyMessageWithReflectorShouldReturnHappy(string value, string expected, string fieldName)
        {
            try
            {
                string actual = reflector.SetField(value, fieldName);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        //UC 7.2 
        [TestCategory("Reflection")]
        [TestMethod]
        [DataRow("happy", "field not found", "improperField")]
        public void SetFieldWhenImproperShouldThrowExceptionNoSuchField(string value, string expected, string fieldName)
        {
            try
            {
                string actual = reflector.SetField(value, fieldName);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        //UC 7.3 
        [TestCategory("Reflection")]
        [TestMethod]
        [DataRow(null, "message should not be null", "message")]
        public void SettingNullMessageWithReflectorShouldThrowException(string value, string expected, string fieldName)
        {
            try
            {
                string actual = reflector.SetField(value, fieldName);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

    }
}

