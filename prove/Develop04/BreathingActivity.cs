public class BreathingActivity : Activity{

    public BreathingActivity(string activity, string description, int duration) : base(activity, description, duration){
        
    }

    public void DisplayActivity(){
        Console.Write("\n\nBreath In... ");
        Activity.ShowCountDown(3);

        Thread.Sleep(250);

        Console.Write("\n\nBreath Out... ");
        Activity.ShowCountDown(4);

        Thread.Sleep(250);
    }
}