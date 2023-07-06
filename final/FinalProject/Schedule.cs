public class Schedule : NoteBook{

    private string _time;
    private string _detail;
    private string _date;

    public Schedule(string entryType, string header, string date, string time, string detail) : base(entryType, header){
        _time = time;
        _detail = detail;
        _date = date;
    }

    public override void NewEntry(List<NoteBook> _notesList){
        Console.WriteLine("What is the title for you event?");
        string title = Console.ReadLine();

        Console.WriteLine("Enter the event date(mm/dd/yyyy): ");
        string date = Console.ReadLine();

        Console.WriteLine("Enter time of event(0:00): ");
        string time = Console.ReadLine();

        Console.WriteLine("Details of Event:");
        string detail = Console.ReadLine();

        Schedule schedule = new Schedule("schedule", title, date, time, detail);
        _notesList.Add(schedule);
    }

    public string GetDate(){
        return _date;
    }

    public string GetTime(){
        return _time;
    }

    public string GetDetail(){
        return _detail;
    }

    public override string ToString(){
        return $"{GetHeader()}: {_date} at {_time}: {_detail} ";
    }
}