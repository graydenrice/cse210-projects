public class Passwords : NoteBook{

    private string _username;
    private string _password;
    DateTime _date = new DateTime();

    public Passwords(string entryType, string header, string username, string password) : base(entryType, header){
        _username = username;
        _password = password;
    }

    public override string NewEntry(){
        return null;
    }
}