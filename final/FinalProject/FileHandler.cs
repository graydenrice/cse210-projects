
public class FileHandler{

    public static void Save(List<NoteBook> _notesList){
        Console.WriteLine("Enter file name: ");
        string file = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(file)){
            foreach (NoteBook note in _notesList){
                string fileInput = $"{note.GetEntryType()} | {note.GetHeader()}";

                if (note is Note notes){
                    fileInput += $" | {notes.GetNoteText()}";
                } else if (note is Schedule schedule) {
                    fileInput += $" | {schedule.GetDate()} | {schedule.GetTime()} | {schedule.GetDetail()}";
                } else if (note is Contact contact){
                    fileInput += $" | {contact.GetPhone()} | {contact.GetInfo()}";
                } else if (note is Passwords password){
                    fileInput += $" | {password.GetUsername()} | {password.GetPassword()}";
                }

                outputFile.WriteLine(fileInput);
            }
        }
    }

    public static void Load(List<NoteBook> _notesList){
        Console.WriteLine("Enter file name: ");
        string file = Console.ReadLine();

        string[] lines = File.ReadAllLines(file);

        for (int i = 0; i < lines.Length; i++){
            string[] parts = lines[i].Split("|");

            string entryType = parts[0].Trim();
            string header = parts[1].Trim();

            if (entryType == "note"){
                string noteText = parts[2].Trim();
                Note noteClass = new Note(entryType, header, noteText);
                _notesList.Add(noteClass);
            } else if (entryType == "schedule"){
                string date = parts[2].Trim();
                string time = parts[3].Trim();
                string detail = parts[4].Trim();
                Schedule schedule = new Schedule(entryType, header, date, time, detail);
                _notesList.Add(schedule);
            } else if (entryType == "contact"){
                string phone = parts[2].Trim();
                string info = parts[3].Trim();
                Contact contact = new Contact(entryType, header, phone, info);
                _notesList.Add(contact);
            } else if (entryType == "password"){
                string username = parts[2].Trim();
                string password = parts[3].Trim();
                Passwords passwords = new Passwords(entryType, header, username, password);
                _notesList.Add(passwords);
            }

        }
    }
}
