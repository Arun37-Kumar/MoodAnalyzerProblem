﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Reflection;

namespace MoodAnalyzerProblem
{
    class MoodAnalyserFactory
    {
        public object CreatemoodAnalyse(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);

            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new CustomException(CustomException.ExceptionType.NO_SUCH_CLASS, "No Class found!");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.NO_SUCH_METHOD, "constructor not found");
            }
        }

        public object CreateMoodAnalyseParameterObject(string className, string constructorName, string message)
        {
            Type type = typeof(MoodAnalysis);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo constructorInfo = type.GetConstructor(new Type[] { typeof(string) });
                    var obj = constructorInfo.Invoke(new object[] { message });
                    return obj;
                }
                else
                {
                    throw new CustomException(CustomException.ExceptionType.NO_SUCH_METHOD, "could not find constructor");
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.NO_SUCH_CLASS, "could not find class");
            }
        }
    }
}
