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
            List<Quiz> list = new JsonParser().Quiz();

            LoadJson(list);
        }

        private static void LoadJson(List<Quiz> list)
        {
            foreach (Quiz item in list)
            {

                int choice;
                do
                {
                    Console.WriteLine(item.Question);
                    for (int i = 0; i < item.Answers.Count; i++)
                    {
                        Console.WriteLine($"[{i}] {item.Answers[i]}");
                    }

                    Console.Write("Enter your choice [0] [1] [2]: ");

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