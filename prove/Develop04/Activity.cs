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
    public static int GetDuration(){
        Console.WriteLine("How long would you like to do this activity(seconds)? ");
        string userInput = Console.ReadLine();
        int _duration = int.Parse(userInput);
        return _duration;
    }
    public string GetPrompt(List<string> _prompts){
        Random newPrompt = new Random();
        int index = newPrompt.Next(_prompts.Count);
        return _prompts[index];
    }

    public static void ShowSpinner(int seconds){
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
    public static void ShowCountDown(int time, bool display = true){
        if(display){
            for(int i = time; i > 0; i -- ){
                Console.Write(i);
                
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
    public void RunBreathingActivity(){
        Thread.Sleep(1000);
        Console.Clear();

        Console.WriteLine(DisplayStartMessage());

        ShowSpinner(3);

        BreathingActivity breath = new BreathingActivity(_activity, _description, _duration);
        Console.WriteLine("Lets begin");

        Activity.ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime){
            breath.DisplayActivity();  
        }
        

        ShowSpinner(3);

        Console.WriteLine(DisplayEndMessage());
    }

    public void RunReflectionActivity(){
        Thread.Sleep(1000);
        Console.Clear();

        Console.WriteLine(DisplayStartMessage());
        Activity.ShowSpinner(8);

        ReflectionActivity reflect = new ReflectionActivity(_activity, _description, _duration);

        Console.WriteLine("Please Consider the Following\n");

        reflect.DisplayPrompt();

        Console.WriteLine("Press enter to continue");
        Console.ReadLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime){
            reflect.DisplayPromptQuestion();
            ShowSpinner(10);
        }

        Console.WriteLine(DisplayEndMessage());
        Thread.Sleep(5000);
    }

    public void RunListingActivity(){
        Thread.Sleep(1000);
        Console.Clear();

        ListingActivity listing = new ListingActivity(_activity, _description, _duration);

        Console.WriteLine(DisplayStartMessage());

        Activity.ShowSpinner(8);

        listing.DisplayPrompt();

        Console.WriteLine("Begin thinking about the question...");

        ShowCountDown(7);

        Console.WriteLine("List as many things as you can: ");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime){
            string input = Console.ReadLine();
            listing.ToList(input);
           
            if(DateTime.Now >= endTime){
                break;
            }

        }

        Thread.Sleep(1000);

        listing.DisplayListNum();

        Activity.ShowSpinner(3);

        Console.WriteLine(DisplayEndMessage());

        Thread.Sleep(5000);
    }
    
}