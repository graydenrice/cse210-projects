public class Contact : NoteBook{

    private string _phone;
    private string _info;

    public Contact(string entryType, string header, string phone, string info) : base(entryType, header){
        _phone = phone;
        _info = info;
    }

    public override void NewEntry(List<NoteBook> _notesList){
        Console.WriteLine("What is the name of your contact?");
        string name = Console.ReadLine();

        Console.WriteLine("Enter phone number: ");
        string phone = Console.ReadLine();

        Console.WriteLine("Enter info about contact: ");
        string info = Console.ReadLine();

        Contact contact = new Contact("contact", name, phone, info);
        _notesList.Add(contact);
    }

    public string GetPhone(){
        return _phone;
    }

    public string GetInfo(){
        return _info;
    }

    public override string ToString(){
        return $"{GetHeader()} Phone: {_phone} - info: {_info}";
    }
}