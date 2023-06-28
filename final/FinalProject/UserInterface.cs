public class UserInterface{

    List<NoteBook> _notesList = new List<NoteBook>();

    bool loop = true;

    public void DisplayMenu(){
        Console.WriteLine("Welcome to the NoteBook program!");
        Thread.Sleep(3000);
        Console.Clear();
        while(loop == true){
            Console.Clear();
            Console.WriteLine("Main menu:");
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. Dispalay NoteBook");
            Console.WriteLine("3. Delete Entry");
            Console.WriteLine("4. Save NoteBook");
            Console.WriteLine("5. Load NoteBook");
            Console.WriteLine("6. Quit");
            Console.WriteLine("What would you like to do? ");
            string user = Console.ReadLine();

            if(user == "1"){
                NewEntryMenu();
            }else if(user == "2"){
                foreach (var note in _notesList){
                    Console.WriteLine(note);
                }
            }else if(user == "3"){
                NoteBook.DeleteEntry();
            }else if(user == "4"){
                FileHandler.Save();
            }else if(user == "5"){
                FileHandler.Load();
            }else if(user == "6"){
                loop = false;
            }else{
                Console.WriteLine("Invalid Response");
            }
        }
    }

    public void NewEntryMenu(){
        Console.WriteLine("Note types");
        Console.WriteLine("1. Note");
        Console.WriteLine("2. Contact");
        Console.WriteLine("3. Schedule");
        Console.WriteLine("4. Password");
        Console.WriteLine("What type of note would you like to add?");
        string user = Console.ReadLine();

        if(user == "1"){
            Note note = new Note("", "", "");
            note.NewEntry(_notesList);
            
        }else if(user == "2"){

        }else if(user == "3"){

        }else if(user == "4"){

        }else{
            Console.WriteLine("Invalid Response");
        }
    }

    public void DisplayNoteBook(){
        
    }
}