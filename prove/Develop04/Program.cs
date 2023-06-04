using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        int duration = 0;
        int timebr = 0;
        int timere = 0;
        int timeli = 0;

        bool loop = true;

        while(loop == true){
            Console.WriteLine("Options:\n1 - Breathing Activity\n2 - Reflection Activity\n3 - Listing Activity\n4 - Quit");
            Console.WriteLine("What would you like to do? ");
            string user = Console.ReadLine();

            if(user == "1"){
                int dur = Activity.SetDuration() + duration;
                string des = "relax by walking you thorugh breathing in and out slowly.\nClear your mind and focus on your breathing";
                BreathingActivity breath = new BreathingActivity("Breathing Activity", des, dur);
                breath.RunBreathingActivity();
                timebr += 1;

            }else if(user == "2"){
                int dur = Activity.SetDuration() + duration;
                string refl = "reflect on times in your\nlife when you have shown strength and resilience.\n This will help you recognize the power you have and\n how you can use it in other parts of your life.\n";
                ReflectionActivity reflect = new ReflectionActivity("Reflecting Activity", refl, dur);
                reflect.RunReflectionActivity();
                timere += 1;

            }else if(user == "3"){
                int dur = Activity.SetDuration() + duration;
                string list = "reflect on the good things in your\nlife by having you list as many things as you can\nin a certian area.";
                ListingActivity listing = new ListingActivity("Listing Activity", list, dur);
                listing.RunListingActivity();
                timeli += 1;

            }else if(user == "4"){
                loop = false;

            }

        }

        Console.Write($"Breathing ran {timebr} time(s)\nReflecting ran {timere} time(s)\nListing ran {timeli} time(s)");
        
    }
}