public abstract class Goals
{

    protected int _points;
    protected string _goalType;
    protected string _goal;
    protected string _description;
    protected bool _complete;


    public Goals(string goalType, string goal, string description, int points, bool complete){
        _points = points;
        _goalType = goalType;
        _goal = goal;
        _description = description;
        _complete = complete;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public static void DisplayGoals(List<Goals> _goalsList, int number){
        foreach (var goal in _goalsList){
            Console.WriteLine($"{number}. {goal}");

            number++;
        }
    }

    public int GetPoints(){
        return _points;
    }

    public string GetGoalType(){
        return _goalType;
    }

    public override string ToString(){
        string status = _complete ? "[X]" : "[ ]";
        return $"{status} {_goal}: ({_description})";
    }

    public abstract void SaveGoal(StreamWriter outputFile);

    public abstract void LoadGoal(string[] parts);


    public static void SaveGoals(List<Goals> _goalsList, int score){
        Console.WriteLine("Enter file name: ");
        string file = Console.ReadLine();

        File.WriteAllText(file, string.Empty);

        using (StreamWriter outputFile = new StreamWriter(file)){
            outputFile.WriteLine(score);

            foreach (Goals goal in _goalsList){
                goal.SaveGoal(outputFile);

                string status = goal.IsComplete() ? "true" : "false";
                string goalLine = $"{goal._goalType} | {status} | {goal._goal} | {goal._description}";

                if (goal is CheckListGoals checkGoal){
                    goalLine += $" | {checkGoal._points} | {checkGoal.GetBonus()} | {checkGoal.GetTimesChecked()} | {checkGoal.GetTimes()}";
                }
                else if (goal is SimpleGoals simpleGoal){
                    goalLine += $" | {simpleGoal._points}";
                }
                else if (goal is EternalGoals eternalGoal){
                    goalLine += $" | {eternalGoal._points}";
                }

                outputFile.WriteLine(goalLine);
            }
        }
    }




    public static int LoadGoals(List<Goals> _goalsList){
        Console.WriteLine("Enter file name: ");
        string file = Console.ReadLine();

        string[] lines = File.ReadAllLines(file);

        int score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++){
            string[] parts = lines[i].Split("|");

            string goalType = parts[0].Trim();
            string comp = parts[1].Trim();
            bool complete = bool.Parse(comp);
            string goal = parts[2].Trim();
            string description = parts[3].Trim();

            if (goalType == "simple"){
                int points = int.Parse(parts[4].Trim());
                SimpleGoals simple = new SimpleGoals(goalType, goal, description, complete, points);
                _goalsList.Add(simple);
            }
            else if (goalType == "eternal"){
                int points = int.Parse(parts[4].Trim());
                EternalGoals eternal = new EternalGoals(goalType, goal, description, complete, points);
                _goalsList.Add(eternal);
            }
            else if (goalType == "check"){
                int points = int.Parse(parts[4].Trim());
                int bonus = int.Parse(parts[5].Trim());
                int timesChecked = int.Parse(parts[6].Trim());
                int times = int.Parse(parts[7].Trim());
                CheckListGoals check = new CheckListGoals(goalType, goal, description, complete, points, bonus, timesChecked, times);
                _goalsList.Add(check);
            }

        }
        return score;
    }
}
