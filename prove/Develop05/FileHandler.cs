public class FileHandler{

    public static void DisplayGoals(List<Goals> _goalsList, int number){
        foreach (var goal in _goalsList){
            Console.WriteLine($"{number}. {goal}");

            number++;
            }
        }

    public static void SaveGoals(List<Goals> _goalsList, int score){
        Console.WriteLine("Enter file name: ");
        string file = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(file)){
            outputFile.WriteLine(score);

            foreach (Goals goal in _goalsList){
                
                string status = goal.IsComplete() ? "true" : "false";
                string goalLine = $"{goal.GetGoalType()} | {status} | {goal.GetGoal()} | {goal.GetDescription()}";

                if (goal is CheckListGoals checkGoal){
                    goalLine += $" | {checkGoal.GetPoints()} | {checkGoal.GetBonus()} | {checkGoal.GetTimesChecked()} | {checkGoal.GetTimes()}";
                }else if (goal is SimpleGoals simpleGoal){
                    goalLine += $" | {simpleGoal.GetPoints()}";
                }else if (goal is EternalGoals eternalGoal){
                    goalLine += $" | {eternalGoal.GetPoints()}";
                }

                outputFile.WriteLine(goalLine);
            }
        }
        _goalsList.Clear();
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