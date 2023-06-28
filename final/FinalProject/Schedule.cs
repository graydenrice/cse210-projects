public class Schedule : NoteBook{

    private int _time;
    private string _detail;
    private string _date;

    public Schedule(string entryType, string header, string date, int time, string detail) : base(entryType, header){
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
        int time = int.Parse(Console.ReadLine());

        Console.WriteLine("Details of Event:");
        string detail = Console.ReadLine();

        Schedule schedule = new Schedule("schedule", title, date, time, detail);
        _notesList.Add(schedule);
    }

    public override string ToString(){
        return $"{GetHeader()}\n{_date} at {_time}\n{_detail} ";
    }
}