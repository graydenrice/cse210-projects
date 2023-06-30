public class Note : NoteBook{

    private string _noteText;

    public Note(string entryType, string header, string noteText) : base(entryType, header){
        _noteText = noteText;
    }

    public override void NewEntry(List<NoteBook> _notesList){
        Console.WriteLine("What is the title of your note?");
        string title = Console.ReadLine();

        Console.WriteLine("Enter note: ");
        string noteText = Console.ReadLine();

        Note note = new Note("note", title, noteText);
        _notesList.Add(note);
    }

    public string GetNoteText(){
        return _noteText;
    }

    public override string ToString(){
        return $"{GetHeader()}: {_noteText}";
    }
}