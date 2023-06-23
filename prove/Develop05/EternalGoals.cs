public class EternalGoals : Goals{

    public EternalGoals(string goalType, string goal, string description, bool complete, int points) : base(goalType, goal, description, points, complete){
        
    }

    public override bool IsComplete(){
       return _complete = false;
    }

    public override int RecordEvent(){
        return _points;
    }
}