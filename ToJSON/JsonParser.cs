using Newtonsoft.Json;

namespace ToJSON
{
    internal class JsonParser
    {
        public List<Quiz> Quiz()
        {
            string file = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory() + "\\quiz.json"));
            return JsonConvert.DeserializeObject<List<Quiz>>(file);   
        }
    }

    public class Quiz
    {
        public string Question { get; set; }
        public List<string> Answers = new();
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