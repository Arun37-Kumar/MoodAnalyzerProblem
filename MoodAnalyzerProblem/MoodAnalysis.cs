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

        public MoodAnalysis()
        {
            message = message;
        }

        public string MoodAnalyser(string message)
        {
            if (message.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }

        public string MoodAnalyser()
        {
            try
            {
                if (message.ToLower().Contains("happy"))
                    return "happy";
                else
                    return "sad";
            }
            catch (NullReferenceException)
            {
                return "happy";
            }
        }
    }
}
    
