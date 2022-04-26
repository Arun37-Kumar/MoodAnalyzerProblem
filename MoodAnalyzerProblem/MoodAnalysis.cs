using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalysis
    {
        public string message;

        public MoodAnalysis(string message)
        {
            this.message = message;
        }

        // Method to Analyze Mood
        public string MoodAnalyser()
        {
            try
            {
                if (this.message.Equals(""))
                {
                    throw new CustomException(CustomException.ExceptionType.EMPTY_MOOD, "Mood should not be empty!");
                }
                else if (message.ToLower().Contains("happy"))
                {
                    return "happy";
                }
                else
                {
                    return "sad";
                }
            }
            catch(NullReferenceException)
            {
                throw new CustomException(CustomException.ExceptionType.NULL_MOOD, "Mood should not be null!");
            }
        }

    }
}

