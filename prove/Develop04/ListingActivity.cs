public class ListingActivity : Activity{

    private List<string> _prompts = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _answers = new List<string>();

    public ListingActivity(string activity, string description, int duration) : base(activity, description, duration){
        
    }

    public void DisplayPrompt(){
        Console.WriteLine(GetPrompt(_prompts));
    }

    public void ToList(string ans){
        _answers.Add(ans);
    }

    public void DisplayListNum(){
        int num = _answers.Count();
        Console.WriteLine($"You have entered {num} things, Thats awesome!");
    }

}