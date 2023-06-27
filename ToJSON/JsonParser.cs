using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace ToJSON
{
    internal class JsonParser
    {
        public static List<Quiz> Quiz()
        {
            string file = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory() + "\\quiz.json"));
            List<Quiz> quiz = JsonConvert.DeserializeObject<List<Quiz>>(file);
            
            return quiz;
        }
    }

    public class Quiz
    {
        public string Question { get; set; }
        public List<string> Answers = new List<string>();
        public int Correct { get; set; }
        public string Description { get; set; }

        public Quiz(string question, List<string> answers, int correct, string desc)
        {
            Question = question;
            Answers = answers;
            Correct = correct;
            Description = desc;
        }
    }
}
