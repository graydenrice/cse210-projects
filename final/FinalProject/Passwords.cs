public class Passwords : NoteBook{

    private string _username;
    private string _password;

    public Passwords(string entryType, string header, string username, string password) : base(entryType, header){
        _username = username;
        _password = password;
    }

    public override void NewEntry(List<NoteBook> _notesList){
        Console.WriteLine("What site is this for? ");
        string site = Console.ReadLine();

        Console.WriteLine("Username: ");
        string username = Console.ReadLine();

        Console.WriteLine("Password: ");
        string pass = Console.ReadLine();

        Passwords password = new Passwords("password", site, username, pass);
        _notesList.Add(password);
    }

    public override string ToString(){
        return $"{GetHeader()}: username:{_username} - password:{_password}";
    }
}