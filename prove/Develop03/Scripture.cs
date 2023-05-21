public class Scripture{
    private string _reference;
    private string _scriptureText;
    private List<Word> _words = new List<Word>();

    public Scripture(string reference, string scriptureText){
        _reference = reference;
        _scriptureText = scriptureText;
        getList();
    }

    public override string ToString(){
        return $"{_reference}\n{_scriptureText}";
    }

    public void getList(){
        string[] array = _scriptureText.Split(" ");
        foreach (var word in array){
            bool IsHidden = false;
            _words.Add(new Word(word, IsHidden));
        }
    }

    public void HideWords(){
        Random random = new Random();

        int newIndex = random.Next(_words.Count);

        for (int i = 0; i < 3; i++){    
            _words[newIndex].Hide();
            newIndex = random.Next(0, _words.Count);
        }
        
    }

    public string GetRenderedText(){
        List<string> _newWords = new List<string>();

        foreach (Word word in _words){
            _newWords.Add(word.renderedText());
        }
        return string.Join(" ", _newWords);
    }

    public bool CompletelyHidden(){
        foreach (Word word in _words){
            if(!word.IsHidden()){
                return false;
            }   
        }
        return true; 
    }


}