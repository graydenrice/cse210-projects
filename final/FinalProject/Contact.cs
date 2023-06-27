public class Contact : NoteBook{

    private string _phone;
    private string _email;

    public Contact(string entryType, string header, string phone, string email) : base(entryType, header){
        _phone = phone;
        _email = email;
    }

    public override string NewEntry(){
        return null;
    }
}