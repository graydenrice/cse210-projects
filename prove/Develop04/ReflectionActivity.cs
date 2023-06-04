public class ReflectionActivity : Activity{

    private List<string> _prompts = new List<string>(){
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public ReflectionActivity(string activity, string description, int duration) : base(activity, description, duration){

    }

    public void DisplayPrompt(){
        Console.WriteLine($"{GetPrompt(_prompts)}\n");
    }

    public string GetPromptQuestion(){
        Random newQuest = new Random();
        int index = newQuest.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPromptQuestion(){
        Console.WriteLine($"{GetPromptQuestion()}");
    }

    public void RunReflectionActivity(){
        Thread.Sleep(1000);
        Console.Clear();

        Console.WriteLine(DisplayStartMessage());
        Activity.ShowSpinner(8);

        Console.WriteLine("Please Consider the Following\n");

        DisplayPrompt();

        Console.WriteLine("Press enter to continue");
        Console.ReadLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while(DateTime.Now < endTime){
            DisplayPromptQuestion();
            ShowSpinner(10);
        }

        Console.WriteLine(DisplayEndMessage());
        Thread.Sleep(5000);
    }
}

