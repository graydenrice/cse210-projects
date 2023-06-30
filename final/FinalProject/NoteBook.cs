public abstract class NoteBook{

    private string _entryType;
    private string _header;

    public NoteBook(string entryType, string header){
        _entryType = entryType;
        _header = header;
    }

    public abstract void NewEntry(List<NoteBook> _notesList);

    public string GetHeader(){
        return _header;
    }

    public string GetEntryType(){
        return _entryType;
    }

}