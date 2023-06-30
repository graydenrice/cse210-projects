public class UserInterface{

    List<NoteBook> _notesList = new List<NoteBook>();

    bool loop = true;

    public void DisplayMenu(){
        int number = 1;
        Console.WriteLine("Welcome to the NoteBook program!");
        Thread.Sleep(1500);
        Console.Clear();
        while(loop == true){
            Console.Clear();
            Console.WriteLine("Main menu:");
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. Display NoteBook");
            Console.WriteLine("3. Delete Entry");
            Console.WriteLine("4. Save NoteBook");
            Console.WriteLine("5. Load NoteBook");
            Console.WriteLine("6. Quit");
            Console.WriteLine("What would you like to do? ");
            string user = Console.ReadLine();

            if(user == "1"){
                Console.Clear();
                NewEntryMenu();
            }else if(user == "2"){
                Console.WriteLine("NoteBook");
                DispalayNoteBook(number);
                Console.WriteLine("Press enter to return to menu");
                Console.ReadLine();
            }else if(user == "3"){
                Console.Clear();
                DispalayNoteBook(number);
                Console.WriteLine("Which note would you like to remove?");
                int del = int.Parse(Console.ReadLine());
                int select = del - 1;

                Console.WriteLine("Are you sure you would like to delete this note?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                string userInput = Console.ReadLine();

                if(userInput == "1"){
                    _notesList.RemoveAt(select);
                }else{
                    Console.WriteLine("");
                }
            }else if(user == "4"){
                FileHandler.Save(_notesList);
            }else if(user == "5"){
                FileHandler.Load(_notesList);
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
            Note note = new Note("note", "", "");
            note.NewEntry(_notesList);
        }else if(user == "2"){
            Schedule schedule = new Schedule("schedule", "", "", "", "");
            schedule.NewEntry(_notesList);
        }else if(user == "3"){
            Contact contact = new Contact("contact", "", "", "");
            contact.NewEntry(_notesList);
        }else if(user == "4"){
            Passwords password = new Passwords("password", "", "", "");
            password.NewEntry(_notesList);
        }else{
            Console.WriteLine("Invalid Response");
        }
    }

    public void DispalayNoteBook(int number){
        foreach (NoteBook note in _notesList){
            Console.WriteLine($"{number}. {note}");

            number++;
        }
    }
}