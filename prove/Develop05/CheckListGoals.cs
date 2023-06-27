public class CheckListGoals : Goals{

    private int _bonus;
    private int _times;
    private int _timesChecked;

    public CheckListGoals(string goalType, string goal, string description, bool complete, int points, int bonus, int timesChecked, int times) : base(goalType, goal, description, points, complete){
        _bonus = bonus;
        _timesChecked = timesChecked;
        _times = times;
    }

    public override bool IsComplete(){
       return _complete;
    }

    public override int RecordEvent(){
        _timesChecked++;
        if(_timesChecked >= _times){
            _complete = true;
            return GetPoints() + GetBonus();
        }
        
        bool completed = IsComplete();
        return _points;
    }

    public override string ToString(){
        return $"{base.ToString()} -- completed {_timesChecked}/{_times}";
    }

    public int GetTimes(){
        return _times;
    }

    public int GetTimesChecked(){
        return _timesChecked;
    }

    public int GetBonus(){
        return _bonus;
    }
}