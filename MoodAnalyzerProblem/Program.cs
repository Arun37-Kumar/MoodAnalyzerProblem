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
            MoodAnalysis mood = new MoodAnalysis();
            Console.WriteLine("Mood is : " + mood.MoodAnalyser(message));
            Console.WriteLine("Mood is : " + mood.MoodAnalyser("I am sad"));
            Console.ReadLine();
        }
    }
}
