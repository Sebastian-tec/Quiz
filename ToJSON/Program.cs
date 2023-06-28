using System.Security.AccessControl;

namespace ToJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            List<Quiz> list = JsonParser.Quiz();

            foreach (Quiz item in list)
            {

                int choice = 0;
                do
                {
                    Console.WriteLine(item.Question);
                    for (int i = 0; i < item.Answers.Count; i++)
                    {
                        Console.WriteLine($"[{i}] " + item.Answers[i]);
                    }

                    Console.Write("Enter your choice: ");

                    if (!int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    if (choice < 0 || choice > item.Answers.Count)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    
                    break; 
                    

                } while (true);

                string result = (item.Answers[choice] == item.Answers[item.Correct]) ? "Correct answer!" : $"Wrong answer! The right answer is {item.Answers[item.Correct]}";

                Console.WriteLine($"\n{result}\n{item.Description}\n");
            }
        }
    }
}