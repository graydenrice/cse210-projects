using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        List<object[]> refList = new List<object[]>();
        refList.Add(new object[]{"proverbs", 3, 5 ,6, "Trust in the Lord with all thine heart;\n and lean not unto thine own understanding.\n In all thy ways acknowledge him,\n and he shall direct thy paths."});
        refList.Add(new object[]{"John", 3, 16, 0, "For God so loved the world, that He gave His only Begotten Son,\n that whosoever believeth in him should not perish,\n but have everlasting life."});
        refList.Add(new object[]{"Psalms", 23, 4, 0, "Yea, though I walk through the valley of the shadow of death,\n I will fear no evil: for thou art with me;\n thy rod and thy staff they comfort me."});
        refList.Add(new object[]{"2 Nephi", 31, 20, 0, "Wherefore, ye must press forward with a steadfastness in Christ,\n having a perfect brightness of hope, and a love of God and of all men.\n Wherefore, if ye shall press forward, feasting upon the word of Christ,\n and endure to the end, behold, thus saith the Father: Ye shall have eternal life."});
        refList.Add(new object[]{"Moroni", 10, 4, 5, "And when ye shall receive these things, I would exhort you that ye would ask God,\n the Eternal Father, in the name of Christ, if these things are not true;\n and if ye shall ask with a sincere heart, with real intent, having faith in Christ,\n he will manifest the truth of it unto you, by the power of the Holy Ghost\n And by the power of the Holy Ghost ye may know the truth of all things."});
        refList.Add(new object[]{"Ether", 12, 27, 0, "And if men come unto me I will show unto them their weakness.\n I give unto men weakness that they may be humble;\n and my grace is sufficient for all men that humble themselves before me;\n for if they humble themselves before me, and have faith in me,\n then will I make weak things become strong unto them."});

        Random rand = new Random();
        int index = rand.Next(refList.Count);
        object[] randRef = refList[index];

        string book = (string)randRef[0];
        int chapter = (int)randRef[1];
        int verse = (int)randRef[2];
        int endVerse = (int)randRef[3];
        string text = (string)randRef[4];

        Reference one = new Reference(book, chapter, verse, endVerse);
        
        Scripture two = new Scripture(one.ToString(), text);

        Console.WriteLine($"{two}\nPress enter to continue or type 'quit' to finish");
        string input = Console.ReadLine();
        Console.Clear();

        bool quit = false;

        while(quit == false){
            
            if(input == "quit"){
                quit = true;
            }else{
                two.HideWords();
                Console.WriteLine(two.GetRenderedText());
                Console.ReadLine();
                Console.Clear();
            
                if (two.CompletelyHidden()){
                    quit = true;
                }
            }
        }
    }
}