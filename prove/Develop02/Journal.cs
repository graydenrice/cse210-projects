using System.IO;
public class Journal
    {
        public List<Entry> _entries {get; set;} = new List<Entry>();

        public void AppendEntry(Entry entry)
            {
                _entries.Add(entry); 
            }
        public void NewEntry()
            {
                Prompt newPrompt = new Prompt();
                string _prompt = newPrompt.RandomPrompt();

                Console.WriteLine(_prompt);
                string _response = Console.ReadLine();

                DateTime date = DateTime.Now;
                string _date = date.ToShortDateString();

                Console.WriteLine("What was the Weather like today? ");
                string _weather = Console.ReadLine();

                Console.WriteLine("What emotion did you feel the most today? ");
                string _emotion = Console.ReadLine();
                
                Entry newEntry = new Entry(_date, _prompt, _response, _weather, _emotion);
                AppendEntry(newEntry);
            }
        public void DisplayJournal()
            {
               foreach(Entry entry in _entries) {
                    Console.WriteLine(entry.ToString());
               }
            }
        public void SaveJournal()
            {
                Console.WriteLine("Enter a file name: ");
                string file = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(file, false)){
                    foreach (Entry entry in _entries){
                        outputFile.WriteLine($"{entry._date}, {entry._weather}, {entry._weather}, {entry._prompt}, {entry._response}");
                    }
                }
            }
        public void LoadJournal()
            {
                Console.WriteLine("Enter file name: ");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines){
                    string[] parts = line.Split(",");

                    string _date = parts[0];
                    string _prompt = parts[1];
                    string _response = parts[2];
                    string _weather = parts[3];
                    string _emotion = parts[4];

                    Entry newEntry = new Entry(_date, _weather, _prompt, _emotion, _response);
                    AppendEntry(newEntry);
                 }
            }
    }