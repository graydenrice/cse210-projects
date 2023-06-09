public class BreathingActivity : Activity{

    public BreathingActivity(string activity, string description, int duration) : base(activity, description, duration){
        
    }

    public void DisplayActivity(){
        Console.Write("\nBreath In... ");
        ShowCountDown(3);

        Thread.Sleep(250);

        Console.Write("\nBreath Out... ");
        ShowCountDown(4);

        Thread.Sleep(250);
    }
    
    public void RunBreathingActivity(){
        Thread.Sleep(1000);
        Console.Clear();

        Console.WriteLine(DisplayStartMessage());

        ShowSpinner(3);

        Console.Write("\nLets begin  ");

        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        Console.CursorVisible = false;
        while(DateTime.Now < endTime){
            DisplayActivity();  
        }
        Console.CursorVisible = true;

        ShowSpinner(3);

        Console.WriteLine(DisplayEndMessage());
    }
}