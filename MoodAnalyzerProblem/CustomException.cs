using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MoodAnalyzerProblem
{
    public class CustomException : Exception
    {
        public ExceptionType exceptionType;
        public enum ExceptionType
        {
            NULL_MOOD,EMPTY_MOOD ,NO_SUCH_METHOD,NO_SUCH_CLASS,EMPTY_MESSAGE,NO_SUCH_FIELD  
        }

        public CustomException(ExceptionType exceptionType,string message) : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}
