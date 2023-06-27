public abstract class NoteBook{

    private string _entryType;
    private string _header;
    List<NoteBook> _notesList = new List<NoteBook>();


    public NoteBook(string entryType, string header){
        _entryType = entryType;
        _header = header;
    }

    public abstract string NewEntry();

    public void DeleteEntry(){

    }

    public void EditEntry(){
        
    }

}