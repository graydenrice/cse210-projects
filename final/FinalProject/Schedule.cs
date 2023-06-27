public class Schedule : NoteBook{

    private int _time;
    private string _plan;
    DateTime _date = new DateTime();

    public Schedule(string entryType, string header, int time, string plan) : base(entryType, header){
        _time = time;
        _plan = plan;
    }

    public override string NewEntry(){
        return null;
    }
}