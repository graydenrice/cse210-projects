using System;

class Program
{
    
    static void Main(string[] args)
    {
        bool loop = true;

        List<Goals> _goalsList = new List<Goals>();

        int _score = 0;

        int number = 1;

        string _metal = "none";

        while(loop == true){
            Console.WriteLine($"Your score is {_score}");
            Console.WriteLine($"Your Current Meatal is {_metal}");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Event\n6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            if(choice == "1"){
                Console.WriteLine("Types of goals:");
                Console.WriteLine("1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
                Console.WriteLine("What goal would you like to create? ");
                string type = Console.ReadLine();

                if(type == "1"){
                    Console.WriteLine("What is the name of your goal? ");
                    string goal = Console.ReadLine();

                    Console.WriteLine("Short description of your goal: ");
                    string description = Console.ReadLine();

                    Console.WriteLine("How many points is this goal worth? ");
                    int points  = int.Parse(Console.ReadLine());

                    SimpleGoals simple = new SimpleGoals("simple", goal, description, false, points);

                    _goalsList.Add(simple);

                }else if(type == "2"){
                Console.WriteLine("What is the name of your goal? ");
                    string goal = Console.ReadLine();

                    Console.WriteLine("Short description of your goal: ");
                    string description = Console.ReadLine();

                    Console.WriteLine("How many points is this goal worth? ");
                    int points = int.Parse(Console.ReadLine());

                    EternalGoals eternal = new EternalGoals("eternal", goal, description, false, points);

                    _goalsList.Add(eternal);

                }else if(type == "3"){
                    Console.WriteLine("What is the name of your goal? ");
                    string goal = Console.ReadLine();

                    Console.WriteLine("Short description of your goal: ");
                    string description = Console.ReadLine();

                    Console.WriteLine("How many points is this goal worth? ");
                    int points = int.Parse(Console.ReadLine());

                    Console.WriteLine("How many times does this task need to be accomplished? ");  
                    int times = int.Parse(Console.ReadLine());;

                    Console.WriteLine("How many bonus points is it worth? ");
                    int bonus = int.Parse(Console.ReadLine());;

                    CheckListGoals check = new CheckListGoals("check", goal, description, false, points, bonus, 0, times);

                    _goalsList.Add(check);
                    }
            }else if(choice == "2"){
               Goals.DisplayGoals(_goalsList, number);
            }else if(choice == "3"){
                Goals.SaveGoals(_goalsList, _score);
            }else if(choice == "4"){
                _score = Goals.LoadGoals(_goalsList);
                
            }else if(choice == "5"){
                Goals.DisplayGoals(_goalsList, number);
                Console.WriteLine("Which goal did you do? ");
                int record = int.Parse(Console.ReadLine());

                if(record >= 1 && record <= _goalsList.Count){
                    Goals goal = _goalsList[record - 1];

                    if(!goal.IsComplete()){
                        string goalType = goal.GetGoalType();

                        switch (goalType){
                            case "check":
                                CheckListGoals checkListGoal = (CheckListGoals)goal;
                                checkListGoal.RecordEvent();
                                break;
                            case "simple":
                            case "eternal":
                                goal.RecordEvent();
                                break;
                            default:
                                Console.WriteLine("Invalid goal type.");
                                break;
                        }

                        _score += goal.GetPoints();

                        Console.WriteLine($"Goal completed! {goal.GetPoints()} points added to the score.");
                    }
                }
                
            }else if(choice == "6"){
                loop = false;
            }else{
                Console.WriteLine("Invalid Response");
            }
            if(_score >= 100){
                _metal = "Bronze";
            }if(_score >= 500){
                _metal = "Silver";
            }if(_score >= 1000){
                _metal = "Gold";
            }if(_score >= 5000){
                _metal = "Diamond";
            }

        }
    }
}