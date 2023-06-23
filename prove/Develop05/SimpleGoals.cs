public class SimpleGoals : Goals{

    public SimpleGoals(string goalType, string goal, string description, bool complete, int points) : base(goalType, goal, description, points, complete){
        
    }

    public override bool IsComplete(){
       return _complete;
    }

    public override int RecordEvent(){
        _complete = true;
        return _points;
    }

    public override string ToString(){
        return $"{base.ToString()}";
    }
}