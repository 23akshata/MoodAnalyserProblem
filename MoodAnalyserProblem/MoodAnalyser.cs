using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        string message;
        public string MoodAnalyseProblem(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            if (message.Contains("Sad"))
            {
                return "Sad";
            }
            else
                return "Happy";
        }
    }
}
