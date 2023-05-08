using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        int loop = 0;
        Journal newEntry = new Journal();
        while(loop == 0){
            Console.WriteLine("Welcome to the Journal!");
            Console.WriteLine("1 - New Entry");
            Console.WriteLine("2 - SaveJournal");
            Console.WriteLine("3 - Display Journal");
            Console.WriteLine("4 - Load Journal");
            Console.WriteLine("5 - Quit");

            Console.WriteLine("What would you like to do?");
            string user = Console.ReadLine();

            if(user == "1"){ 
                newEntry.NewEntry();
            }else  if(user == "2"){
                newEntry.SaveJournal();
            }else if(user == "3"){
                newEntry.DisplayJournal();
            }else if(user == "4"){
                newEntry.LoadJournal();
            }else if(user == "5"){
                loop += 1;
            }else{
                Console.WriteLine("Invalid Input");
            }
        }
    }
    
}