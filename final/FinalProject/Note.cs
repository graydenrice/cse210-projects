public class Note : NoteBook{

    private string _noteText;

    public Note(string entryType, string header, string noteText) : base(entryType, header){
        _noteText = noteText;
    }

    public override string NewEntry(){
        return null;
    }
}