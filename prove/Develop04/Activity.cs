public class Activity{
    private string _activity;
    private string _description;
    private int _duration;

    public Activity(string activity, string description, int duration){
        _activity = activity;
        _description = description;
        _duration = duration;
    }

    public string DisplayStartMessage(){
        return $"Welcome to the {_activity}\n\nThis activity will help you {_description}";
    }
    public string DisplayEndMessage(){
        return $"\nGreat job on completeing {_duration} seconds of the {_activity}\n";
    }
    public static int SetDuration(){
        Console.WriteLine("How long would you like to do this activity(seconds)? ");
        string userInput = Console.ReadLine();
        int _duration = int.Parse(userInput);
        return _duration;
    }
    public int GetDuration(){
        return _duration;
    }
    public string GetPrompt(List<string> _prompts){
        Random newPrompt = new Random();
        int index = newPrompt.Next(_prompts.Count);
        return _prompts[index];
    }

    public void ShowSpinner(int seconds){
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while(DateTime.Now < endTime){
            Console.Write("-");

            Thread.Sleep(250);

            Console.Write("\b \b");
            Console.Write("\\");

            Thread.Sleep(250);

            Console.Write("\b \b");
            Console.Write("|");

            Thread.Sleep(250);

            Console.Write("\b \b");
            Console.Write("/");

            Thread.Sleep(250);
                    
            Console.Write("\b \b");
        }
    }
    public void ShowCountDown(int time){
        
        for(int i = time; i > 0; i -- ){
            Console.Write(i);
                
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    
}