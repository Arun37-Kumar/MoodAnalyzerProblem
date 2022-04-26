using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer Problem : ");

            Console.WriteLine("Enter the message : ");
            string message = Console.ReadLine();
            MoodAnalysis mood = new MoodAnalysis(message);
            Console.WriteLine("Mood is : " + mood.MoodAnalyser());
            //Console.WriteLine("Mood is : " + mood.MoodAnalyser("I am sad"));
            MoodAnalyserFactory factor = new MoodAnalyserFactory();
            //factor.CreatemoodAnalyse("I am happy","CreatemoodAnalyse");
            //factor.CreateMoodAnalyseParameterObject("MoodAnalyserFactory","I am sad", "CreateMoodAnalyseParameterObject");
            //factor.InvokeAnalyseMood("I am happy","MoodAnalyser");
            factor.SetField("I am happy","MoodAnalyser");
            Console.ReadLine();
        }
    }
}
