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

    public int GetPoints(){
        return _points;
    }

    public string GetGoal(){
        return _goal;
    }

    public string GetDescription(){
        return _description;
    }

    public string GetGoalType(){
        return _goalType;
    }

    public override string ToString(){
        string status = _complete ? "[X]" : "[ ]";
        return $"{status} {_goal}: ({_description})";
    }

   
}
